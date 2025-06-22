namespace WindowsFormsApp1.Purncasing_Departmnet
{
    partial class frmFilterAndEditPurncasingBill_
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnCalnsel = new System.Windows.Forms.Button();
            this.clsSearchPurncasing1 = new WindowsFormsApp1.Purncasing_Departmnet.control.clsSearchPurncasing();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(203, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(779, 39);
            this.lblTitle.TabIndex = 159;
            this.lblTitle.Text = "البحث عن \\وتعديل فاتورة المشتريات";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(125)))), ((int)(((byte)(189)))));
            this.guna2Panel1.Controls.Add(this.iconButton1);
            this.guna2Panel1.Controls.Add(this.btnClose);
            this.guna2Panel1.Controls.Add(this.lblTitle);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1181, 36);
            this.guna2Panel1.TabIndex = 224;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(125)))), ((int)(((byte)(189)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(1146, 5);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(31, 28);
            this.iconButton1.TabIndex = 141;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
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
            // 
            // btnCalnsel
            // 
            this.btnCalnsel.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnCalnsel.FlatAppearance.BorderSize = 2;
            this.btnCalnsel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalnsel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalnsel.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.btnCalnsel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalnsel.Location = new System.Drawing.Point(1040, 597);
            this.btnCalnsel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalnsel.Name = "btnCalnsel";
            this.btnCalnsel.Size = new System.Drawing.Size(126, 37);
            this.btnCalnsel.TabIndex = 225;
            this.btnCalnsel.Text = "أغلاق";
            this.btnCalnsel.UseVisualStyleBackColor = true;
            this.btnCalnsel.Click += new System.EventHandler(this.btnCalnsel_Click);
            // 
            // clsSearchPurncasing1
            // 
            this.clsSearchPurncasing1.BackColor = System.Drawing.Color.White;
            this.clsSearchPurncasing1.Location = new System.Drawing.Point(11, 42);
            this.clsSearchPurncasing1.Name = "clsSearchPurncasing1";
            this.clsSearchPurncasing1.Size = new System.Drawing.Size(1166, 534);
            this.clsSearchPurncasing1.TabIndex = 226;
            // 
            // frmFilterAndEditPurncasingBill_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1181, 641);
            this.Controls.Add(this.clsSearchPurncasing1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnCalnsel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFilterAndEditPurncasingBill_";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFilterAndEditPurncasingBill_";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Button btnCalnsel;
        private control.clsSearchPurncasing clsSearchPurncasing1;
    }
}