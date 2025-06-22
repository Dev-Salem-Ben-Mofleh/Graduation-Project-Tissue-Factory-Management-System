using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Management_Boxes
{
    public partial class frmShowBoxInfo : Form
    {
        public frmShowBoxInfo()
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

        private void frmShowBoxInfo_Load(object sender, EventArgs e)
        {
            cltBoxInfo1.LoadInfo();
        }
    }
}
