namespace WindowsFormsApp1.Sales_Department
{
    partial class frmSales
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.cmsSales = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewBilltoolStripMenuIt = new System.Windows.Forms.ToolStripMenuItem();
            this.editBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecordsCountSales = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.txSearchBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnAddNewBill = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEditBill = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.dtTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbPaymentStatute = new Guna.UI2.WinForms.Guna2ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCurrncy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.طباعةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(481, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 42);
            this.label2.TabIndex = 166;
            this.label2.Text = "أدارة المبيعات ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmsSales
            // 
            this.cmsSales.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.AddNewBilltoolStripMenuIt,
            this.editBillToolStripMenuItem,
            this.deleteBillToolStripMenuItem,
            this.طباعةToolStripMenuItem});
            this.cmsSales.Name = "contextMenuStrip1";
            this.cmsSales.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsSales.Size = new System.Drawing.Size(245, 216);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.showDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showDetailsToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.ApplicationType;
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(244, 38);
            this.showDetailsToolStripMenuItem.Text = "&عرض معلومات الفاتورة";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // AddNewBilltoolStripMenuIt
            // 
            this.AddNewBilltoolStripMenuIt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AddNewBilltoolStripMenuIt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewBilltoolStripMenuIt.ForeColor = System.Drawing.Color.White;
            this.AddNewBilltoolStripMenuIt.Image = global::WindowsFormsApp1.Properties.Resources.Notes_32;
            this.AddNewBilltoolStripMenuIt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddNewBilltoolStripMenuIt.Name = "AddNewBilltoolStripMenuIt";
            this.AddNewBilltoolStripMenuIt.Size = new System.Drawing.Size(244, 38);
            this.AddNewBilltoolStripMenuIt.Text = "أضافة &فاتورة جديدة";
            this.AddNewBilltoolStripMenuIt.Click += new System.EventHandler(this.AddNewBilltoolStripMenuIt_Click);
            // 
            // editBillToolStripMenuItem
            // 
            this.editBillToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.editBillToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBillToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editBillToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.edit_32;
            this.editBillToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editBillToolStripMenuItem.Name = "editBillToolStripMenuItem";
            this.editBillToolStripMenuItem.Size = new System.Drawing.Size(244, 38);
            this.editBillToolStripMenuItem.Text = "&تعديل فاتورة ";
            this.editBillToolStripMenuItem.Click += new System.EventHandler(this.editBillToolStripMenuItem_Click);
            // 
            // deleteBillToolStripMenuItem
            // 
            this.deleteBillToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.deleteBillToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBillToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteBillToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Delete_32;
            this.deleteBillToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteBillToolStripMenuItem.Name = "deleteBillToolStripMenuItem";
            this.deleteBillToolStripMenuItem.Size = new System.Drawing.Size(244, 38);
            this.deleteBillToolStripMenuItem.Text = "&حذف فاتورة";
            this.deleteBillToolStripMenuItem.Click += new System.EventHandler(this.deleteBillToolStripMenuItem_Click);
            // 
            // lblRecordsCountSales
            // 
            this.lblRecordsCountSales.AutoSize = true;
            this.lblRecordsCountSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCountSales.Location = new System.Drawing.Point(110, 615);
            this.lblRecordsCountSales.Name = "lblRecordsCountSales";
            this.lblRecordsCountSales.Size = new System.Drawing.Size(21, 16);
            this.lblRecordsCountSales.TabIndex = 169;
            this.lblRecordsCountSales.Text = "??";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 612);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 168;
            this.label4.Text = "# Records:";
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.AllowUserToResizeRows = false;
            this.dgvSales.BackgroundColor = System.Drawing.Color.White;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.ContextMenuStrip = this.cmsSales;
            this.dgvSales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSales.GridColor = System.Drawing.Color.CornflowerBlue;
            this.dgvSales.Location = new System.Drawing.Point(12, 249);
            this.dgvSales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSales.MultiSelect = false;
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.Size = new System.Drawing.Size(1055, 346);
            this.dgvSales.TabIndex = 182;
            this.dgvSales.TabStop = false;
            // 
            // txSearchBy
            // 
            this.txSearchBy.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txSearchBy.BorderThickness = 2;
            this.txSearchBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txSearchBy.DefaultText = "";
            this.txSearchBy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txSearchBy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txSearchBy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txSearchBy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txSearchBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txSearchBy.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txSearchBy.ForeColor = System.Drawing.Color.Black;
            this.txSearchBy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txSearchBy.Location = new System.Drawing.Point(536, 23);
            this.txSearchBy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txSearchBy.Name = "txSearchBy";
            this.txSearchBy.PasswordChar = '\0';
            this.txSearchBy.PlaceholderText = "";
            this.txSearchBy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txSearchBy.SelectedText = "";
            this.txSearchBy.Size = new System.Drawing.Size(248, 32);
            this.txSearchBy.TabIndex = 177;
            this.txSearchBy.TextChanged += new System.EventHandler(this.txSearchBy_TextChanged);
            this.txSearchBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txSearchBy_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(953, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 170;
            this.label3.Text = "بحث ب:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 180;
            this.label1.Text = "حالة الفاتورة:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(915, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 24);
            this.label6.TabIndex = 184;
            this.label6.Text = "حسب التاريح:";
            // 
            // dtFrom
            // 
            this.dtFrom.Checked = true;
            this.dtFrom.FillColor = System.Drawing.Color.CornflowerBlue;
            this.dtFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtFrom.ForeColor = System.Drawing.Color.White;
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(633, 85);
            this.dtFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtFrom.Size = new System.Drawing.Size(237, 36);
            this.dtFrom.TabIndex = 220;
            this.dtFrom.Value = new System.DateTime(2024, 11, 17, 16, 43, 49, 517);
            this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
            // 
            // btnAddNewBill
            // 
            this.btnAddNewBill.FlatAppearance.BorderSize = 0;
            this.btnAddNewBill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnAddNewBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAddNewBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewBill.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.btnAddNewBill.IconColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddNewBill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddNewBill.IconSize = 65;
            this.btnAddNewBill.Location = new System.Drawing.Point(99, 64);
            this.btnAddNewBill.Name = "btnAddNewBill";
            this.btnAddNewBill.Size = new System.Drawing.Size(88, 75);
            this.btnAddNewBill.TabIndex = 184;
            this.btnAddNewBill.UseVisualStyleBackColor = true;
            this.btnAddNewBill.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(876, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 24);
            this.label7.TabIndex = 221;
            this.label7.Text = "من:";
            // 
            // btnEditBill
            // 
            this.btnEditBill.FlatAppearance.BorderSize = 0;
            this.btnEditBill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnEditBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEditBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBill.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            this.btnEditBill.IconColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditBill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditBill.IconSize = 65;
            this.btnEditBill.Location = new System.Drawing.Point(5, 64);
            this.btnEditBill.Name = "btnEditBill";
            this.btnEditBill.Size = new System.Drawing.Size(88, 75);
            this.btnEditBill.TabIndex = 185;
            this.btnEditBill.UseVisualStyleBackColor = true;
            this.btnEditBill.Click += new System.EventHandler(this.btnEditBill_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(589, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 24);
            this.label8.TabIndex = 222;
            this.label8.Text = "إلى:";
            // 
            // dtTo
            // 
            this.dtTo.Checked = true;
            this.dtTo.FillColor = System.Drawing.Color.CornflowerBlue;
            this.dtTo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.ForeColor = System.Drawing.Color.White;
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(346, 85);
            this.dtTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTo.Name = "dtTo";
            this.dtTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtTo.Size = new System.Drawing.Size(237, 36);
            this.dtTo.TabIndex = 223;
            this.dtTo.Value = new System.DateTime(2024, 11, 17, 16, 43, 49, 517);
            this.dtTo.ValueChanged += new System.EventHandler(this.dtTo_ValueChanged);
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbFilter.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.cbFilter.BorderRadius = 5;
            this.cbFilter.BorderThickness = 2;
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbFilter.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cbFilter.ItemHeight = 30;
            this.cbFilter.Items.AddRange(new object[] {
            "رقم الفاتورة",
            "اسم العميل"});
            this.cbFilter.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.cbFilter.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbFilter.ItemsAppearance.SelectedForeColor = System.Drawing.Color.RoyalBlue;
            this.cbFilter.Location = new System.Drawing.Point(791, 19);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbFilter.Size = new System.Drawing.Size(166, 36);
            this.cbFilter.TabIndex = 224;
            this.cbFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // cbPaymentStatute
            // 
            this.cbPaymentStatute.BackColor = System.Drawing.Color.Transparent;
            this.cbPaymentStatute.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.cbPaymentStatute.BorderRadius = 5;
            this.cbPaymentStatute.BorderThickness = 2;
            this.cbPaymentStatute.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPaymentStatute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentStatute.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPaymentStatute.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPaymentStatute.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cbPaymentStatute.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cbPaymentStatute.ItemHeight = 30;
            this.cbPaymentStatute.Items.AddRange(new object[] {
            "الكل",
            "آجل",
            "نقدا"});
            this.cbPaymentStatute.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.cbPaymentStatute.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbPaymentStatute.ItemsAppearance.SelectedForeColor = System.Drawing.Color.RoyalBlue;
            this.cbPaymentStatute.Location = new System.Drawing.Point(280, 22);
            this.cbPaymentStatute.Name = "cbPaymentStatute";
            this.cbPaymentStatute.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbPaymentStatute.Size = new System.Drawing.Size(145, 36);
            this.cbPaymentStatute.TabIndex = 211;
            this.cbPaymentStatute.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbPaymentStatute.SelectedIndexChanged += new System.EventHandler(this.cbPaymentStatute_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCurrncy);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbPaymentStatute);
            this.groupBox1.Controls.Add(this.cbFilter);
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnEditBill);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnAddNewBill);
            this.groupBox1.Controls.Add(this.dtFrom);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txSearchBy);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1054, 152);
            this.groupBox1.TabIndex = 186;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "البحث العام";
            // 
            // cbCurrncy
            // 
            this.cbCurrncy.BackColor = System.Drawing.Color.Transparent;
            this.cbCurrncy.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.cbCurrncy.BorderRadius = 5;
            this.cbCurrncy.BorderThickness = 2;
            this.cbCurrncy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCurrncy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrncy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCurrncy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCurrncy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cbCurrncy.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cbCurrncy.ItemHeight = 30;
            this.cbCurrncy.Items.AddRange(new object[] {
            "الكل",
            "الريال اليمني",
            "الريال السعودي",
            "الدولار الأمريكي"});
            this.cbCurrncy.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.cbCurrncy.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbCurrncy.ItemsAppearance.SelectedForeColor = System.Drawing.Color.RoyalBlue;
            this.cbCurrncy.Location = new System.Drawing.Point(2, 22);
            this.cbCurrncy.Name = "cbCurrncy";
            this.cbCurrncy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbCurrncy.Size = new System.Drawing.Size(193, 36);
            this.cbCurrncy.TabIndex = 227;
            this.cbCurrncy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbCurrncy.SelectedIndexChanged += new System.EventHandler(this.cbCurrncy_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(192, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 226;
            this.label5.Text = "نوع المال:";
            // 
            // طباعةToolStripMenuItem
            // 
            this.طباعةToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.طباعةToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.طباعةToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.طباعةToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Save_32;
            this.طباعةToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.طباعةToolStripMenuItem.Name = "طباعةToolStripMenuItem";
            this.طباعةToolStripMenuItem.Size = new System.Drawing.Size(244, 38);
            this.طباعةToolStripMenuItem.Text = "طباعة";
            this.طباعةToolStripMenuItem.Click += new System.EventHandler(this.طباعةToolStripMenuItem_Click);
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1073, 653);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRecordsCountSales);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.cmsSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem deleteBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewBilltoolStripMenuIt;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsSales;
        private System.Windows.Forms.Label lblRecordsCountSales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvSales;
        private Guna.UI2.WinForms.Guna2TextBox txSearchBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtFrom;
        private FontAwesome.Sharp.IconButton btnAddNewBill;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnEditBill;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtTo;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cbPaymentStatute;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbCurrncy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem طباعةToolStripMenuItem;
    }
}