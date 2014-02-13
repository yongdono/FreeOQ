﻿// Type: OpenQuant.Shared.Data.Import.CSV.CustomFormatHelpDialog
// Assembly: OpenQuant.Shared, Version=1.0.5037.20293, Culture=neutral, PublicKeyToken=null
// MVID: A690BAEF-D039-46EF-A391-4A4F5A74669E
// Assembly location: E:\OpenQuant\Bin\OpenQuant.Shared.dll

using OpenQuant.Shared.Properties;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Import.CSV
{
  internal class CustomFormatHelpDialog : Form
  {
    private IContainer components;
    private Panel panel1;
    private Button btnClose;
    private WebBrowser browser;

    public CustomFormatHelpDialog()
    {
      this.InitializeComponent();
      this.browser.DocumentText = Resources.formats;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.panel1 = new Panel();
      this.btnClose = new Button();
      this.browser = new WebBrowser();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      this.panel1.Controls.Add((Control) this.btnClose);
      this.panel1.Dock = DockStyle.Bottom;
      this.panel1.Location = new Point(0, 396);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(531, 34);
      this.panel1.TabIndex = 0;
      this.btnClose.DialogResult = DialogResult.Cancel;
      this.btnClose.Location = new Point(447, 6);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(70, 22);
      this.btnClose.TabIndex = 0;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.browser.Dock = DockStyle.Fill;
      this.browser.IsWebBrowserContextMenuEnabled = false;
      this.browser.Location = new Point(0, 0);
      this.browser.MinimumSize = new Size(20, 20);
      this.browser.Name = "browser";
      this.browser.Size = new Size(531, 396);
      this.browser.TabIndex = 1;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnClose;
      this.ClientSize = new Size(531, 430);
      this.Controls.Add((Control) this.browser);
      this.Controls.Add((Control) this.panel1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "CustomFormatHelpDialog";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Custom Format Help";
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
