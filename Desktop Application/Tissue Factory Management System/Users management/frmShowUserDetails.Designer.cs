namespace WindowsFormsApp1.Users_management
{
    partial class frmShowUserDetails
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCalnsel = new System.Windows.Forms.Button();
            this.ctlPersonCard1 = new WindowsFormsApp1.Management_Persons.ctlPersonCard();
            this.cltUserCard1 = new WindowsFormsApp1.Users_management.controls.cltUserCard();
            this.guna2Panel1.SuspendLayout();
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
            this.guna2Panel1.Size = new System.Drawing.Size(927, 36);
            this.guna2Panel1.TabIndex = 258;
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
            this.btnClose.Location = new System.Drawing.Point(891, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(73, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(779, 33);
            this.lblTitle.TabIndex = 234;
            this.lblTitle.Text = "عرض معلومات المستخدم";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalnsel
            // 
            this.btnCalnsel.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnCalnsel.FlatAppearance.BorderSize = 2;
            this.btnCalnsel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalnsel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalnsel.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.btnCalnsel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalnsel.Location = new System.Drawing.Point(783, 472);
            this.btnCalnsel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalnsel.Name = "btnCalnsel";
            this.btnCalnsel.Size = new System.Drawing.Size(126, 37);
            this.btnCalnsel.TabIndex = 1;
            this.btnCalnsel.Text = "أغلاق";
            this.btnCalnsel.UseVisualStyleBackColor = true;
            this.btnCalnsel.Click += new System.EventHandler(this.btnCalnsel_Click);
            // 
            // ctlPersonCard1
            // 
            this.ctlPersonCard1.BackColor = System.Drawing.Color.White;
            this.ctlPersonCard1.Location = new System.Drawing.Point(6, 45);
            this.ctlPersonCard1.Name = "ctlPersonCard1";
            this.ctlPersonCard1.Size = new System.Drawing.Size(910, 278);
            this.ctlPersonCard1.TabIndex = 259;
            // 
            // cltUserCard1
            // 
            this.cltUserCard1.BackColor = System.Drawing.Color.White;
            this.cltUserCard1.Location = new System.Drawing.Point(1, 329);
            this.cltUserCard1.Name = "cltUserCard1";
            this.cltUserCard1.Size = new System.Drawing.Size(910, 133);
            this.cltUserCard1.TabIndex = 261;
            // 
            // frmShowUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(927, 523);
            this.Controls.Add(this.cltUserCard1);
            this.Controls.Add(this.ctlPersonCard1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnCalnsel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowUserDetails";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowUserDetails";
            this.Load += new System.EventHandler(this.frmShowUserDetails_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Management_Persons.ctlPersonCard ctlPersonCard1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCalnsel;
        private controls.cltUserCard cltUserCard1;
    }
}