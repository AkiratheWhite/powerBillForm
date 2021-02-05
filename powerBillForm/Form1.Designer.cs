
namespace powerBillForm
{
    partial class powerBillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(powerBillForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.PowerCalcTab = new System.Windows.Forms.TabPage();
            this.txtAccNo = new System.Windows.Forms.TextBox();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.lblAccNo = new System.Windows.Forms.Label();
            this.lblCusName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtUsageOff = new System.Windows.Forms.TextBox();
            this.lblPowerUseOff = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtUsage = new System.Windows.Forms.TextBox();
            this.lblPowerUse = new System.Windows.Forms.Label();
            this.btnCalculateCost = new System.Windows.Forms.Button();
            this.chkDetails = new System.Windows.Forms.CheckBox();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.panelOff = new System.Windows.Forms.Panel();
            this.lblOverLimitOff = new System.Windows.Forms.Label();
            this.lblFlatRateLimitOff = new System.Windows.Forms.Label();
            this.txtFlatRateLimitOff = new System.Windows.Forms.TextBox();
            this.lblOff = new System.Windows.Forms.Label();
            this.txtOverLimitOff = new System.Windows.Forms.TextBox();
            this.txtUsageCostOff = new System.Windows.Forms.TextBox();
            this.lblUsageCostOff = new System.Windows.Forms.Label();
            this.txtUsageRateOff = new System.Windows.Forms.TextBox();
            this.lblUsageRateOff = new System.Windows.Forms.Label();
            this.txtFlatRateOff = new System.Windows.Forms.TextBox();
            this.lblFlateRateOff = new System.Windows.Forms.Label();
            this.panelReg = new System.Windows.Forms.Panel();
            this.lblOverLimit = new System.Windows.Forms.Label();
            this.lblFlatRateLimit = new System.Windows.Forms.Label();
            this.txtOverLimit = new System.Windows.Forms.TextBox();
            this.txtUsageCost = new System.Windows.Forms.TextBox();
            this.lblPeak = new System.Windows.Forms.Label();
            this.txtFlatRateLimit = new System.Windows.Forms.TextBox();
            this.lblUsageCost = new System.Windows.Forms.Label();
            this.txtUsageRate = new System.Windows.Forms.TextBox();
            this.lblUsageRate = new System.Windows.Forms.Label();
            this.txtFlatRate = new System.Windows.Forms.TextBox();
            this.lblFlateRate = new System.Windows.Forms.Label();
            this.comboCusType = new System.Windows.Forms.ComboBox();
            this.lblCusType = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.CusInfoTab = new System.Windows.Forms.TabPage();
            this.txtIndusCharge = new System.Windows.Forms.TextBox();
            this.txtCommCharge = new System.Windows.Forms.TextBox();
            this.txtResCharge = new System.Windows.Forms.TextBox();
            this.txtTotalCharge = new System.Windows.Forms.TextBox();
            this.txtCusCount = new System.Windows.Forms.TextBox();
            this.lblTotalCharge = new System.Windows.Forms.Label();
            this.lblIndusCharge = new System.Windows.Forms.Label();
            this.lblCommCharge = new System.Windows.Forms.Label();
            this.lblResCharge = new System.Windows.Forms.Label();
            this.lblCusCount = new System.Windows.Forms.Label();
            this.dataCusData = new System.Windows.Forms.DataGridView();
            this.CusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chargedAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.PowerCalcTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDetails.SuspendLayout();
            this.panelOff.SuspendLayout();
            this.panelReg.SuspendLayout();
            this.CusInfoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCusData)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.PowerCalcTab);
            this.tabControl.Controls.Add(this.CusInfoTab);
            this.tabControl.Location = new System.Drawing.Point(25, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(971, 589);
            this.tabControl.TabIndex = 0;
            // 
            // PowerCalcTab
            // 
            this.PowerCalcTab.Controls.Add(this.txtAccNo);
            this.PowerCalcTab.Controls.Add(this.txtCusName);
            this.PowerCalcTab.Controls.Add(this.lblAccNo);
            this.PowerCalcTab.Controls.Add(this.lblCusName);
            this.PowerCalcTab.Controls.Add(this.pictureBox1);
            this.PowerCalcTab.Controls.Add(this.btnExit);
            this.PowerCalcTab.Controls.Add(this.txtUsageOff);
            this.PowerCalcTab.Controls.Add(this.lblPowerUseOff);
            this.PowerCalcTab.Controls.Add(this.btnReset);
            this.PowerCalcTab.Controls.Add(this.txtUsage);
            this.PowerCalcTab.Controls.Add(this.lblPowerUse);
            this.PowerCalcTab.Controls.Add(this.btnCalculateCost);
            this.PowerCalcTab.Controls.Add(this.chkDetails);
            this.PowerCalcTab.Controls.Add(this.panelDetails);
            this.PowerCalcTab.Controls.Add(this.comboCusType);
            this.PowerCalcTab.Controls.Add(this.lblCusType);
            this.PowerCalcTab.Controls.Add(this.txtTotalCost);
            this.PowerCalcTab.Controls.Add(this.lblTotalCost);
            this.PowerCalcTab.Location = new System.Drawing.Point(4, 36);
            this.PowerCalcTab.Name = "PowerCalcTab";
            this.PowerCalcTab.Padding = new System.Windows.Forms.Padding(3);
            this.PowerCalcTab.Size = new System.Drawing.Size(963, 549);
            this.PowerCalcTab.TabIndex = 0;
            this.PowerCalcTab.Text = "Power Bill Calculator";
            this.PowerCalcTab.UseVisualStyleBackColor = true;
            // 
            // txtAccNo
            // 
            this.txtAccNo.Location = new System.Drawing.Point(280, 47);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(153, 34);
            this.txtAccNo.TabIndex = 69;
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(59, 47);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(153, 34);
            this.txtCusName.TabIndex = 68;
            // 
            // lblAccNo
            // 
            this.lblAccNo.AutoSize = true;
            this.lblAccNo.Location = new System.Drawing.Point(275, 17);
            this.lblAccNo.Name = "lblAccNo";
            this.lblAccNo.Size = new System.Drawing.Size(133, 27);
            this.lblAccNo.TabIndex = 67;
            this.lblAccNo.Text = "Account No.";
            // 
            // lblCusName
            // 
            this.lblCusName.AutoSize = true;
            this.lblCusName.Location = new System.Drawing.Point(54, 17);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(168, 27);
            this.lblCusName.TabIndex = 66;
            this.lblCusName.Text = "Customer Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(716, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 131);
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(54, 470);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(192, 57);
            this.btnExit.TabIndex = 64;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // txtUsageOff
            // 
            this.txtUsageOff.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsageOff.Location = new System.Drawing.Point(58, 274);
            this.txtUsageOff.Name = "txtUsageOff";
            this.txtUsageOff.Size = new System.Drawing.Size(153, 34);
            this.txtUsageOff.TabIndex = 60;
            // 
            // lblPowerUseOff
            // 
            this.lblPowerUseOff.AutoSize = true;
            this.lblPowerUseOff.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerUseOff.Location = new System.Drawing.Point(54, 247);
            this.lblPowerUseOff.Name = "lblPowerUseOff";
            this.lblPowerUseOff.Size = new System.Drawing.Size(262, 24);
            this.lblPowerUseOff.TabIndex = 63;
            this.lblPowerUseOff.Text = "Power Usage (Off-Peak, kWh)";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(54, 407);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(192, 57);
            this.btnReset.TabIndex = 62;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // txtUsage
            // 
            this.txtUsage.Location = new System.Drawing.Point(58, 206);
            this.txtUsage.Name = "txtUsage";
            this.txtUsage.Size = new System.Drawing.Size(153, 34);
            this.txtUsage.TabIndex = 58;
            // 
            // lblPowerUse
            // 
            this.lblPowerUse.AutoSize = true;
            this.lblPowerUse.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerUse.Location = new System.Drawing.Point(54, 179);
            this.lblPowerUse.Name = "lblPowerUse";
            this.lblPowerUse.Size = new System.Drawing.Size(175, 24);
            this.lblPowerUse.TabIndex = 59;
            this.lblPowerUse.Text = "Power Usage (kWh)";
            // 
            // btnCalculateCost
            // 
            this.btnCalculateCost.Location = new System.Drawing.Point(54, 344);
            this.btnCalculateCost.Name = "btnCalculateCost";
            this.btnCalculateCost.Size = new System.Drawing.Size(194, 57);
            this.btnCalculateCost.TabIndex = 61;
            this.btnCalculateCost.Text = "Calculate Bill";
            this.btnCalculateCost.UseVisualStyleBackColor = true;
            this.btnCalculateCost.Click += new System.EventHandler(this.BtnCalculateCost_Click);
            // 
            // chkDetails
            // 
            this.chkDetails.AutoCheck = false;
            this.chkDetails.AutoSize = true;
            this.chkDetails.Location = new System.Drawing.Point(322, 182);
            this.chkDetails.Name = "chkDetails";
            this.chkDetails.Size = new System.Drawing.Size(212, 31);
            this.chkDetails.TabIndex = 57;
            this.chkDetails.Text = "Show More Details";
            this.chkDetails.UseVisualStyleBackColor = true;
            this.chkDetails.CheckedChanged += new System.EventHandler(this.ChkDetails_CheckedChanged);
            this.chkDetails.Click += new System.EventHandler(this.ChkDetails_Click);
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.panelOff);
            this.panelDetails.Controls.Add(this.panelReg);
            this.panelDetails.Location = new System.Drawing.Point(322, 219);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(573, 308);
            this.panelDetails.TabIndex = 54;
            // 
            // panelOff
            // 
            this.panelOff.Controls.Add(this.lblOverLimitOff);
            this.panelOff.Controls.Add(this.lblFlatRateLimitOff);
            this.panelOff.Controls.Add(this.txtFlatRateLimitOff);
            this.panelOff.Controls.Add(this.lblOff);
            this.panelOff.Controls.Add(this.txtOverLimitOff);
            this.panelOff.Controls.Add(this.txtUsageCostOff);
            this.panelOff.Controls.Add(this.lblUsageCostOff);
            this.panelOff.Controls.Add(this.txtUsageRateOff);
            this.panelOff.Controls.Add(this.lblUsageRateOff);
            this.panelOff.Controls.Add(this.txtFlatRateOff);
            this.panelOff.Controls.Add(this.lblFlateRateOff);
            this.panelOff.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelOff.Location = new System.Drawing.Point(292, 12);
            this.panelOff.Name = "panelOff";
            this.panelOff.Size = new System.Drawing.Size(268, 285);
            this.panelOff.TabIndex = 10;
            // 
            // lblOverLimitOff
            // 
            this.lblOverLimitOff.AutoSize = true;
            this.lblOverLimitOff.Location = new System.Drawing.Point(3, 221);
            this.lblOverLimitOff.Name = "lblOverLimitOff";
            this.lblOverLimitOff.Size = new System.Drawing.Size(220, 21);
            this.lblOverLimitOff.TabIndex = 4;
            this.lblOverLimitOff.Text = "Rate Limit Exceeded (kWh)";
            // 
            // lblFlatRateLimitOff
            // 
            this.lblFlatRateLimitOff.AutoSize = true;
            this.lblFlatRateLimitOff.Location = new System.Drawing.Point(3, 160);
            this.lblFlatRateLimitOff.Name = "lblFlatRateLimitOff";
            this.lblFlatRateLimitOff.Size = new System.Drawing.Size(175, 21);
            this.lblFlatRateLimitOff.TabIndex = 16;
            this.lblFlatRateLimitOff.Text = "Flat Rate Limit (kWh)";
            // 
            // txtFlatRateLimitOff
            // 
            this.txtFlatRateLimitOff.Location = new System.Drawing.Point(7, 184);
            this.txtFlatRateLimitOff.Name = "txtFlatRateLimitOff";
            this.txtFlatRateLimitOff.ReadOnly = true;
            this.txtFlatRateLimitOff.Size = new System.Drawing.Size(120, 29);
            this.txtFlatRateLimitOff.TabIndex = 17;
            this.txtFlatRateLimitOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOff
            // 
            this.lblOff.AutoSize = true;
            this.lblOff.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOff.Location = new System.Drawing.Point(2, 9);
            this.lblOff.Name = "lblOff";
            this.lblOff.Size = new System.Drawing.Size(174, 27);
            this.lblOff.TabIndex = 14;
            this.lblOff.Text = "Off-Peak Usage";
            // 
            // txtOverLimitOff
            // 
            this.txtOverLimitOff.Location = new System.Drawing.Point(7, 245);
            this.txtOverLimitOff.Name = "txtOverLimitOff";
            this.txtOverLimitOff.ReadOnly = true;
            this.txtOverLimitOff.Size = new System.Drawing.Size(120, 29);
            this.txtOverLimitOff.TabIndex = 5;
            this.txtOverLimitOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUsageCostOff
            // 
            this.txtUsageCostOff.Location = new System.Drawing.Point(7, 125);
            this.txtUsageCostOff.Name = "txtUsageCostOff";
            this.txtUsageCostOff.ReadOnly = true;
            this.txtUsageCostOff.Size = new System.Drawing.Size(120, 29);
            this.txtUsageCostOff.TabIndex = 9;
            this.txtUsageCostOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUsageCostOff
            // 
            this.lblUsageCostOff.AutoSize = true;
            this.lblUsageCostOff.Location = new System.Drawing.Point(3, 101);
            this.lblUsageCostOff.Name = "lblUsageCostOff";
            this.lblUsageCostOff.Size = new System.Drawing.Size(121, 21);
            this.lblUsageCostOff.TabIndex = 8;
            this.lblUsageCostOff.Text = "Usage Cost ($)";
            // 
            // txtUsageRateOff
            // 
            this.txtUsageRateOff.Location = new System.Drawing.Point(133, 60);
            this.txtUsageRateOff.Name = "txtUsageRateOff";
            this.txtUsageRateOff.ReadOnly = true;
            this.txtUsageRateOff.Size = new System.Drawing.Size(120, 29);
            this.txtUsageRateOff.TabIndex = 7;
            this.txtUsageRateOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUsageRateOff
            // 
            this.lblUsageRateOff.AutoSize = true;
            this.lblUsageRateOff.Location = new System.Drawing.Point(129, 36);
            this.lblUsageRateOff.Name = "lblUsageRateOff";
            this.lblUsageRateOff.Size = new System.Drawing.Size(120, 21);
            this.lblUsageRateOff.TabIndex = 6;
            this.lblUsageRateOff.Text = "Usage Rate ($)";
            // 
            // txtFlatRateOff
            // 
            this.txtFlatRateOff.Location = new System.Drawing.Point(7, 60);
            this.txtFlatRateOff.Name = "txtFlatRateOff";
            this.txtFlatRateOff.ReadOnly = true;
            this.txtFlatRateOff.Size = new System.Drawing.Size(120, 29);
            this.txtFlatRateOff.TabIndex = 1;
            this.txtFlatRateOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFlateRateOff
            // 
            this.lblFlateRateOff.AutoSize = true;
            this.lblFlateRateOff.Location = new System.Drawing.Point(3, 36);
            this.lblFlateRateOff.Name = "lblFlateRateOff";
            this.lblFlateRateOff.Size = new System.Drawing.Size(103, 21);
            this.lblFlateRateOff.TabIndex = 0;
            this.lblFlateRateOff.Text = "Flat Rate ($)";
            // 
            // panelReg
            // 
            this.panelReg.Controls.Add(this.lblOverLimit);
            this.panelReg.Controls.Add(this.lblFlatRateLimit);
            this.panelReg.Controls.Add(this.txtOverLimit);
            this.panelReg.Controls.Add(this.txtUsageCost);
            this.panelReg.Controls.Add(this.lblPeak);
            this.panelReg.Controls.Add(this.txtFlatRateLimit);
            this.panelReg.Controls.Add(this.lblUsageCost);
            this.panelReg.Controls.Add(this.txtUsageRate);
            this.panelReg.Controls.Add(this.lblUsageRate);
            this.panelReg.Controls.Add(this.txtFlatRate);
            this.panelReg.Controls.Add(this.lblFlateRate);
            this.panelReg.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelReg.Location = new System.Drawing.Point(8, 12);
            this.panelReg.Name = "panelReg";
            this.panelReg.Size = new System.Drawing.Size(269, 285);
            this.panelReg.TabIndex = 0;
            // 
            // lblOverLimit
            // 
            this.lblOverLimit.AutoSize = true;
            this.lblOverLimit.Location = new System.Drawing.Point(3, 221);
            this.lblOverLimit.Name = "lblOverLimit";
            this.lblOverLimit.Size = new System.Drawing.Size(220, 21);
            this.lblOverLimit.TabIndex = 4;
            this.lblOverLimit.Text = "Rate Limit Exceeded (kWh)";
            // 
            // lblFlatRateLimit
            // 
            this.lblFlatRateLimit.AutoSize = true;
            this.lblFlatRateLimit.Location = new System.Drawing.Point(3, 160);
            this.lblFlatRateLimit.Name = "lblFlatRateLimit";
            this.lblFlatRateLimit.Size = new System.Drawing.Size(175, 21);
            this.lblFlatRateLimit.TabIndex = 2;
            this.lblFlatRateLimit.Text = "Flat Rate Limit (kWh)";
            // 
            // txtOverLimit
            // 
            this.txtOverLimit.Location = new System.Drawing.Point(7, 245);
            this.txtOverLimit.Name = "txtOverLimit";
            this.txtOverLimit.ReadOnly = true;
            this.txtOverLimit.Size = new System.Drawing.Size(120, 29);
            this.txtOverLimit.TabIndex = 5;
            this.txtOverLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUsageCost
            // 
            this.txtUsageCost.Location = new System.Drawing.Point(7, 125);
            this.txtUsageCost.Name = "txtUsageCost";
            this.txtUsageCost.ReadOnly = true;
            this.txtUsageCost.Size = new System.Drawing.Size(120, 29);
            this.txtUsageCost.TabIndex = 9;
            this.txtUsageCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPeak
            // 
            this.lblPeak.AutoSize = true;
            this.lblPeak.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeak.Location = new System.Drawing.Point(3, 9);
            this.lblPeak.Name = "lblPeak";
            this.lblPeak.Size = new System.Drawing.Size(133, 27);
            this.lblPeak.TabIndex = 13;
            this.lblPeak.Text = "Peak Usage";
            // 
            // txtFlatRateLimit
            // 
            this.txtFlatRateLimit.Location = new System.Drawing.Point(7, 184);
            this.txtFlatRateLimit.Name = "txtFlatRateLimit";
            this.txtFlatRateLimit.ReadOnly = true;
            this.txtFlatRateLimit.Size = new System.Drawing.Size(120, 29);
            this.txtFlatRateLimit.TabIndex = 3;
            this.txtFlatRateLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUsageCost
            // 
            this.lblUsageCost.AutoSize = true;
            this.lblUsageCost.Location = new System.Drawing.Point(6, 101);
            this.lblUsageCost.Name = "lblUsageCost";
            this.lblUsageCost.Size = new System.Drawing.Size(121, 21);
            this.lblUsageCost.TabIndex = 8;
            this.lblUsageCost.Text = "Usage Cost ($)";
            // 
            // txtUsageRate
            // 
            this.txtUsageRate.Location = new System.Drawing.Point(133, 60);
            this.txtUsageRate.Name = "txtUsageRate";
            this.txtUsageRate.ReadOnly = true;
            this.txtUsageRate.Size = new System.Drawing.Size(120, 29);
            this.txtUsageRate.TabIndex = 7;
            this.txtUsageRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUsageRate
            // 
            this.lblUsageRate.AutoSize = true;
            this.lblUsageRate.Location = new System.Drawing.Point(129, 36);
            this.lblUsageRate.Name = "lblUsageRate";
            this.lblUsageRate.Size = new System.Drawing.Size(120, 21);
            this.lblUsageRate.TabIndex = 6;
            this.lblUsageRate.Text = "Usage Rate ($)";
            // 
            // txtFlatRate
            // 
            this.txtFlatRate.Location = new System.Drawing.Point(7, 60);
            this.txtFlatRate.Name = "txtFlatRate";
            this.txtFlatRate.ReadOnly = true;
            this.txtFlatRate.Size = new System.Drawing.Size(120, 29);
            this.txtFlatRate.TabIndex = 1;
            this.txtFlatRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFlateRate
            // 
            this.lblFlateRate.AutoSize = true;
            this.lblFlateRate.Location = new System.Drawing.Point(3, 36);
            this.lblFlateRate.Name = "lblFlateRate";
            this.lblFlateRate.Size = new System.Drawing.Size(103, 21);
            this.lblFlateRate.TabIndex = 0;
            this.lblFlateRate.Text = "Flat Rate ($)";
            // 
            // comboCusType
            // 
            this.comboCusType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCusType.FormattingEnabled = true;
            this.comboCusType.Items.AddRange(new object[] {
            "Residential",
            "Commercial",
            "Industrial"});
            this.comboCusType.Location = new System.Drawing.Point(58, 125);
            this.comboCusType.Name = "comboCusType";
            this.comboCusType.Size = new System.Drawing.Size(190, 35);
            this.comboCusType.TabIndex = 53;
            this.comboCusType.SelectedIndexChanged += new System.EventHandler(this.ComboCusType_SelectedIndexChanged);
            // 
            // lblCusType
            // 
            this.lblCusType.AutoSize = true;
            this.lblCusType.Location = new System.Drawing.Point(53, 95);
            this.lblCusType.Name = "lblCusType";
            this.lblCusType.Size = new System.Drawing.Size(157, 27);
            this.lblCusType.TabIndex = 52;
            this.lblCusType.Text = "Customer Type";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(280, 125);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(199, 34);
            this.txtTotalCost.TabIndex = 56;
            this.txtTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(275, 95);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(142, 27);
            this.lblTotalCost.TabIndex = 55;
            this.lblTotalCost.Text = "Total Cost ($)";
            // 
            // CusInfoTab
            // 
            this.CusInfoTab.Controls.Add(this.txtIndusCharge);
            this.CusInfoTab.Controls.Add(this.txtCommCharge);
            this.CusInfoTab.Controls.Add(this.txtResCharge);
            this.CusInfoTab.Controls.Add(this.txtTotalCharge);
            this.CusInfoTab.Controls.Add(this.txtCusCount);
            this.CusInfoTab.Controls.Add(this.lblTotalCharge);
            this.CusInfoTab.Controls.Add(this.lblIndusCharge);
            this.CusInfoTab.Controls.Add(this.lblCommCharge);
            this.CusInfoTab.Controls.Add(this.lblResCharge);
            this.CusInfoTab.Controls.Add(this.lblCusCount);
            this.CusInfoTab.Controls.Add(this.dataCusData);
            this.CusInfoTab.Location = new System.Drawing.Point(4, 36);
            this.CusInfoTab.Name = "CusInfoTab";
            this.CusInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.CusInfoTab.Size = new System.Drawing.Size(963, 549);
            this.CusInfoTab.TabIndex = 1;
            this.CusInfoTab.Text = "Customer Information";
            this.CusInfoTab.UseVisualStyleBackColor = true;
            // 
            // txtIndusCharge
            // 
            this.txtIndusCharge.Location = new System.Drawing.Point(648, 428);
            this.txtIndusCharge.Name = "txtIndusCharge";
            this.txtIndusCharge.ReadOnly = true;
            this.txtIndusCharge.Size = new System.Drawing.Size(181, 34);
            this.txtIndusCharge.TabIndex = 61;
            this.txtIndusCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCommCharge
            // 
            this.txtCommCharge.Location = new System.Drawing.Point(297, 500);
            this.txtCommCharge.Name = "txtCommCharge";
            this.txtCommCharge.ReadOnly = true;
            this.txtCommCharge.Size = new System.Drawing.Size(181, 34);
            this.txtCommCharge.TabIndex = 60;
            this.txtCommCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResCharge
            // 
            this.txtResCharge.Location = new System.Drawing.Point(297, 428);
            this.txtResCharge.Name = "txtResCharge";
            this.txtResCharge.ReadOnly = true;
            this.txtResCharge.Size = new System.Drawing.Size(181, 34);
            this.txtResCharge.TabIndex = 59;
            this.txtResCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalCharge
            // 
            this.txtTotalCharge.Location = new System.Drawing.Point(33, 500);
            this.txtTotalCharge.Name = "txtTotalCharge";
            this.txtTotalCharge.ReadOnly = true;
            this.txtTotalCharge.Size = new System.Drawing.Size(181, 34);
            this.txtTotalCharge.TabIndex = 58;
            this.txtTotalCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCusCount
            // 
            this.txtCusCount.Location = new System.Drawing.Point(33, 428);
            this.txtCusCount.Name = "txtCusCount";
            this.txtCusCount.ReadOnly = true;
            this.txtCusCount.Size = new System.Drawing.Size(181, 34);
            this.txtCusCount.TabIndex = 57;
            this.txtCusCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalCharge
            // 
            this.lblTotalCharge.AutoSize = true;
            this.lblTotalCharge.Location = new System.Drawing.Point(28, 470);
            this.lblTotalCharge.Name = "lblTotalCharge";
            this.lblTotalCharge.Size = new System.Drawing.Size(195, 27);
            this.lblTotalCharge.TabIndex = 5;
            this.lblTotalCharge.Text = "Sum of all Charges:";
            // 
            // lblIndusCharge
            // 
            this.lblIndusCharge.AutoSize = true;
            this.lblIndusCharge.Location = new System.Drawing.Point(643, 398);
            this.lblIndusCharge.Name = "lblIndusCharge";
            this.lblIndusCharge.Size = new System.Drawing.Size(287, 27);
            this.lblIndusCharge.TabIndex = 4;
            this.lblIndusCharge.Text = "Industrial Customer Charges:";
            // 
            // lblCommCharge
            // 
            this.lblCommCharge.AutoSize = true;
            this.lblCommCharge.Location = new System.Drawing.Point(292, 470);
            this.lblCommCharge.Name = "lblCommCharge";
            this.lblCommCharge.Size = new System.Drawing.Size(311, 27);
            this.lblCommCharge.TabIndex = 3;
            this.lblCommCharge.Text = "Commercial Customer Charges:";
            // 
            // lblResCharge
            // 
            this.lblResCharge.AutoSize = true;
            this.lblResCharge.Location = new System.Drawing.Point(292, 398);
            this.lblResCharge.Name = "lblResCharge";
            this.lblResCharge.Size = new System.Drawing.Size(299, 27);
            this.lblResCharge.TabIndex = 2;
            this.lblResCharge.Text = "Residential Customer Charges:";
            // 
            // lblCusCount
            // 
            this.lblCusCount.AutoSize = true;
            this.lblCusCount.Location = new System.Drawing.Point(28, 398);
            this.lblCusCount.Name = "lblCusCount";
            this.lblCusCount.Size = new System.Drawing.Size(186, 27);
            this.lblCusCount.TabIndex = 1;
            this.lblCusCount.Text = "No. of Customers:";
            // 
            // dataCusData
            // 
            this.dataCusData.AllowUserToResizeColumns = false;
            this.dataCusData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCusData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CusName,
            this.accNo,
            this.cusType,
            this.chargedAmount});
            this.dataCusData.Location = new System.Drawing.Point(0, 3);
            this.dataCusData.Name = "dataCusData";
            this.dataCusData.ReadOnly = true;
            this.dataCusData.RowTemplate.Height = 30;
            this.dataCusData.Size = new System.Drawing.Size(963, 384);
            this.dataCusData.TabIndex = 0;
            // 
            // CusName
            // 
            this.CusName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CusName.HeaderText = "Customer Name";
            this.CusName.Name = "CusName";
            this.CusName.ReadOnly = true;
            // 
            // accNo
            // 
            this.accNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accNo.HeaderText = "Account No.";
            this.accNo.Name = "accNo";
            this.accNo.ReadOnly = true;
            // 
            // cusType
            // 
            this.cusType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cusType.HeaderText = "Customer Type";
            this.cusType.Name = "cusType";
            this.cusType.ReadOnly = true;
            // 
            // chargedAmount
            // 
            this.chargedAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chargedAmount.HeaderText = "Bill Amount ($)";
            this.chargedAmount.Name = "chargedAmount";
            this.chargedAmount.ReadOnly = true;
            // 
            // powerBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 622);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "powerBillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate your power bill.";
            this.Load += new System.EventHandler(this.PowerBillForm_Load);
            this.tabControl.ResumeLayout(false);
            this.PowerCalcTab.ResumeLayout(false);
            this.PowerCalcTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDetails.ResumeLayout(false);
            this.panelOff.ResumeLayout(false);
            this.panelOff.PerformLayout();
            this.panelReg.ResumeLayout(false);
            this.panelReg.PerformLayout();
            this.CusInfoTab.ResumeLayout(false);
            this.CusInfoTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCusData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage PowerCalcTab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtUsageOff;
        private System.Windows.Forms.Label lblPowerUseOff;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtUsage;
        private System.Windows.Forms.Label lblPowerUse;
        private System.Windows.Forms.Button btnCalculateCost;
        private System.Windows.Forms.CheckBox chkDetails;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Panel panelOff;
        private System.Windows.Forms.Label lblOverLimitOff;
        private System.Windows.Forms.Label lblFlatRateLimitOff;
        private System.Windows.Forms.TextBox txtFlatRateLimitOff;
        private System.Windows.Forms.Label lblOff;
        private System.Windows.Forms.TextBox txtOverLimitOff;
        private System.Windows.Forms.TextBox txtUsageCostOff;
        private System.Windows.Forms.Label lblUsageCostOff;
        private System.Windows.Forms.TextBox txtUsageRateOff;
        private System.Windows.Forms.Label lblUsageRateOff;
        private System.Windows.Forms.TextBox txtFlatRateOff;
        private System.Windows.Forms.Label lblFlateRateOff;
        private System.Windows.Forms.Panel panelReg;
        private System.Windows.Forms.Label lblOverLimit;
        private System.Windows.Forms.Label lblFlatRateLimit;
        private System.Windows.Forms.TextBox txtOverLimit;
        private System.Windows.Forms.TextBox txtUsageCost;
        private System.Windows.Forms.Label lblPeak;
        private System.Windows.Forms.TextBox txtFlatRateLimit;
        private System.Windows.Forms.Label lblUsageCost;
        private System.Windows.Forms.TextBox txtUsageRate;
        private System.Windows.Forms.Label lblUsageRate;
        private System.Windows.Forms.TextBox txtFlatRate;
        private System.Windows.Forms.Label lblFlateRate;
        private System.Windows.Forms.ComboBox comboCusType;
        private System.Windows.Forms.Label lblCusType;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.TabPage CusInfoTab;
        private System.Windows.Forms.DataGridView dataCusData;
        private System.Windows.Forms.Label lblAccNo;
        private System.Windows.Forms.Label lblCusName;
        private System.Windows.Forms.TextBox txtAccNo;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn accNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusType;
        private System.Windows.Forms.DataGridViewTextBoxColumn chargedAmount;
        private System.Windows.Forms.Label lblTotalCharge;
        private System.Windows.Forms.Label lblIndusCharge;
        private System.Windows.Forms.Label lblCommCharge;
        private System.Windows.Forms.Label lblResCharge;
        private System.Windows.Forms.Label lblCusCount;
        private System.Windows.Forms.TextBox txtCusCount;
        private System.Windows.Forms.TextBox txtIndusCharge;
        private System.Windows.Forms.TextBox txtCommCharge;
        private System.Windows.Forms.TextBox txtResCharge;
        private System.Windows.Forms.TextBox txtTotalCharge;
    }
}

