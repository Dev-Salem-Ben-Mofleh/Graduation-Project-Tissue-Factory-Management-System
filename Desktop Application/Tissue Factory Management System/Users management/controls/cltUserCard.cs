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
using WindowsFormsApp1.Management_Persons;

namespace WindowsFormsApp1.Users_management.controls
{
    public partial class cltUserCard : UserControl
    {
        private clsUser _User;

        private int? _UserID = -1;

        public int? UserID
        {
            get { return _UserID; }
        }

        public clsUser SelectedUserInfo
        {
            get { return _User; }
        }

        public void LoadUserInfo(int? UserID)
        {


            _User = clsUser.Find(UserID);
            if (_User == null)
            {
                ResetPersonInfo();
                MessageBox.Show(" لا يوجد مستخدم بهذا الرقم = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserInfo();
        }

        private void _FillUserInfo()
        {
            lbkUdpateUser.Enabled = true;
            _UserID = _User.UserID;
            lblID.Text = _User.UserID.ToString();
            lblIsActive.Text = _User.IsActive==true?"نشط":"غير نشط";
            lblUserName.Text = _User.UserName;
        }

        public void ResetPersonInfo()
        {
            _UserID = -1;
            lblID.Text = "[????]";
            lblIsActive.Text = "[????]";
            lblUserName.Text = "[????]";
   
        }
        public cltUserCard()
        {
            InitializeComponent();
        }

        private void lbkUdpateUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddAndUpdateUser frm = new frmAddAndUpdateUser(_UserID);
            frm.ShowDialog();

            LoadUserInfo(_UserID);
        }
    }
}
