namespace CSV_Reader
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
            // 初始化列表框元件
            this.averagesListBox = new System.Windows.Forms.ListBox();
            // 初始化「取得分數」按鈕元件
            this.getScoresButton = new System.Windows.Forms.Button();
            // 初始化「結束」按鈕元件
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // averagesListBox
            // 顯示平均成績的列表框
            this.averagesListBox.FormattingEnabled = true;
            this.averagesListBox.Location = new System.Drawing.Point(12, 15);
            this.averagesListBox.Name = "averagesListBox";
            this.averagesListBox.Size = new System.Drawing.Size(360, 200);
            this.averagesListBox.TabIndex = 0;
            this.averagesListBox.Font = new System.Drawing.Font("微軟正黑體", 18F);
            // 
            // getScoresButton
            // 「取得分數」按鈕：點擊後讀取CSV檔案並計算平均成績
            this.getScoresButton.Location = new System.Drawing.Point(50, 230);
            this.getScoresButton.Name = "getScoresButton";
            this.getScoresButton.Size = new System.Drawing.Size(130, 50);
            this.getScoresButton.TabIndex = 1;
            this.getScoresButton.Text = "取得分數";
            this.getScoresButton.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.getScoresButton.UseVisualStyleBackColor = true;
            this.getScoresButton.Click += new System.EventHandler(this.getScoresButton_Click);
            // 
            // exitButton
            // 「結束」按鈕：點擊後關閉應用程式
            this.exitButton.Location = new System.Drawing.Point(200, 230);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(130, 50);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "結束";
            this.exitButton.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // CSV讀取器應用程式主視窗
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 300);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getScoresButton);
            this.Controls.Add(this.averagesListBox);
            this.Name = "Form1";
            this.Text = "CSV 讀取器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox averagesListBox;
        private System.Windows.Forms.Button getScoresButton;
        private System.Windows.Forms.Button exitButton;
    }
}

