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
    public partial class frmSearchPerson : Form
    {
        public delegate void DataBackEventHandler(object sender, int? PeronsID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public frmSearchPerson()
        {
            InitializeComponent();
        }

        private void btnCalnsel_Click(object sender, EventArgs e)

        {

            DataBack?.Invoke(this, cltFilterPerson1.PersonID);
            this.Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this, cltFilterPerson1.PersonID);
            this.Close();

        }

        private void frmSearchPerson_Load(object sender, EventArgs e)
        {
        
        }

        private void cltFilterPerson1_Load(object sender, EventArgs e)
        {

        }
    }
}
