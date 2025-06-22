namespace WindowsFormsApp1.ManagmentReports
{
    partial class frmProdctsR
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrint = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTypePrint = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbTypeMove = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSaleR = new System.Windows.Forms.DataGridView();
            this.lblRecordsCountStocks = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblnotfound = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleR)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(548, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 226;
            this.label1.Text = "نوع البحث :";
            // 
            // dtFrom
            // 
            this.dtFrom.Checked = true;
            this.dtFrom.FillColor = System.Drawing.Color.CornflowerBlue;
            this.dtFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtFrom.ForeColor = System.Drawing.Color.White;
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(695, 22);
            this.dtFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtFrom.Size = new System.Drawing.Size(237, 36);
            this.dtFrom.TabIndex = 220;
            this.dtFrom.Value = new System.DateTime(2024, 11, 17, 16, 43, 49, 517);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbTypePrint);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbTypeMove);
            this.groupBox1.Controls.Add(this.dtFrom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1029, 128);
            this.groupBox1.TabIndex = 206;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "البحث العام";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::WindowsFormsApp1.Properties.Resources.SearchPerson;
            this.btnSearch.Location = new System.Drawing.Point(250, 25);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(45, 41);
            this.btnSearch.TabIndex = 359;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.btnPrint.Location = new System.Drawing.Point(482, 65);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPrint.Size = new System.Drawing.Size(127, 41);
            this.btnPrint.TabIndex = 358;
            this.btnPrint.Text = "تصدير      ";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(908, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 357;
            this.label5.Text = "نوع التصدير :";
            // 
            // cbTypePrint
            // 
            this.cbTypePrint.BackColor = System.Drawing.Color.Transparent;
            this.cbTypePrint.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.cbTypePrint.BorderRadius = 5;
            this.cbTypePrint.BorderThickness = 2;
            this.cbTypePrint.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTypePrint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypePrint.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTypePrint.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTypePrint.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cbTypePrint.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cbTypePrint.ItemHeight = 30;
            this.cbTypePrint.Items.AddRange(new object[] {
            "Excel",
            "Pdf",
            "الطابعة",
            "أرسال الى المدير"});
            this.cbTypePrint.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.cbTypePrint.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbTypePrint.ItemsAppearance.SelectedForeColor = System.Drawing.Color.RoyalBlue;
            this.cbTypePrint.Location = new System.Drawing.Point(632, 70);
            this.cbTypePrint.Name = "cbTypePrint";
            this.cbTypePrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbTypePrint.Size = new System.Drawing.Size(253, 36);
            this.cbTypePrint.TabIndex = 356;
            this.cbTypePrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbTypeMove
            // 
            this.cbTypeMove.BackColor = System.Drawing.Color.Transparent;
            this.cbTypeMove.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.cbTypeMove.BorderRadius = 5;
            this.cbTypeMove.BorderThickness = 2;
            this.cbTypeMove.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTypeMove.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeMove.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTypeMove.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTypeMove.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cbTypeMove.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cbTypeMove.ItemHeight = 30;
            this.cbTypeMove.Items.AddRange(new object[] {
            "يومي",
            "شهري",
            "سنوي"});
            this.cbTypeMove.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.cbTypeMove.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbTypeMove.ItemsAppearance.SelectedForeColor = System.Drawing.Color.RoyalBlue;
            this.cbTypeMove.Location = new System.Drawing.Point(343, 23);
            this.cbTypeMove.Name = "cbTypeMove";
            this.cbTypeMove.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbTypeMove.Size = new System.Drawing.Size(183, 36);
            this.cbTypeMove.TabIndex = 225;
            this.cbTypeMove.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbTypeMove.SelectedIndexChanged += new System.EventHandler(this.cbTypeMove_SelectedIndexChanged);
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
            // dgvSaleR
            // 
            this.dgvSaleR.AllowUserToAddRows = false;
            this.dgvSaleR.AllowUserToDeleteRows = false;
            this.dgvSaleR.AllowUserToResizeRows = false;
            this.dgvSaleR.BackgroundColor = System.Drawing.Color.White;
            this.dgvSaleR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleR.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSaleR.GridColor = System.Drawing.Color.CornflowerBlue;
            this.dgvSaleR.Location = new System.Drawing.Point(24, 233);
            this.dgvSaleR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSaleR.MultiSelect = false;
            this.dgvSaleR.Name = "dgvSaleR";
            this.dgvSaleR.ReadOnly = true;
            this.dgvSaleR.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaleR.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSaleR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaleR.Size = new System.Drawing.Size(1029, 370);
            this.dgvSaleR.TabIndex = 205;
            this.dgvSaleR.TabStop = false;
            // 
            // lblRecordsCountStocks
            // 
            this.lblRecordsCountStocks.AutoSize = true;
            this.lblRecordsCountStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCountStocks.Location = new System.Drawing.Point(122, 620);
            this.lblRecordsCountStocks.Name = "lblRecordsCountStocks";
            this.lblRecordsCountStocks.Size = new System.Drawing.Size(21, 16);
            this.lblRecordsCountStocks.TabIndex = 204;
            this.lblRecordsCountStocks.Text = "??";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 617);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 203;
            this.label4.Text = "# Records:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(419, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 42);
            this.label2.TabIndex = 202;
            this.label2.Text = "تقارير المنتجات";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnotfound
            // 
            this.lblnotfound.AutoSize = true;
            this.lblnotfound.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnotfound.ForeColor = System.Drawing.Color.Red;
            this.lblnotfound.Location = new System.Drawing.Point(452, 611);
            this.lblnotfound.Name = "lblnotfound";
            this.lblnotfound.Size = new System.Drawing.Size(267, 29);
            this.lblnotfound.TabIndex = 207;
            this.lblnotfound.Text = "لا توجد تقارير لهذا التاريخ ";
            // 
            // frmProdctsR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1073, 653);
            this.Controls.Add(this.lblnotfound);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSaleR);
            this.Controls.Add(this.lblRecordsCountStocks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProdctsR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProdctsR";
            this.Load += new System.EventHandler(this.frmProdctsR_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtFrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbTypeMove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvSaleR;
        private System.Windows.Forms.Label lblRecordsCountStocks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnPrint;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbTypePrint;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblnotfound;
    }
}