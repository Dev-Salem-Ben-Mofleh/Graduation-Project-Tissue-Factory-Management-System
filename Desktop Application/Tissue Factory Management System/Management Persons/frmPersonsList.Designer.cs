namespace WindowsFormsApp1.Management_Persons
{
    partial class frmPersonsList
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
            this.cbFilterType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbSearchBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txSearchValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRecordsCountPersons = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmsSales = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewPersonoolStripMenuIt = new System.Windows.Forms.ToolStripMenuItem();
            this.editPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPersons = new System.Windows.Forms.DataGridView();
            this.btnSearchPerson = new System.Windows.Forms.Button();
            this.btnAddPersons = new System.Windows.Forms.Button();
            this.cmsSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFilterType
            // 
            this.cbFilterType.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterType.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.cbFilterType.BorderRadius = 5;
            this.cbFilterType.BorderThickness = 2;
            this.cbFilterType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cbFilterType.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cbFilterType.ItemHeight = 30;
            this.cbFilterType.Items.AddRange(new object[] {
            "الكل",
            "عميل",
            "مورد"});
            this.cbFilterType.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.cbFilterType.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbFilterType.ItemsAppearance.SelectedForeColor = System.Drawing.Color.RoyalBlue;
            this.cbFilterType.Location = new System.Drawing.Point(222, 122);
            this.cbFilterType.Name = "cbFilterType";
            this.cbFilterType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbFilterType.Size = new System.Drawing.Size(139, 36);
            this.cbFilterType.TabIndex = 2;
            this.cbFilterType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbFilterType.SelectedIndexChanged += new System.EventHandler(this.cbFilterType_SelectedIndexChanged);
            // 
            // cbSearchBy
            // 
            this.cbSearchBy.BackColor = System.Drawing.Color.Transparent;
            this.cbSearchBy.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.cbSearchBy.BorderRadius = 5;
            this.cbSearchBy.BorderThickness = 2;
            this.cbSearchBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearchBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearchBy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cbSearchBy.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cbSearchBy.ItemHeight = 30;
            this.cbSearchBy.Items.AddRange(new object[] {
            "رقم المميز",
            "الأسم",
            "رقم التلفون",
            "الموقع"});
            this.cbSearchBy.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.cbSearchBy.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbSearchBy.ItemsAppearance.SelectedForeColor = System.Drawing.Color.RoyalBlue;
            this.cbSearchBy.Location = new System.Drawing.Point(748, 122);
            this.cbSearchBy.Name = "cbSearchBy";
            this.cbSearchBy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbSearchBy.Size = new System.Drawing.Size(190, 36);
            this.cbSearchBy.TabIndex = 0;
            this.cbSearchBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbSearchBy.SelectedIndexChanged += new System.EventHandler(this.cbSearchBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 180;
            this.label1.Text = "نوع الشخص:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(944, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 170;
            this.label3.Text = "بحث ب:";
            // 
            // txSearchValue
            // 
            this.txSearchValue.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txSearchValue.BorderThickness = 2;
            this.txSearchValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txSearchValue.DefaultText = "";
            this.txSearchValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txSearchValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txSearchValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txSearchValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txSearchValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txSearchValue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txSearchValue.ForeColor = System.Drawing.Color.Black;
            this.txSearchValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txSearchValue.Location = new System.Drawing.Point(468, 125);
            this.txSearchValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txSearchValue.Name = "txSearchValue";
            this.txSearchValue.PasswordChar = '\0';
            this.txSearchValue.PlaceholderText = "";
            this.txSearchValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txSearchValue.SelectedText = "";
            this.txSearchValue.Size = new System.Drawing.Size(275, 33);
            this.txSearchValue.TabIndex = 1;
            this.txSearchValue.TextChanged += new System.EventHandler(this.txSearchValue_TextChanged);
            this.txSearchValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txSearchValue_KeyPress);
            // 
            // lblRecordsCountPersons
            // 
            this.lblRecordsCountPersons.AutoSize = true;
            this.lblRecordsCountPersons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCountPersons.Location = new System.Drawing.Point(111, 612);
            this.lblRecordsCountPersons.Name = "lblRecordsCountPersons";
            this.lblRecordsCountPersons.Size = new System.Drawing.Size(21, 16);
            this.lblRecordsCountPersons.TabIndex = 189;
            this.lblRecordsCountPersons.Text = "??";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 609);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 188;
            this.label4.Text = "# Records:";
            // 
            // cmsSales
            // 
            this.cmsSales.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.AddNewPersonoolStripMenuIt,
            this.editPersonToolStripMenuItem,
            this.deletePersonToolStripMenuItem,
            this.AccountToolStripMenuItem});
            this.cmsSales.Name = "contextMenuStrip1";
            this.cmsSales.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsSales.Size = new System.Drawing.Size(251, 194);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.showDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showDetailsToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.PersonDetails_32;
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(250, 38);
            this.showDetailsToolStripMenuItem.Text = "&عرض معلومات الشخص";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // AddNewPersonoolStripMenuIt
            // 
            this.AddNewPersonoolStripMenuIt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AddNewPersonoolStripMenuIt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewPersonoolStripMenuIt.ForeColor = System.Drawing.Color.White;
            this.AddNewPersonoolStripMenuIt.Image = global::WindowsFormsApp1.Properties.Resources.AddPerson_32;
            this.AddNewPersonoolStripMenuIt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddNewPersonoolStripMenuIt.Name = "AddNewPersonoolStripMenuIt";
            this.AddNewPersonoolStripMenuIt.Size = new System.Drawing.Size(250, 38);
            this.AddNewPersonoolStripMenuIt.Text = "أضافة &شخص جديد";
            this.AddNewPersonoolStripMenuIt.Click += new System.EventHandler(this.AddNewPersonoolStripMenuIt_Click);
            // 
            // editPersonToolStripMenuItem
            // 
            this.editPersonToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.editPersonToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPersonToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editPersonToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.edit_32;
            this.editPersonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editPersonToolStripMenuItem.Name = "editPersonToolStripMenuItem";
            this.editPersonToolStripMenuItem.Size = new System.Drawing.Size(250, 38);
            this.editPersonToolStripMenuItem.Text = "&تعديل معلومات الشخص";
            this.editPersonToolStripMenuItem.Click += new System.EventHandler(this.editPersonToolStripMenuItem_Click);
            // 
            // deletePersonToolStripMenuItem
            // 
            this.deletePersonToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.deletePersonToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePersonToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deletePersonToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Delete_32;
            this.deletePersonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deletePersonToolStripMenuItem.Name = "deletePersonToolStripMenuItem";
            this.deletePersonToolStripMenuItem.Size = new System.Drawing.Size(250, 38);
            this.deletePersonToolStripMenuItem.Text = "&حذف الشخص";
            this.deletePersonToolStripMenuItem.Click += new System.EventHandler(this.deletePersonToolStripMenuItem_Click);
            // 
            // AccountToolStripMenuItem
            // 
            this.AccountToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AccountToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.AccountToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.List_321;
            this.AccountToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem";
            this.AccountToolStripMenuItem.Size = new System.Drawing.Size(250, 38);
            this.AccountToolStripMenuItem.Text = "&كشف الحساب للشخص";
            this.AccountToolStripMenuItem.Click += new System.EventHandler(this.AccountToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(420, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 42);
            this.label2.TabIndex = 187;
            this.label2.Text = "أدارة الأشخاص ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPersons
            // 
            this.dgvPersons.AllowUserToAddRows = false;
            this.dgvPersons.AllowUserToDeleteRows = false;
            this.dgvPersons.AllowUserToResizeRows = false;
            this.dgvPersons.BackgroundColor = System.Drawing.Color.White;
            this.dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersons.ContextMenuStrip = this.cmsSales;
            this.dgvPersons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPersons.GridColor = System.Drawing.Color.CornflowerBlue;
            this.dgvPersons.Location = new System.Drawing.Point(12, 188);
            this.dgvPersons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPersons.MultiSelect = false;
            this.dgvPersons.Name = "dgvPersons";
            this.dgvPersons.ReadOnly = true;
            this.dgvPersons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersons.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersons.Size = new System.Drawing.Size(1002, 407);
            this.dgvPersons.TabIndex = 3;
            this.dgvPersons.TabStop = false;
            // 
            // btnSearchPerson
            // 
            this.btnSearchPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPerson.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPerson.Image = global::WindowsFormsApp1.Properties.Resources.SearchPerson1;
            this.btnSearchPerson.Location = new System.Drawing.Point(46, 97);
            this.btnSearchPerson.Name = "btnSearchPerson";
            this.btnSearchPerson.Size = new System.Drawing.Size(62, 61);
            this.btnSearchPerson.TabIndex = 5;
            this.btnSearchPerson.UseVisualStyleBackColor = true;
            this.btnSearchPerson.Click += new System.EventHandler(this.btnSearchPerson_Click);
            // 
            // btnAddPersons
            // 
            this.btnAddPersons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddPersons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPersons.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPersons.Image = global::WindowsFormsApp1.Properties.Resources.Add_Person_40;
            this.btnAddPersons.Location = new System.Drawing.Point(124, 97);
            this.btnAddPersons.Name = "btnAddPersons";
            this.btnAddPersons.Size = new System.Drawing.Size(62, 61);
            this.btnAddPersons.TabIndex = 4;
            this.btnAddPersons.UseVisualStyleBackColor = true;
            this.btnAddPersons.Click += new System.EventHandler(this.btnAddPersons_Click);
            // 
            // frmPersonsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1073, 653);
            this.Controls.Add(this.btnSearchPerson);
            this.Controls.Add(this.btnAddPersons);
            this.Controls.Add(this.cbFilterType);
            this.Controls.Add(this.cbSearchBy);
            this.Controls.Add(this.lblRecordsCountPersons);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPersons);
            this.Controls.Add(this.txSearchValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPersonsList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPersonsList";
            this.Load += new System.EventHandler(this.frmPersonsList_Load);
            this.cmsSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterType;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearchBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txSearchValue;
        private System.Windows.Forms.Label lblRecordsCountPersons;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem deletePersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewPersonoolStripMenuIt;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsSales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPersons;
        private System.Windows.Forms.Button btnAddPersons;
        private System.Windows.Forms.Button btnSearchPerson;
        private System.Windows.Forms.ToolStripMenuItem AccountToolStripMenuItem;
    }
}