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
using WindowsFormsApp1.Sales_Department.Control;

namespace WindowsFormsApp1.Sales_Department
{
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }

        private static DataTable _dtAllSales = clsSale.GetAllSales();

        private DataTable _dtPeople = _dtAllSales.DefaultView.ToTable(false, "SaleID", "SaleDate",
            "TotalAmount", "Discount", "NetAmount", "Name"
            , "UserID", "TypeName","CurrncyName");

        private void _RefresPrudctionlList()
        {
            _dtAllSales = clsSale.GetAllSales();
            _dtPeople = _dtAllSales.DefaultView.ToTable(false, "SaleID", "SaleDate",
            "TotalAmount", "Discount", "NetAmount", "Name"
            , "UserID", "TypeName", "CurrncyName");

            dgvSales.DataSource = _dtPeople;
            lblRecordsCountSales.Text = dgvSales.Rows.Count.ToString();
            cbFilter.SelectedIndex = 0;
            cbPaymentStatute.SelectedIndex = 0;
            cbCurrncy.SelectedIndex = 0;

        }

        private void _SearchByDate()
        {
            string FilterColumn = "SaleDate";
            string FilterValue = cbFilter.Text;

            _dtPeople.DefaultView.RowFilter = string.Format("[{0}] >= #{1}# AND [{0}] <= #{2}#",
                FilterColumn,
                dtFrom.Value.ToString("MM/dd/yyyy"),
                dtTo.Value.ToString("MM/dd/yyyy"));

            lblRecordsCountSales.Text = _dtAllSales.Rows.Count.ToString();
        }

        private void _SearchTypeName()
        {
            string FilterColumn = "TypeName";
            string FilterValue = cbPaymentStatute.Text;


            if (FilterValue == "الكل")
                _dtPeople.DefaultView.RowFilter = "";
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%' AND [{2}] >= #{3}# AND [{2}] <= #{4}#",
                    FilterColumn, cbPaymentStatute.Text.Trim(),
                    "SaleDate",
                dtFrom.Value.ToString("MM/dd/yyyy"),
                dtTo.Value.ToString("MM/dd/yyyy"));

            lblRecordsCountSales.Text = _dtAllSales.Rows.Count.ToString();
        }

        private void _SearchTypeCurrency()
        {
            string FilterColumn = "CurrncyName";
            string FilterValue = cbCurrncy.Text;


            if (FilterValue == "الكل")
                _dtPeople.DefaultView.RowFilter = "";
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%' AND [{2}] >= #{3}# AND [{2}] <= #{4}#",
                    FilterColumn, cbCurrncy.Text.Trim(),
                    "SaleDate",
                dtFrom.Value.ToString("MM/dd/yyyy"),
                dtTo.Value.ToString("MM/dd/yyyy"));

            lblRecordsCountSales.Text = _dtAllSales.Rows.Count.ToString();
        }


        private void frmSales_Load(object sender, EventArgs e)
        {
            dgvSales.DataSource = _dtPeople;
            cbFilter.SelectedIndex = 0;
            cbPaymentStatute.SelectedIndex = 0;
            cbCurrncy.SelectedIndex = 0;
            dtFrom.Value = DateTime.Now.AddMonths(-1);
            dtTo.Value = DateTime.Now;
            lblRecordsCountSales.Text = dgvSales.Rows.Count.ToString();

                dgvSales.Columns[0].HeaderText = "رقم الفاتورة";
                dgvSales.Columns[0].Width = 110;

                dgvSales.Columns[1].HeaderText = "تاريخ الفاتورة";
                dgvSales.Columns[1].Width = 100;


                dgvSales.Columns[2].HeaderText = "المبلغ الأجمالي";
                dgvSales.Columns[2].Width = 120;

                dgvSales.Columns[3].HeaderText = "الخصم";
                dgvSales.Columns[3].Width = 100;


                dgvSales.Columns[4].HeaderText = "الميلغ الصافي";
                dgvSales.Columns[4].Width = 120;

                dgvSales.Columns[5].HeaderText = "أسم العميل";
                dgvSales.Columns[5].Width = 120;


                dgvSales.Columns[6].HeaderText = "رقم المستخدم";
                dgvSales.Columns[6].Width = 120;

                dgvSales.Columns[7].HeaderText = "حالة الدفع الفاتورة";
                dgvSales.Columns[7].Width = 120;

                dgvSales.Columns[8].HeaderText = "نوع العملة";
                dgvSales.Columns[8].Width = 120;
            
        }

        

        private void iconButton1_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateSalesBill frm = new frmAddAndUpdateSalesBill();
            frm.ShowDialog();
            _RefresPrudctionlList();
        }

        private void btnEditBill_Click(object sender, EventArgs e)
        {
             frmFilterAndEditBillSale frm = new frmFilterAndEditBillSale();
            frm.ShowDialog();
            _RefresPrudctionlList();

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowSaleBill frm = new frmShowSaleBill((int)dgvSales.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefresPrudctionlList();

        }

        private void AddNewBilltoolStripMenuIt_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateSalesBill frm = new frmAddAndUpdateSalesBill();
            frm.ShowDialog();
            _RefresPrudctionlList();

        }

        private void editBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateSalesBill frm = new frmAddAndUpdateSalesBill((int)dgvSales.CurrentRow.Cells[0].Value);
            
            frm.ShowDialog();
            _RefresPrudctionlList();

        }

        private void txSearchBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilter.Text)
            {
                case "رقم الفاتورة":
                    FilterColumn = "SaleID";
                    break;


                case "اسم العميل":
                    FilterColumn = "Name";
                    break;


            }

            if (txSearchBy.Text.Trim() == "")
            {
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] >= #{1}# AND [{0}] <= #{2}#",
                             FilterColumn,
                             dtFrom.Value.ToString("MM/dd/yyyy"),
                             dtTo.Value.ToString("MM/dd/yyyy"));
                lblRecordsCountSales.Text = dgvSales.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "SaleID")

                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txSearchBy.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%' AND [{2}] >= #{3}# AND [{2}] <= #{4}#",
                    FilterColumn, txSearchBy.Text.Trim(),
                    "SaleDate",
                dtFrom.Value.ToString("MM/dd/yyyy"),
                dtTo.Value.ToString("MM/dd/yyyy"));

            lblRecordsCountSales.Text = dgvSales.Rows.Count.ToString();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txSearchBy.Text = "";
            txSearchBy.Focus();
        }

        private void cbPaymentStatute_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SearchTypeName();
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            _SearchByDate();
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            _SearchByDate();

        }

        private void deleteBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انته متأكد أنك تريد حذف هذا الفاتورة [" + dgvSales.CurrentRow.Cells[0].Value + "]", "تأكيد الحذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {
                clsSale _Sale = clsSale.Find((int)dgvSales.CurrentRow.Cells[0].Value);


                if (clsSale.DeleteSale((int)dgvSales.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("تم حذف الفاتورة بنجاح", "تم بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefresPrudctionlList();
                }

                else
                    MessageBox.Show("لم يتم حذف الفاتورة لديها معلومات مرتبظه بجدول اخر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void cbCurrncy_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SearchTypeCurrency();
        }

        private void txSearchBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "رقم الفاتورة")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void طباعةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //public invoicBill(int? SaleID, string Total, string Discount, string NetAmoutn)

            invoicBill frm = new invoicBill((int)dgvSales.CurrentRow.Cells[0].Value, dgvSales.CurrentRow.Cells[2].Value.ToString(),
                dgvSales.CurrentRow.Cells[3].Value.ToString(), dgvSales.CurrentRow.Cells[4].Value.ToString());

            frm.ShowDialog();
        }
    }
}
