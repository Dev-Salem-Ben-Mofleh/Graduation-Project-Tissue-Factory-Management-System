using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Suite.Descriptions;
using FontAwesome.Sharp;
using InstituteBussiness;
using WindowsFormsApp1.Global;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
        int CounterFailedLogin = 0;

        public frmLogin()
        {

            InitializeComponent();
        }

        public void LoadDataFromRegistory()
        {
            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;
                txtPassword.Text = Password;
                chkRememberMe.Checked = true;
            }
            else
                chkRememberMe.Checked = false;

        }
        public void CheckAndFindUser()
        {
            string Password;
            string HashPassword;

            Password = txtPassword.Text.Trim();
            HashPassword = clsUtil.ComputeHash(Password);
            clsUser user = clsUser.FindByUsernameAndPassword(txtUserName.Text.Trim(), HashPassword);


            if (user != null)
            {

                if (chkRememberMe.Checked)
                {
                    //store username and password
                    clsGlobal.RememberUsernameAndPassword(txtUserName.Text.Trim(), Password);

                }
                else
                {
                    //store empty username and password
                    clsGlobal.RememberUsernameAndPassword("", "");

                }

                //incase the user is not active
                if (!user.IsActive)
                {

                    txtUserName.Focus();
                    MessageBox.Show("هذا الحساب غير مفعل ,تواصل مع مديرك", "حساب غير مفعل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                clsGlobal.CurrentUser = user;
                clslogin_registe _Registe=new clslogin_registe();
                _Registe.UserID = user.UserID;
                _Registe.DateLogin = DateTime.Now;
                _Registe.Save();
                this.Hide();
                frmHome frm = new frmHome(this);
                frm.ShowDialog();


            }
            else
            {
                CounterFailedLogin++;
                txtUserName.Focus();
                MessageBox.Show("كملة المرور  أو أسم الستخدم خطأ, لديك من المحاولات" + CounterFailedLogin + "/3 قبل الغلق  ", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (CounterFailedLogin == 3)
                    this.Close();
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheckAndFindUser();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            LoadDataFromRegistory();

        }
    }
}
