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
    public partial class frmUpdatePassword : Form
    {
        private int? _UserID;
        private clsUser _User;
        public frmUpdatePassword(int? UserID)
        {
            _UserID = UserID;
            InitializeComponent();
        }

        private void _ResetDefualtValues()
        {
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirm.Text = "";
        }

        private void _Save()
        {

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.Password = clsUtil.ComputeHash(txtNewPassword.Text.Trim());


            if (_User.Save())
            {

                MessageBox.Show("تم تحديث كلمة السر بنجاح",
                   "حفظ.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefualtValues();
            }
            else
            {
                MessageBox.Show("حدث خطأ كلمة السر لم يتم تحديثها ",
                   "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalnsel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void frmUpdatePassword_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            _User = clsUser.Find(_UserID);

            if (_User == null)
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("المستخدم فير موجود بهذا الرقم =" + _UserID,
                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

                return;

            }
            cltUserCard1.LoadUserInfo(_UserID);
            ctlPersonCard1.LoadPersonInfo(_User.PersonID);

        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            string HashPassword;

            if (string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "لا يجب ان يكون هذا الحقل فارغا");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            };

            HashPassword = clsUtil.ComputeHash(txtCurrentPassword.Text.Trim());

            if (_User.Password.Trim() != HashPassword)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "كلمة السسر الحالية خطأ");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            };

        }

        private void txtConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirm.Text.Trim() != txtNewPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirm, "كلمة السر هذه لا تطابق كلمة السر التي أدخلتها");
            }
            else
            {
                errorProvider1.SetError(txtConfirm, null);
            };
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "لا يجب أن يكون الحقل فارغ");
            }
            else
            if (!clsValidation.ValidatePassword(txtNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "لا تقل عن 8 أحرف تحتوي على حرف كبير واحد على الأقل تحتوي على حرف صغير واحد على الأقل تحتوي على رقم واحد على الأقل تحتوي على رمز خاص واحد على الأقل");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, null);
            };
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
