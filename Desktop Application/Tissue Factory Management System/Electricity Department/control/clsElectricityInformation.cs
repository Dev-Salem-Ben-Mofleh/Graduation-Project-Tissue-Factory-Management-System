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

namespace WindowsFormsApp1.Electricity_Department.control
{
    public partial class clsElectricityInformation : UserControl
    {
        public clsElectricityInformation()
        {
            InitializeComponent();
        }


        private clsElectricite _electricite;

        private int? _EleID = -1;

        public int? EleID
        {
            get { return EleID; }
        }

        public clsElectricite SelectedEleIDInfo
        {
            get { return _electricite; }
        }

        public void LoadElexInfo(int? EleID)
        {


            _electricite = clsElectricite.Find(EleID);
            if (_electricite == null)
            {
                ResetSaleInfo();
                MessageBox.Show(" لا توجد فاتورة بهذا الرقم = " + EleID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillExpneseInfo();
        }

        private void _FillExpneseInfo()
        {
            _EleID = _electricite.ElectrictyID;
            lblId.Text = _electricite.ElectrictyID.ToString();
            lblDate.Text = _electricite.date.ToShortDateString();
            lblType.Text = _electricite.TypeOf;
            lblTotal.Text = _electricite.Total.ToString();
            lblQuantity.Text = _electricite.Quantity.ToString();
            lblUintPrice.Text = _electricite.UintPrice.ToString();

        }

        public void ResetSaleInfo()
        {
            _EleID = -1;
            lblId.Text = "[????]";
            lblDate.Text = "[????]";
            lblTotal.Text = "[????]";
            lblQuantity.Text = "[????]";
            lblUintPrice.Text = "[????]";
            lblType.Text = "[????]";


        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void clsElectricityInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
