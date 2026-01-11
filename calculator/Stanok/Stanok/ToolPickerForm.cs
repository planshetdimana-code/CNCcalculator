using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Stanok.Models;
using Stanok.Services;

namespace Stanok;

public partial class ToolPickerForm : Form
{
    private BindingList<Tool> _tools = new();
    public Tool? SelectedTool { get; private set; }

    public ToolPickerForm()
    {
        InitializeComponent();
        Load += (_, _) => Populate();
        gridTools.CellFormatting += gridTools_CellFormatting;
    }

    private void Populate()
    {
        _tools = new BindingList<Tool>(ToolCatalog.GetTools().ToList());
        gridTools.AutoGenerateColumns = false;
        gridTools.DataSource = _tools;
    }

    private void btnSelect_Click(object sender, EventArgs e)
    {
        if (gridTools.CurrentRow?.DataBoundItem is Tool tool)
        {
            SelectedTool = tool;
            DialogResult = DialogResult.OK;
        }
        else
        {
            MessageBox.Show("Выберите фрезу из списка.", "Каталог фрез", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void btnCancel_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;

    private void gridTools_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (gridTools.Columns[e.ColumnIndex].Name == "colImage")
        {
            if (gridTools.Rows[e.RowIndex].DataBoundItem is Tool t && File.Exists(t.ImagePath))
            {
                try
                {
                    using var img = Image.FromFile(t.ImagePath);
                    e.Value = new Bitmap(img);
                    e.FormattingApplied = true;
                }
                catch { /* ignore */ }
            }
        }
    }
}
