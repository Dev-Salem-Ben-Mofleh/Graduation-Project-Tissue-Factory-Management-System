using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Production_mamagment
{
    public partial class frmShowDetailsProductions : Form
    {
        int? _ProductionID;
        public frmShowDetailsProductions(int? productionID)
        {
            InitializeComponent();
            _ProductionID = productionID;
        }

        private void btnCalnsel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmShowDetailsProductions_Load(object sender, EventArgs e)
        {
            clsProductionDetails1.LoadProductionInfo(_ProductionID);
        }
    }
}
