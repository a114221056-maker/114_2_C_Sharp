namespace Cell_Phone_Inventory
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除所使用的資源。
        /// </summary>
        /// <param name="disposing">如果為 true，表示應釋放受控資源；否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 設計工具支援所需的方法 - 請勿用程式碼編輯器修改
        /// 此方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            // 以下為設計工具自動產生的元件初始化程式碼。
            // 我已將所有可見文字改為繁體中文並統一字型大小為 18，以符合要求。
            // 同時調整元件大小與位置，避免元件重疊。其餘邏輯與事件綁定保持不變。
            this.enterDataGroupBox = new System.Windows.Forms.GroupBox();
            this.addPhoneButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.promptPriceLabel = new System.Windows.Forms.Label();
            this.promptModelLabel = new System.Windows.Forms.Label();
            this.promptBrandLabel = new System.Windows.Forms.Label();
            this.listGroupBox = new System.Windows.Forms.GroupBox();
            this.phoneListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.enterDataGroupBox.SuspendLayout();
            this.listGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // 輸入資料群組框 (enterDataGroupBox)
            // 
            // 設定此群組框的字型為繁體中文常用字型，大小 18，讓內部元件可以繼承此字型
            this.enterDataGroupBox.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.enterDataGroupBox.Controls.Add(this.addPhoneButton);
            this.enterDataGroupBox.Controls.Add(this.priceTextBox);
            this.enterDataGroupBox.Controls.Add(this.modelTextBox);
            this.enterDataGroupBox.Controls.Add(this.brandTextBox);
            this.enterDataGroupBox.Controls.Add(this.promptPriceLabel);
            this.enterDataGroupBox.Controls.Add(this.promptModelLabel);
            this.enterDataGroupBox.Controls.Add(this.promptBrandLabel);
            // 調整位置與大小，避免與右側列表群組重疊
            this.enterDataGroupBox.Location = new System.Drawing.Point(12, 12);
            this.enterDataGroupBox.Name = "enterDataGroupBox";
            this.enterDataGroupBox.Size = new System.Drawing.Size(320, 220);
            this.enterDataGroupBox.TabIndex = 5;
            this.enterDataGroupBox.TabStop = false;
            this.enterDataGroupBox.Text = "輸入手機資料"; // 群組框標題（繁體中文）
            // 
            // 新增手機按鈕 (addPhoneButton)
            // 
            this.addPhoneButton.Location = new System.Drawing.Point(184, 168);
            this.addPhoneButton.Name = "addPhoneButton";
            this.addPhoneButton.Size = new System.Drawing.Size(120, 40);
            this.addPhoneButton.TabIndex = 7;
            this.addPhoneButton.Text = "加入手機"; // 按鈕文字改為繁體中文
            this.addPhoneButton.UseVisualStyleBackColor = true;
            this.addPhoneButton.Click += new System.EventHandler(this.addPhoneButton_Click);
            // 
            // 價格文字方塊 (priceTextBox)
            // 
            // 文字方塊會繼承群組框的字型設定，因此只調整大小與位置
            this.priceTextBox.Location = new System.Drawing.Point(140, 124);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(164, 39);
            this.priceTextBox.TabIndex = 5;
            // 
            // 型號文字方塊 (modelTextBox)
            // 
            this.modelTextBox.Location = new System.Drawing.Point(140, 78);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(164, 39);
            this.modelTextBox.TabIndex = 4;
            // 
            // 品牌文字方塊 (brandTextBox)
            // 
            this.brandTextBox.Location = new System.Drawing.Point(140, 32);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(164, 39);
            this.brandTextBox.TabIndex = 3;
            // 
            // 價格標籤 (promptPriceLabel)
            // 
            this.promptPriceLabel.AutoSize = true;
            this.promptPriceLabel.Location = new System.Drawing.Point(20, 128);
            this.promptPriceLabel.Name = "promptPriceLabel";
            this.promptPriceLabel.Size = new System.Drawing.Size(60, 30);
            this.promptPriceLabel.TabIndex = 2;
            this.promptPriceLabel.Text = "價格："; // 標籤文字改為繁體中文
            // 
            // 型號標籤 (promptModelLabel)
            // 
            this.promptModelLabel.AutoSize = true;
            this.promptModelLabel.Location = new System.Drawing.Point(20, 82);
            this.promptModelLabel.Name = "promptModelLabel";
            this.promptModelLabel.Size = new System.Drawing.Size(60, 30);
            this.promptModelLabel.TabIndex = 1;
            this.promptModelLabel.Text = "型號："; // 標籤文字改為繁體中文
            // 
            // 品牌標籤 (promptBrandLabel)
            // 
            this.promptBrandLabel.AutoSize = true;
            this.promptBrandLabel.Location = new System.Drawing.Point(20, 36);
            this.promptBrandLabel.Name = "promptBrandLabel";
            this.promptBrandLabel.Size = new System.Drawing.Size(60, 30);
            this.promptBrandLabel.TabIndex = 0;
            this.promptBrandLabel.Text = "品牌："; // 標籤文字改為繁體中文
            // 
            // 列表群組框 (listGroupBox)
            // 
            // 設定右側群組框的字型為繁體中文，大小 18
            this.listGroupBox.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listGroupBox.Controls.Add(this.phoneListBox);
            this.listGroupBox.Location = new System.Drawing.Point(344, 12);
            this.listGroupBox.Name = "listGroupBox";
            this.listGroupBox.Size = new System.Drawing.Size(300, 220);
            this.listGroupBox.TabIndex = 8;
            this.listGroupBox.TabStop = false;
            this.listGroupBox.Text = "選擇手機"; // 群組框標題（繁體中文）
            // 
            // 手機清單 (phoneListBox)
            // 
            this.phoneListBox.FormattingEnabled = true;
            this.phoneListBox.ItemHeight = 30;
            this.phoneListBox.Location = new System.Drawing.Point(16, 34);
            this.phoneListBox.Name = "phoneListBox";
            this.phoneListBox.Size = new System.Drawing.Size(268, 154);
            this.phoneListBox.TabIndex = 8;
            this.phoneListBox.SelectedIndexChanged += new System.EventHandler(this.phoneListBox_SelectedIndexChanged);
            // 
            // 結束按鈕 (exitButton)
            // 
            this.exitButton.Location = new System.Drawing.Point(290, 244);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 40);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "結束"; // 按鈕文字改為繁體中文
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // 表單 Form1
            // 
            // 將表單的字型也設定為繁體中文字型，讓未明確設定字型的元件可繼承
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 300);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.listGroupBox);
            this.Controls.Add(this.enterDataGroupBox);
            this.Name = "Form1";
            this.Text = "手機庫存管理"; // 表單標題改為繁體中文
            this.enterDataGroupBox.ResumeLayout(false);
            this.enterDataGroupBox.PerformLayout();
            this.listGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox enterDataGroupBox;
        private System.Windows.Forms.Button addPhoneButton;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.Label promptPriceLabel;
        private System.Windows.Forms.Label promptModelLabel;
        private System.Windows.Forms.Label promptBrandLabel;
        private System.Windows.Forms.GroupBox listGroupBox;
        private System.Windows.Forms.ListBox phoneListBox;
        private System.Windows.Forms.Button exitButton;
    }
}

