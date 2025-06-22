using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Electricity_Department
{
    public partial class frmShowRecoredElectricityDetails : Form
    {
        int? _Ele;
        public frmShowRecoredElectricityDetails( int? ele)
        {
            InitializeComponent();
            _Ele = ele;
        }

        private void btnCalnsel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmShowRecoredElectricityDetails_Load(object sender, EventArgs e)
        {
            clsElectricityInformation1.LoadElexInfo(_Ele);
        }
    }
}
