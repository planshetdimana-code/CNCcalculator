using System.Drawing;
using System.Windows.Forms;

namespace Stanok;

partial class ToolPickerForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        gridTools = new DataGridView();
        colImage = new DataGridViewImageColumn();
        colDiameter = new DataGridViewTextBoxColumn();
        colFlutes = new DataGridViewTextBoxColumn();
        panelButtons = new FlowLayoutPanel();
        btnSelect = new Button();
        btnCancel = new Button();
        ((System.ComponentModel.ISupportInitialize)gridTools).BeginInit();
        SuspendLayout();
        // 
        // gridTools
        // 
        gridTools.AllowUserToAddRows = false;
        gridTools.AllowUserToDeleteRows = false;
        gridTools.AllowUserToResizeRows = false;
        gridTools.BackgroundColor = Color.White;
        gridTools.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        gridTools.Columns.AddRange(new DataGridViewColumn[] { colImage, colDiameter, colFlutes });
        gridTools.Dock = DockStyle.Fill;
        gridTools.Location = new Point(0, 0);
        gridTools.MultiSelect = false;
        gridTools.Name = "gridTools";
        gridTools.ReadOnly = true;
        gridTools.RowHeadersVisible = false;
        gridTools.RowTemplate.Height = 80;
        gridTools.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        gridTools.Size = new Size(520, 360);
        gridTools.TabIndex = 0;
        // 
        // colImage
        // 
        colImage.DataPropertyName = "ImagePath";
        colImage.HeaderText = "Изображение";
        colImage.ImageLayout = DataGridViewImageCellLayout.Zoom;
        colImage.Name = "colImage";
        colImage.ReadOnly = true;
        colImage.Width = 120;
        colImage.ValuesAreIcons = false;
        // 
        // colDiameter
        // 
        colDiameter.DataPropertyName = "Diameter";
        colDiameter.HeaderText = "Диаметр, мм";
        colDiameter.Name = "colDiameter";
        colDiameter.ReadOnly = true;
        colDiameter.Width = 140;
        // 
        // colFlutes
        // 
        colFlutes.DataPropertyName = "Flutes";
        colFlutes.HeaderText = "Зубьев";
        colFlutes.Name = "colFlutes";
        colFlutes.ReadOnly = true;
        colFlutes.Width = 80;
        // 
        // panelButtons
        // 
        panelButtons.Dock = DockStyle.Bottom;
        panelButtons.FlowDirection = FlowDirection.RightToLeft;
        panelButtons.Location = new Point(0, 360);
        panelButtons.Name = "panelButtons";
        panelButtons.Padding = new Padding(10);
        panelButtons.Size = new Size(520, 50);
        panelButtons.TabIndex = 1;
        panelButtons.Controls.Add(btnCancel);
        panelButtons.Controls.Add(btnSelect);
        // 
        // btnSelect
        // 
        btnSelect.AutoSize = true;
        btnSelect.Location = new Point(322, 13);
        btnSelect.Name = "btnSelect";
        btnSelect.Size = new Size(85, 27);
        btnSelect.TabIndex = 0;
        btnSelect.Text = "Выбрать";
        btnSelect.UseVisualStyleBackColor = true;
        btnSelect.Click += btnSelect_Click;
        // 
        // btnCancel
        // 
        btnCancel.AutoSize = true;
        btnCancel.Location = new Point(413, 13);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(88, 27);
        btnCancel.TabIndex = 1;
        btnCancel.Text = "Отмена";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // ToolPickerForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(520, 410);
        Controls.Add(gridTools);
        Controls.Add(panelButtons);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "ToolPickerForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Каталог фрез";
        ((System.ComponentModel.ISupportInitialize)gridTools).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView gridTools;
    private DataGridViewImageColumn colImage;
    private DataGridViewTextBoxColumn colDiameter;
    private DataGridViewTextBoxColumn colFlutes;
    private FlowLayoutPanel panelButtons;
    private Button btnSelect;
    private Button btnCancel;
}

