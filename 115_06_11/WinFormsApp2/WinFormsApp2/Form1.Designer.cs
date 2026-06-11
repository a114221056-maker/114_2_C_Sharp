namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.ListBox employeeListBox;

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
            lblTitle = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSearch = new Button();
            btnClose = new Button();
            lblEmployees = new Label();
            employeeListBox = new ListBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 18F);
            lblTitle.Location = new Point(20, 37);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(236, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "員工資料管理";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("微軟正黑體", 18F);
            btnAdd.Location = new Point(20, 98);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(178, 52);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "新增員工";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("微軟正黑體", 18F);
            btnDelete.Location = new Point(20, 180);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(178, 52);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "刪除員工";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("微軟正黑體", 18F);
            btnEdit.Location = new Point(20, 260);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(178, 52);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "修改員工";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("微軟正黑體", 18F);
            btnSearch.Location = new Point(20, 333);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(178, 52);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "查詢員工";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("微軟正黑體", 18F);
            btnClose.Location = new Point(20, 403);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(178, 52);
            btnClose.TabIndex = 5;
            btnClose.Text = "離開";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblEmployees
            // 
            lblEmployees.AutoSize = true;
            lblEmployees.Font = new Font("微軟正黑體", 18F);
            lblEmployees.Location = new Point(424, 37);
            lblEmployees.Name = "lblEmployees";
            lblEmployees.Size = new Size(308, 45);
            lblEmployees.TabIndex = 6;
            lblEmployees.Text = "員工編號與姓名：";
            lblEmployees.Click += lblEmployees_Click;
            // 
            // employeeListBox
            // 
            employeeListBox.Font = new Font("微軟正黑體", 18F);
            employeeListBox.ItemHeight = 45;
            employeeListBox.Location = new Point(320, 98);
            employeeListBox.Name = "employeeListBox";
            employeeListBox.Size = new Size(540, 364);
            employeeListBox.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 500);
            Controls.Add(lblTitle);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSearch);
            Controls.Add(btnClose);
            Controls.Add(lblEmployees);
            Controls.Add(employeeListBox);
            Name = "Form1";
            Text = "EmployeeRoster";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
