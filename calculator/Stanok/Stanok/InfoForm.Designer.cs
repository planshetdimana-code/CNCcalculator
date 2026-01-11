using System.Drawing;
using System.Windows.Forms;

namespace Stanok;

partial class InfoForm
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
        infoTextBox = new RichTextBox();
        btnClose = new Button();
        SuspendLayout();
        // 
        // infoTextBox
        // 
        infoTextBox.Dock = DockStyle.Top;
        infoTextBox.Location = new Point(0, 0);
        infoTextBox.Name = "infoTextBox";
        infoTextBox.ReadOnly = true;
        infoTextBox.Size = new Size(800, 520);
        infoTextBox.TabIndex = 0;
        infoTextBox.Text = "";
        infoTextBox.BorderStyle = BorderStyle.None;
        infoTextBox.BackColor = Color.White;
        infoTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        // 
        // btnClose
        // 
        btnClose.Anchor = AnchorStyles.Bottom;
        btnClose.Location = new Point(350, 530);
        btnClose.Name = "btnClose";
        btnClose.Size = new Size(100, 32);
        btnClose.TabIndex = 1;
        btnClose.Text = "Закрыть";
        btnClose.UseVisualStyleBackColor = true;
        btnClose.Click += btnClose_Click;
        // 
        // InfoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(800, 574);
        Controls.Add(btnClose);
        Controls.Add(infoTextBox);
        AcceptButton = btnClose;
        CancelButton = btnClose;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "InfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Справочная информация";
        ResumeLayout(false);
    }

    #endregion

    private RichTextBox infoTextBox;
    private Button btnClose;
}
