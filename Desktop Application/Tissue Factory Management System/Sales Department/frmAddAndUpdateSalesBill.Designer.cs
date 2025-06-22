namespace WindowsFormsApp1.Sales_Department
{
    partial class frmAddAndUpdateSalesBill
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSaleBillId = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbStateSales = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbNameProduct = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnCalnsel = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddToBill = new FontAwesome.Sharp.IconButton();
            this.btnPrint = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCurreny3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblNetAmount = new System.Windows.Forms.Label();
            this.lblCurreny = new System.Windows.Forms.Label();
            this.dgvٍSaleItem = new System.Windows.Forms.DataGridView();
            this.cmSaleItems = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.حذقسلعةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ndQuqntity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblCurreny2 = new System.Windows.Forms.Label();
            this.cbCurrencyType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.cbClintName = new System.Windows.Forms.ComboBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvٍSaleItem)).BeginInit();
            this.cmSaleItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndQuqntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(125)))), ((int)(((byte)(189)))));
            this.guna2Panel1.Controls.Add(this.btnClose);
            this.guna2Panel1.Controls.Add(this.lblTitle);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1260, 36);
            this.guna2Panel1.TabIndex = 141;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(125)))), ((int)(((byte)(189)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 30;
            this.btnClose.Location = new System.Drawing.Point(1226, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 28);
            this.btnClose.TabIndex = 140;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(196, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(779, 39);
            this.lblTitle.TabIndex = 158;
            this.lblTitle.Text = "أضافة\\تعديل فاتورة البيع";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSaleBillId
            // 
            this.lblSaleBillId.AutoSize = true;
            this.lblSaleBillId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleBillId.Location = new System.Drawing.Point(1065, 72);
            this.lblSaleBillId.Name = "lblSaleBillId";
            this.lblSaleBillId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSaleBillId.Size = new System.Drawing.Size(44, 20);
            this.lblSaleBillId.TabIndex = 188;
            this.lblSaleBillId.Text = "[???]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(873, 69);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(171, 19);
            this.label11.TabIndex = 184;
            this.label11.Text = "أسم الشركة\\العميل :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1150, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 170;
            this.label1.Text = ": رقم الفاتورة";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(875, 123);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(65, 19);
            this.label8.TabIndex = 195;
            this.label8.Text = "التاريخ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(457, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 198;
            this.label2.Text = "أسم المنتج :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(457, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 201;
            this.label3.Text = "الخصم :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(875, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 207;
            this.label5.Text = "حالة البيع :";
            // 
            // cbStateSales
            // 
            this.cbStateSales.BackColor = System.Drawing.Color.Transparent;
            this.cbStateSales.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.cbStateSales.BorderRadius = 5;
            this.cbStateSales.BorderThickness = 2;
            this.cbStateSales.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStateSales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStateSales.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStateSales.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStateSales.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cbStateSales.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cbStateSales.ItemHeight = 30;
            this.cbStateSales.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.cbStateSales.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbStateSales.ItemsAppearance.SelectedForeColor = System.Drawing.Color.RoyalBlue;
            this.cbStateSales.Location = new System.Drawing.Point(591, 168);
            this.cbStateSales.Name = "cbStateSales";
            this.cbStateSales.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbStateSales.Size = new System.Drawing.Size(235, 36);
            this.cbStateSales.TabIndex = 208;
            this.cbStateSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbNameProduct
            // 
            this.cbNameProduct.BackColor = System.Drawing.Color.Transparent;
            this.cbNameProduct.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.cbNameProduct.BorderRadius = 5;
            this.cbNameProduct.BorderThickness = 2;
            this.cbNameProduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNameProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNameProduct.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNameProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNameProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cbNameProduct.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cbNameProduct.ItemHeight = 30;
            this.cbNameProduct.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.cbNameProduct.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbNameProduct.ItemsAppearance.SelectedForeColor = System.Drawing.Color.RoyalBlue;
            this.cbNameProduct.Location = new System.Drawing.Point(177, 59);
            this.cbNameProduct.Name = "cbNameProduct";
            this.cbNameProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbNameProduct.Size = new System.Drawing.Size(235, 36);
            this.cbNameProduct.TabIndex = 209;
            this.cbNameProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtDate
            // 
            this.dtDate.Checked = true;
            this.dtDate.Enabled = false;
            this.dtDate.FillColor = System.Drawing.Color.CornflowerBlue;
            this.dtDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtDate.ForeColor = System.Drawing.Color.White;
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(591, 113);
            this.dtDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtDate.Name = "dtDate";
            this.dtDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtDate.Size = new System.Drawing.Size(237, 36);
            this.dtDate.TabIndex = 219;
            this.dtDate.Value = new System.DateTime(2024, 11, 17, 16, 43, 49, 517);
            // 
            // btnCalnsel
            // 
            this.btnCalnsel.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnCalnsel.FlatAppearance.BorderSize = 2;
            this.btnCalnsel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalnsel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalnsel.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.btnCalnsel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalnsel.Location = new System.Drawing.Point(975, 597);
            this.btnCalnsel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalnsel.Name = "btnCalnsel";
            this.btnCalnsel.Size = new System.Drawing.Size(126, 37);
            this.btnCalnsel.TabIndex = 220;
            this.btnCalnsel.Text = "ألغاء";
            this.btnCalnsel.UseVisualStyleBackColor = true;
            this.btnCalnsel.Click += new System.EventHandler(this.btnCalnsel_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.Payment;
            this.pictureBox5.Location = new System.Drawing.Point(837, 171);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 206;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.List_32;
            this.pictureBox1.Location = new System.Drawing.Point(419, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 197;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::WindowsFormsApp1.Properties.Resources.Calendar_32;
            this.pictureBox11.Location = new System.Drawing.Point(837, 119);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(31, 26);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 194;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::WindowsFormsApp1.Properties.Resources.id__1_;
            this.pictureBox8.Location = new System.Drawing.Point(1112, 65);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 180;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.office_man;
            this.pictureBox3.Location = new System.Drawing.Point(837, 63);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 176;
            this.pictureBox3.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::WindowsFormsApp1.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1121, 597);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 37);
            this.btnSave.TabIndex = 168;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddToBill
            // 
            this.btnAddToBill.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddToBill.FlatAppearance.BorderSize = 2;
            this.btnAddToBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToBill.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToBill.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddToBill.IconColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddToBill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddToBill.IconSize = 40;
            this.btnAddToBill.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddToBill.Location = new System.Drawing.Point(22, 51);
            this.btnAddToBill.Name = "btnAddToBill";
            this.btnAddToBill.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddToBill.Size = new System.Drawing.Size(127, 41);
            this.btnAddToBill.TabIndex = 223;
            this.btnAddToBill.Text = "أضافة       ";
            this.btnAddToBill.UseVisualStyleBackColor = true;
            this.btnAddToBill.Click += new System.EventHandler(this.btnAddToBill_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnPrint.FlatAppearance.BorderSize = 2;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnPrint.IconColor = System.Drawing.Color.CornflowerBlue;
            this.btnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrint.IconSize = 40;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.Location = new System.Drawing.Point(1122, 266);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPrint.Size = new System.Drawing.Size(127, 41);
            this.btnPrint.TabIndex = 224;
            this.btnPrint.Text = "طباعة      ";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(877, 273);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(125, 19);
            this.label6.TabIndex = 227;
            this.label6.Text = "المبلغ الصافي :";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.money_321;
            this.pictureBox6.Location = new System.Drawing.Point(839, 269);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(31, 26);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 226;
            this.pictureBox6.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(454, 279);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 230;
            this.label7.Text = "الأجمالي:";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::WindowsFormsApp1.Properties.Resources.money_32;
            this.pictureBox7.Location = new System.Drawing.Point(414, 273);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(31, 26);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 229;
            this.pictureBox7.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(318, 278);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotal.Size = new System.Drawing.Size(44, 20);
            this.lblTotal.TabIndex = 231;
            this.lblTotal.Text = "[???]";
            // 
            // lblCurreny3
            // 
            this.lblCurreny3.AutoSize = true;
            this.lblCurreny3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurreny3.Location = new System.Drawing.Point(186, 279);
            this.lblCurreny3.Name = "lblCurreny3";
            this.lblCurreny3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCurreny3.Size = new System.Drawing.Size(60, 20);
            this.lblCurreny3.TabIndex = 232;
            this.lblCurreny3.Text = "ريالا يمني";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.money_32;
            this.pictureBox2.Location = new System.Drawing.Point(417, 227);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 233;
            this.pictureBox2.TabStop = false;
            // 
            // lblNetAmount
            // 
            this.lblNetAmount.AutoSize = true;
            this.lblNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetAmount.Location = new System.Drawing.Point(737, 275);
            this.lblNetAmount.Name = "lblNetAmount";
            this.lblNetAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNetAmount.Size = new System.Drawing.Size(44, 20);
            this.lblNetAmount.TabIndex = 234;
            this.lblNetAmount.Text = "[???]";
            // 
            // lblCurreny
            // 
            this.lblCurreny.AutoSize = true;
            this.lblCurreny.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurreny.Location = new System.Drawing.Point(593, 278);
            this.lblCurreny.Name = "lblCurreny";
            this.lblCurreny.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCurreny.Size = new System.Drawing.Size(60, 20);
            this.lblCurreny.TabIndex = 235;
            this.lblCurreny.Text = "ريالا يمني";
            // 
            // dgvٍSaleItem
            // 
            this.dgvٍSaleItem.AllowUserToAddRows = false;
            this.dgvٍSaleItem.AllowUserToResizeRows = false;
            this.dgvٍSaleItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvٍSaleItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvٍSaleItem.BackgroundColor = System.Drawing.Color.White;
            this.dgvٍSaleItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvٍSaleItem.ContextMenuStrip = this.cmSaleItems;
            this.dgvٍSaleItem.GridColor = System.Drawing.Color.CornflowerBlue;
            this.dgvٍSaleItem.Location = new System.Drawing.Point(22, 315);
            this.dgvٍSaleItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvٍSaleItem.MultiSelect = false;
            this.dgvٍSaleItem.Name = "dgvٍSaleItem";
            this.dgvٍSaleItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvٍSaleItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvٍSaleItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvٍSaleItem.Size = new System.Drawing.Size(1225, 272);
            this.dgvٍSaleItem.TabIndex = 236;
            this.dgvٍSaleItem.TabStop = false;
            this.dgvٍSaleItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvٍSaleItem_CellContentClick);
            this.dgvٍSaleItem.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvٍSaleItem_CellEndEdit);
            // 
            // cmSaleItems
            // 
            this.cmSaleItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.حذقسلعةToolStripMenuItem});
            this.cmSaleItems.Name = "guna2ContextMenuStrip1";
            this.cmSaleItems.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmSaleItems.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmSaleItems.RenderStyle.ColorTable = null;
            this.cmSaleItems.RenderStyle.RoundedEdges = true;
            this.cmSaleItems.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmSaleItems.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmSaleItems.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmSaleItems.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmSaleItems.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmSaleItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmSaleItems.Size = new System.Drawing.Size(170, 42);
            // 
            // حذقسلعةToolStripMenuItem
            // 
            this.حذقسلعةToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.حذقسلعةToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.حذقسلعةToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.حذقسلعةToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Delete_32;
            this.حذقسلعةToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.حذقسلعةToolStripMenuItem.Name = "حذقسلعةToolStripMenuItem";
            this.حذقسلعةToolStripMenuItem.Size = new System.Drawing.Size(169, 38);
            this.حذقسلعةToolStripMenuItem.Text = "حذف سلعة ";
            this.حذقسلعةToolStripMenuItem.Click += new System.EventHandler(this.حذقسلعةToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ndQuqntity
            // 
            this.ndQuqntity.BackColor = System.Drawing.Color.Transparent;
            this.ndQuqntity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ndQuqntity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ndQuqntity.Location = new System.Drawing.Point(177, 115);
            this.ndQuqntity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ndQuqntity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndQuqntity.Name = "ndQuqntity";
            this.ndQuqntity.Size = new System.Drawing.Size(235, 36);
            this.ndQuqntity.TabIndex = 271;
            this.ndQuqntity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndQuqntity.Validating += new System.ComponentModel.CancelEventHandler(this.ndQuqntity_Validating);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.Count_32;
            this.pictureBox4.Location = new System.Drawing.Point(419, 122);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 269;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(457, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 270;
            this.label4.Text = "الكمية :";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(322, 230);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDiscount.Size = new System.Drawing.Size(44, 20);
            this.lblDiscount.TabIndex = 272;
            this.lblDiscount.Text = "[???]";
            // 
            // lblCurreny2
            // 
            this.lblCurreny2.AutoSize = true;
            this.lblCurreny2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurreny2.Location = new System.Drawing.Point(186, 233);
            this.lblCurreny2.Name = "lblCurreny2";
            this.lblCurreny2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCurreny2.Size = new System.Drawing.Size(60, 20);
            this.lblCurreny2.TabIndex = 273;
            this.lblCurreny2.Text = "ريالا يمني";
            // 
            // cbCurrencyType
            // 
            this.cbCurrencyType.BackColor = System.Drawing.Color.Transparent;
            this.cbCurrencyType.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.cbCurrencyType.BorderRadius = 5;
            this.cbCurrencyType.BorderThickness = 2;
            this.cbCurrencyType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCurrencyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrencyType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCurrencyType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCurrencyType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cbCurrencyType.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cbCurrencyType.ItemHeight = 30;
            this.cbCurrencyType.Items.AddRange(new object[] {
            "الريال اليمني",
            "الريال السعودي",
            "الدولار الأمريكي"});
            this.cbCurrencyType.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.cbCurrencyType.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbCurrencyType.ItemsAppearance.SelectedForeColor = System.Drawing.Color.RoyalBlue;
            this.cbCurrencyType.Location = new System.Drawing.Point(177, 168);
            this.cbCurrencyType.Name = "cbCurrencyType";
            this.cbCurrencyType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbCurrencyType.Size = new System.Drawing.Size(235, 36);
            this.cbCurrencyType.TabIndex = 276;
            this.cbCurrencyType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbCurrencyType.SelectedIndexChanged += new System.EventHandler(this.cbCurrencyType_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(457, 174);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(96, 19);
            this.label12.TabIndex = 275;
            this.label12.Text = "نوع العملة :";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::WindowsFormsApp1.Properties.Resources.money_32;
            this.pictureBox9.Location = new System.Drawing.Point(419, 174);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(31, 26);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 274;
            this.pictureBox9.TabStop = false;
            // 
            // cbClintName
            // 
            this.cbClintName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClintName.FormattingEnabled = true;
            this.cbClintName.Items.AddRange(new object[] {
            "أضافة عميل جديد"});
            this.cbClintName.Location = new System.Drawing.Point(591, 63);
            this.cbClintName.Name = "cbClintName";
            this.cbClintName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbClintName.Size = new System.Drawing.Size(235, 33);
            this.cbClintName.TabIndex = 277;
            this.cbClintName.SelectedIndexChanged += new System.EventHandler(this.cbClintName_SelectedIndexChanged);
            this.cbClintName.Validating += new System.ComponentModel.CancelEventHandler(this.cbClintName_Validating_1);
            // 
            // frmAddAndUpdateSalesBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1260, 639);
            this.Controls.Add(this.cbClintName);
            this.Controls.Add(this.cbCurrencyType);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.lblCurreny2);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.ndQuqntity);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvٍSaleItem);
            this.Controls.Add(this.lblCurreny);
            this.Controls.Add(this.lblNetAmount);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblCurreny3);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnAddToBill);
            this.Controls.Add(this.btnCalnsel);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.cbNameProduct);
            this.Controls.Add(this.cbStateSales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.lblSaleBillId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddAndUpdateSalesBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddAndUpdateSalesBill";
            this.Load += new System.EventHandler(this.frmAddAndUpdateSalesBill_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvٍSaleItem)).EndInit();
            this.cmSaleItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndQuqntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnClose;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSaleBillId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Guna.UI2.WinForms.Guna2ComboBox cbStateSales;
        private Guna.UI2.WinForms.Guna2ComboBox cbNameProduct;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtDate;
        private System.Windows.Forms.Button btnCalnsel;
        private FontAwesome.Sharp.IconButton btnAddToBill;
        private FontAwesome.Sharp.IconButton btnPrint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCurreny3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblNetAmount;
        private System.Windows.Forms.Label lblCurreny;
        private System.Windows.Forms.DataGridView dgvٍSaleItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2NumericUpDown ndQuqntity;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCurreny2;
        private System.Windows.Forms.Label lblDiscount;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmSaleItems;
        private System.Windows.Forms.ToolStripMenuItem حذقسلعةToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ComboBox cbCurrencyType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.ComboBox cbClintName;
    }
}