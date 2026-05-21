namespace Account_Simulator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.depositGroupBox = new System.Windows.Forms.GroupBox();
            this.depositButton = new System.Windows.Forms.Button();
            this.depositTextBox = new System.Windows.Forms.TextBox();
            this.depositAmountDescriptionLabel = new System.Windows.Forms.Label();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.openingAmountLabel = new System.Windows.Forms.Label();
            this.openingAmountTextBox = new System.Windows.Forms.TextBox();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.accountGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.withdrawTextBox = new System.Windows.Forms.TextBox();
            this.withdrawAmountDescriptionLabel = new System.Windows.Forms.Label();
            this.balanceDescriptionLabel = new System.Windows.Forms.Label();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.depositGroupBox.SuspendLayout();
            this.accountGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // depositGroupBox
            // 
            this.depositGroupBox.Controls.Add(this.depositButton);
            this.depositGroupBox.Controls.Add(this.depositTextBox);
            this.depositGroupBox.Controls.Add(this.depositAmountDescriptionLabel);
            this.depositGroupBox.Location = new System.Drawing.Point(46, 330);
            this.depositGroupBox.Name = "depositGroupBox";
            this.depositGroupBox.Size = new System.Drawing.Size(297, 208);
            this.depositGroupBox.TabIndex = 0;
            this.depositGroupBox.TabStop = false;
            this.depositGroupBox.Text = "存款";
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(156, 145);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(116, 45);
            this.depositButton.TabIndex = 2;
            this.depositButton.Text = "存款";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // depositTextBox
            // 
            this.depositTextBox.Location = new System.Drawing.Point(140, 63);
            this.depositTextBox.Name = "depositTextBox";
            this.depositTextBox.Size = new System.Drawing.Size(141, 53);
            this.depositTextBox.TabIndex = 1;
            // 
            // depositAmountDescriptionLabel
            // 
            this.depositAmountDescriptionLabel.AutoSize = true;
            this.depositAmountDescriptionLabel.Location = new System.Drawing.Point(6, 70);
            this.depositAmountDescriptionLabel.Name = "depositAmountDescriptionLabel";
            this.depositAmountDescriptionLabel.Size = new System.Drawing.Size(128, 46);
            this.depositAmountDescriptionLabel.TabIndex = 0;
            this.depositAmountDescriptionLabel.Text = "金額：";
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.Location = new System.Drawing.Point(106, 49);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(128, 53);
            this.accountNumberLabel.TabIndex = 0;
            this.accountNumberLabel.Text = "帳號：";
            this.accountNumberLabel.Click += new System.EventHandler(this.accountNumberLabel_Click);
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Location = new System.Drawing.Point(280, 52);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(246, 53);
            this.accountNumberTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(106, 107);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(128, 50);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "姓名：";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(280, 107);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(246, 53);
            this.nameTextBox.TabIndex = 3;
            // 
            // openingAmountLabel
            // 
            this.openingAmountLabel.Location = new System.Drawing.Point(106, 169);
            this.openingAmountLabel.Name = "openingAmountLabel";
            this.openingAmountLabel.Size = new System.Drawing.Size(135, 46);
            this.openingAmountLabel.TabIndex = 4;
            this.openingAmountLabel.Text = "開戶金額：";
            // 
            // openingAmountTextBox
            // 
            this.openingAmountTextBox.Location = new System.Drawing.Point(280, 166);
            this.openingAmountTextBox.Name = "openingAmountTextBox";
            this.openingAmountTextBox.Size = new System.Drawing.Size(246, 53);
            this.openingAmountTextBox.TabIndex = 5;
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(564, 179);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(177, 55);
            this.createAccountButton.TabIndex = 6;
            this.createAccountButton.Text = "建立帳戶";
            // 
            // accountGroupBox
            // 
            this.accountGroupBox.Controls.Add(this.accountNumberLabel);
            this.accountGroupBox.Controls.Add(this.accountNumberTextBox);
            this.accountGroupBox.Controls.Add(this.nameLabel);
            this.accountGroupBox.Controls.Add(this.nameTextBox);
            this.accountGroupBox.Controls.Add(this.openingAmountLabel);
            this.accountGroupBox.Controls.Add(this.openingAmountTextBox);
            this.accountGroupBox.Controls.Add(this.createAccountButton);
            this.accountGroupBox.Location = new System.Drawing.Point(20, 20);
            this.accountGroupBox.Name = "accountGroupBox";
            this.accountGroupBox.Size = new System.Drawing.Size(756, 249);
            this.accountGroupBox.TabIndex = 5;
            this.accountGroupBox.TabStop = false;
            this.accountGroupBox.Text = "建立帳戶";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.withdrawButton);
            this.groupBox1.Controls.Add(this.withdrawTextBox);
            this.groupBox1.Controls.Add(this.withdrawAmountDescriptionLabel);
            this.groupBox1.Location = new System.Drawing.Point(373, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 191);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "提款";
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(154, 126);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(121, 47);
            this.withdrawButton.TabIndex = 2;
            this.withdrawButton.Text = "提款";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // withdrawTextBox
            // 
            this.withdrawTextBox.Location = new System.Drawing.Point(134, 69);
            this.withdrawTextBox.Name = "withdrawTextBox";
            this.withdrawTextBox.Size = new System.Drawing.Size(151, 53);
            this.withdrawTextBox.TabIndex = 1;
            // 
            // withdrawAmountDescriptionLabel
            // 
            this.withdrawAmountDescriptionLabel.AutoSize = true;
            this.withdrawAmountDescriptionLabel.Location = new System.Drawing.Point(6, 72);
            this.withdrawAmountDescriptionLabel.Name = "withdrawAmountDescriptionLabel";
            this.withdrawAmountDescriptionLabel.Size = new System.Drawing.Size(128, 46);
            this.withdrawAmountDescriptionLabel.TabIndex = 0;
            this.withdrawAmountDescriptionLabel.Text = "金額：";
            // 
            // balanceDescriptionLabel
            // 
            this.balanceDescriptionLabel.AutoSize = true;
            this.balanceDescriptionLabel.Location = new System.Drawing.Point(690, 347);
            this.balanceDescriptionLabel.Name = "balanceDescriptionLabel";
            this.balanceDescriptionLabel.Size = new System.Drawing.Size(128, 46);
            this.balanceDescriptionLabel.TabIndex = 2;
            this.balanceDescriptionLabel.Text = "餘額：";
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(698, 416);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.ReadOnly = true;
            this.balanceTextBox.Size = new System.Drawing.Size(256, 53);
            this.balanceTextBox.TabIndex = 3;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(767, 493);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(135, 61);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 596);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.balanceDescriptionLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.depositGroupBox);
            this.Controls.Add(this.accountGroupBox);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "帳戶模擬器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.depositGroupBox.ResumeLayout(false);
            this.depositGroupBox.PerformLayout();
            this.accountGroupBox.ResumeLayout(false);
            this.accountGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox depositGroupBox;
        private System.Windows.Forms.GroupBox accountGroupBox;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label openingAmountLabel;
        private System.Windows.Forms.TextBox openingAmountTextBox;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.TextBox depositTextBox;
        private System.Windows.Forms.Label depositAmountDescriptionLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.TextBox withdrawTextBox;
        private System.Windows.Forms.Label withdrawAmountDescriptionLabel;
        private System.Windows.Forms.Label balanceDescriptionLabel;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Button exitButton;
    }
}

