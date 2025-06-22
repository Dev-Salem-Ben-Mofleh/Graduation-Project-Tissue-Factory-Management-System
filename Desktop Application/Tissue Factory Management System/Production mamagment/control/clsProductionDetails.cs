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

namespace WindowsFormsApp1.Production_mamagment.control
{
    public partial class clsProductionDetails : UserControl
    {
        private clsProduction _Production;

        private int? _ProductionID = -1;

        public int? ProductionID
        {
            get { return _ProductionID; }
        }

        public clsProduction SelectedPersonInfo
        {
            get { return _Production; }
        }

        public void LoadProductionInfo(int? ProductionID)
        {


            _Production = clsProduction.Find(ProductionID);
            if (_Production == null)
            {
                ResetPersonInfo();
                MessageBox.Show(" لا يوجد شخص بهذا الرقم = " + ProductionID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }

        private void _FillPersonInfo()
        {
            _ProductionID = _Production.ProductID;
            lblID.Text = _Production.ProductID.ToString();
            lblNameProduct.Text = _Production.productInfo.ProductName;
            lblQuantity.Text = _Production.Quantity.ToString();
            lblDamgedQuantity.Text = _Production.DamagedQuantity.ToString();
            lblDate.Text = _Production.ProductionDate.ToShortDateString();
            lblRaw.Text = _Production.rawMaterialInfo.Material_Name;
            lblQuantutyRaw.Text = _Production.RawAmount.ToString();
            lbluintm.Text = _Production.productInfo.UnitMeasurement;

        }

        public void ResetPersonInfo()
        {
            _ProductionID = -1;
            lblID.Text = "[????]";
            lblNameProduct.Text = "[????]";
            lblQuantity.Text = "[????]";
            lblDamgedQuantity.Text = "[????]";
            lblDate.Text = "[????]";
            lblRaw.Text = "[????]";
            lblQuantutyRaw.Text = "[????]";
        }

        public clsProductionDetails()
        {
            InitializeComponent();
        }


        private void clsProductionDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
