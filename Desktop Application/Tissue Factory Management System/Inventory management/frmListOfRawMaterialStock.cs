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
using WindowsFormsApp1.Expenses_Management;
using WindowsFormsApp1.Production_mamagment;
using WindowsFormsApp1.Purncasing_Departmnet;

namespace WindowsFormsApp1.Inventory_management
{
    public partial class frmListOfRawMaterialStock : Form
    {
        public frmListOfRawMaterialStock()
        {
            InitializeComponent();
        }


        private static DataTable _dtAllRaws = clsRawMaterial.GetAllRawMaterials();

        private DataTable _dtPeople = _dtAllRaws.DefaultView.ToTable(false, "MaterialID", "Material_Name",
            "Unit_cost", "Quantity", "DeliveryDate");

        private void _RefresPrudctionlList()
        {
            _dtAllRaws = clsRawMaterial.GetAllRawMaterials();
            _dtPeople = _dtAllRaws.DefaultView.ToTable(false, "MaterialID", "Material_Name",
            "Unit_cost", "Quantity", "DeliveryDate");

            dgvRaws.DataSource = _dtPeople;
            lblRecordsCountRaws.Text = dgvRaws.Rows.Count.ToString();
            cbFilter.SelectedIndex = 0;
        }


        private void frmListOfRawMaterialStock_Load(object sender, EventArgs e)
        {
            _RefresPrudctionlList();
            dgvRaws.DataSource = _dtPeople;
            cbFilter.SelectedIndex = 0;
            lblRecordsCountRaws.Text = dgvRaws.Rows.Count.ToString();
            

                dgvRaws.Columns[0].HeaderText = "رقم المادة الخام";
                dgvRaws.Columns[0].Width = 150;

                dgvRaws.Columns[1].HeaderText = "اسم المادة الخام";
                dgvRaws.Columns[1].Width = 130;


                dgvRaws.Columns[2].HeaderText = "سعر الكيلو غرام";
                dgvRaws.Columns[2].Width = 130;

                dgvRaws.Columns[3].HeaderText = "الكمية في المخزون";
                dgvRaws.Columns[3].Width = 130;


                dgvRaws.Columns[4].HeaderText = "تاريخ التوصيل";
                dgvRaws.Columns[4].Width = 120;

        }

        private void AddNewBilltoolStripMenuIt_Click(object sender, EventArgs e)
        {
            frmAddAndUpdatePurncasing frm = new frmAddAndUpdatePurncasing();
            frm.ShowDialog();
        }

        private void btnAddNewBill_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateProduction frm = new frmAddAndUpdateProduction();
            frm.ShowDialog();
        }

        private void txSearchBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilter.Text)
            {
                case "رقم المادة الخام":
                    FilterColumn = "MaterialID";
                    break;


                case "اسم المادة الخام":
                    FilterColumn = "Material_Name";
                    break;


            }

            if (txSearchBy.Text.Trim() == "")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblRecordsCountRaws.Text = dgvRaws.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "MaterialID")

                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txSearchBy.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txSearchBy.Text.Trim());

            lblRecordsCountRaws.Text = dgvRaws.Rows.Count.ToString();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txSearchBy.Text = "";
            txSearchBy.Focus();
        }

        private void txSearchBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (cbFilter.Text == "رقم المادة الخام")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
