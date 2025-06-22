using BussinesLayer;
using Guna.UI2.WinForms;
using InstituteBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Global;

namespace WindowsFormsApp1.Users_management
{
    public partial class frmAddAndUpdateUser : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enum enGendor { Female = 0, Male = 1 };

        private enMode _Mode;
        private int? _UserID = -1;
        clsUser _user;


        private void _FillLocations()
        {
            DataTable RanksName = clsLocation.GetAllLocations();
            foreach (DataRow Row in RanksName.Rows)
            {
                cbLocations.Items.Add(Row["LocationName"]);
            }
        }

        public frmAddAndUpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;

        }
        public frmAddAndUpdateUser(int? UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _Mode = enMode.Update;
        }

        private void _ResetDefualtValues()
        {
            _FillLocations();
            cbLocations.SelectedIndex = 0;
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "أضافة مستخدم جديد";
                _user = new clsUser();
            }
            else
            {
                lblTitle.Text = "تحديث معلومات مستخدم ";
            }

            

            txtName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtConfirmPassword.Text = "";
            txtPassword.Text = "";
            txtUserNam.Text = "";
            chActive.Checked =true;
        }

        private void _LoadData()
        {

            _user = clsUser.Find(_UserID);

            if (_user == null)
            {
                MessageBox.Show("No User with ID = " + _UserID, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblID.Text = _UserID.ToString();
            txtName.Text = _user.PersonInfo.Name;
            txtEmail.Text = _user.PersonInfo.Email;
            txtPhone.Text = _user.PersonInfo.PhoneNumber.ToString();
            cbLocations.SelectedIndex = cbLocations.FindString(_user.PersonInfo.locationInfo.LocationName);
            txtPassword.Enabled=false;
            txtConfirmPassword.Enabled = false;
            txtUserNam.Text = _user.UserName;
            chActive.Checked = (_user.IsActive);

        }

        private void _Save()
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("بعض الحقول يوجد فيها أخطاء", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Mode == enMode.Update)
            {
                _user.PersonInfo.Name = txtName.Text.Trim();
                _user.PersonInfo.Email = txtEmail.Text.Trim();
                _user.PersonInfo.PhoneNumber = txtPhone.Text.Trim();
                _user.PersonInfo.Location = cbLocations.SelectedIndex + 1;
                _user.UserName = txtUserNam.Text;
                _user.IsActive = (chActive.Checked);
            }
            else

            {
                _user.PersonInfo.Name = txtName.Text.Trim();
                _user.PersonInfo.Email = txtEmail.Text.Trim();
                _user.PersonInfo.PhoneNumber = txtPhone.Text.Trim();
                _user.PersonInfo.Location = cbLocations.SelectedIndex + 1;
                _user.UserName = txtUserNam.Text;
                _user.Password = clsUtil.ComputeHash(txtPassword.Text.Trim());
                _user.IsActive = (chActive.Checked);
            }
            if (_user.PersonInfo.Save())
                _user.PersonID = _user.PersonInfo.PersonID;

            if (_user.Save())
            {
                lblID.Text = _user.UserID.ToString();

                _Mode = enMode.Update;
                lblTitle.Text = "تحديث مستخدم شخص";

                MessageBox.Show("تم حفظ البيانات بشكل صحيح", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
                MessageBox.Show("خظأ:  لم يتم حفظ البيانات بشكل صحيح ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
        


        private void frmAddAndUpdateUser_Load(object sender, EventArgs e)
        {

            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnCalnsel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "لا يجب ترك الحقل فارغ");
                return;
            }
            else
            if (!clsValidation.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "تنسيق الأيميل خاطئ");
                return;

            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            };
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            Guna2TextBox Temp = ((Guna2TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "لا يجب ترك الحقل فارغ");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (_Mode == enMode.Update)
                return;

            if (string.IsNullOrEmpty(txtConfirmPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "لا يجب ترك الحقل فارغ");
                return;
            }
            else
            if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "يجب ان تكون متطابقة مع كلمة السر");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            };
        }

        private void txtUserNam_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserNam.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserNam, "لا يجب ترك الحقل فارغ");
                return;
            }


            if (_Mode == enMode.AddNew)
            {

                if (clsUser.DoesUserExist(txtUserNam.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUserNam, "أسم المسخدم مستخدم بواسطة مستخدم اخر");
                }
                else
                {
                    errorProvider1.SetError(txtUserNam, null);
                };
            }
            else
            {
                //incase update make sure not to use anothers user name
                if (_user.UserName != txtUserNam.Text.Trim())
                {
                    if (clsUser.DoesUserExist(txtUserNam.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtUserNam, "أسم المسخدم مستخدم بواسطة مستخدم اخر");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtUserNam, null);
                    };
                }
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {

            if (_Mode == enMode.Update)
                return;

            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "لا يجب ترك الحقل فارغ");
                return;
            }
            
            else
             if (!clsValidation.ValidatePassword(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "لا تقل عن 8 أحرف تحتوي على حرف كبير واحد على الأقل تحتوي على حرف صغير واحد على الأقل تحتوي على رقم واحد على الأقل تحتوي على رمز خاص واحد على الأقل");
                return;
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            };
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPhone, "لا يجب ترك الحقل فارغ");
            }
            if (!clsValidation.PhoneNumber(txtPhone.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPhone, "يجب ان يكون عدد الارقام صحيح");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtPhone, null);
            }
        }
    }
}
