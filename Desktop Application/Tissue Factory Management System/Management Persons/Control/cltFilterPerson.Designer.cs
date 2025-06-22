namespace WindowsFormsApp1.Management_Persons.Control
{
    partial class cltFilterPerson
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.btnAddNewPerso = new System.Windows.Forms.Button();
            this.txSearchBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ctlPersonCard1 = new WindowsFormsApp1.Management_Persons.ctlPersonCard();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.btnAddNewPerso);
            this.gbFilters.Controls.Add(this.txSearchBy);
            this.gbFilters.Controls.Add(this.btnSearch);
            this.gbFilters.Controls.Add(this.label1);
            this.gbFilters.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilters.Location = new System.Drawing.Point(3, 2);
            this.gbFilters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFilters.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbFilters.Size = new System.Drawing.Size(721, 63);
            this.gbFilters.TabIndex = 19;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "بحث";
            // 
            // btnAddNewPerso
            // 
            this.btnAddNewPerso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNewPerso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewPerso.Image = global::WindowsFormsApp1.Properties.Resources.AddPerson_32;
            this.btnAddNewPerso.Location = new System.Drawing.Point(176, 13);
            this.btnAddNewPerso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddNewPerso.Name = "btnAddNewPerso";
            this.btnAddNewPerso.Size = new System.Drawing.Size(45, 41);
            this.btnAddNewPerso.TabIndex = 2;
            this.btnAddNewPerso.UseVisualStyleBackColor = true;
            this.btnAddNewPerso.Click += new System.EventHandler(this.btnAddNewPerso_Click);
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
            this.txSearchBy.Location = new System.Drawing.Point(293, 17);
            this.txSearchBy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txSearchBy.Name = "txSearchBy";
            this.txSearchBy.PasswordChar = '\0';
            this.txSearchBy.PlaceholderText = "";
            this.txSearchBy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txSearchBy.SelectedText = "";
            this.txSearchBy.Size = new System.Drawing.Size(275, 35);
            this.txSearchBy.TabIndex = 0;
            this.txSearchBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txSearchBy_KeyPress);
            this.txSearchBy.Validating += new System.ComponentModel.CancelEventHandler(this.txSearchBy_Validating);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::WindowsFormsApp1.Properties.Resources.SearchPerson;
            this.btnSearch.Location = new System.Drawing.Point(232, 14);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(45, 41);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(575, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "رقم الشخص :";
            // 
            // ctlPersonCard1
            // 
            this.ctlPersonCard1.BackColor = System.Drawing.Color.White;
            this.ctlPersonCard1.Location = new System.Drawing.Point(3, 70);
            this.ctlPersonCard1.Name = "ctlPersonCard1";
            this.ctlPersonCard1.Size = new System.Drawing.Size(910, 278);
            this.ctlPersonCard1.TabIndex = 20;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cltFilterPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctlPersonCard1);
            this.Controls.Add(this.gbFilters);
            this.Name = "cltFilterPerson";
            this.Size = new System.Drawing.Size(924, 368);
            this.Load += new System.EventHandler(this.cltFilterPerson_Load);
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private ctlPersonCard ctlPersonCard1;
        private System.Windows.Forms.Button btnAddNewPerso;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2TextBox txSearchBy;
    }
}
