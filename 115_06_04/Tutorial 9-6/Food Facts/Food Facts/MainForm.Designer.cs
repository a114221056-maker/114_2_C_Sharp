namespace Food_Facts
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.muffinRadioButton = new System.Windows.Forms.RadioButton();
            this.popcornRadioButton = new System.Windows.Forms.RadioButton();
            this.bananaRadioButton = new System.Windows.Forms.RadioButton();
            this.displayButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.muffinRadioButton);
            this.groupBox1.Controls.Add(this.popcornRadioButton);
            this.groupBox1.Controls.Add(this.bananaRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(53, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "選擇食物";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // muffinRadioButton
            // 
            this.muffinRadioButton.AutoSize = true;
            this.muffinRadioButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.muffinRadioButton.Location = new System.Drawing.Point(20, 158);
            this.muffinRadioButton.Name = "muffinRadioButton";
            this.muffinRadioButton.Size = new System.Drawing.Size(297, 49);
            this.muffinRadioButton.TabIndex = 2;
            this.muffinRadioButton.TabStop = true;
            this.muffinRadioButton.Text = "一個大藍莓瑪芬";
            this.muffinRadioButton.UseVisualStyleBackColor = true;
            this.muffinRadioButton.CheckedChanged += new System.EventHandler(this.muffinRadioButton_CheckedChanged);
            // 
            // popcornRadioButton
            // 
            this.popcornRadioButton.AutoSize = true;
            this.popcornRadioButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.popcornRadioButton.Location = new System.Drawing.Point(20, 103);
            this.popcornRadioButton.Name = "popcornRadioButton";
            this.popcornRadioButton.Size = new System.Drawing.Size(405, 49);
            this.popcornRadioButton.TabIndex = 1;
            this.popcornRadioButton.TabStop = true;
            this.popcornRadioButton.Text = "一杯爆米花（空氣爆）";
            this.popcornRadioButton.UseVisualStyleBackColor = true;
            // 
            // bananaRadioButton
            // 
            this.bananaRadioButton.AutoSize = true;
            this.bananaRadioButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bananaRadioButton.Location = new System.Drawing.Point(20, 48);
            this.bananaRadioButton.Name = "bananaRadioButton";
            this.bananaRadioButton.Size = new System.Drawing.Size(189, 49);
            this.bananaRadioButton.TabIndex = 0;
            this.bananaRadioButton.TabStop = true;
            this.bananaRadioButton.Text = "一根香蕉";
            this.bananaRadioButton.UseVisualStyleBackColor = true;
            // 
            // displayButton
            // 
            this.displayButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.displayButton.Location = new System.Drawing.Point(73, 270);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(177, 50);
            this.displayButton.TabIndex = 1;
            this.displayButton.Text = "顯示食物資訊";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(280, 270);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 50);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 332);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "MainForm";
            this.Text = "食物資訊";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton muffinRadioButton;
        private System.Windows.Forms.RadioButton popcornRadioButton;
        private System.Windows.Forms.RadioButton bananaRadioButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button exitButton;
    }
}

