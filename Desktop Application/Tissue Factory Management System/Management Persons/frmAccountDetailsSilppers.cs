using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Management_Persons.Control;

namespace WindowsFormsApp1.Management_Persons
{
    public partial class frmAccountDetailsSilppers : Form
    {
        int? _personID;

        public frmAccountDetailsSilppers(int? personID)
        {
            InitializeComponent();
            _personID = personID;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnCalnsel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmAccountDetailsSilppers_Load(object sender, EventArgs e)
        {
            cltSilpers1.LoadAccountInfo(_personID);

        }
    }
}
