namespace Review_Q2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Controls
        private System.Windows.Forms.GroupBox grpOilLubrication;
        private System.Windows.Forms.CheckBox chkChangeOil;
        private System.Windows.Forms.CheckBox chkLubrication;

        private System.Windows.Forms.GroupBox grpCleaning;
        private System.Windows.Forms.CheckBox chkRadiatorCleaning;
        private System.Windows.Forms.CheckBox chkTransmissionCleaning;

        private System.Windows.Forms.GroupBox grpOtherServices;
        private System.Windows.Forms.CheckBox chkBrake;
        private System.Windows.Forms.CheckBox chkReplaceMuffler;
        private System.Windows.Forms.CheckBox chkTireRotation;

        private System.Windows.Forms.GroupBox grpPartsLabor;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.TextBox txtParts;
        private System.Windows.Forms.Label lblLaborHours;
        private System.Windows.Forms.TextBox txtLaborHours;

        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblServiceLabor; // label caption
        // replaced textbox with label for display-only values
        private System.Windows.Forms.Label lblServiceLaborValue;
        private System.Windows.Forms.Label lblPartsSummary; // label caption
        private System.Windows.Forms.Label lblPartsValue;
        private System.Windows.Forms.Label lblTax; // label caption
        private System.Windows.Forms.Label lblTaxValue;
        private System.Windows.Forms.Label lblTotal; // label caption
        private System.Windows.Forms.Label lblTotalValue;

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;

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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 420);
            this.Text = "汽車維修服務";

            // Oil & Lubrication Group
            this.grpOilLubrication = new System.Windows.Forms.GroupBox();
            this.grpOilLubrication.Text = "機油和潤滑";
            this.grpOilLubrication.SetBounds(12, 12, 220, 90);

            this.chkChangeOil = new System.Windows.Forms.CheckBox();
            this.chkChangeOil.Text = "更換機油 (NT$780)";
            this.chkChangeOil.AutoSize = true;
            this.chkChangeOil.Location = new System.Drawing.Point(12, 24);

            this.chkLubrication = new System.Windows.Forms.CheckBox();
            this.chkLubrication.Text = "潤滑保養 (NT$540)";
            this.chkLubrication.AutoSize = true;
            this.chkLubrication.Location = new System.Drawing.Point(12, 50);

            this.grpOilLubrication.Controls.Add(this.chkChangeOil);
            this.grpOilLubrication.Controls.Add(this.chkLubrication);

            // Cleaning Group
            this.grpCleaning = new System.Windows.Forms.GroupBox();
            this.grpCleaning.Text = "清洗服務";
            this.grpCleaning.SetBounds(250, 12, 220, 90);

            this.chkRadiatorCleaning = new System.Windows.Forms.CheckBox();
            this.chkRadiatorCleaning.Text = "水箱清洗 (NT$900)";
            this.chkRadiatorCleaning.AutoSize = true;
            this.chkRadiatorCleaning.Location = new System.Drawing.Point(12, 24);

            this.chkTransmissionCleaning = new System.Windows.Forms.CheckBox();
            this.chkTransmissionCleaning.Text = "變速箱清洗 (NT$2,400)";
            this.chkTransmissionCleaning.AutoSize = true;
            this.chkTransmissionCleaning.Location = new System.Drawing.Point(12, 50);

            this.grpCleaning.Controls.Add(this.chkRadiatorCleaning);
            this.grpCleaning.Controls.Add(this.chkTransmissionCleaning);

            // Other Services Group
            this.grpOtherServices = new System.Windows.Forms.GroupBox();
            this.grpOtherServices.Text = "其他服務";
            this.grpOtherServices.SetBounds(12, 110, 220, 120);

            this.chkBrake = new System.Windows.Forms.CheckBox();
            this.chkBrake.Text = "煞車 (NT$450)";
            this.chkBrake.AutoSize = true;
            this.chkBrake.Location = new System.Drawing.Point(12, 24);

            this.chkReplaceMuffler = new System.Windows.Forms.CheckBox();
            this.chkReplaceMuffler.Text = "更換消音器 (NT$3,000)";
            this.chkReplaceMuffler.AutoSize = true;
            this.chkReplaceMuffler.Location = new System.Drawing.Point(12, 50);

            this.chkTireRotation = new System.Windows.Forms.CheckBox();
            this.chkTireRotation.Text = "輪胎換位 (NT$600)";
            this.chkTireRotation.AutoSize = true;
            this.chkTireRotation.Location = new System.Drawing.Point(12, 76);

            this.grpOtherServices.Controls.Add(this.chkBrake);
            this.grpOtherServices.Controls.Add(this.chkReplaceMuffler);
            this.grpOtherServices.Controls.Add(this.chkTireRotation);

            // Parts & Labor Group
            this.grpPartsLabor = new System.Windows.Forms.GroupBox();
            this.grpPartsLabor.Text = "零件和工時";
            this.grpPartsLabor.SetBounds(250, 110, 220, 120);

            this.lblParts = new System.Windows.Forms.Label();
            this.lblParts.Text = "零件 (NT$)";
            this.lblParts.AutoSize = true;
            this.lblParts.Location = new System.Drawing.Point(12, 28);

            this.txtParts = new System.Windows.Forms.TextBox();
            this.txtParts.SetBounds(100, 24, 100, 23);

            this.lblLaborHours = new System.Windows.Forms.Label();
            this.lblLaborHours.Text = "工時數 (小時)";
            this.lblLaborHours.AutoSize = true;
            this.lblLaborHours.Location = new System.Drawing.Point(12, 64);

            this.txtLaborHours = new System.Windows.Forms.TextBox();
            this.txtLaborHours.Name = "txtLaborHours";
            this.txtLaborHours.SetBounds(100, 64, 100, 23);

            this.grpPartsLabor.Controls.Add(this.lblParts);
            this.grpPartsLabor.Controls.Add(this.txtParts);
            this.grpPartsLabor.Controls.Add(this.lblLaborHours);
            this.grpPartsLabor.Controls.Add(this.txtLaborHours);

            // Summary Group
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.grpSummary.Text = "費用摘要";
            this.grpSummary.SetBounds(12, 240, 458, 120);

            this.lblServiceLabor = new System.Windows.Forms.Label();
            this.lblServiceLabor.Text = "服務與工資";
            this.lblServiceLabor.AutoSize = true;
            this.lblServiceLabor.Location = new System.Drawing.Point(12, 28);

            // value labels (display-only)
            this.lblServiceLaborValue = new System.Windows.Forms.Label();
            this.lblServiceLaborValue.SetBounds(140, 24, 300, 23);
            this.lblServiceLaborValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblServiceLaborValue.Text = string.Empty;
            this.lblServiceLaborValue.AutoSize = false;

            this.lblPartsSummary = new System.Windows.Forms.Label();
            this.lblPartsSummary.Text = "零件";
            this.lblPartsSummary.AutoSize = true;
            this.lblPartsSummary.Location = new System.Drawing.Point(12, 56);

            this.lblPartsValue = new System.Windows.Forms.Label();
            this.lblPartsValue.SetBounds(140, 52, 120, 23);
            this.lblPartsValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPartsValue.Text = string.Empty;
            this.lblPartsValue.AutoSize = false;

            this.lblTax = new System.Windows.Forms.Label();
            this.lblTax.Text = "稅金 (零件)";
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(12, 84);

            this.lblTaxValue = new System.Windows.Forms.Label();
            this.lblTaxValue.SetBounds(140, 80, 120, 23);
            this.lblTaxValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTaxValue.Text = string.Empty;
            this.lblTaxValue.AutoSize = false;

            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotal.Text = "總費用";
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(280, 56);

            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTotalValue.SetBounds(340, 52, 100, 23);
            this.lblTotalValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalValue.Text = string.Empty;
            this.lblTotalValue.AutoSize = false;

            this.grpSummary.Controls.Add(this.lblServiceLabor);
            this.grpSummary.Controls.Add(this.lblServiceLaborValue);
            this.grpSummary.Controls.Add(this.lblPartsSummary);
            this.grpSummary.Controls.Add(this.lblPartsValue);
            this.grpSummary.Controls.Add(this.lblTax);
            this.grpSummary.Controls.Add(this.lblTaxValue);
            this.grpSummary.Controls.Add(this.lblTotal);
            this.grpSummary.Controls.Add(this.lblTotalValue);

            // Buttons
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnCalculate.Text = "計算總額";
            this.btnCalculate.SetBounds(90, 370, 100, 28);

            this.btnClear = new System.Windows.Forms.Button();
            this.btnClear.Text = "清除";
            this.btnClear.SetBounds(200, 370, 80, 28);

            this.btnExit = new System.Windows.Forms.Button();
            this.btnExit.Text = "離開";
            this.btnExit.SetBounds(300, 370, 80, 28);

            // Add controls to form
            this.Controls.Add(this.grpOilLubrication);
            this.Controls.Add(this.grpCleaning);
            this.Controls.Add(this.grpOtherServices);
            this.Controls.Add(this.grpPartsLabor);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
        }

        #endregion
    }
}
