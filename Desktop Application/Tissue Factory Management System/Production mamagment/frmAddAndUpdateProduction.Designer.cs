namespace WindowsFormsApp1.Production_mamagment
{
    partial class frmAddAndUpdateProduction
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
            this.cbRaws = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.ndQuqntity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nuQuanatityDamaged = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ndQuantityRaws = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnCalnsel = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbProductss = new Guna.UI2.WinForms.Guna2ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndQuqntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuQuanatityDamaged)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndQuantityRaws)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbRaws
            // 
            this.cbRaws.BackColor = System.Drawing.Color.Transparent;
            this.cbRaws.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.cbRaws.BorderRadius = 5;
            this.cbRaws.BorderThickness = 2;
            this.cbRaws.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRaws.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRaws.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRaws.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRaws.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cbRaws.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cbRaws.ItemHeight = 30;
            this.cbRaws.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.cbRaws.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbRaws.ItemsAppearance.SelectedForeColor = System.Drawing.Color.RoyalBlue;
            this.cbRaws.Location = new System.Drawing.Point(431, 181);
            this.cbRaws.Name = "cbRaws";
            this.cbRaws.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbRaws.Size = new System.Drawing.Size(235, 36);
            this.cbRaws.TabIndex = 262;
            this.cbRaws.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(713, 188);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(135, 19);
            this.label6.TabIndex = 261;
            this.label6.Text = "نوع المادة الخام :";
            // 
            // dtDate
            // 
            this.dtDate.Checked = true;
            this.dtDate.Enabled = false;
            this.dtDate.FillColor = System.Drawing.Color.CornflowerBlue;
            this.dtDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtDate.ForeColor = System.Drawing.Color.White;
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(431, 114);
            this.dtDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtDate.Name = "dtDate";
            this.dtDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtDate.Size = new System.Drawing.Size(237, 36);
            this.dtDate.TabIndex = 254;
            this.dtDate.Value = new System.DateTime(2024, 11, 17, 16, 43, 49, 517);
            // 
            // lblTitle
            // 
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(37, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(779, 39);
            this.lblTitle.TabIndex = 158;
            this.lblTitle.Text = "أضافة\\تعديل  أنتاج";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(295, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 248;
            this.label4.Text = "الكمية :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 244;
            this.label2.Text = "أسم المنتج :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(713, 128);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(65, 19);
            this.label8.TabIndex = 242;
            this.label8.Text = "التاريخ :";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(626, 50);
            this.lblID.Name = "lblID";
            this.lblID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblID.Size = new System.Drawing.Size(44, 20);
            this.lblID.TabIndex = 240;
            this.lblID.Text = "[???]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(717, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 236;
            this.label1.Text = "رقم خطة الأنتاج";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(125)))), ((int)(((byte)(189)))));
            this.guna2Panel1.Controls.Add(this.btnClose);
            this.guna2Panel1.Controls.Add(this.lblTitle);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(862, 36);
            this.guna2Panel1.TabIndex = 234;
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
            this.btnClose.Location = new System.Drawing.Point(824, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 28);
            this.btnClose.TabIndex = 140;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ndQuqntity
            // 
            this.ndQuqntity.BackColor = System.Drawing.Color.Transparent;
            this.ndQuqntity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ndQuqntity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ndQuqntity.Location = new System.Drawing.Point(97, 114);
            this.ndQuqntity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ndQuqntity.Name = "ndQuqntity";
            this.ndQuqntity.Size = new System.Drawing.Size(150, 36);
            this.ndQuqntity.TabIndex = 268;
            this.ndQuqntity.Validating += new System.ComponentModel.CancelEventHandler(this.ndQuantityRaws_Validating);
            // 
            // nuQuanatityDamaged
            // 
            this.nuQuanatityDamaged.BackColor = System.Drawing.Color.Transparent;
            this.nuQuanatityDamaged.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nuQuanatityDamaged.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nuQuanatityDamaged.Location = new System.Drawing.Point(97, 173);
            this.nuQuanatityDamaged.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nuQuanatityDamaged.Name = "nuQuanatityDamaged";
            this.nuQuanatityDamaged.Size = new System.Drawing.Size(150, 36);
            this.nuQuanatityDamaged.TabIndex = 271;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 270;
            this.label3.Text = "الكمية التالفة :";
            // 
            // ndQuantityRaws
            // 
            this.ndQuantityRaws.BackColor = System.Drawing.Color.Transparent;
            this.ndQuantityRaws.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ndQuantityRaws.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ndQuantityRaws.Location = new System.Drawing.Point(532, 240);
            this.ndQuantityRaws.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ndQuantityRaws.Name = "ndQuantityRaws";
            this.ndQuantityRaws.Size = new System.Drawing.Size(134, 36);
            this.ndQuantityRaws.TabIndex = 274;
            this.ndQuantityRaws.Validating += new System.ComponentModel.CancelEventHandler(this.ndQuantityRaws_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(713, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(146, 19);
            this.label5.TabIndex = 273;
            this.label5.Text = "كمية المواد الخام :";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.Count_32;
            this.pictureBox5.Location = new System.Drawing.Point(679, 247);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 272;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Count_32;
            this.pictureBox2.Location = new System.Drawing.Point(260, 180);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 269;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.Question_32;
            this.pictureBox6.Location = new System.Drawing.Point(675, 184);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(31, 26);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 260;
            this.pictureBox6.TabStop = false;
            // 
            // btnCalnsel
            // 
            this.btnCalnsel.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnCalnsel.FlatAppearance.BorderSize = 2;
            this.btnCalnsel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalnsel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalnsel.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.btnCalnsel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalnsel.Location = new System.Drawing.Point(587, 307);
            this.btnCalnsel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalnsel.Name = "btnCalnsel";
            this.btnCalnsel.Size = new System.Drawing.Size(126, 37);
            this.btnCalnsel.TabIndex = 255;
            this.btnCalnsel.Text = "ألغاء";
            this.btnCalnsel.UseVisualStyleBackColor = true;
            this.btnCalnsel.Click += new System.EventHandler(this.btnCalnsel_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.Count_32;
            this.pictureBox4.Location = new System.Drawing.Point(257, 121);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 247;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.List_32;
            this.pictureBox1.Location = new System.Drawing.Point(257, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 243;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::WindowsFormsApp1.Properties.Resources.Calendar_32;
            this.pictureBox11.Location = new System.Drawing.Point(675, 122);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(31, 26);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 241;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::WindowsFormsApp1.Properties.Resources.id__1_;
            this.pictureBox8.Location = new System.Drawing.Point(679, 49);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 238;
            this.pictureBox8.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::WindowsFormsApp1.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(729, 307);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 37);
            this.btnSave.TabIndex = 235;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbProductss
            // 
            this.cbProductss.BackColor = System.Drawing.Color.Transparent;
            this.cbProductss.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.cbProductss.BorderRadius = 5;
            this.cbProductss.BorderThickness = 2;
            this.cbProductss.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbProductss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductss.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbProductss.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbProductss.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cbProductss.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cbProductss.ItemHeight = 30;
            this.cbProductss.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.cbProductss.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbProductss.ItemsAppearance.SelectedForeColor = System.Drawing.Color.RoyalBlue;
            this.cbProductss.Location = new System.Drawing.Point(16, 49);
            this.cbProductss.Name = "cbProductss";
            this.cbProductss.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbProductss.Size = new System.Drawing.Size(235, 36);
            this.cbProductss.TabIndex = 275;
            this.cbProductss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbProductss.SelectedIndexChanged += new System.EventHandler(this.cbProductss_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(441, 252);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 276;
            this.label7.Text = "كيلو غرام";
            // 
            // frmAddAndUpdateProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 362);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbProductss);
            this.Controls.Add(this.ndQuantityRaws);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nuQuanatityDamaged);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ndQuqntity);
            this.Controls.Add(this.cbRaws);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.btnCalnsel);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddAndUpdateProduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddAndUpdateProduction";
            this.Load += new System.EventHandler(this.frmAddAndUpdateProduction_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ndQuqntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuQuanatityDamaged)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndQuantityRaws)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cbRaws;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnCalnsel;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtDate;
        private System.Windows.Forms.PictureBox pictureBox4;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2NumericUpDown ndQuqntity;
        private Guna.UI2.WinForms.Guna2NumericUpDown nuQuanatityDamaged;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2NumericUpDown ndQuantityRaws;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbProductss;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label7;
    }
}