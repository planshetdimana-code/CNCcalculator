using System.Collections.Generic;
using Stanok.Models;

namespace Stanok.Services;

public static class MaterialCatalog
{
    private static readonly IReadOnlyList<Material> MaterialsInternal = new List<Material>
    {
        new()
        {
            Key = "aluminum",
            Name = "Алюминиевые сплавы",
            Hardness = 95,
            VcMin = 250,
            VcMax = 800,
            DefaultVc = 500,
            FzMin = 0.01,
            FzMax = 0.30,
            DefaultFz = 0.15,
            Kc1 = 800,
            Mc = 0.25,
            Description = "Алюминиевые и магниевые сплавы (HB < 110)"
        },
        new()
        {
            Key = "steel_soft",
            Name = "Сталь конструкционная (< 200 HB)",
            Hardness = 180,
            VcMin = 100,
            VcMax = 250,
            DefaultVc = 150,
            FzMin = 0.02,
            FzMax = 0.20,
            DefaultFz = 0.12,
            Kc1 = 1800,
            Mc = 0.25,
            Description = "Низкоуглеродистые конструкционные стали"
        },
        new()
        {
            Key = "steel_medium",
            Name = "Сталь улучшенная (200-300 HB)",
            Hardness = 250,
            VcMin = 80,
            VcMax = 180,
            DefaultVc = 120,
            FzMin = 0.015,
            FzMax = 0.15,
            DefaultFz = 0.10,
            Kc1 = 2100,
            Mc = 0.25,
            Description = "Улучшенные конструкции, HB 200-300"
        },
        new()
        {
            Key = "steel_hard",
            Name = "Сталь закаленная (300-400 HB)",
            Hardness = 340,
            VcMin = 50,
            VcMax = 120,
            DefaultVc = 80,
            FzMin = 0.01,
            FzMax = 0.12,
            DefaultFz = 0.08,
            Kc1 = 2500,
            Mc = 0.25,
            Description = "Термообработанные стали повышенной твердости"
        },
        new()
        {
            Key = "stainless",
            Name = "Нержавеющая сталь",
            Hardness = 200,
            VcMin = 70,
            VcMax = 150,
            DefaultVc = 100,
            FzMin = 0.015,
            FzMax = 0.15,
            DefaultFz = 0.10,
            Kc1 = 2300,
            Mc = 0.25,
            Description = "Аустенитные и мартенситные сталей"
        },
        new()
        {
            Key = "cast_iron",
            Name = "Чугун серый",
            Hardness = 220,
            VcMin = 100,
            VcMax = 180,
            DefaultVc = 120,
            FzMin = 0.02,
            FzMax = 0.25,
            DefaultFz = 0.15,
            Kc1 = 1400,
            Mc = 0.22,
            Description = "Серые чугуны, высокое демпфирование"
        },
        new()
        {
            Key = "brass",
            Name = "Латунь / Бронза",
            Hardness = 150,
            VcMin = 200,
            VcMax = 500,
            DefaultVc = 300,
            FzMin = 0.02,
            FzMax = 0.20,
            DefaultFz = 0.12,
            Kc1 = 900,
            Mc = 0.20,
            Description = "Латунные и бронзовые сплавы"
        },
        new()
        {
            Key = "titanium",
            Name = "Титановые сплавы",
            Hardness = 320,
            VcMin = 40,
            VcMax = 100,
            DefaultVc = 60,
            FzMin = 0.01,
            FzMax = 0.10,
            DefaultFz = 0.08,
            Kc1 = 1800,
            Mc = 0.28,
            Description = "Альфа-бета титановые сплавы"
        },
        new()
        {
            Key = "plastic",
            Name = "Пластики (PA, POM, PEEK)",
            Hardness = 40,
            VcMin = 250,
            VcMax = 600,
            DefaultVc = 400,
            FzMin = 0.02,
            FzMax = 0.40,
            DefaultFz = 0.20,
            Kc1 = 400,
            Mc = 0.20,
            Description = "Инженерные пластики, композиты"
        }
    };

    public static IReadOnlyList<Material> GetAll() => MaterialsInternal;

    public static Material GetDefault() => MaterialsInternal[0];
}
