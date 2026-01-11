using Stanok.Models;

namespace Stanok.Services;

public record CalculationInput(
    double Diameter,
    int Teeth,
    double DepthAp,
    double WidthAe,
    Material Material,
    bool ToolOptionsEnabled,
    ToolMaterialOption ToolMaterial,
    ToolOverhangOption ToolOverhang,
    ToolConditionOption ToolCondition,
    bool OperationOptionsEnabled,
    OperationTypeOption OperationType,
    bool MachineOptionsEnabled,
    double MachinePower,
    double MachineMaxSpeed,
    double MachineMaxFeed);

public record CalculationResult(
    double CuttingSpeed,
    double SpindleSpeed,
    double FeedPerTooth,
    double FeedRate,
    double VolumeRemovalCm3,
    double CuttingForce,
    double CuttingPower,
    double Torque,
    double TimeSeconds,
    bool SpeedWithinLimit,
    bool PowerWithinLimit,
    bool FeedWithinLimit,
    bool MachineChecksActive,
    IReadOnlyList<string> Warnings);

public class CalculationService
{
    private const double DefaultLengthMm = 100.0; // Путь обработки для отчета
    private const double DefaultEfficiency = 0.85; // КПД шпинделя
    private const double ReferenceDiameterMm = 10.0; // Диаметр, для которого заданы базовые подачи

    public CalculationResult Calculate(CalculationInput input)
    {
        Validate(input);

        // Расчет скорости резания
        var vc = input.Material.DefaultVc;

        // Корректировка по материалу инструмента
        if (input.ToolOptionsEnabled)
        {
            vc *= input.ToolMaterial switch
            {
                ToolMaterialOption.CarbideCoated => 1.2,
                ToolMaterialOption.Hss => 0.5,
                _ => 1.0
            };

            // Корректировка по вылету
            vc *= input.ToolOverhang switch
            {
                ToolOverhangOption.Medium => 0.8,
                ToolOverhangOption.High => 0.6,
                _ => 1.0
            };

            // Корректировка по состоянию
            vc *= input.ToolCondition switch
            {
                ToolConditionOption.Normal => 0.9,
                ToolConditionOption.Worn => 0.7,
                _ => 1.0
            };
        }

        // Корректировка по типу обработки
        if (input.OperationOptionsEnabled)
        {
            vc *= input.OperationType switch
            {
                OperationTypeOption.Roughing => 0.8,
                OperationTypeOption.Finishing => 1.2,
                _ => 1.0
            };
        }

        vc = Math.Clamp(vc, input.Material.VcMin, input.Material.VcMax);

        // Расчет подачи на зуб - базовое значение уже с учетом типа обработки
        var fz = input.Material.DefaultFz;

        // Корректировка подачи по диаметру инструмента
        var diameterFactor = Math.Sqrt(Math.Max(input.Diameter, 0.1) / ReferenceDiameterMm);
        fz *= Math.Min(diameterFactor, 1.5);

        // Специальные ограничения для микрофрез
        if (input.Diameter < 1.0)
        {
            fz = Math.Min(fz * 0.5, 0.02);
        }
        else if (input.Diameter < 3.0)
        {
            fz *= 0.7;
        }

        // Корректировка по количеству зубьев
        if (input.Teeth > 4)
        {
            fz *= Math.Min(0.9, 1.0 - (input.Teeth - 4) * 0.02);
        }

        // Корректировка по состоянию инструмента
        if (input.ToolOptionsEnabled && input.ToolCondition == ToolConditionOption.Worn)
        {
            fz *= 0.85;
        }

        fz = Math.Clamp(fz, input.Material.FzMin, input.Material.FzMax);

        var n = (vc * 1000d) / (Math.PI * input.Diameter);
        var feedRate = fz * input.Teeth * n;
        var volumeRemovalCm3 = input.DepthAp * input.WidthAe * feedRate / 1000d;

        // Расчет средней толщины стружки: hm = fz × sin(φ) / φ, где φ = arccos(1 - 2×ae/D)
        var aeOverD = Math.Min(input.WidthAe / input.Diameter, 1.0);
        var phi = Math.Acos(Math.Max(1 - 2 * aeOverD, -1.0));
        var hm = phi > 0.001 ? fz * Math.Sin(phi) / phi : fz;

        // Расчет удельной силы резания: kc = kc1 × hm^(-mc)
        var kc = input.Material.Kc1 * Math.Pow(Math.Max(hm, 0.001), -input.Material.Mc);

        // Расчет силы резания: Fc = kc × ap × fz × z (по формуле из требований)
        var cuttingForce = kc * input.DepthAp * fz * input.Teeth;

        var cuttingPower = volumeRemovalCm3 * kc / (60000d * DefaultEfficiency);
        var torque = n > 0 ? cuttingPower * 9550d / n : 0d;
        var timeSeconds = feedRate > 0 ? (DefaultLengthMm / feedRate) * 60d : 0d;

        var warnings = new List<string>();
        var speedWithinLimit = true;
        var powerWithinLimit = true;
        var feedWithinLimit = true;

        if (input.MachineOptionsEnabled)
        {
            var speedRatio = input.MachineMaxSpeed <= 0 ? 0 : n / input.MachineMaxSpeed;
            var powerRatio = input.MachinePower <= 0 ? 0 : cuttingPower / input.MachinePower;
            var feedRatio = input.MachineMaxFeed <= 0 ? 0 : feedRate / input.MachineMaxFeed;

            if (speedRatio > 1)
            {
                speedWithinLimit = false;
                warnings.Add($"Критично: частота вращения {n:F0} об/мин превышает предел станка ({input.MachineMaxSpeed:F0} об/мин).");
            }
            else if (speedRatio > 0.8)
            {
                warnings.Add($"Предупреждение: частота вращения {n:F0} об/мин превышает 80% ресурса шпинделя.");
            }

            if (powerRatio > 1)
            {
                powerWithinLimit = false;
                warnings.Add($"Критично: требуемая мощность {cuttingPower:F2} кВт превышает мощность шпинделя ({input.MachinePower:F2} кВт).");
            }
            else if (powerRatio > 0.8)
            {
                warnings.Add($"Предупреждение: нагрузка на шпиндель {powerRatio * 100:F0}% приближается к лимиту.");
            }

            if (feedRatio > 1)
            {
                feedWithinLimit = false;
                warnings.Add($"Критично: минутная подача {feedRate:F0} мм/мин превышает паспортный предел ({input.MachineMaxFeed:F0} мм/мин).");
            }
            else if (feedRatio > 0.8)
            {
                warnings.Add($"Предупреждение: подача задействует {feedRatio * 100:F0}% доступного ресурса приводов.");
            }
        }

        if (!input.OperationOptionsEnabled)
        {
            warnings.Add("Параметры обработки не активированы: используется универсальный режим.");
        }

        if (!input.ToolOptionsEnabled)
        {
            warnings.Add("Настройки инструмента отключены: расчёт выполнен с усреднёнными коэффициентами.");
        }

        if (!input.MachineOptionsEnabled)
        {
            warnings.Add("Ограничения станка не заданы — проверьте режимы перед запуском.");
        }

        var toothFrequency = input.Teeth * n / 60d;
        if (toothFrequency > 500)
        {
            warnings.Add($"Предупреждение: частота прохода зубьев {toothFrequency:F0} Гц превышает рекомендуемые 500 Гц.");
        }

        if (input.WidthAe >= input.Diameter)
        {
            warnings.Add("Критично: ширина резания превышает диаметр фрезы — возможен клин инструмента.");
        }
        else if (input.WidthAe >= 0.95 * input.Diameter)
        {
            warnings.Add("Предупреждение: ae ≈ D — режим соответствует фрезерованию пазов.");
        }

        if (input.Diameter < 3 && fz > 0.05)
        {
            warnings.Add("Критично: подача на зуб превышает безопасное значение для микрофрез (D < 3 мм).");
        }

        if (warnings.Count == 0)
        {
            warnings.Add("Все параметры в допустимых диапазонах.");
        }

        return new CalculationResult(
            CuttingSpeed: Round(vc),
            SpindleSpeed: Round(n),
            FeedPerTooth: Round(fz),
            FeedRate: Round(feedRate),
            VolumeRemovalCm3: Round(volumeRemovalCm3),
            CuttingForce: Round(cuttingForce),
            CuttingPower: Round(cuttingPower),
            Torque: Round(torque),
            TimeSeconds: Round(timeSeconds),
            SpeedWithinLimit: speedWithinLimit,
            PowerWithinLimit: powerWithinLimit,
            FeedWithinLimit: feedWithinLimit,
            MachineChecksActive: input.MachineOptionsEnabled,
            Warnings: warnings);
    }


    private static void Validate(CalculationInput input)
    {
        if (input.Diameter <= 0.05)
        {
            throw new ArgumentException("Диаметр фрезы должен быть больше 0.05 мм.");
        }

        if (input.WidthAe <= 0 || input.DepthAp <= 0)
        {
            throw new ArgumentException("Глубина и ширина резания должны быть больше нуля.");
        }

        if (input.Teeth <= 0)
        {
            throw new ArgumentException("Количество зубьев должно быть больше нуля.");
        }

        if (input.MachineOptionsEnabled)
        {
            if (input.MachinePower <= 0 || input.MachineMaxSpeed <= 0 || input.MachineMaxFeed <= 0)
            {
                throw new ArgumentException("Параметры станка должны быть положительными.");
            }
        }
    }

    private static double Round(double value) => Math.Round(value, 3);
}
