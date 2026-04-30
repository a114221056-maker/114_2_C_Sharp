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
            this.averagesListBox = new System.Windows.Forms.ListBox();
            this.getScoresButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // 設定整個表單的字型為繁體中文常用字型，字型大小為 18
            // 這樣子表單內的元件（若未單獨指定字型）會使用此字型大小，便於顯示繁體中文與較大字體
            //
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // averagesListBox
            // 
            // 以下為顯示分數或平均值的清單框，調整大小以支援較大字型
            this.averagesListBox.FormattingEnabled = true;
            this.averagesListBox.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.averagesListBox.Location = new System.Drawing.Point(12, 12);
            this.averagesListBox.Name = "averagesListBox";
            this.averagesListBox.Size = new System.Drawing.Size(360, 220);
            this.averagesListBox.TabIndex = 0;
            // 
            // getScoresButton
            // 
            // 讀取分數按鈕：將顯示文字改為繁體中文，並放置在清單框下方，尺寸增大以利點選
            this.getScoresButton.Location = new System.Drawing.Point(48, 242);
            this.getScoresButton.Name = "getScoresButton";
            this.getScoresButton.Size = new System.Drawing.Size(140, 44);
            this.getScoresButton.TabIndex = 1;
            this.getScoresButton.Text = "讀取分數";
            this.getScoresButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.getScoresButton.UseVisualStyleBackColor = true;
            this.getScoresButton.Click += new System.EventHandler(this.getScoresButton_Click);
            // 
            // exitButton
            // 
            // 結束按鈕：將顯示文字改為繁體中文，並放置於讀取分數按鈕右側
            this.exitButton.Location = new System.Drawing.Point(208, 242);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 44);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "結束";
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // colorLabel
            // 顯示列舉顏色名稱與對應整數值
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorLabel.Location = new System.Drawing.Point(12, 290);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(360, 30);
            this.colorLabel.TabIndex = 3;
            this.colorLabel.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.colorLabel.Text = "";
            // 
            // Form1
            // 
            // 調整表單大小以容納較大字型與放大的元件尺寸
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 310);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getScoresButton);
            this.Controls.Add(this.averagesListBox);
            this.Controls.Add(this.colorLabel);
            this.Name = "Form1";
            // 表單標題改為繁體中文
            this.Text = "CSV 讀取器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox averagesListBox;
        private System.Windows.Forms.Button getScoresButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label colorLabel;
    }
}

