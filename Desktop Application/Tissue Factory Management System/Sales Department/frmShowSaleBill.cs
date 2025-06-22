using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Sales_Department
{
    public partial class frmShowSaleBill : Form
    {
        int? _SaleID;
        public frmShowSaleBill(int? SaleID)
        {
            _SaleID = SaleID;
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnCalnsel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void clsSaleInformaiton1_Load(object sender, EventArgs e)
        {
            clsSaleInformaiton1.LoadSaleInfo(_SaleID);
        }
    }
}
