using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Products_management
{
    public partial class frmShowDetailsProducts : Form
    {
        private int? _ProductID;

        public frmShowDetailsProducts(int? ProductID)
        {
            InitializeComponent();
            _ProductID = ProductID;
        }


        private void btnCalnsel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmShowDetailsProducts_Load(object sender, EventArgs e)
        {
            clsPruductInformataion1.LoadProductInfo(_ProductID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
