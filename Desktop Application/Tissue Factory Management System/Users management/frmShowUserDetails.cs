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

namespace WindowsFormsApp1.Users_management
{
    public partial class frmShowUserDetails : Form
    {
        int? _UserID;
        public frmShowUserDetails(int? UserID)
        {
            _UserID = UserID;
            InitializeComponent();
        }

     
        public frmShowUserDetails()
        {
            InitializeComponent();
        }

        private void btnCalnsel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmShowUserDetails_Load(object sender, EventArgs e)
        {
            cltUserCard1.LoadUserInfo(_UserID);
            ctlPersonCard1.LoadPersonInfo(clsUser.Find(_UserID).PersonID);
        }
    }
}
