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
using WindowsFormsApp1.Production_mamagment;
using WindowsFormsApp1.Products_management;

namespace WindowsFormsApp1.Inventory_management
{
    public partial class frmProducingMaterials : Form
    {
        public frmProducingMaterials()
        {
            InitializeComponent();
        }

        private static DataTable _dtAllProducts = clsProduct.GetAllProducts();

        private DataTable _dtProduct = _dtAllProducts.DefaultView.ToTable(false, "ProductID", "ProductName",
            "UnitPrice", "Quantity");

        private void _RefresPrudctionlList()
        {
            _dtAllProducts = clsProduct.GetAllProducts();
            _dtProduct = _dtAllProducts.DefaultView.ToTable(false, "ProductID", "ProductName",
            "UnitPrice", "Quantity");

            dgvProducts.DataSource = _dtProduct;
            lblRecordsCountProducts.Text = dgvProducts.Rows.Count.ToString();
            cbFilter.SelectedIndex = 0;
        }

        private void frmProducingMaterials_Load(object sender, EventArgs e)
        {
            _RefresPrudctionlList();

            dgvProducts.DataSource = _dtProduct;
            cbFilter.SelectedIndex = 0;
            lblRecordsCountProducts.Text = dgvProducts.Rows.Count.ToString();
            

                dgvProducts.Columns[0].HeaderText = "رقم المنتج";
                dgvProducts.Columns[0].Width = 110;

                dgvProducts.Columns[1].HeaderText = "أسم المنتج";
                dgvProducts.Columns[1].Width = 100;


                dgvProducts.Columns[2].HeaderText = "سعر الحبة";
                dgvProducts.Columns[2].Width = 120;

                dgvProducts.Columns[3].HeaderText = "الكمية في المخزون";
                dgvProducts.Columns[3].Width = 150;

        }

        private void AddNewBilltoolStripMenuIt_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateProduct frm = new frmAddAndUpdateProduct();
            frm.ShowDialog();
        }

        private void btnAddNewBill_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateProduct frm = new frmAddAndUpdateProduct();
            frm.ShowDialog();
        }

        private void txSearchBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilter.Text)
            {
                case "رقم المنتج":
                    FilterColumn = "ProductID";
                    break;


                case "اسم المنتج":
                    FilterColumn = "ProductName";
                    break;


            }

            if (txSearchBy.Text.Trim() == "")
            {
                _dtProduct.DefaultView.RowFilter = "";
                lblRecordsCountProducts.Text = dgvProducts.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "ProductID")

                _dtProduct.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txSearchBy.Text.Trim());
            else
                _dtProduct.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txSearchBy.Text.Trim());

            lblRecordsCountProducts.Text = dgvProducts.Rows.Count.ToString();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txSearchBy.Text = "";
            txSearchBy.Focus();
        }

        private void txSearchBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "رقم المنتج")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
