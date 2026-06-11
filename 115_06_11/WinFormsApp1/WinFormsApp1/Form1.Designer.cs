namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        // 標籤：提示使用者在上方文字方塊輸入要轉換的內容
        private System.Windows.Forms.Label labelInput;
        // 文字方塊：多行輸入，使用者可以在此輸入欲轉換的字串
        private System.Windows.Forms.TextBox textBoxInput;
        // 標籤：顯示整串轉換後的摩斯密碼的標題
        private System.Windows.Forms.Label labelMorse;
        // 文字方塊：以唯讀方式顯示整串摩斯密碼結果，方便複製或查看
        private System.Windows.Forms.TextBox textBoxMorse;
        // 標籤：顯示逐字對照清單的標題
        private System.Windows.Forms.Label labelList;
        // 清單：逐字顯示每一個字元對應的摩斯碼
        private System.Windows.Forms.ListBox listBox1;
        // 按鈕：執行轉換動作
        private System.Windows.Forms.Button btnConvert;
        // 按鈕：清空所有欄位
        private System.Windows.Forms.Button btnClear;

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
            labelInput = new Label();
            textBoxInput = new TextBox();
            labelMorse = new Label();
            textBoxMorse = new TextBox();
            labelList = new Label();
            listBox1 = new ListBox();
            btnConvert = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Font = new Font("微軟正黑體", 18F);
            labelInput.Location = new Point(12, 12);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(236, 45);
            labelInput.TabIndex = 0;
            labelInput.Text = "請輸入字串：";
            // 
            // textBoxInput
            // 
            textBoxInput.Font = new Font("微軟正黑體", 18F);
            textBoxInput.Location = new Point(12, 60);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.ScrollBars = ScrollBars.Vertical;
            textBoxInput.Size = new Size(684, 140);
            textBoxInput.TabIndex = 1;
            // 
            // labelMorse
            // 
            labelMorse.AutoSize = true;
            labelMorse.Font = new Font("微軟正黑體", 18F);
            labelMorse.Location = new Point(12, 200);
            labelMorse.Name = "labelMorse";
            labelMorse.Size = new Size(272, 45);
            labelMorse.TabIndex = 2;
            labelMorse.Text = "完整摩斯密碼：";
            // 
            // textBoxMorse
            // 
            textBoxMorse.Font = new Font("微軟正黑體", 18F);
            textBoxMorse.Location = new Point(12, 238);
            textBoxMorse.Multiline = true;
            textBoxMorse.Name = "textBoxMorse";
            textBoxMorse.ReadOnly = true;
            textBoxMorse.ScrollBars = ScrollBars.Vertical;
            textBoxMorse.Size = new Size(684, 140);
            textBoxMorse.TabIndex = 3;
            // 
            // labelList
            // 
            labelList.AutoSize = true;
            labelList.Font = new Font("微軟正黑體", 18F);
            labelList.Location = new Point(12, 388);
            labelList.Name = "labelList";
            labelList.Size = new Size(200, 45);
            labelList.TabIndex = 4;
            labelList.Text = "逐字對照：";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("微軟正黑體", 18F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 45;
            listBox1.Location = new Point(12, 443);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(684, 139);
            listBox1.TabIndex = 5;
            // 
            // btnConvert
            // 
            btnConvert.Font = new Font("微軟正黑體", 18F);
            btnConvert.Location = new Point(420, 588);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(140, 57);
            btnConvert.TabIndex = 6;
            btnConvert.Text = "轉換";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("微軟正黑體", 18F);
            btnClear.Location = new Point(576, 588);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 57);
            btnClear.TabIndex = 7;
            btnClear.Text = "清除";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(21F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 666);
            Controls.Add(btnClear);
            Controls.Add(btnConvert);
            Controls.Add(listBox1);
            Controls.Add(labelList);
            Controls.Add(textBoxMorse);
            Controls.Add(labelMorse);
            Controls.Add(textBoxInput);
            Controls.Add(labelInput);
            Font = new Font("微軟正黑體", 18F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "摩斯密碼轉換";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
