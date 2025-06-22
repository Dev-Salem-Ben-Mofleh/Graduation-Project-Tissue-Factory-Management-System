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
    public partial class frmShowPersonsDetails : Form
    {
        int? _PersonID;
        public frmShowPersonsDetails(int?PersonID)
        {
            _PersonID = PersonID;
            InitializeComponent();
        }

        private void ctlPersonCard1_Load(object sender, EventArgs e)
        {
            ctlPersonCard1.LoadPersonInfo(_PersonID);
        }

        private void btnCalnsel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
