namespace Test_Score_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.testScoresListBox = new System.Windows.Forms.ListBox();
            this.avgScoreDescriptionLabel = new System.Windows.Forms.Label();
            this.aboveAvgDescriptionLabel = new System.Windows.Forms.Label();
            this.belowAvgDescriptionLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.aboveAverageLabel = new System.Windows.Forms.Label();
            this.belowAverageLabel = new System.Windows.Forms.Label();
            this.getScoresButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchScoreTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // testScoresListBox
            // 
            this.testScoresListBox.FormattingEnabled = true;
            this.testScoresListBox.ItemHeight = 40;
            this.testScoresListBox.Location = new System.Drawing.Point(42, 37);
            this.testScoresListBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.testScoresListBox.Name = "testScoresListBox";
            this.testScoresListBox.Size = new System.Drawing.Size(645, 604);
            this.testScoresListBox.TabIndex = 0;
            // 
            // avgScoreDescriptionLabel
            // 
            this.avgScoreDescriptionLabel.AutoSize = true;
            this.avgScoreDescriptionLabel.Location = new System.Drawing.Point(744, 139);
            this.avgScoreDescriptionLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.avgScoreDescriptionLabel.Name = "avgScoreDescriptionLabel";
            this.avgScoreDescriptionLabel.Size = new System.Drawing.Size(197, 40);
            this.avgScoreDescriptionLabel.TabIndex = 1;
            this.avgScoreDescriptionLabel.Text = "平均成績：";
            // 
            // aboveAvgDescriptionLabel
            // 
            this.aboveAvgDescriptionLabel.AutoSize = true;
            this.aboveAvgDescriptionLabel.Location = new System.Drawing.Point(744, 342);
            this.aboveAvgDescriptionLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.aboveAvgDescriptionLabel.Name = "aboveAvgDescriptionLabel";
            this.aboveAvgDescriptionLabel.Size = new System.Drawing.Size(305, 40);
            this.aboveAvgDescriptionLabel.TabIndex = 2;
            this.aboveAvgDescriptionLabel.Text = "高於平均的人數：";
            // 
            // belowAvgDescriptionLabel
            // 
            this.belowAvgDescriptionLabel.AutoSize = true;
            this.belowAvgDescriptionLabel.Location = new System.Drawing.Point(744, 538);
            this.belowAvgDescriptionLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.belowAvgDescriptionLabel.Name = "belowAvgDescriptionLabel";
            this.belowAvgDescriptionLabel.Size = new System.Drawing.Size(305, 40);
            this.belowAvgDescriptionLabel.TabIndex = 3;
            this.belowAvgDescriptionLabel.Text = "低於平均的人數：";
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Location = new System.Drawing.Point(1610, 49);
            this.averageLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(485, 100);
            this.averageLabel.TabIndex = 4;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboveAverageLabel
            // 
            this.aboveAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aboveAverageLabel.Location = new System.Drawing.Point(1610, 234);
            this.aboveAverageLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.aboveAverageLabel.Name = "aboveAverageLabel";
            this.aboveAverageLabel.Size = new System.Drawing.Size(485, 100);
            this.aboveAverageLabel.TabIndex = 5;
            this.aboveAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // belowAverageLabel
            // 
            this.belowAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.belowAverageLabel.Location = new System.Drawing.Point(1610, 418);
            this.belowAverageLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.belowAverageLabel.Name = "belowAverageLabel";
            this.belowAverageLabel.Size = new System.Drawing.Size(485, 100);
            this.belowAverageLabel.TabIndex = 6;
            this.belowAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getScoresButton
            // 
            this.getScoresButton.Location = new System.Drawing.Point(93, 814);
            this.getScoresButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.getScoresButton.Name = "getScoresButton";
            this.getScoresButton.Size = new System.Drawing.Size(545, 141);
            this.getScoresButton.TabIndex = 7;
            this.getScoresButton.Text = "取得分數";
            this.getScoresButton.UseVisualStyleBackColor = true;
            this.getScoresButton.Click += new System.EventHandler(this.getScoresButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(711, 817);
            this.exitButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(560, 138);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(50, 725);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(197, 40);
            this.searchLabel.TabIndex = 9;
            this.searchLabel.Text = "搜尋分數：";
            // 
            // searchScoreTextBox
            // 
            this.searchScoreTextBox.Location = new System.Drawing.Point(1330, 572);
            this.searchScoreTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.searchScoreTextBox.Name = "searchScoreTextBox";
            this.searchScoreTextBox.Size = new System.Drawing.Size(410, 48);
            this.searchScoreTextBox.TabIndex = 10;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1785, 572);
            this.searchButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(315, 108);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "搜尋";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchResultLabel
            // 
            this.searchResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchResultLabel.Location = new System.Drawing.Point(291, 695);
            this.searchResultLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.searchResultLabel.Name = "searchResultLabel";
            this.searchResultLabel.Size = new System.Drawing.Size(719, 100);
            this.searchResultLabel.TabIndex = 12;
            this.searchResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2170, 1015);
            this.Controls.Add(this.searchResultLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchScoreTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getScoresButton);
            this.Controls.Add(this.belowAverageLabel);
            this.Controls.Add(this.aboveAverageLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.belowAvgDescriptionLabel);
            this.Controls.Add(this.aboveAvgDescriptionLabel);
            this.Controls.Add(this.avgScoreDescriptionLabel);
            this.Controls.Add(this.testScoresListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = resources.GetString("$this.Text");
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox testScoresListBox;
        private System.Windows.Forms.Label avgScoreDescriptionLabel;
        private System.Windows.Forms.Label aboveAvgDescriptionLabel;
        private System.Windows.Forms.Label belowAvgDescriptionLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label aboveAverageLabel;
        private System.Windows.Forms.Label belowAverageLabel;
        private System.Windows.Forms.Button getScoresButton;
        private System.Windows.Forms.Button exitButton;
        // 新增：搜尋相關欄位（僅介面）
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchScoreTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchResultLabel;
    }
}

