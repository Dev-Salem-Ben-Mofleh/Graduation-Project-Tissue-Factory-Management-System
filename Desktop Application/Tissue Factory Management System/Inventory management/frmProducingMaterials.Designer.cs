namespace WindowsFormsApp1.Inventory_management
{
    partial class frmProducingMaterials
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
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddNewBill = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txSearchBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.cmsSales = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddNewBilltoolStripMenuIt = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecordsCountProducts = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.cmsSales.SuspendLayout();
            this.SuspendLayout();
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
            this.cbFilter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cbFilter.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cbFilter.ItemHeight = 30;
            this.cbFilter.Items.AddRange(new object[] {
            "رقم المنتج",
            "اسم المنتج"});
            this.cbFilter.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.cbFilter.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbFilter.ItemsAppearance.SelectedForeColor = System.Drawing.Color.RoyalBlue;
            this.cbFilter.Location = new System.Drawing.Point(765, 33);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbFilter.Size = new System.Drawing.Size(190, 36);
            this.cbFilter.TabIndex = 224;
            this.cbFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbFilter);
            this.groupBox1.Controls.Add(this.btnAddNewBill);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txSearchBy);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1029, 90);
            this.groupBox1.TabIndex = 196;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "البحث العام";
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
            this.btnAddNewBill.Location = new System.Drawing.Point(236, 11);
            this.btnAddNewBill.Name = "btnAddNewBill";
            this.btnAddNewBill.Size = new System.Drawing.Size(88, 75);
            this.btnAddNewBill.TabIndex = 184;
            this.btnAddNewBill.UseVisualStyleBackColor = true;
            this.btnAddNewBill.Click += new System.EventHandler(this.btnAddNewBill_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(953, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 170;
            this.label3.Text = "بحث ب:";
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
            this.txSearchBy.Location = new System.Drawing.Point(485, 34);
            this.txSearchBy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txSearchBy.Name = "txSearchBy";
            this.txSearchBy.PasswordChar = '\0';
            this.txSearchBy.PlaceholderText = "";
            this.txSearchBy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txSearchBy.SelectedText = "";
            this.txSearchBy.Size = new System.Drawing.Size(275, 38);
            this.txSearchBy.TabIndex = 177;
            this.txSearchBy.TextChanged += new System.EventHandler(this.txSearchBy_TextChanged);
            this.txSearchBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txSearchBy_KeyPress);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.ContextMenuStrip = this.cmsSales;
            this.dgvProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProducts.GridColor = System.Drawing.Color.CornflowerBlue;
            this.dgvProducts.Location = new System.Drawing.Point(13, 183);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1029, 408);
            this.dgvProducts.TabIndex = 195;
            this.dgvProducts.TabStop = false;
            // 
            // cmsSales
            // 
            this.cmsSales.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewBilltoolStripMenuIt});
            this.cmsSales.Name = "contextMenuStrip1";
            this.cmsSales.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsSales.Size = new System.Drawing.Size(200, 42);
            // 
            // AddNewBilltoolStripMenuIt
            // 
            this.AddNewBilltoolStripMenuIt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AddNewBilltoolStripMenuIt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewBilltoolStripMenuIt.ForeColor = System.Drawing.Color.White;
            this.AddNewBilltoolStripMenuIt.Image = global::WindowsFormsApp1.Properties.Resources.Notes_32;
            this.AddNewBilltoolStripMenuIt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddNewBilltoolStripMenuIt.Name = "AddNewBilltoolStripMenuIt";
            this.AddNewBilltoolStripMenuIt.Size = new System.Drawing.Size(199, 38);
            this.AddNewBilltoolStripMenuIt.Text = "أضافة &منتج جديد";
            this.AddNewBilltoolStripMenuIt.Click += new System.EventHandler(this.AddNewBilltoolStripMenuIt_Click);
            // 
            // lblRecordsCountProducts
            // 
            this.lblRecordsCountProducts.AutoSize = true;
            this.lblRecordsCountProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCountProducts.Location = new System.Drawing.Point(111, 608);
            this.lblRecordsCountProducts.Name = "lblRecordsCountProducts";
            this.lblRecordsCountProducts.Size = new System.Drawing.Size(21, 16);
            this.lblRecordsCountProducts.TabIndex = 194;
            this.lblRecordsCountProducts.Text = "??";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 605);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 193;
            this.label4.Text = "# Records:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(456, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 42);
            this.label2.TabIndex = 192;
            this.label2.Text = "أدارة مخزون المواد المنتجة";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmProducingMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1073, 653);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.lblRecordsCountProducts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProducingMaterials";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProducingMaterials";
            this.Load += new System.EventHandler(this.frmProducingMaterials_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.cmsSales.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnAddNewBill;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txSearchBy;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.ContextMenuStrip cmsSales;
        private System.Windows.Forms.ToolStripMenuItem AddNewBilltoolStripMenuIt;
        private System.Windows.Forms.Label lblRecordsCountProducts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}