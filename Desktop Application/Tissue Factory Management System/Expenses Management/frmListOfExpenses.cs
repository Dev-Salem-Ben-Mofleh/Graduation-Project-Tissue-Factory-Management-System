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
using WindowsFormsApp1.Electricity_Department;

namespace WindowsFormsApp1.Expenses_Management
{
    public partial class frmListOfExpenses : Form
    {
        public frmListOfExpenses()
        {
            InitializeComponent();
        }


        private static DataTable _dtAllExpenses = clsExpense.GetAllExpenses();

        private DataTable _dtPeople = _dtAllExpenses.DefaultView.ToTable(false, "ExpenseID", "Amount",
            "ExpenseDate", "Name", "UserID");
        private void _FillTypesOfExpenses()
        {
            DataTable RawName = clsTypesOfExpense.GetAllTypesOfExpenses();
            foreach (DataRow Row in RawName.Rows)
            {
                cbTypeOfEx.Items.Add(Row["Name"]);
            }
        }

        private void _RefresPrudctionlList()
        {
            _dtAllExpenses = clsExpense.GetAllExpenses();
            _dtPeople = _dtAllExpenses.DefaultView.ToTable(false, "ExpenseID", "Amount",
            "ExpenseDate", "Name", "UserID");

            dgvExpense.DataSource = _dtPeople;
            lblRecordsCountExpense.Text = dgvExpense.Rows.Count.ToString();
            cbFilter.SelectedIndex = 0;
            cbTypeOfEx.SelectedIndex = 0;
            
        }

        private void _SearchByDate()
        {
            string FilterColumn = "ExpenseDate";
            string FilterValue = cbFilter.Text;

            _dtPeople.DefaultView.RowFilter = string.Format("[{0}] >= #{1}# AND [{0}] <= #{2}#",
                FilterColumn,
                dtFrom.Value.ToString("MM/dd/yyyy"),
                dtTo.Value.ToString("MM/dd/yyyy"));

            lblRecordsCountExpense.Text = _dtAllExpenses.Rows.Count.ToString();
        }

        private void _SearchTypeName()
        {
            string FilterColumn = "Name";
            string FilterValue = cbTypeOfEx.Text;


            if (FilterValue == "الكل")
                _dtPeople.DefaultView.RowFilter = "";
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%' AND [{2}] >= #{3}# AND [{2}] <= #{4}#",
             FilterColumn, cbTypeOfEx.Text.Trim(),
             "ExpenseDate",
         dtFrom.Value.ToString("MM/dd/yyyy"),
         dtTo.Value.ToString("MM/dd/yyyy"));



            lblRecordsCountExpense.Text = _dtAllExpenses.Rows.Count.ToString();
        }

        private void frmListOfExpenses_Load(object sender, EventArgs e)
        {
            dgvExpense.DataSource = _dtPeople;
            cbFilter.SelectedIndex = 0;
            cbTypeOfEx.SelectedIndex = 0;
            dtFrom.Value = DateTime.Now.AddMonths(-1);
            dtTo.Value = DateTime.Now;
            _FillTypesOfExpenses();

            lblRecordsCountExpense.Text = dgvExpense.Rows.Count.ToString();

                dgvExpense.Columns[0].HeaderText = "رقم الفاتورة";
                dgvExpense.Columns[0].Width = 110;

                dgvExpense.Columns[1].HeaderText = "المبلغ الأجمالي";
                dgvExpense.Columns[1].Width = 120;


                dgvExpense.Columns[2].HeaderText = "تاريخ الفاتورة";
                dgvExpense.Columns[2].Width = 100;


                dgvExpense.Columns[3].HeaderText = "نوع المصروفات";
                dgvExpense.Columns[3].Width = 160;


                dgvExpense.Columns[4].HeaderText = "رقم المستخدم";
                dgvExpense.Columns[4].Width = 120;

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowExpensesDetails frm = new frmShowExpensesDetails((int)dgvExpense.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefresPrudctionlList();

        }

        private void AddNewBilltoolStripMenuIt_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateExpenses frm = new frmAddAndUpdateExpenses();
            frm.ShowDialog();
            _RefresPrudctionlList();

        }

        private void btnAddNewBill_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateExpenses frm = new frmAddAndUpdateExpenses();
            frm.ShowDialog();
            _RefresPrudctionlList();

        }

        private void btnEditBill_Click(object sender, EventArgs e)
        {
            frmFilterExpensesBill frm = new frmFilterExpensesBill();
            frm.ShowDialog();
            _RefresPrudctionlList();

        }

        private void cbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbTypeOfEx_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SearchTypeName();

        }

        private void deleteBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انته متأكد أنك تريد حذف هذا الفاتورة [" + dgvExpense.CurrentRow.Cells[0].Value + "]", "تأكيد الحذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {
                clsExpense _Expense = clsExpense.Find((int)dgvExpense.CurrentRow.Cells[0].Value);


                if (clsExpense.DeleteExpense((int)dgvExpense.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("تم حذف الفاتورة بنجاح", "تم بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefresPrudctionlList();
                }

                else
                    MessageBox.Show("لم يتم حذف الفاتورة لديها معلومات مرتبظه بجدول اخر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void txSearchBy_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txSearchBy.Text = "";
            txSearchBy.Focus();
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            _SearchByDate();
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            _SearchByDate();
        }

        private void editBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateExpenses frm = new frmAddAndUpdateExpenses((int)dgvExpense.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefresPrudctionlList();
        }

        private void txSearchBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "رقم الفاتورة")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txSearchBy_TextChanged_1(object sender, EventArgs e)
        {
          
            if (txSearchBy.Text.Trim() != "")

                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", "ExpenseID", txSearchBy.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] >= #{1}# AND [{0}] <= #{2}#",
                                             "ExpenseDate",
                                             dtFrom.Value.ToString("MM/dd/yyyy"),
                                             dtTo.Value.ToString("MM/dd/yyyy"));

            lblRecordsCountExpense.Text = dgvExpense.Rows.Count.ToString();
        }
    }
}
