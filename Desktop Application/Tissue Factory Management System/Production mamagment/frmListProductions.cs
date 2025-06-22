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
using WindowsFormsApp1.Management_Persons;

namespace WindowsFormsApp1.Production_mamagment
{
    public partial class frmListProductions : Form
    {
        public frmListProductions()
        {
            InitializeComponent();
        }


        private static DataTable _dtAllProductions = clsProduction.GetAllProductions();

        private DataTable _dtPeople = _dtAllProductions.DefaultView.ToTable(false, "ProductionID", "Quantity",
            "ProductionDate", "DamagedQuantity", "RawAmount", "Name"
            , "Material_Name", "ProductName");

        private void _RefresPrudctionlList()
        {
            _dtAllProductions = clsProduction.GetAllProductions();
            _dtPeople = _dtAllProductions.DefaultView.ToTable(false, "ProductionID", "Quantity",
            "ProductionDate", "DamagedQuantity", "RawAmount", "Name"
            , "Material_Name", "ProductName");

            dgvPructions.DataSource = _dtPeople;
            lblRecordsCountProudctions.Text = dgvPructions.Rows.Count.ToString();
            cbFilterBy.SelectedIndex = 0;

        }

        private void _SearchByDate()
        {
            string FilterColumn = "ProductionDate";
            string FilterValue = cbFilterBy.Text;

                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] >= #{1}# AND [{0}] <= #{2}#",
                    FilterColumn,
                    dtfrom.Value.ToString("MM/dd/yyyy"),
                    dtTo.Value.ToString("MM/dd/yyyy"));

            lblRecordsCountProudctions.Text = _dtAllProductions.Rows.Count.ToString();
        }


        private void frmListProductions_Load(object sender, EventArgs e)
        {
            _RefresPrudctionlList();
            dgvPructions.DataSource = _dtPeople;
            cbFilterBy.SelectedIndex = 0;
            dtfrom.Value = DateTime.Now.AddMonths(-1);
            dtTo.Value = DateTime.Now;
            lblRecordsCountProudctions.Text = dgvPructions.Rows.Count.ToString();


                dgvPructions.Columns[0].HeaderText = "رقم الأنتاج";
                dgvPructions.Columns[0].Width = 110;

                dgvPructions.Columns[1].HeaderText = "الكمية المنتجة";
                dgvPructions.Columns[1].Width = 100;


                dgvPructions.Columns[2].HeaderText = "تاريخ الأنتاج";
                dgvPructions.Columns[2].Width = 120;

                dgvPructions.Columns[3].HeaderText = "الكمية التالفة";
                dgvPructions.Columns[3].Width = 100;


                dgvPructions.Columns[4].HeaderText = "كمية المواد الخام";
                dgvPructions.Columns[4].Width = 120;

                dgvPructions.Columns[5].HeaderText = "أسم المستخدم";
                dgvPructions.Columns[5].Width = 120;


                dgvPructions.Columns[6].HeaderText = "اسسم المادة الخام";
                dgvPructions.Columns[6].Width = 120;

                dgvPructions.Columns[7].HeaderText = "اسم  المنتج";
                dgvPructions.Columns[7].Width = 120;
            
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowDetailsProductions frm = new frmShowDetailsProductions((int)dgvPructions.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefresPrudctionlList();
        }

        private void AddNewBilltoolStripMenuIt_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateProduction frm = new frmAddAndUpdateProduction();
            frm.ShowDialog();
            _RefresPrudctionlList();

        }

        private void editBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateProduction frm = new frmAddAndUpdateProduction((int)dgvPructions.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefresPrudctionlList();

        }

        private void btnAddNewBill_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateProduction frm = new frmAddAndUpdateProduction();
            frm.ShowDialog();
            _RefresPrudctionlList();

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
           txSearchBy.Text = "";
            txSearchBy.Focus();
        }

        private void txSearchBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "رقم الأنتاج":
                    FilterColumn = "ProductionID";
                    break;


                case "اسم المادة الخام":
                    FilterColumn = "Material_Name";
                    break;


                case "اسم المنتج":
                    FilterColumn = "ProductName";
                    break;

            }

            if (txSearchBy.Text.Trim() == "")
            {
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] >= #{1}# AND [{0}] <= #{2}#",
                                    "ProductionDate",
                                    dtfrom.Value.ToString("MM/dd/yyyy"),
                                    dtTo.Value.ToString("MM/dd/yyyy"));
                lblRecordsCountProudctions.Text = dgvPructions.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "ProductionID")

                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txSearchBy.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%' AND [{2}] >= #{3}# AND [{2}] <= #{4}#",
                    FilterColumn, txSearchBy.Text.Trim(),
                    "ProductionDate",
                    dtfrom.Value.ToString("MM/dd/yyyy"),
                    dtTo.Value.ToString("MM/dd/yyyy"));

            lblRecordsCountProudctions.Text = dgvPructions.Rows.Count.ToString();
        }

        private void dtfrom_ValueChanged(object sender, EventArgs e)
        {
            _SearchByDate();
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            _SearchByDate();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انته متأكد أنك تريد حذف هذا الأنتاج [" + dgvPructions.CurrentRow.Cells[0].Value + "]", "تأكيد الحذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {
                 clsProduction _production = clsProduction.Find((int)dgvPructions.CurrentRow.Cells[0].Value);


                if (clsProduction.DeleteProduction((int)dgvPructions.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("تم حذف الأنتاج بنجاح", "تم بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefresPrudctionlList();
                }

                else
                    MessageBox.Show("لم يتم حذف الأنتاج لدية معلومات مرتبظه بجدول اخر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void txSearchBy_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (cbFilterBy.Text == "رقم الأنتاج")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
