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
using WindowsFormsApp1.Sales_Department;

namespace WindowsFormsApp1.Electricity_Department
{
    public partial class frmElectricity : Form
    {
        public frmElectricity()
        {
            InitializeComponent();
        }



        private static DataTable _dtAllElectrictie = clsElectricite.GetAllElectricites();

        private DataTable _dtPeople = _dtAllElectrictie.DefaultView.ToTable(false, "ElectrictyID", "Quantity",
            "TypeOf", "UintPrice", "Total", "date"
            , "UserID");

        private void _RefresPrudctionlList()
        {
            _dtAllElectrictie = clsElectricite.GetAllElectricites();
            _dtPeople = _dtAllElectrictie.DefaultView.ToTable(false, "ElectrictyID", "Quantity",
            "TypeOf", "UintPrice", "Total", "date"
            , "UserID");

            dgvElect.DataSource = _dtPeople;
            lblRecordsCountElectr.Text = dgvElect.Rows.Count.ToString();
            cbFilter.SelectedIndex = 0;

        }

        private void _SearchByDate()
        {
            string FilterColumn = "date";
            string FilterValue = cbFilter.Text;

            _dtPeople.DefaultView.RowFilter = string.Format("[{0}] >= #{1}# AND [{0}] <= #{2}#",
                FilterColumn,
                dtFrom.Value.ToString("MM/dd/yyyy"),
                dtTo.Value.ToString("MM/dd/yyyy"));

            lblRecordsCountElectr.Text = _dtAllElectrictie.Rows.Count.ToString();
        }



        private void frmElectricity_Load(object sender, EventArgs e)
        {
            dgvElect.DataSource = _dtPeople;
            cbFilter.SelectedIndex = 0;
            dtFrom.Value = DateTime.Now.AddMonths(-1);
            dtTo.Value = DateTime.Now;
            lblRecordsCountElectr.Text = dgvElect.Rows.Count.ToString();


                dgvElect.Columns[0].HeaderText = "رقم سجل الكهرباء";
                dgvElect.Columns[0].Width = 150;

                dgvElect.Columns[1].HeaderText = "كمية النقط";
                dgvElect.Columns[1].Width = 100;


                dgvElect.Columns[2].HeaderText = "نوع النفط";
                dgvElect.Columns[2].Width = 120;

                dgvElect.Columns[3].HeaderText = "سعر اللتر";
                dgvElect.Columns[3].Width = 100;

                dgvElect.Columns[4].HeaderText = "المجموع";
                dgvElect.Columns[4].Width = 200;

                dgvElect.Columns[5].HeaderText = "تاريخ العميلة";
                dgvElect.Columns[5].Width = 120;

                dgvElect.Columns[6].HeaderText = "رقم المستخدم";
                dgvElect.Columns[6].Width = 100;





        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowRecoredElectricityDetails frm = new frmShowRecoredElectricityDetails((int)dgvElect.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefresPrudctionlList();

        }

        private void AddNewBilltoolStripMenuIt_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateElectricity frm = new frmAddAndUpdateElectricity();
            frm.ShowDialog();
            _RefresPrudctionlList();

        }

        private void btnAddNewBill_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateElectricity frm = new frmAddAndUpdateElectricity();
            frm.ShowDialog();
            _RefresPrudctionlList();
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            _SearchByDate();

        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            _SearchByDate();

        }

        private void lblRecordsCountElectr_Click(object sender, EventArgs e)
        {

        }

        private void deleteBillToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل انته متأكد أنك تريد حذف هذا السجل [" + dgvElect.CurrentRow.Cells[0].Value + "]", "تأكيد الحذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {
                clsPerson Person = clsPerson.Find((int)dgvElect.CurrentRow.Cells[0].Value);


                if (clsPerson.DeletePerson((int)dgvElect.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("تم حذف السجل بنجاح", "تم بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefresPrudctionlList();
                }

                else
                    MessageBox.Show("لم يتم حذف السجل لدية معلومات مرتبظه بجدول اخر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txSearchBy_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = "";

            switch (cbFilter.Text)
            {
                case "رقم سجل الكهرباء":
                    FilterColumn = "ElectrictyID";
                    break;


                case "نوع النفط":
                    FilterColumn = "TypeOf";
                    break;

            }

            if (txSearchBy.Text.Trim() == "")
            {
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] >= #{1}# AND [{0}] <= #{2}#",
                    "date",
                    dtFrom.Value.ToString("MM/dd/yyyy"),
                    dtTo.Value.ToString("MM/dd/yyyy"));
                lblRecordsCountElectr.Text = dgvElect.Rows.Count.ToString();

                return;
            }


            if (FilterColumn == "ElectrictyID")

                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txSearchBy.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%' AND [{2}] >= #{3}# AND [{2}] <= #{4}#",
                    FilterColumn, txSearchBy.Text.Trim(),
                    "date",
                    dtFrom.Value.ToString("MM/dd/yyyy"),
                    dtTo.Value.ToString("MM/dd/yyyy"));


            lblRecordsCountElectr.Text = dgvElect.Rows.Count.ToString();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txSearchBy.Text = "";
            txSearchBy.Focus();
        }

        private void editBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateElectricity frm = new frmAddAndUpdateElectricity((int)dgvElect.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefresPrudctionlList();
        }

        private void txSearchBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (cbFilter.Text == "رقم سجل الكهرباء")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
