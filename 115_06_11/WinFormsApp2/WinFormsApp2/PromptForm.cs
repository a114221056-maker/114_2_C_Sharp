using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2
{
    /// <summary>
    /// 簡單的輸入提示視窗，提供一個 Label 與 TextBox 用以接收使用者輸入
    /// </summary>
    public class PromptForm : Form
    {
        private Label lblPrompt;
        private TextBox txtInput;
        private Button btnOK;
        private Button btnCancel;

        public string InputText => txtInput.Text;

        public PromptForm(string prompt)
        {
            InitializeComponent();
            lblPrompt.Text = prompt;
        }

        private void InitializeComponent()
        {
            this.Text = "輸入";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ClientSize = new Size(420, 160);
            this.Font = new Font("微軟正黑體", 14F);

            lblPrompt = new Label() { Text = "提示：", Location = new Point(20, 20), AutoSize = true };
            txtInput = new TextBox() { Location = new Point(20, 50), Size = new Size(360, 30) };

            btnOK = new Button() { Text = "確定", Location = new Point(200, 100), Size = new Size(90, 36) };
            btnCancel = new Button() { Text = "取消", Location = new Point(300, 100), Size = new Size(90, 36) };

            btnOK.Click += BtnOK_Click;
            btnCancel.Click += BtnCancel_Click;

            this.Controls.Add(lblPrompt);
            this.Controls.Add(txtInput);
            this.Controls.Add(btnOK);
            this.Controls.Add(btnCancel);
        }

        private void BtnOK_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
