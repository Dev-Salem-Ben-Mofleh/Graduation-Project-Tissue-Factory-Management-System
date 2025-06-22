namespace WindowsFormsApp1.DashBoard
{
    partial class frmDashBoard
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
            this.btnAddSaleBill = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnAddPurncBill = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnAddProductionBill = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnAddExpensesBill = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnAddPerson = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.paSideBar = new Guna.UI2.WinForms.Guna2Panel();
            this.paContainerUsers = new System.Windows.Forms.Panel();
            this.clsPurchasesReports1 = new WindowsFormsApp1.DashBoard.Controls.clsPurchasesReports();
            this.clsSaleReports1 = new WindowsFormsApp1.DashBoard.Controls.clsSaleReports();
            this.btn7Days = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn3Months = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn1Month = new Guna.UI2.WinForms.Guna2GradientButton();
            this.paSideBar.SuspendLayout();
            this.paContainerUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddSaleBill
            // 
            this.btnAddSaleBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSaleBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSaleBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddSaleBill.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddSaleBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddSaleBill.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddSaleBill.FillColor2 = System.Drawing.Color.Blue;
            this.btnAddSaleBill.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSaleBill.ForeColor = System.Drawing.Color.White;
            this.btnAddSaleBill.Location = new System.Drawing.Point(913, 12);
            this.btnAddSaleBill.Name = "btnAddSaleBill";
            this.btnAddSaleBill.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddSaleBill.Size = new System.Drawing.Size(148, 148);
            this.btnAddSaleBill.TabIndex = 1;
            this.btnAddSaleBill.Text = "أضافة فاتورة بيع جديدة";
            this.btnAddSaleBill.Click += new System.EventHandler(this.btnAddSaleBill_Click);
            // 
            // btnAddPurncBill
            // 
            this.btnAddPurncBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPurncBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPurncBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPurncBill.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPurncBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPurncBill.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddPurncBill.FillColor2 = System.Drawing.Color.Blue;
            this.btnAddPurncBill.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPurncBill.ForeColor = System.Drawing.Color.White;
            this.btnAddPurncBill.Location = new System.Drawing.Point(708, 12);
            this.btnAddPurncBill.Name = "btnAddPurncBill";
            this.btnAddPurncBill.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddPurncBill.Size = new System.Drawing.Size(148, 148);
            this.btnAddPurncBill.TabIndex = 2;
            this.btnAddPurncBill.Text = "أضافة فاتورة شراء جديدة";
            this.btnAddPurncBill.Click += new System.EventHandler(this.btnAddPurncBill_Click);
            // 
            // btnAddProductionBill
            // 
            this.btnAddProductionBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProductionBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProductionBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddProductionBill.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddProductionBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddProductionBill.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddProductionBill.FillColor2 = System.Drawing.Color.Blue;
            this.btnAddProductionBill.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProductionBill.ForeColor = System.Drawing.Color.White;
            this.btnAddProductionBill.Location = new System.Drawing.Point(492, 12);
            this.btnAddProductionBill.Name = "btnAddProductionBill";
            this.btnAddProductionBill.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddProductionBill.Size = new System.Drawing.Size(148, 148);
            this.btnAddProductionBill.TabIndex = 3;
            this.btnAddProductionBill.Text = "أضافة أنتاج جديد";
            this.btnAddProductionBill.Click += new System.EventHandler(this.btnAddProductionBill_Click);
            // 
            // btnAddExpensesBill
            // 
            this.btnAddExpensesBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddExpensesBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddExpensesBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddExpensesBill.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddExpensesBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddExpensesBill.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddExpensesBill.FillColor2 = System.Drawing.Color.Blue;
            this.btnAddExpensesBill.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExpensesBill.ForeColor = System.Drawing.Color.White;
            this.btnAddExpensesBill.Location = new System.Drawing.Point(272, 12);
            this.btnAddExpensesBill.Name = "btnAddExpensesBill";
            this.btnAddExpensesBill.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddExpensesBill.Size = new System.Drawing.Size(148, 148);
            this.btnAddExpensesBill.TabIndex = 4;
            this.btnAddExpensesBill.Text = "أضافة فاتورة مصروفات جديدة";
            this.btnAddExpensesBill.Click += new System.EventHandler(this.btnAddExpensesBill_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPerson.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPerson.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddPerson.FillColor2 = System.Drawing.Color.Blue;
            this.btnAddPerson.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPerson.ForeColor = System.Drawing.Color.White;
            this.btnAddPerson.Location = new System.Drawing.Point(74, 12);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddPerson.Size = new System.Drawing.Size(148, 148);
            this.btnAddPerson.TabIndex = 5;
            this.btnAddPerson.Text = "أضافة عميل أو مورد جديد";
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // paSideBar
            // 
            this.paSideBar.AutoScroll = true;
            this.paSideBar.AutoSize = true;
            this.paSideBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.paSideBar.BackColor = System.Drawing.Color.White;
            this.paSideBar.Controls.Add(this.paContainerUsers);
            this.paSideBar.Location = new System.Drawing.Point(28, 166);
            this.paSideBar.Name = "paSideBar";
            this.paSideBar.Size = new System.Drawing.Size(1019, 478);
            this.paSideBar.TabIndex = 6;
            // 
            // paContainerUsers
            // 
            this.paContainerUsers.AutoScroll = true;
            this.paContainerUsers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.paContainerUsers.BackColor = System.Drawing.Color.White;
            this.paContainerUsers.Controls.Add(this.clsPurchasesReports1);
            this.paContainerUsers.Controls.Add(this.clsSaleReports1);
            this.paContainerUsers.Controls.Add(this.btn7Days);
            this.paContainerUsers.Controls.Add(this.btn3Months);
            this.paContainerUsers.Controls.Add(this.btn1Month);
            this.paContainerUsers.Location = new System.Drawing.Point(6, 5);
            this.paContainerUsers.Margin = new System.Windows.Forms.Padding(0);
            this.paContainerUsers.Name = "paContainerUsers";
            this.paContainerUsers.Size = new System.Drawing.Size(1013, 473);
            this.paContainerUsers.TabIndex = 11;
            // 
            // clsPurchasesReports1
            // 
            this.clsPurchasesReports1.BackColor = System.Drawing.Color.White;
            this.clsPurchasesReports1.Location = new System.Drawing.Point(26, 452);
            this.clsPurchasesReports1.Name = "clsPurchasesReports1";
            this.clsPurchasesReports1.Size = new System.Drawing.Size(919, 367);
            this.clsPurchasesReports1.TabIndex = 12;
            // 
            // clsSaleReports1
            // 
            this.clsSaleReports1.BackColor = System.Drawing.Color.White;
            this.clsSaleReports1.Location = new System.Drawing.Point(26, 77);
            this.clsSaleReports1.Name = "clsSaleReports1";
            this.clsSaleReports1.Size = new System.Drawing.Size(959, 367);
            this.clsSaleReports1.TabIndex = 11;
            // 
            // btn7Days
            // 
            this.btn7Days.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn7Days.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn7Days.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn7Days.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn7Days.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn7Days.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btn7Days.FillColor2 = System.Drawing.Color.Blue;
            this.btn7Days.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7Days.ForeColor = System.Drawing.Color.White;
            this.btn7Days.Location = new System.Drawing.Point(74, 11);
            this.btn7Days.Name = "btn7Days";
            this.btn7Days.Size = new System.Drawing.Size(217, 46);
            this.btn7Days.TabIndex = 8;
            this.btn7Days.Text = "قبل سبعة أيام من الان";
            this.btn7Days.Click += new System.EventHandler(this.btn7Days_Click);
            // 
            // btn3Months
            // 
            this.btn3Months.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn3Months.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn3Months.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn3Months.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn3Months.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn3Months.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btn3Months.FillColor2 = System.Drawing.Color.Blue;
            this.btn3Months.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3Months.ForeColor = System.Drawing.Color.White;
            this.btn3Months.Location = new System.Drawing.Point(732, 11);
            this.btn3Months.Name = "btn3Months";
            this.btn3Months.Size = new System.Drawing.Size(217, 46);
            this.btn3Months.TabIndex = 10;
            this.btn3Months.Text = "قبل ثلاث اشهر من الان";
            this.btn3Months.Click += new System.EventHandler(this.btn3Months_Click);
            // 
            // btn1Month
            // 
            this.btn1Month.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn1Month.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn1Month.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn1Month.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn1Month.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn1Month.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btn1Month.FillColor2 = System.Drawing.Color.Blue;
            this.btn1Month.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Month.ForeColor = System.Drawing.Color.White;
            this.btn1Month.Location = new System.Drawing.Point(389, 11);
            this.btn1Month.Name = "btn1Month";
            this.btn1Month.Size = new System.Drawing.Size(217, 46);
            this.btn1Month.TabIndex = 9;
            this.btn1Month.Text = "قبل شهر من الان";
            this.btn1Month.Click += new System.EventHandler(this.btn1Month_Click);
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1073, 653);
            this.Controls.Add(this.paSideBar);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.btnAddExpensesBill);
            this.Controls.Add(this.btnAddProductionBill);
            this.Controls.Add(this.btnAddPurncBill);
            this.Controls.Add(this.btnAddSaleBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashBoard";
            this.Load += new System.EventHandler(this.frmDashBoard_Load);
            this.paSideBar.ResumeLayout(false);
            this.paContainerUsers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientCircleButton btnAddSaleBill;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnAddPurncBill;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnAddProductionBill;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnAddExpensesBill;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnAddPerson;
        private Guna.UI2.WinForms.Guna2Panel paSideBar;
        private System.Windows.Forms.Panel paContainerUsers;
        private Guna.UI2.WinForms.Guna2GradientButton btn7Days;
        private Guna.UI2.WinForms.Guna2GradientButton btn3Months;
        private Guna.UI2.WinForms.Guna2GradientButton btn1Month;
        private Controls.clsSaleReports clsSaleReports1;
        private Controls.clsPurchasesReports clsPurchasesReports1;
    }
}