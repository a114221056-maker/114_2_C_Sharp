namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelMorse;
        private System.Windows.Forms.Label labelMapping;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxMorse;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonClear;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelInput = new System.Windows.Forms.Label();
            this.labelMorse = new System.Windows.Forms.Label();
            this.labelMapping = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxMorse = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelInput.Location = new System.Drawing.Point(12, 47);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(236, 45);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "請輸入字串：";
            // 
            // labelMorse
            // 
            this.labelMorse.AutoSize = true;
            this.labelMorse.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelMorse.Location = new System.Drawing.Point(12, 275);
            this.labelMorse.Name = "labelMorse";
            this.labelMorse.Size = new System.Drawing.Size(272, 45);
            this.labelMorse.TabIndex = 2;
            this.labelMorse.Text = "完整摩斯密碼：";
            // 
            // labelMapping
            // 
            this.labelMapping.AutoSize = true;
            this.labelMapping.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelMapping.Location = new System.Drawing.Point(12, 581);
            this.labelMapping.Name = "labelMapping";
            this.labelMapping.Size = new System.Drawing.Size(200, 45);
            this.labelMapping.TabIndex = 4;
            this.labelMapping.Text = "逐字對照：";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxInput.Location = new System.Drawing.Point(20, 114);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput.Size = new System.Drawing.Size(610, 120);
            this.textBoxInput.TabIndex = 1;
            // 
            // textBoxMorse
            // 
            this.textBoxMorse.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxMorse.Location = new System.Drawing.Point(20, 347);
            this.textBoxMorse.Multiline = true;
            this.textBoxMorse.Name = "textBoxMorse";
            this.textBoxMorse.ReadOnly = true;
            this.textBoxMorse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMorse.Size = new System.Drawing.Size(610, 160);
            this.textBoxMorse.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 45;
            this.listBox1.Location = new System.Drawing.Point(20, 647);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(450, 139);
            this.listBox1.TabIndex = 5;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonConvert.Location = new System.Drawing.Point(572, 647);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(135, 50);
            this.buttonConvert.TabIndex = 6;
            this.buttonConvert.Text = "轉換";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonClear.Location = new System.Drawing.Point(572, 725);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(135, 50);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "清除";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 798);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelMorse);
            this.Controls.Add(this.textBoxMorse);
            this.Controls.Add(this.labelMapping);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.buttonClear);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "摩斯密碼轉換";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

