namespace Review_Q3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblNum3;
        private System.Windows.Forms.Label lblNum4;
        private System.Windows.Forms.Label lblNum5;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox listBoxLottery;
        private System.Windows.Forms.Label labelResult;

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
            topPanel = new Panel();
            lblNum1 = new Label();
            lblNum2 = new Label();
            lblNum3 = new Label();
            lblNum4 = new Label();
            lblNum5 = new Label();
            btnGenerate = new Button();
            btnLoad = new Button();
            btnExit = new Button();
            listBoxLottery = new ListBox();
            labelResult = new Label();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BorderStyle = BorderStyle.FixedSingle;
            topPanel.Controls.Add(lblNum1);
            topPanel.Controls.Add(lblNum2);
            topPanel.Controls.Add(lblNum3);
            topPanel.Controls.Add(lblNum4);
            topPanel.Controls.Add(lblNum5);
            topPanel.Location = new Point(20, 20);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(597, 120);
            topPanel.TabIndex = 0;
            // 
            // lblNum1
            // 
            lblNum1.BorderStyle = BorderStyle.FixedSingle;
            lblNum1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblNum1.Location = new Point(10, 15);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(80, 80);
            lblNum1.TabIndex = 0;
            lblNum1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNum2
            // 
            lblNum2.BorderStyle = BorderStyle.FixedSingle;
            lblNum2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblNum2.Location = new Point(110, 15);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(80, 80);
            lblNum2.TabIndex = 1;
            lblNum2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNum3
            // 
            lblNum3.BorderStyle = BorderStyle.FixedSingle;
            lblNum3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblNum3.Location = new Point(232, 15);
            lblNum3.Name = "lblNum3";
            lblNum3.Size = new Size(80, 80);
            lblNum3.TabIndex = 2;
            lblNum3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNum4
            // 
            lblNum4.BorderStyle = BorderStyle.FixedSingle;
            lblNum4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblNum4.Location = new Point(356, 15);
            lblNum4.Name = "lblNum4";
            lblNum4.Size = new Size(80, 80);
            lblNum4.TabIndex = 3;
            lblNum4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNum5
            // 
            lblNum5.BorderStyle = BorderStyle.FixedSingle;
            lblNum5.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblNum5.Location = new Point(479, 15);
            lblNum5.Name = "lblNum5";
            lblNum5.Size = new Size(80, 80);
            lblNum5.TabIndex = 4;
            lblNum5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGenerate
            // 
            btnGenerate.Enabled = false;
            btnGenerate.Location = new Point(140, 160);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(120, 50);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "產生號碼";
            btnGenerate.Visible = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(300, 160);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(120, 50);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "開獎號碼";
            btnLoad.Click += btnLoad_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(460, 160);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 50);
            btnExit.TabIndex = 3;
            btnExit.Text = "離開";
            btnExit.Click += btnExit_Click;
            // 
            // listBoxLottery
            // 
            listBoxLottery.FormattingEnabled = true;
            listBoxLottery.Location = new Point(20, 240);
            listBoxLottery.Name = "listBoxLottery";
            listBoxLottery.Size = new Size(420, 211);
            listBoxLottery.TabIndex = 4;
            // 
            // labelResult
            // 
            labelResult.BorderStyle = BorderStyle.FixedSingle;
            labelResult.Font = new Font("Segoe UI", 10F);
            labelResult.Location = new Point(460, 240);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(400, 220);
            labelResult.TabIndex = 5;
            labelResult.Text = "中獎比對結果";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 500);
            Controls.Add(topPanel);
            Controls.Add(btnGenerate);
            Controls.Add(btnLoad);
            Controls.Add(btnExit);
            Controls.Add(listBoxLottery);
            Controls.Add(labelResult);
            Name = "Form1";
            Text = "樂透號碼產生器";
            topPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
