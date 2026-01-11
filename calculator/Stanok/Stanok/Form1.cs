using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Stanok.Models;
using Stanok.Services;

namespace Stanok;

public partial class Form1 : Form
{
    private readonly CalculationService _calculationService = new();
    private readonly List<Material> _materials = MaterialCatalog.GetAll().ToList();
    private bool _initializing;

    private readonly List<Option<ToolMaterialOption>> _toolMaterialOptions = new()
    {
        new("Твёрдый сплав без покрытия", ToolMaterialOption.Carbide),
        new("Твёрдый сплав с покрытием", ToolMaterialOption.CarbideCoated),
        new("Быстрорежущая сталь (HSS)", ToolMaterialOption.Hss)
    };

    private readonly List<Option<ToolOverhangOption>> _toolOverhangOptions = new()
    {
        new("< 3×D (жёсткий)", ToolOverhangOption.Low),
        new("3-5×D (средний)", ToolOverhangOption.Medium),
        new("> 5×D (большой)", ToolOverhangOption.High)
    };

    private readonly List<Option<ToolConditionOption>> _toolConditionOptions = new()
    {
        new("Новый", ToolConditionOption.New),
        new("Приработанный", ToolConditionOption.Normal),
        new("Изношенный", ToolConditionOption.Worn)
    };

    private readonly List<Option<OperationTypeOption>> _operationOptions = new()
    {
        new("Черновая", OperationTypeOption.Roughing),
        new("Получистовая", OperationTypeOption.SemiFinishing),
        new("Чистовая", OperationTypeOption.Finishing)
    };

    public Form1()
    {
        InitializeComponent();
        HookOptionToggles();
        InitializeDataSources();
        ClearResults();
        LoadDbConfig();
    }

    private void InitializeDataSources()
    {
        _initializing = true;

        cmbMaterial.DisplayMember = nameof(Material.Name);
        cmbMaterial.ValueMember = nameof(Material.Key);
        cmbMaterial.DataSource = _materials;
        cmbMaterial.SelectedItem = _materials.FirstOrDefault();

        BindCombo(cmbToolMaterial, _toolMaterialOptions);
        BindCombo(cmbToolOverhang, _toolOverhangOptions);
        BindCombo(cmbToolCondition, _toolConditionOptions);
        BindCombo(cmbProcessType, _operationOptions);

        chkToolOptions.Checked = true;
        chkProcessOptions.Checked = true;
        chkMachineOptions.Checked = true;

        numDiameter.Minimum = 0.1M;
        numDiameter.Maximum = 500;
        numDiameter.Value = 10;

        numTeeth.Minimum = 1;
        numTeeth.Maximum = 20;
        numTeeth.Value = 4;

        numAp.Minimum = 0.01M;
        numAp.Maximum = 100;
        numAp.Value = 2;

        numAe.Minimum = 0.01M;
        numAe.Maximum = 500;
        numAe.Value = 5;

        numMachinePower.Value = 5.5M;
        numMachineMaxRpm.Value = 24000;
        numMachineMaxFeed.Value = 15000;

        _initializing = false;

        lstWarnings.Items.Clear();
        lstWarnings.Items.Add("Введите основные параметры и запустите расчёт.");

        UpdateMaterialHint();
    }

    private void HookOptionToggles()
    {
        chkToolOptions.CheckedChanged += (_, _) => ToggleSection(tblTool, chkToolOptions.Checked);
        chkProcessOptions.CheckedChanged += (_, _) => ToggleSection(tblProcess, chkProcessOptions.Checked);
        chkMachineOptions.CheckedChanged += (_, _) => ToggleSection(tblMachine, chkMachineOptions.Checked);

        cmbMaterial.SelectedIndexChanged += (_, _) => UpdateMaterialHint();

        ToggleSection(tblTool, chkToolOptions.Checked);
        ToggleSection(tblProcess, chkProcessOptions.Checked);
        ToggleSection(tblMachine, chkMachineOptions.Checked);
    }

    private void ToggleSection(Control control, bool enabled)
    {
        control.Enabled = enabled;
        control.ForeColor = enabled ? SystemColors.ControlText : Color.Gray;
    }

    private void BindCombo<T>(ComboBox comboBox, List<Option<T>> options)
    {
        comboBox.DisplayMember = nameof(Option<T>.Text);
        comboBox.ValueMember = nameof(Option<T>.Value);
        comboBox.DataSource = options.Select(o => new Option<T>(o.Text, o.Value)).ToList();
        comboBox.SelectedIndex = 0;
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
        if (cmbMaterial.SelectedItem is not Material material)
        {
            MessageBox.Show("Выберите материал заготовки.", "Расчёт", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            var input = BuildInput(material);
            var result = _calculationService.Calculate(input);
            DisplayResults(result);
            SetStatus("Режимы рассчитаны.");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка расчёта", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private CalculationInput BuildInput(Material material)
    {
        return new CalculationInput(
            Diameter: (double)numDiameter.Value,
            Teeth: (int)numTeeth.Value,
            DepthAp: (double)numAp.Value,
            WidthAe: (double)numAe.Value,
            Material: material,
            ToolOptionsEnabled: chkToolOptions.Checked,
            ToolMaterial: GetSelectedValue(cmbToolMaterial, ToolMaterialOption.Carbide),
            ToolOverhang: GetSelectedValue(cmbToolOverhang, ToolOverhangOption.Low),
            ToolCondition: GetSelectedValue(cmbToolCondition, ToolConditionOption.New),
            OperationOptionsEnabled: chkProcessOptions.Checked,
            OperationType: GetSelectedValue(cmbProcessType, OperationTypeOption.Roughing),
            MachineOptionsEnabled: chkMachineOptions.Checked,
            MachinePower: (double)numMachinePower.Value,
            MachineMaxSpeed: (double)numMachineMaxRpm.Value,
            MachineMaxFeed: (double)numMachineMaxFeed.Value);
    }

    private static T GetSelectedValue<T>(ComboBox comboBox, T fallback)
    {
        return comboBox.SelectedItem is Option<T> option ? option.Value : fallback;
    }

    private void DisplayResults(CalculationResult result)
    {
        lblResultVc.Text = $"{result.CuttingSpeed:F0} м/мин";
        lblResultSpindleSpeed.Text = $"{result.SpindleSpeed:F0} об/мин";
        lblResultFz.Text = $"{result.FeedPerTooth:F4} мм/зуб";
        lblResultFeed.Text = $"{result.FeedRate:F0} мм/мин";
        lblResultVolume.Text = $"{result.VolumeRemovalCm3:F1} см³/мин";
        lblResultForce.Text = $"{result.CuttingForce:F0} Н";
        lblResultPower.Text = FormatPower(result);
        lblResultTorque.Text = $"{result.Torque:F2} Н·м";
        lblResultTime.Text = $"{result.TimeSeconds:F1} с";

        lstWarnings.BeginUpdate();
        lstWarnings.Items.Clear();
        foreach (var warning in result.Warnings)
        {
            lstWarnings.Items.Add(warning);
        }
        lstWarnings.EndUpdate();
    }

    private void btnSelectTool_Click(object sender, EventArgs e)
    {
        using var dlg = new ToolPickerForm();
        if (dlg.ShowDialog(this) == DialogResult.OK && dlg.SelectedTool is not null)
        {
            var t = dlg.SelectedTool;
            numDiameter.Value = (decimal)Math.Clamp(t.Diameter, (double)numDiameter.Minimum, (double)numDiameter.Maximum);
            numTeeth.Value = Math.Clamp(t.Flutes, (int)numTeeth.Minimum, (int)numTeeth.Maximum);
            SetStatus($"Выбрана фреза: Ø{t.Diameter:0.0} · {t.Flutes}p");
        }
    }

    private static string FormatPower(CalculationResult result)
    {
        if (!result.MachineChecksActive)
        {
            return $"{result.CuttingPower:F2} кВт ✓";
        }

        return result.PowerWithinLimit
            ? $"{result.CuttingPower:F2} кВт ✓"
            : $"{result.CuttingPower:F2} кВт ⚠";
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        InitializeDataSources();
        ClearResults();
        SetStatus("Форма сброшена.");
    }

    private void ClearResults()
    {
        lblResultVc.Text = "--";
        lblResultSpindleSpeed.Text = "--";
        lblResultFz.Text = "--";
        lblResultFeed.Text = "--";
        lblResultVolume.Text = "--";
        lblResultForce.Text = "--";
        lblResultPower.Text = "--";
        lblResultTorque.Text = "--";
        lblResultTime.Text = "--";
    }

    private void btnHelp_Click(object sender, EventArgs e)
    {
        using var dialog = new InfoForm();
        dialog.ShowDialog(this);
    }

    private void UpdateMaterialHint()
    {
        if (_initializing)
        {
            return;
        }

        if (cmbMaterial.SelectedItem is not Material material)
        {
            lblMaterialHint.Text = "Материал не выбран.";
            return;
        }

        lblMaterialHint.Text =
            $"{material.Description}. Рекомендуемые диапазоны: Vc {material.VcMin:F0}-{material.VcMax:F0} м/мин, fz {material.FzMin:F3}-{material.FzMax:F3} мм/зуб.";
    }

    private void SetStatus(string text) => lblStatus.Text = text;

    private void btnTestConnection_Click(object sender, EventArgs e)
    {
        
    }

    private void txtDbName_TextChanged(object sender, EventArgs e)
    {

    }

    private void LoadDbConfig()
    {
        try
        {
            var config = DbConfigManager.Load();
            txtDbServer.Text = config.Server;
            txtDbPort.Text = config.Port;
            txtDbName.Text = config.Database;
            txtDbUser.Text = config.User;
            txtDbPassword.Text = config.Password;
        }
        catch
        {
            // Игнорируем ошибки загрузки, используются значения по умолчанию
        }
    }

    private void btnSaveDbConfig_Click(object sender, EventArgs e)
    {
        try
        {
            var config = new DbConfig
            {
                Server = txtDbServer.Text.Trim(),
                Port = txtDbPort.Text.Trim(),
                Database = txtDbName.Text.Trim(),
                User = txtDbUser.Text.Trim(),
                Password = txtDbPassword.Text
            };

            DbConfigManager.Save(config);
            MessageBox.Show($"Настройки успешно сохранены в файл:\n{DbConfigManager.GetConfigFilePath()}",
                "Сохранение настроек", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SetStatus("Настройки БД сохранены.");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при сохранении настроек:\n{ex.Message}",
                "Сохранение настроек", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnTestConnection_Click_1(object sender, EventArgs e)
    {
        var server = txtDbServer.Text.Trim();
        var port = txtDbPort.Text.Trim();
        var database = txtDbName.Text.Trim();
        var user = txtDbUser.Text.Trim();
        var password = txtDbPassword.Text;

        if (string.IsNullOrEmpty(server) || string.IsNullOrEmpty(database) || string.IsNullOrEmpty(user))
        {
            MessageBox.Show("Заполните все обязательные поля (Сервер, База данных, Пользователь).",
                "Проверка подключения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var connectionString = $"Server={server};Port={port};Database={database};Uid={user};Pwd={password};";

        try
        {
            // Note: MySql.Data.MySqlClient requires MySql.Data NuGet package
            using var connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();
            MessageBox.Show("Подключение к базе данных успешно установлено!",
                "Проверка подключения", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SetStatus("MySQL подключение проверено.");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка подключения к базе данных:\n{ex.Message}",
                "Проверка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            SetStatus("Ошибка подключения MySQL.");
        }
    }

    private sealed record Option<T>(string Text, T Value);
}
