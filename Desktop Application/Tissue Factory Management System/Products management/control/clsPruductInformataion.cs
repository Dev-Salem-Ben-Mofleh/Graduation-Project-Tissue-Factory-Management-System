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

namespace WindowsFormsApp1.Products_management
{
    public partial class clsPruductInformataion : UserControl
    {
        public clsPruductInformataion()
        {
            InitializeComponent();
        }

        private clsProduct _Product;

        private int? _ProductID = -1;

        public int? ProductID
        {
            get { return _ProductID; }
        }

        public clsProduct SelectedProductInfo
        {
            get { return _Product; }
        }

        public void LoadProductInfo(int? ProductID)
        {

            _Product = clsProduct.Find(ProductID);
            if (_Product == null)
            {
                ResetPersonInfo();
                MessageBox.Show(" لا يوجد شخص بهذا الرقم = " + ProductID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillProductInfo();
        }

        private void _FillProductInfo()
        {
            lbkUpdateProduct.Enabled = true;
            _ProductID = _Product.ProductID;
            lblID.Text = _Product.ProductID.ToString();
            lblName.Text = _Product.ProductName;
            lblDes.Text = _Product.description==null?"No description": _Product.description;
            lblUintM.Text = _Product.UnitMeasurement.ToString();
            lblUintPrice.Text = _Product.UnitPrice.ToString();
            lblQuantity.Text = _Product.Quantity.ToString();

        }

        public void ResetPersonInfo()
        {
            _ProductID = -1;
            lblID.Text = "[????]";
            lblName.Text = "[????]";
            lblDes.Text = "[????]";
            lblUintM.Text = "[????]";
            lblUintPrice.Text = "[????]";
            lblQuantity.Text = "[????]";
        }
        private void lbkUpdateProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddAndUpdateProduct frm = new frmAddAndUpdateProduct(_ProductID);
            frm.ShowDialog();
            LoadProductInfo(_ProductID);
        }
    }
}
