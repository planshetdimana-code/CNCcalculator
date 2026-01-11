using System.Drawing;
using System.Windows.Forms;

namespace Stanok;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tabSections = new TabControl();
        tabMainParameters = new TabPage();
        tblMainParameters = new TableLayoutPanel();
        lblDiameter = new Label();
        pnlDiameter = new FlowLayoutPanel();
        numDiameter = new NumericUpDown();
        btnSelectTool = new Button();
        lblTeeth = new Label();
        numTeeth = new NumericUpDown();
        lblMaterial = new Label();
        cmbMaterial = new ComboBox();
        lblAp = new Label();
        numAp = new NumericUpDown();
        lblAe = new Label();
        numAe = new NumericUpDown();
        lblMaterialHint = new Label();
        tabToolSettings = new TabPage();
        tblTool = new TableLayoutPanel();
        lblToolMaterial = new Label();
        cmbToolMaterial = new ComboBox();
        lblToolOverhang = new Label();
        cmbToolOverhang = new ComboBox();
        lblToolCondition = new Label();
        cmbToolCondition = new ComboBox();
        chkToolOptions = new CheckBox();
        tabProcessParameters = new TabPage();
        tblProcess = new TableLayoutPanel();
        lblProcessType = new Label();
        cmbProcessType = new ComboBox();
        chkProcessOptions = new CheckBox();
        tabMachineLimits = new TabPage();
        tblMachine = new TableLayoutPanel();
        lblMachinePower = new Label();
        numMachinePower = new NumericUpDown();
        lblMachineMaxRpm = new Label();
        numMachineMaxRpm = new NumericUpDown();
        lblMachineMaxFeed = new Label();
        numMachineMaxFeed = new NumericUpDown();
        chkMachineOptions = new CheckBox();
        tabDatabase = new TabPage();
        tblDatabase = new TableLayoutPanel();
        btnTestConnection = new Button();
        lblDbServer = new Label();
        txtDbServer = new TextBox();
        lblDbPort = new Label();
        txtDbPort = new TextBox();
        lblDbName = new Label();
        txtDbName = new TextBox();
        lblDbUser = new Label();
        txtDbUser = new TextBox();
        lblDbPassword = new Label();
        txtDbPassword = new TextBox();
        btnSaveDbConfig = new Button();
        grpResults = new GroupBox();
        tblResultsContainer = new TableLayoutPanel();
        tblResults = new TableLayoutPanel();
        lblResultNameVc = new Label();
        lblResultVc = new Label();
        lblResultNameSpeed = new Label();
        lblResultSpindleSpeed = new Label();
        lblResultNameFz = new Label();
        lblResultFz = new Label();
        lblResultNameFeed = new Label();
        lblResultFeed = new Label();
        lblResultNameVolume = new Label();
        lblResultVolume = new Label();
        lblResultNamePower = new Label();
        lblResultPower = new Label();
        lblResultNameForce = new Label();
        lblResultForce = new Label();
        lblResultNameTorque = new Label();
        lblResultTorque = new Label();
        lblResultNameTime = new Label();
        lblResultTime = new Label();
        lblWarningsTitle = new Label();
        lstWarnings = new ListBox();
        layoutActions = new TableLayoutPanel();
        flowButtons = new FlowLayoutPanel();
        btnCalculate = new Button();
        btnClear = new Button();
        btnHelp = new Button();
        lblStatus = new Label();
        tabSections.SuspendLayout();
        tabMainParameters.SuspendLayout();
        tblMainParameters.SuspendLayout();
        pnlDiameter.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numDiameter).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numTeeth).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numAp).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numAe).BeginInit();
        tabToolSettings.SuspendLayout();
        tblTool.SuspendLayout();
        tabProcessParameters.SuspendLayout();
        tblProcess.SuspendLayout();
        tabMachineLimits.SuspendLayout();
        tblMachine.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numMachinePower).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numMachineMaxRpm).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numMachineMaxFeed).BeginInit();
        tabDatabase.SuspendLayout();
        tblDatabase.SuspendLayout();
        grpResults.SuspendLayout();
        tblResultsContainer.SuspendLayout();
        tblResults.SuspendLayout();
        layoutActions.SuspendLayout();
        flowButtons.SuspendLayout();
        SuspendLayout();
        // 
        // tabSections
        // 
        tabSections.Controls.Add(tabMainParameters);
        tabSections.Controls.Add(tabToolSettings);
        tabSections.Controls.Add(tabProcessParameters);
        tabSections.Controls.Add(tabMachineLimits);
        tabSections.Controls.Add(tabDatabase);
        tabSections.Dock = DockStyle.Top;
        tabSections.Location = new Point(0, 0);
        tabSections.Margin = new Padding(3, 2, 3, 2);
        tabSections.Name = "tabSections";
        tabSections.SelectedIndex = 0;
        tabSections.Size = new Size(1072, 240);
        tabSections.TabIndex = 0;
        // 
        // tabMainParameters
        // 
        tabMainParameters.Controls.Add(tblMainParameters);
        tabMainParameters.Location = new Point(4, 24);
        tabMainParameters.Margin = new Padding(3, 2, 3, 2);
        tabMainParameters.Name = "tabMainParameters";
        tabMainParameters.Padding = new Padding(9, 8, 9, 8);
        tabMainParameters.Size = new Size(1064, 212);
        tabMainParameters.TabIndex = 0;
        tabMainParameters.Text = "Основные параметры";
        tabMainParameters.UseVisualStyleBackColor = true;
        // 
        // tblMainParameters
        // 
        tblMainParameters.ColumnCount = 2;
        tblMainParameters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
        tblMainParameters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
        tblMainParameters.Controls.Add(lblDiameter, 0, 0);
        tblMainParameters.Controls.Add(pnlDiameter, 1, 0);
        tblMainParameters.Controls.Add(lblTeeth, 0, 1);
        tblMainParameters.Controls.Add(numTeeth, 1, 1);
        tblMainParameters.Controls.Add(lblMaterial, 0, 2);
        tblMainParameters.Controls.Add(cmbMaterial, 1, 2);
        tblMainParameters.Controls.Add(lblAp, 0, 3);
        tblMainParameters.Controls.Add(numAp, 1, 3);
        tblMainParameters.Controls.Add(lblAe, 0, 4);
        tblMainParameters.Controls.Add(numAe, 1, 4);
        tblMainParameters.Controls.Add(lblMaterialHint, 0, 5);
        tblMainParameters.Dock = DockStyle.Fill;
        tblMainParameters.Location = new Point(9, 8);
        tblMainParameters.Margin = new Padding(3, 2, 3, 2);
        tblMainParameters.Name = "tblMainParameters";
        tblMainParameters.RowCount = 6;
        tblMainParameters.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tblMainParameters.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tblMainParameters.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tblMainParameters.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tblMainParameters.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tblMainParameters.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tblMainParameters.Size = new Size(1046, 196);
        tblMainParameters.TabIndex = 0;
        // 
        // lblDiameter
        // 
        lblDiameter.Dock = DockStyle.Fill;
        lblDiameter.Location = new Point(3, 0);
        lblDiameter.Name = "lblDiameter";
        lblDiameter.Size = new Size(464, 30);
        lblDiameter.TabIndex = 0;
        lblDiameter.Text = "Диаметр фрезы (D), мм *";
        lblDiameter.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // pnlDiameter
        // 
        pnlDiameter.AutoSize = true;
        pnlDiameter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        pnlDiameter.Controls.Add(numDiameter);
        pnlDiameter.Controls.Add(btnSelectTool);
        pnlDiameter.Dock = DockStyle.Left;
        pnlDiameter.Location = new Point(470, 2);
        pnlDiameter.Margin = new Padding(0, 2, 3, 2);
        pnlDiameter.Name = "pnlDiameter";
        pnlDiameter.Size = new Size(266, 26);
        pnlDiameter.TabIndex = 50;
        pnlDiameter.WrapContents = false;
        // 
        // numDiameter
        // 
        numDiameter.DecimalPlaces = 2;
        numDiameter.Location = new Point(3, 2);
        numDiameter.Margin = new Padding(3, 2, 6, 2);
        numDiameter.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
        numDiameter.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
        numDiameter.Name = "numDiameter";
        numDiameter.Size = new Size(131, 23);
        numDiameter.TabIndex = 0;
        numDiameter.Value = new decimal(new int[] { 10, 0, 0, 0 });
        // 
        // btnSelectTool
        // 
        btnSelectTool.AutoSize = true;
        btnSelectTool.Location = new Point(143, 0);
        btnSelectTool.Margin = new Padding(3, 0, 3, 0);
        btnSelectTool.Name = "btnSelectTool";
        btnSelectTool.Size = new Size(120, 27);
        btnSelectTool.TabIndex = 10;
        btnSelectTool.Text = "Выбрать фрезу";
        btnSelectTool.UseVisualStyleBackColor = true;
        btnSelectTool.Click += btnSelectTool_Click;
        // 
        // lblTeeth
        // 
        lblTeeth.Dock = DockStyle.Fill;
        lblTeeth.Location = new Point(3, 30);
        lblTeeth.Name = "lblTeeth";
        lblTeeth.Size = new Size(464, 30);
        lblTeeth.TabIndex = 1;
        lblTeeth.Text = "Количество зубьев (z) *";
        lblTeeth.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // numTeeth
        // 
        numTeeth.Dock = DockStyle.Left;
        numTeeth.Location = new Point(473, 32);
        numTeeth.Margin = new Padding(3, 2, 3, 2);
        numTeeth.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
        numTeeth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numTeeth.Name = "numTeeth";
        numTeeth.Size = new Size(131, 23);
        numTeeth.TabIndex = 1;
        numTeeth.Value = new decimal(new int[] { 4, 0, 0, 0 });
        // 
        // lblMaterial
        // 
        lblMaterial.Dock = DockStyle.Fill;
        lblMaterial.Location = new Point(3, 60);
        lblMaterial.Name = "lblMaterial";
        lblMaterial.Size = new Size(464, 30);
        lblMaterial.TabIndex = 2;
        lblMaterial.Text = "Материал заготовки *";
        lblMaterial.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // cmbMaterial
        // 
        cmbMaterial.Dock = DockStyle.Fill;
        cmbMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbMaterial.FormattingEnabled = true;
        cmbMaterial.Location = new Point(473, 62);
        cmbMaterial.Margin = new Padding(3, 2, 3, 2);
        cmbMaterial.Name = "cmbMaterial";
        cmbMaterial.Size = new Size(570, 23);
        cmbMaterial.TabIndex = 2;
        // 
        // lblAp
        // 
        lblAp.Dock = DockStyle.Fill;
        lblAp.Location = new Point(3, 90);
        lblAp.Name = "lblAp";
        lblAp.Size = new Size(464, 30);
        lblAp.TabIndex = 3;
        lblAp.Text = "Глубина резания (ap), мм *";
        lblAp.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // numAp
        // 
        numAp.DecimalPlaces = 2;
        numAp.Dock = DockStyle.Left;
        numAp.Location = new Point(473, 92);
        numAp.Margin = new Padding(3, 2, 3, 2);
        numAp.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
        numAp.Name = "numAp";
        numAp.Size = new Size(131, 23);
        numAp.TabIndex = 3;
        numAp.Value = new decimal(new int[] { 2, 0, 0, 0 });
        // 
        // lblAe
        // 
        lblAe.Dock = DockStyle.Fill;
        lblAe.Location = new Point(3, 120);
        lblAe.Name = "lblAe";
        lblAe.Size = new Size(464, 30);
        lblAe.TabIndex = 4;
        lblAe.Text = "Ширина резания (ae), мм *";
        lblAe.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // numAe
        // 
        numAe.DecimalPlaces = 2;
        numAe.Dock = DockStyle.Left;
        numAe.Location = new Point(473, 122);
        numAe.Margin = new Padding(3, 2, 3, 2);
        numAe.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
        numAe.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
        numAe.Name = "numAe";
        numAe.Size = new Size(131, 23);
        numAe.TabIndex = 4;
        numAe.Value = new decimal(new int[] { 5, 0, 0, 0 });
        // 
        // lblMaterialHint
        // 
        lblMaterialHint.AutoSize = true;
        tblMainParameters.SetColumnSpan(lblMaterialHint, 2);
        lblMaterialHint.Dock = DockStyle.Fill;
        lblMaterialHint.ForeColor = Color.DimGray;
        lblMaterialHint.Location = new Point(3, 150);
        lblMaterialHint.Name = "lblMaterialHint";
        lblMaterialHint.Size = new Size(1040, 46);
        lblMaterialHint.TabIndex = 10;
        lblMaterialHint.Text = "Диапазоны материала будут показаны здесь.";
        lblMaterialHint.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // tabToolSettings
        // 
        tabToolSettings.Controls.Add(tblTool);
        tabToolSettings.Controls.Add(chkToolOptions);
        tabToolSettings.Location = new Point(4, 24);
        tabToolSettings.Margin = new Padding(3, 2, 3, 2);
        tabToolSettings.Name = "tabToolSettings";
        tabToolSettings.Padding = new Padding(9, 8, 9, 8);
        tabToolSettings.Size = new Size(1064, 212);
        tabToolSettings.TabIndex = 1;
        tabToolSettings.Text = "Настройки инструмента";
        tabToolSettings.UseVisualStyleBackColor = true;
        // 
        // tblTool
        // 
        tblTool.ColumnCount = 2;
        tblTool.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
        tblTool.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
        tblTool.Controls.Add(lblToolMaterial, 0, 0);
        tblTool.Controls.Add(cmbToolMaterial, 1, 0);
        tblTool.Controls.Add(lblToolOverhang, 0, 1);
        tblTool.Controls.Add(cmbToolOverhang, 1, 1);
        tblTool.Controls.Add(lblToolCondition, 0, 2);
        tblTool.Controls.Add(cmbToolCondition, 1, 2);
        tblTool.Dock = DockStyle.Fill;
        tblTool.Location = new Point(9, 27);
        tblTool.Margin = new Padding(3, 2, 3, 2);
        tblTool.Name = "tblTool";
        tblTool.RowCount = 4;
        tblTool.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tblTool.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tblTool.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tblTool.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tblTool.Size = new Size(1046, 177);
        tblTool.TabIndex = 1;
        // 
        // lblToolMaterial
        // 
        lblToolMaterial.Dock = DockStyle.Fill;
        lblToolMaterial.Location = new Point(3, 0);
        lblToolMaterial.Name = "lblToolMaterial";
        lblToolMaterial.Size = new Size(464, 30);
        lblToolMaterial.TabIndex = 0;
        lblToolMaterial.Text = "Материал инструмента";
        lblToolMaterial.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // cmbToolMaterial
        // 
        cmbToolMaterial.Dock = DockStyle.Left;
        cmbToolMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbToolMaterial.FormattingEnabled = true;
        cmbToolMaterial.Location = new Point(473, 2);
        cmbToolMaterial.Margin = new Padding(3, 2, 3, 2);
        cmbToolMaterial.Name = "cmbToolMaterial";
        cmbToolMaterial.Size = new Size(219, 23);
        cmbToolMaterial.TabIndex = 0;
        // 
        // lblToolOverhang
        // 
        lblToolOverhang.Dock = DockStyle.Fill;
        lblToolOverhang.Location = new Point(3, 30);
        lblToolOverhang.Name = "lblToolOverhang";
        lblToolOverhang.Size = new Size(464, 30);
        lblToolOverhang.TabIndex = 1;
        lblToolOverhang.Text = "Вылет инструмента (L/D)";
        lblToolOverhang.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // cmbToolOverhang
        // 
        cmbToolOverhang.Dock = DockStyle.Left;
        cmbToolOverhang.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbToolOverhang.FormattingEnabled = true;
        cmbToolOverhang.Location = new Point(473, 32);
        cmbToolOverhang.Margin = new Padding(3, 2, 3, 2);
        cmbToolOverhang.Name = "cmbToolOverhang";
        cmbToolOverhang.Size = new Size(219, 23);
        cmbToolOverhang.TabIndex = 1;
        // 
        // lblToolCondition
        // 
        lblToolCondition.Dock = DockStyle.Fill;
        lblToolCondition.Location = new Point(3, 60);
        lblToolCondition.Name = "lblToolCondition";
        lblToolCondition.Size = new Size(464, 30);
        lblToolCondition.TabIndex = 2;
        lblToolCondition.Text = "Состояние инструмента";
        lblToolCondition.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // cmbToolCondition
        // 
        cmbToolCondition.Dock = DockStyle.Left;
        cmbToolCondition.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbToolCondition.FormattingEnabled = true;
        cmbToolCondition.Location = new Point(473, 62);
        cmbToolCondition.Margin = new Padding(3, 2, 3, 2);
        cmbToolCondition.Name = "cmbToolCondition";
        cmbToolCondition.Size = new Size(219, 23);
        cmbToolCondition.TabIndex = 2;
        // 
        // chkToolOptions
        // 
        chkToolOptions.AutoSize = true;
        chkToolOptions.Dock = DockStyle.Top;
        chkToolOptions.Location = new Point(9, 8);
        chkToolOptions.Margin = new Padding(3, 2, 3, 2);
        chkToolOptions.Name = "chkToolOptions";
        chkToolOptions.Size = new Size(1046, 19);
        chkToolOptions.TabIndex = 0;
        chkToolOptions.Text = "Активировать настройки инструмента";
        chkToolOptions.UseVisualStyleBackColor = true;
        // 
        // tabProcessParameters
        // 
        tabProcessParameters.Controls.Add(tblProcess);
        tabProcessParameters.Controls.Add(chkProcessOptions);
        tabProcessParameters.Location = new Point(4, 24);
        tabProcessParameters.Margin = new Padding(3, 2, 3, 2);
        tabProcessParameters.Name = "tabProcessParameters";
        tabProcessParameters.Padding = new Padding(9, 8, 9, 8);
        tabProcessParameters.Size = new Size(1064, 212);
        tabProcessParameters.TabIndex = 2;
        tabProcessParameters.Text = "Параметры обработки";
        tabProcessParameters.UseVisualStyleBackColor = true;
        // 
        // tblProcess
        // 
        tblProcess.ColumnCount = 2;
        tblProcess.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
        tblProcess.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
        tblProcess.Controls.Add(lblProcessType, 0, 0);
        tblProcess.Controls.Add(cmbProcessType, 1, 0);
        tblProcess.Dock = DockStyle.Fill;
        tblProcess.Location = new Point(9, 27);
        tblProcess.Margin = new Padding(3, 2, 3, 2);
        tblProcess.Name = "tblProcess";
        tblProcess.RowCount = 2;
        tblProcess.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tblProcess.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tblProcess.Size = new Size(1046, 177);
        tblProcess.TabIndex = 1;
        // 
        // lblProcessType
        // 
        lblProcessType.Dock = DockStyle.Fill;
        lblProcessType.Location = new Point(3, 0);
        lblProcessType.Name = "lblProcessType";
        lblProcessType.Size = new Size(464, 30);
        lblProcessType.TabIndex = 0;
        lblProcessType.Text = "Тип обработки";
        lblProcessType.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // cmbProcessType
        // 
        cmbProcessType.Dock = DockStyle.Left;
        cmbProcessType.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbProcessType.FormattingEnabled = true;
        cmbProcessType.Location = new Point(473, 2);
        cmbProcessType.Margin = new Padding(3, 2, 3, 2);
        cmbProcessType.Name = "cmbProcessType";
        cmbProcessType.Size = new Size(219, 23);
        cmbProcessType.TabIndex = 0;
        // 
        // chkProcessOptions
        // 
        chkProcessOptions.AutoSize = true;
        chkProcessOptions.Dock = DockStyle.Top;
        chkProcessOptions.Location = new Point(9, 8);
        chkProcessOptions.Margin = new Padding(3, 2, 3, 2);
        chkProcessOptions.Name = "chkProcessOptions";
        chkProcessOptions.Size = new Size(1046, 19);
        chkProcessOptions.TabIndex = 0;
        chkProcessOptions.Text = "Активировать параметры обработки";
        chkProcessOptions.UseVisualStyleBackColor = true;
        // 
        // tabMachineLimits
        // 
        tabMachineLimits.Controls.Add(tblMachine);
        tabMachineLimits.Controls.Add(chkMachineOptions);
        tabMachineLimits.Location = new Point(4, 24);
        tabMachineLimits.Margin = new Padding(3, 2, 3, 2);
        tabMachineLimits.Name = "tabMachineLimits";
        tabMachineLimits.Padding = new Padding(9, 8, 9, 8);
        tabMachineLimits.Size = new Size(1064, 212);
        tabMachineLimits.TabIndex = 3;
        tabMachineLimits.Text = "Ограничения станка";
        tabMachineLimits.UseVisualStyleBackColor = true;
        // 
        // tblMachine
        // 
        tblMachine.ColumnCount = 2;
        tblMachine.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
        tblMachine.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
        tblMachine.Controls.Add(lblMachinePower, 0, 0);
        tblMachine.Controls.Add(numMachinePower, 1, 0);
        tblMachine.Controls.Add(lblMachineMaxRpm, 0, 1);
        tblMachine.Controls.Add(numMachineMaxRpm, 1, 1);
        tblMachine.Controls.Add(lblMachineMaxFeed, 0, 2);
        tblMachine.Controls.Add(numMachineMaxFeed, 1, 2);
        tblMachine.Dock = DockStyle.Fill;
        tblMachine.Location = new Point(9, 27);
        tblMachine.Margin = new Padding(3, 2, 3, 2);
        tblMachine.Name = "tblMachine";
        tblMachine.RowCount = 4;
        tblMachine.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tblMachine.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tblMachine.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tblMachine.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tblMachine.Size = new Size(1046, 177);
        tblMachine.TabIndex = 1;
        // 
        // lblMachinePower
        // 
        lblMachinePower.Dock = DockStyle.Fill;
        lblMachinePower.Location = new Point(3, 0);
        lblMachinePower.Name = "lblMachinePower";
        lblMachinePower.Size = new Size(464, 30);
        lblMachinePower.TabIndex = 0;
        lblMachinePower.Text = "Мощность шпинделя, кВт";
        lblMachinePower.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // numMachinePower
        // 
        numMachinePower.DecimalPlaces = 1;
        numMachinePower.Dock = DockStyle.Left;
        numMachinePower.Location = new Point(473, 2);
        numMachinePower.Margin = new Padding(3, 2, 3, 2);
        numMachinePower.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numMachinePower.Name = "numMachinePower";
        numMachinePower.Size = new Size(131, 23);
        numMachinePower.TabIndex = 0;
        numMachinePower.Value = new decimal(new int[] { 55, 0, 0, 65536 });
        // 
        // lblMachineMaxRpm
        // 
        lblMachineMaxRpm.Dock = DockStyle.Fill;
        lblMachineMaxRpm.Location = new Point(3, 30);
        lblMachineMaxRpm.Name = "lblMachineMaxRpm";
        lblMachineMaxRpm.Size = new Size(464, 30);
        lblMachineMaxRpm.TabIndex = 1;
        lblMachineMaxRpm.Text = "Макс. обороты шпинделя, об/мин";
        lblMachineMaxRpm.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // numMachineMaxRpm
        // 
        numMachineMaxRpm.Dock = DockStyle.Left;
        numMachineMaxRpm.Increment = new decimal(new int[] { 100, 0, 0, 0 });
        numMachineMaxRpm.Location = new Point(473, 32);
        numMachineMaxRpm.Margin = new Padding(3, 2, 3, 2);
        numMachineMaxRpm.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        numMachineMaxRpm.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
        numMachineMaxRpm.Name = "numMachineMaxRpm";
        numMachineMaxRpm.Size = new Size(131, 23);
        numMachineMaxRpm.TabIndex = 1;
        numMachineMaxRpm.Value = new decimal(new int[] { 24000, 0, 0, 0 });
        // 
        // lblMachineMaxFeed
        // 
        lblMachineMaxFeed.Dock = DockStyle.Fill;
        lblMachineMaxFeed.Location = new Point(3, 60);
        lblMachineMaxFeed.Name = "lblMachineMaxFeed";
        lblMachineMaxFeed.Size = new Size(464, 30);
        lblMachineMaxFeed.TabIndex = 2;
        lblMachineMaxFeed.Text = "Макс. подача станка, мм/мин";
        lblMachineMaxFeed.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // numMachineMaxFeed
        // 
        numMachineMaxFeed.Dock = DockStyle.Left;
        numMachineMaxFeed.Increment = new decimal(new int[] { 100, 0, 0, 0 });
        numMachineMaxFeed.Location = new Point(473, 62);
        numMachineMaxFeed.Margin = new Padding(3, 2, 3, 2);
        numMachineMaxFeed.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        numMachineMaxFeed.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
        numMachineMaxFeed.Name = "numMachineMaxFeed";
        numMachineMaxFeed.Size = new Size(131, 23);
        numMachineMaxFeed.TabIndex = 2;
        numMachineMaxFeed.Value = new decimal(new int[] { 15000, 0, 0, 0 });
        // 
        // chkMachineOptions
        // 
        chkMachineOptions.AutoSize = true;
        chkMachineOptions.Dock = DockStyle.Top;
        chkMachineOptions.Location = new Point(9, 8);
        chkMachineOptions.Margin = new Padding(3, 2, 3, 2);
        chkMachineOptions.Name = "chkMachineOptions";
        chkMachineOptions.Size = new Size(1046, 19);
        chkMachineOptions.TabIndex = 0;
        chkMachineOptions.Text = "Учитывать ограничения станка";
        chkMachineOptions.UseVisualStyleBackColor = true;
        // 
        // tabDatabase
        // 
        tabDatabase.Controls.Add(tblDatabase);
        tabDatabase.Location = new Point(4, 24);
        tabDatabase.Margin = new Padding(3, 2, 3, 2);
        tabDatabase.Name = "tabDatabase";
        tabDatabase.Padding = new Padding(9, 8, 9, 8);
        tabDatabase.Size = new Size(1064, 212);
        tabDatabase.TabIndex = 4;
        tabDatabase.Text = "Подключение к БД";
        tabDatabase.UseVisualStyleBackColor = true;
        // 
        // tblDatabase
        // 
        tblDatabase.ColumnCount = 2;
        tblDatabase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
        tblDatabase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
        tblDatabase.Controls.Add(btnTestConnection, 0, 5);
        tblDatabase.Controls.Add(lblDbServer, 0, 0);
        tblDatabase.Controls.Add(txtDbServer, 1, 0);
        tblDatabase.Controls.Add(lblDbPort, 0, 1);
        tblDatabase.Controls.Add(txtDbPort, 1, 1);
        tblDatabase.Controls.Add(lblDbName, 0, 2);
        tblDatabase.Controls.Add(txtDbName, 1, 2);
        tblDatabase.Controls.Add(lblDbUser, 0, 3);
        tblDatabase.Controls.Add(txtDbUser, 1, 3);
        tblDatabase.Controls.Add(lblDbPassword, 0, 4);
        tblDatabase.Controls.Add(txtDbPassword, 1, 4);
        tblDatabase.Controls.Add(btnSaveDbConfig, 1, 5);
        tblDatabase.Dock = DockStyle.Fill;
        tblDatabase.Location = new Point(9, 8);
        tblDatabase.Margin = new Padding(3, 2, 3, 2);
        tblDatabase.Name = "tblDatabase";
        tblDatabase.RowCount = 6;
        tblDatabase.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tblDatabase.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tblDatabase.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tblDatabase.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tblDatabase.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tblDatabase.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tblDatabase.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tblDatabase.Size = new Size(1046, 196);
        tblDatabase.TabIndex = 0;
        // 
        // btnTestConnection
        // 
        btnTestConnection.Anchor = AnchorStyles.Left;
        btnTestConnection.Location = new Point(3, 162);
        btnTestConnection.Margin = new Padding(3, 2, 3, 2);
        btnTestConnection.Name = "btnTestConnection";
        btnTestConnection.Size = new Size(150, 22);
        btnTestConnection.TabIndex = 7;
        btnTestConnection.Text = "Тест соединения";
        btnTestConnection.UseVisualStyleBackColor = true;
        btnTestConnection.Click += btnTestConnection_Click_1;
        // 
        // lblDbServer
        // 
        lblDbServer.Dock = DockStyle.Fill;
        lblDbServer.Location = new Point(3, 0);
        lblDbServer.Name = "lblDbServer";
        lblDbServer.Size = new Size(360, 30);
        lblDbServer.TabIndex = 0;
        lblDbServer.Text = "Сервер MySQL:";
        lblDbServer.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtDbServer
        // 
        txtDbServer.Dock = DockStyle.Fill;
        txtDbServer.Location = new Point(369, 2);
        txtDbServer.Margin = new Padding(3, 2, 3, 2);
        txtDbServer.Name = "txtDbServer";
        txtDbServer.Size = new Size(674, 23);
        txtDbServer.TabIndex = 0;
        txtDbServer.Text = "localhost";
        // 
        // lblDbPort
        // 
        lblDbPort.Dock = DockStyle.Fill;
        lblDbPort.Location = new Point(3, 30);
        lblDbPort.Name = "lblDbPort";
        lblDbPort.Size = new Size(360, 30);
        lblDbPort.TabIndex = 1;
        lblDbPort.Text = "Порт:";
        lblDbPort.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtDbPort
        // 
        txtDbPort.Dock = DockStyle.Left;
        txtDbPort.Location = new Point(369, 32);
        txtDbPort.Margin = new Padding(3, 2, 3, 2);
        txtDbPort.Name = "txtDbPort";
        txtDbPort.Size = new Size(100, 23);
        txtDbPort.TabIndex = 1;
        txtDbPort.Text = "3306";
        // 
        // lblDbName
        // 
        lblDbName.Dock = DockStyle.Fill;
        lblDbName.Location = new Point(3, 60);
        lblDbName.Name = "lblDbName";
        lblDbName.Size = new Size(360, 30);
        lblDbName.TabIndex = 2;
        lblDbName.Text = "Имя базы данных:";
        lblDbName.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtDbName
        // 
        txtDbName.Dock = DockStyle.Fill;
        txtDbName.Location = new Point(369, 62);
        txtDbName.Margin = new Padding(3, 2, 3, 2);
        txtDbName.Name = "txtDbName";
        txtDbName.Size = new Size(674, 23);
        txtDbName.TabIndex = 2;
        txtDbName.Text = "cnc_calc";
        txtDbName.TextChanged += txtDbName_TextChanged;
        // 
        // lblDbUser
        // 
        lblDbUser.Dock = DockStyle.Fill;
        lblDbUser.Location = new Point(3, 90);
        lblDbUser.Name = "lblDbUser";
        lblDbUser.Size = new Size(360, 30);
        lblDbUser.TabIndex = 3;
        lblDbUser.Text = "Пользователь:";
        lblDbUser.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtDbUser
        // 
        txtDbUser.Dock = DockStyle.Fill;
        txtDbUser.Location = new Point(369, 92);
        txtDbUser.Margin = new Padding(3, 2, 3, 2);
        txtDbUser.Name = "txtDbUser";
        txtDbUser.Size = new Size(674, 23);
        txtDbUser.TabIndex = 3;
        txtDbUser.Text = "root";
        // 
        // lblDbPassword
        // 
        lblDbPassword.Dock = DockStyle.Fill;
        lblDbPassword.Location = new Point(3, 120);
        lblDbPassword.Name = "lblDbPassword";
        lblDbPassword.Size = new Size(360, 30);
        lblDbPassword.TabIndex = 4;
        lblDbPassword.Text = "Пароль:";
        lblDbPassword.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtDbPassword
        // 
        txtDbPassword.Dock = DockStyle.Fill;
        txtDbPassword.Location = new Point(369, 122);
        txtDbPassword.Margin = new Padding(3, 2, 3, 2);
        txtDbPassword.Name = "txtDbPassword";
        txtDbPassword.PasswordChar = '●';
        txtDbPassword.Size = new Size(674, 23);
        txtDbPassword.TabIndex = 4;
        // 
        // btnSaveDbConfig
        // 
        btnSaveDbConfig.Anchor = AnchorStyles.Left;
        btnSaveDbConfig.Location = new Point(369, 162);
        btnSaveDbConfig.Margin = new Padding(3, 2, 3, 2);
        btnSaveDbConfig.Name = "btnSaveDbConfig";
        btnSaveDbConfig.Size = new Size(150, 22);
        btnSaveDbConfig.TabIndex = 6;
        btnSaveDbConfig.Text = "Сохранить настройки";
        btnSaveDbConfig.UseVisualStyleBackColor = true;
        btnSaveDbConfig.Click += btnSaveDbConfig_Click;
        // 
        // grpResults
        // 
        grpResults.Controls.Add(tblResultsContainer);
        grpResults.Dock = DockStyle.Fill;
        grpResults.Location = new Point(0, 240);
        grpResults.Margin = new Padding(3, 2, 3, 2);
        grpResults.Name = "grpResults";
        grpResults.Padding = new Padding(9, 8, 9, 8);
        grpResults.Size = new Size(1072, 453);
        grpResults.TabIndex = 1;
        grpResults.TabStop = false;
        grpResults.Text = "Результаты расчёта";
        // 
        // tblResultsContainer
        // 
        tblResultsContainer.ColumnCount = 1;
        tblResultsContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tblResultsContainer.Controls.Add(tblResults, 0, 0);
        tblResultsContainer.Controls.Add(lblWarningsTitle, 0, 1);
        tblResultsContainer.Controls.Add(lstWarnings, 0, 2);
        tblResultsContainer.Dock = DockStyle.Fill;
        tblResultsContainer.Location = new Point(9, 24);
        tblResultsContainer.Margin = new Padding(3, 2, 3, 2);
        tblResultsContainer.Name = "tblResultsContainer";
        tblResultsContainer.RowCount = 3;
        tblResultsContainer.RowStyles.Add(new RowStyle(SizeType.Absolute, 165F));
        tblResultsContainer.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
        tblResultsContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tblResultsContainer.Size = new Size(1054, 421);
        tblResultsContainer.TabIndex = 0;
        // 
        // tblResults
        // 
        tblResults.ColumnCount = 2;
        tblResults.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tblResults.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tblResults.Controls.Add(lblResultNameVc, 0, 0);
        tblResults.Controls.Add(lblResultVc, 1, 0);
        tblResults.Controls.Add(lblResultNameSpeed, 0, 1);
        tblResults.Controls.Add(lblResultSpindleSpeed, 1, 1);
        tblResults.Controls.Add(lblResultNameFz, 0, 2);
        tblResults.Controls.Add(lblResultFz, 1, 2);
        tblResults.Controls.Add(lblResultNameFeed, 0, 3);
        tblResults.Controls.Add(lblResultFeed, 1, 3);
        tblResults.Controls.Add(lblResultNameVolume, 0, 4);
        tblResults.Controls.Add(lblResultVolume, 1, 4);
        tblResults.Controls.Add(lblResultNamePower, 0, 5);
        tblResults.Controls.Add(lblResultPower, 1, 5);
        tblResults.Controls.Add(lblResultNameForce, 0, 6);
        tblResults.Controls.Add(lblResultForce, 1, 6);
        tblResults.Controls.Add(lblResultNameTorque, 0, 7);
        tblResults.Controls.Add(lblResultTorque, 1, 7);
        tblResults.Controls.Add(lblResultNameTime, 0, 8);
        tblResults.Controls.Add(lblResultTime, 1, 8);
        tblResults.Dock = DockStyle.Fill;
        tblResults.Location = new Point(3, 2);
        tblResults.Margin = new Padding(3, 2, 3, 2);
        tblResults.Name = "tblResults";
        tblResults.RowCount = 9;
        tblResults.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
        tblResults.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
        tblResults.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
        tblResults.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
        tblResults.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
        tblResults.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
        tblResults.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
        tblResults.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
        tblResults.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
        tblResults.Size = new Size(1048, 161);
        tblResults.TabIndex = 0;
        // 
        // lblResultNameVc
        // 
        lblResultNameVc.Dock = DockStyle.Fill;
        lblResultNameVc.Location = new Point(3, 0);
        lblResultNameVc.Name = "lblResultNameVc";
        lblResultNameVc.Size = new Size(518, 16);
        lblResultNameVc.TabIndex = 0;
        lblResultNameVc.Text = "Скорость резания (Vc)";
        lblResultNameVc.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblResultVc
        // 
        lblResultVc.Dock = DockStyle.Fill;
        lblResultVc.Location = new Point(527, 0);
        lblResultVc.Name = "lblResultVc";
        lblResultVc.Size = new Size(518, 16);
        lblResultVc.TabIndex = 1;
        lblResultVc.Text = "--";
        lblResultVc.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblResultNameSpeed
        // 
        lblResultNameSpeed.Dock = DockStyle.Fill;
        lblResultNameSpeed.Location = new Point(3, 16);
        lblResultNameSpeed.Name = "lblResultNameSpeed";
        lblResultNameSpeed.Size = new Size(518, 16);
        lblResultNameSpeed.TabIndex = 2;
        lblResultNameSpeed.Text = "Частота вращения (n)";
        lblResultNameSpeed.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblResultSpindleSpeed
        // 
        lblResultSpindleSpeed.Dock = DockStyle.Fill;
        lblResultSpindleSpeed.Location = new Point(527, 16);
        lblResultSpindleSpeed.Name = "lblResultSpindleSpeed";
        lblResultSpindleSpeed.Size = new Size(518, 16);
        lblResultSpindleSpeed.TabIndex = 3;
        lblResultSpindleSpeed.Text = "--";
        lblResultSpindleSpeed.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblResultNameFz
        // 
        lblResultNameFz.Dock = DockStyle.Fill;
        lblResultNameFz.Location = new Point(3, 32);
        lblResultNameFz.Name = "lblResultNameFz";
        lblResultNameFz.Size = new Size(518, 16);
        lblResultNameFz.TabIndex = 4;
        lblResultNameFz.Text = "Подача на зуб (fz)";
        lblResultNameFz.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblResultFz
        // 
        lblResultFz.Dock = DockStyle.Fill;
        lblResultFz.Location = new Point(527, 32);
        lblResultFz.Name = "lblResultFz";
        lblResultFz.Size = new Size(518, 16);
        lblResultFz.TabIndex = 5;
        lblResultFz.Text = "--";
        lblResultFz.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblResultNameFeed
        // 
        lblResultNameFeed.Dock = DockStyle.Fill;
        lblResultNameFeed.Location = new Point(3, 48);
        lblResultNameFeed.Name = "lblResultNameFeed";
        lblResultNameFeed.Size = new Size(518, 16);
        lblResultNameFeed.TabIndex = 6;
        lblResultNameFeed.Text = "Минутная подача (F)";
        lblResultNameFeed.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblResultFeed
        // 
        lblResultFeed.Dock = DockStyle.Fill;
        lblResultFeed.Location = new Point(527, 48);
        lblResultFeed.Name = "lblResultFeed";
        lblResultFeed.Size = new Size(518, 16);
        lblResultFeed.TabIndex = 7;
        lblResultFeed.Text = "--";
        lblResultFeed.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblResultNameVolume
        // 
        lblResultNameVolume.Dock = DockStyle.Fill;
        lblResultNameVolume.Location = new Point(3, 64);
        lblResultNameVolume.Name = "lblResultNameVolume";
        lblResultNameVolume.Size = new Size(518, 16);
        lblResultNameVolume.TabIndex = 8;
        lblResultNameVolume.Text = "Объём съёма (Q)";
        lblResultNameVolume.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblResultVolume
        // 
        lblResultVolume.Dock = DockStyle.Fill;
        lblResultVolume.Location = new Point(527, 64);
        lblResultVolume.Name = "lblResultVolume";
        lblResultVolume.Size = new Size(518, 16);
        lblResultVolume.TabIndex = 9;
        lblResultVolume.Text = "--";
        lblResultVolume.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblResultNamePower
        // 
        lblResultNamePower.Dock = DockStyle.Fill;
        lblResultNamePower.Location = new Point(3, 80);
        lblResultNamePower.Name = "lblResultNamePower";
        lblResultNamePower.Size = new Size(518, 16);
        lblResultNamePower.TabIndex = 10;
        lblResultNamePower.Text = "Требуемая мощность (Pc)";
        lblResultNamePower.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblResultPower
        // 
        lblResultPower.Dock = DockStyle.Fill;
        lblResultPower.Location = new Point(527, 80);
        lblResultPower.Name = "lblResultPower";
        lblResultPower.Size = new Size(518, 16);
        lblResultPower.TabIndex = 11;
        lblResultPower.Text = "--";
        lblResultPower.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblResultNameForce
        // 
        lblResultNameForce.Dock = DockStyle.Fill;
        lblResultNameForce.Location = new Point(3, 96);
        lblResultNameForce.Name = "lblResultNameForce";
        lblResultNameForce.Size = new Size(518, 16);
        lblResultNameForce.TabIndex = 12;
        lblResultNameForce.Text = "Сила резания (Fc)";
        lblResultNameForce.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblResultForce
        // 
        lblResultForce.Dock = DockStyle.Fill;
        lblResultForce.Location = new Point(527, 96);
        lblResultForce.Name = "lblResultForce";
        lblResultForce.Size = new Size(518, 16);
        lblResultForce.TabIndex = 13;
        lblResultForce.Text = "--";
        lblResultForce.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblResultNameTorque
        // 
        lblResultNameTorque.Dock = DockStyle.Fill;
        lblResultNameTorque.Location = new Point(3, 112);
        lblResultNameTorque.Name = "lblResultNameTorque";
        lblResultNameTorque.Size = new Size(518, 16);
        lblResultNameTorque.TabIndex = 16;
        lblResultNameTorque.Text = "Крутящий момент (Mc)";
        lblResultNameTorque.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblResultTorque
        // 
        lblResultTorque.Dock = DockStyle.Fill;
        lblResultTorque.Location = new Point(527, 112);
        lblResultTorque.Name = "lblResultTorque";
        lblResultTorque.Size = new Size(518, 16);
        lblResultTorque.TabIndex = 17;
        lblResultTorque.Text = "--";
        lblResultTorque.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblResultNameTime
        // 
        lblResultNameTime.Dock = DockStyle.Fill;
        lblResultNameTime.Location = new Point(3, 128);
        lblResultNameTime.Name = "lblResultNameTime";
        lblResultNameTime.Size = new Size(518, 33);
        lblResultNameTime.TabIndex = 18;
        lblResultNameTime.Text = "Время на 100 мм";
        lblResultNameTime.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblResultTime
        // 
        lblResultTime.Dock = DockStyle.Fill;
        lblResultTime.Location = new Point(527, 128);
        lblResultTime.Name = "lblResultTime";
        lblResultTime.Size = new Size(518, 33);
        lblResultTime.TabIndex = 19;
        lblResultTime.Text = "--";
        lblResultTime.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblWarningsTitle
        // 
        lblWarningsTitle.AutoSize = true;
        lblWarningsTitle.Dock = DockStyle.Fill;
        lblWarningsTitle.Location = new Point(3, 165);
        lblWarningsTitle.Name = "lblWarningsTitle";
        lblWarningsTitle.Size = new Size(1048, 22);
        lblWarningsTitle.TabIndex = 1;
        lblWarningsTitle.Text = "Предупреждения и рекомендации";
        lblWarningsTitle.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lstWarnings
        // 
        lstWarnings.Dock = DockStyle.Fill;
        lstWarnings.FormattingEnabled = true;
        lstWarnings.IntegralHeight = false;
        lstWarnings.ItemHeight = 15;
        lstWarnings.Location = new Point(3, 189);
        lstWarnings.Margin = new Padding(3, 2, 3, 2);
        lstWarnings.Name = "lstWarnings";
        lstWarnings.Size = new Size(1048, 230);
        lstWarnings.TabIndex = 2;
        // 
        // layoutActions
        // 
        layoutActions.ColumnCount = 2;
        layoutActions.ColumnStyles.Add(new ColumnStyle());
        layoutActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        layoutActions.Controls.Add(flowButtons, 0, 0);
        layoutActions.Controls.Add(lblStatus, 1, 0);
        layoutActions.Dock = DockStyle.Bottom;
        layoutActions.Location = new Point(0, 693);
        layoutActions.Margin = new Padding(3, 2, 3, 2);
        layoutActions.Name = "layoutActions";
        layoutActions.RowCount = 1;
        layoutActions.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
        layoutActions.Size = new Size(1072, 45);
        layoutActions.TabIndex = 2;
        // 
        // flowButtons
        // 
        flowButtons.Anchor = AnchorStyles.Left;
        flowButtons.AutoSize = true;
        flowButtons.Controls.Add(btnCalculate);
        flowButtons.Controls.Add(btnClear);
        flowButtons.Controls.Add(btnHelp);
        flowButtons.Location = new Point(3, 7);
        flowButtons.Margin = new Padding(3, 2, 3, 2);
        flowButtons.Name = "flowButtons";
        flowButtons.Size = new Size(401, 30);
        flowButtons.TabIndex = 0;
        flowButtons.WrapContents = false;
        // 
        // btnCalculate
        // 
        btnCalculate.Location = new Point(3, 2);
        btnCalculate.Margin = new Padding(3, 2, 3, 2);
        btnCalculate.Name = "btnCalculate";
        btnCalculate.Size = new Size(105, 26);
        btnCalculate.TabIndex = 0;
        btnCalculate.Text = "Рассчитать";
        btnCalculate.UseVisualStyleBackColor = true;
        btnCalculate.Click += btnCalculate_Click;
        // 
        // btnClear
        // 
        btnClear.Location = new Point(114, 2);
        btnClear.Margin = new Padding(3, 2, 3, 2);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(88, 26);
        btnClear.TabIndex = 1;
        btnClear.Text = "Очистить";
        btnClear.UseVisualStyleBackColor = true;
        btnClear.Click += btnClear_Click;
        // 
        // btnHelp
        // 
        btnHelp.Location = new Point(208, 2);
        btnHelp.Margin = new Padding(3, 2, 3, 2);
        btnHelp.Name = "btnHelp";
        btnHelp.Size = new Size(190, 26);
        btnHelp.TabIndex = 2;
        btnHelp.Text = "Справочная информация";
        btnHelp.UseVisualStyleBackColor = true;
        btnHelp.Click += btnHelp_Click;
        // 
        // lblStatus
        // 
        lblStatus.Dock = DockStyle.Fill;
        lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
        lblStatus.ForeColor = Color.DimGray;
        lblStatus.Location = new Point(410, 0);
        lblStatus.Name = "lblStatus";
        lblStatus.Padding = new Padding(9, 0, 0, 0);
        lblStatus.Size = new Size(659, 45);
        lblStatus.TabIndex = 1;
        lblStatus.Text = "Готово.";
        lblStatus.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1072, 738);
        Controls.Add(grpResults);
        Controls.Add(tabSections);
        Controls.Add(layoutActions);
        Margin = new Padding(3, 2, 3, 2);
        MinimumSize = new Size(877, 610);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ЧПУ-калькулятор режимов резания фрезерования";
        tabSections.ResumeLayout(false);
        tabMainParameters.ResumeLayout(false);
        tblMainParameters.ResumeLayout(false);
        tblMainParameters.PerformLayout();
        pnlDiameter.ResumeLayout(false);
        pnlDiameter.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numDiameter).EndInit();
        ((System.ComponentModel.ISupportInitialize)numTeeth).EndInit();
        ((System.ComponentModel.ISupportInitialize)numAp).EndInit();
        ((System.ComponentModel.ISupportInitialize)numAe).EndInit();
        tabToolSettings.ResumeLayout(false);
        tabToolSettings.PerformLayout();
        tblTool.ResumeLayout(false);
        tabProcessParameters.ResumeLayout(false);
        tabProcessParameters.PerformLayout();
        tblProcess.ResumeLayout(false);
        tabMachineLimits.ResumeLayout(false);
        tabMachineLimits.PerformLayout();
        tblMachine.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numMachinePower).EndInit();
        ((System.ComponentModel.ISupportInitialize)numMachineMaxRpm).EndInit();
        ((System.ComponentModel.ISupportInitialize)numMachineMaxFeed).EndInit();
        tabDatabase.ResumeLayout(false);
        tblDatabase.ResumeLayout(false);
        tblDatabase.PerformLayout();
        grpResults.ResumeLayout(false);
        tblResultsContainer.ResumeLayout(false);
        tblResultsContainer.PerformLayout();
        tblResults.ResumeLayout(false);
        layoutActions.ResumeLayout(false);
        layoutActions.PerformLayout();
        flowButtons.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private Label lblHeader;
    private Label lblSubHeader;
    private TabControl tabSections;
    private TabPage tabMainParameters;
    private TabPage tabToolSettings;
    private TabPage tabProcessParameters;
    private TabPage tabMachineLimits;
    private TableLayoutPanel tblMainParameters;
    private Label lblDiameter;
    private FlowLayoutPanel pnlDiameter;
    private NumericUpDown numDiameter;
    private Button btnSelectTool;
    private Label lblTeeth;
    private NumericUpDown numTeeth;
    private Label lblMaterial;
    private ComboBox cmbMaterial;
    private Label lblAp;
    private NumericUpDown numAp;
    private Label lblAe;
    private NumericUpDown numAe;
    private Label lblMaterialHint;
    private TableLayoutPanel tblTool;
    private Label lblToolMaterial;
    private ComboBox cmbToolMaterial;
    private Label lblToolOverhang;
    private ComboBox cmbToolOverhang;
    private Label lblToolCondition;
    private ComboBox cmbToolCondition;
    private CheckBox chkToolOptions;
    private TableLayoutPanel tblProcess;
    private Label lblProcessType;
    private ComboBox cmbProcessType;
    private CheckBox chkProcessOptions;
    private TableLayoutPanel tblMachine;
    private Label lblMachinePower;
    private NumericUpDown numMachinePower;
    private Label lblMachineMaxRpm;
    private NumericUpDown numMachineMaxRpm;
    private Label lblMachineMaxFeed;
    private NumericUpDown numMachineMaxFeed;
    private CheckBox chkMachineOptions;
    private GroupBox grpResults;
    private TableLayoutPanel tblResults;
    private Label lblResultNameVc;
    private Label lblResultVc;
    private Label lblResultNameSpeed;
    private Label lblResultSpindleSpeed;
    private Label lblResultNameFz;
    private Label lblResultFz;
    private Label lblResultNameFeed;
    private Label lblResultFeed;
    private Label lblResultNameVolume;
    private Label lblResultVolume;
    private Label lblResultNameForce;
    private Label lblResultForce;
    private Label lblResultNamePower;
    private Label lblResultPower;
    private Label lblResultNameTorque;
    private Label lblResultTorque;
    private Label lblResultNameTime;
    private Label lblResultTime;
    private Label lblWarningsTitle;
    private TableLayoutPanel layoutActions;
    private FlowLayoutPanel flowButtons;
    private Button btnCalculate;
    private Button btnClear;
    private Button btnHelp;
    private Label lblStatus;
    private TableLayoutPanel tblResultsContainer;
    private TabPage tabDatabase;
    private TableLayoutPanel tblDatabase;
    private Label lblDbServer;
    private TextBox txtDbServer;
    private Label lblDbPort;
    private TextBox txtDbPort;
    private Label lblDbName;
    private TextBox txtDbName;
    private Label lblDbUser;
    private TextBox txtDbUser;
    private Label lblDbPassword;
    private TextBox txtDbPassword;
    private Button btnSaveDbConfig;
    private ListBox lstWarnings;
    private Button btnTestConnection;
}
