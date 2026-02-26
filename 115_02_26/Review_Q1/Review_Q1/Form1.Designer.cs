namespace Review_Q1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Controls
        private System.Windows.Forms.Label computerLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.PictureBox computerPictureBox;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button stoneButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button scissorButton;
        private System.Windows.Forms.Button exitButton;

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
            computerLabel = new Label();
            playerLabel = new Label();
            computerPictureBox = new PictureBox();
            playerPictureBox = new PictureBox();
            resultLabel = new Label();
            stoneButton = new Button();
            paperButton = new Button();
            scissorButton = new Button();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)computerPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerPictureBox).BeginInit();
            SuspendLayout();
            // 
            // computerLabel
            // 
            computerLabel.AutoSize = true;
            computerLabel.Font = new Font("微軟正黑體", 18F);
            computerLabel.Location = new Point(100, 18);
            computerLabel.Name = "computerLabel";
            computerLabel.Size = new Size(128, 45);
            computerLabel.TabIndex = 0;
            computerLabel.Text = "電腦出";
            // 
            // playerLabel
            // 
            playerLabel.AutoSize = true;
            playerLabel.Font = new Font("微軟正黑體", 18F);
            playerLabel.Location = new Point(460, 18);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new Size(128, 45);
            playerLabel.TabIndex = 1;
            playerLabel.Text = "玩家出";
            // 
            // computerPictureBox
            // 
            computerPictureBox.BackColor = Color.BurlyWood;
            computerPictureBox.Image = Properties.Resources.stone_computer;
            computerPictureBox.Location = new Point(46, 60);
            computerPictureBox.Name = "computerPictureBox";
            computerPictureBox.Size = new Size(250, 140);
            computerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            computerPictureBox.TabIndex = 2;
            computerPictureBox.TabStop = false;
            // 
            // playerPictureBox
            // 
            playerPictureBox.BackColor = Color.BurlyWood;
            playerPictureBox.Image = Properties.Resources.stone_player;
            playerPictureBox.Location = new Point(410, 60);
            playerPictureBox.Name = "playerPictureBox";
            playerPictureBox.Size = new Size(250, 140);
            playerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            playerPictureBox.TabIndex = 3;
            playerPictureBox.TabStop = false;
            // 
            // resultLabel
            // 
            resultLabel.BorderStyle = BorderStyle.FixedSingle;
            resultLabel.Font = new Font("微軟正黑體", 20F);
            resultLabel.Location = new Point(150, 220);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(400, 50);
            resultLabel.TabIndex = 4;
            resultLabel.Text = "準備遊戲";
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // stoneButton
            // 
            stoneButton.Font = new Font("微軟正黑體", 18F);
            stoneButton.Location = new Point(70, 290);
            stoneButton.Name = "stoneButton";
            stoneButton.Size = new Size(140, 60);
            stoneButton.TabIndex = 5;
            stoneButton.Text = "石頭";
            stoneButton.UseVisualStyleBackColor = true;
            stoneButton.Click += stoneButton_Click;
            // 
            // paperButton
            // 
            paperButton.Font = new Font("微軟正黑體", 18F);
            paperButton.Location = new Point(280, 290);
            paperButton.Name = "paperButton";
            paperButton.Size = new Size(140, 60);
            paperButton.TabIndex = 6;
            paperButton.Text = "布";
            paperButton.UseVisualStyleBackColor = true;
            paperButton.Click += paperButton_Click;
            // 
            // scissorButton
            // 
            scissorButton.Font = new Font("微軟正黑體", 18F);
            scissorButton.Location = new Point(490, 290);
            scissorButton.Name = "scissorButton";
            scissorButton.Size = new Size(140, 60);
            scissorButton.TabIndex = 7;
            scissorButton.Text = "剪刀";
            scissorButton.UseVisualStyleBackColor = true;
            scissorButton.Click += scissorButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("微軟正黑體", 18F);
            exitButton.Location = new Point(225, 358);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(217, 50);
            exitButton.TabIndex = 8;
            exitButton.Text = "結束遊戲";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 420);
            Controls.Add(computerLabel);
            Controls.Add(playerLabel);
            Controls.Add(computerPictureBox);
            Controls.Add(playerPictureBox);
            Controls.Add(resultLabel);
            Controls.Add(stoneButton);
            Controls.Add(paperButton);
            Controls.Add(scissorButton);
            Controls.Add(exitButton);
            Name = "Form1";
            Text = "猜拳遊戲";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)computerPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
