using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Management_Persons
{
    public partial class frmAccountDetails : Form
    {
        int? _personID;


        public frmAccountDetails(int? personID)
        {
            InitializeComponent();
            _personID = personID;

        }

        private void btnCalnsel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmAccountDetails_Load(object sender, EventArgs e)
        {
            cltAccount1.LoadAccountInfo(_personID);
        }

        private void cltAccount1_Load(object sender, EventArgs e)
        {

        }
    }
}
