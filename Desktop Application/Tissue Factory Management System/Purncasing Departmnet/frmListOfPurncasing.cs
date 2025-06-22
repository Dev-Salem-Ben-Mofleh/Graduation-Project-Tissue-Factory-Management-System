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
using WindowsFormsApp1.Products_management;

namespace WindowsFormsApp1.Purncasing_Departmnet
{
    public partial class frmListOfPurncasing : Form
    {
        public frmListOfPurncasing()
        {
            InitializeComponent();
        }



        private static DataTable _dtAllPruchases = clsPurchase.GetAllPurchases();

        private DataTable _dtPeople = _dtAllPruchases.DefaultView.ToTable(false, "PurchaseID", "PurchaseDate",
            "TotalAmount", "Discount", "NetAmount", "Name"
            , "UserID", "TypeName", "CurrncyName");

        private void _RefresPrudctionlList()
        {
            _dtAllPruchases = clsPurchase.GetAllPurchases();
            _dtPeople = _dtAllPruchases.DefaultView.ToTable(false, "PurchaseID", "PurchaseDate",
            "TotalAmount", "Discount", "NetAmount", "Name"
            , "UserID", "TypeName", "CurrncyName");

            dgvPruchase.DataSource = _dtPeople;
            lblRecordsCountPruchases.Text = dgvPruchase.Rows.Count.ToString();
            cbFilter.SelectedIndex = 0;
            cbPayment.SelectedIndex = 0;
            cbCurrency.SelectedIndex = 0;
      
        }

        private void _SearchByDate()
        {
            string FilterColumn = "PurchaseDate";
            string FilterValue = cbFilter.Text;

            _dtPeople.DefaultView.RowFilter = string.Format("[{0}] >= #{1}# AND [{0}] <= #{2}#",
                FilterColumn,
                dtFrom.Value.ToString("MM/dd/yyyy"),
                dtTo.Value.ToString("MM/dd/yyyy"));

            lblRecordsCountPruchases.Text = _dtAllPruchases.Rows.Count.ToString();
        }

        private void _SearchTypeName()
        {
            string FilterColumn = "TypeName";
            string FilterValue = cbPayment.Text;


            if (FilterValue == "الكل")
                _dtPeople.DefaultView.RowFilter = "";
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%' AND [{2}] >= #{3}# AND [{2}] <= #{4}#",
        FilterColumn, cbPayment.Text.Trim(),
        "PurchaseDate",
    dtFrom.Value.ToString("MM/dd/yyyy"),
    dtTo.Value.ToString("MM/dd/yyyy"));

            lblRecordsCountPruchases.Text = _dtAllPruchases.Rows.Count.ToString();
        }

        private void _SearchTypeCurrency()
        {
            string FilterColumn = "CurrncyName";
            string FilterValue = cbCurrency.Text;


            if (FilterValue == "الكل")
                _dtPeople.DefaultView.RowFilter = "";
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%' AND [{2}] >= #{3}# AND [{2}] <= #{4}#",
                    FilterColumn, cbCurrency.Text.Trim(),
                    "PurchaseDate",
                dtFrom.Value.ToString("MM/dd/yyyy"),
                dtTo.Value.ToString("MM/dd/yyyy"));

            lblRecordsCountPruchases.Text = _dtAllPruchases.Rows.Count.ToString();
        }


        private void frmListOfPurncasing_Load(object sender, EventArgs e)
        {
            dgvPruchase.DataSource = _dtPeople;
            cbFilter.SelectedIndex = 0;
            cbPayment.SelectedIndex = 0;
            cbCurrency.SelectedIndex = 0;
            dtFrom.Value = DateTime.Now.AddMonths(-1);
            dtTo.Value = DateTime.Now;
            lblRecordsCountPruchases.Text = dgvPruchase.Rows.Count.ToString();

                dgvPruchase.Columns[0].HeaderText = "رقم الفاتورة";
                dgvPruchase.Columns[0].Width = 110;

                dgvPruchase.Columns[1].HeaderText = "تاريخ الفاتورة";
                dgvPruchase.Columns[1].Width = 100;


                dgvPruchase.Columns[2].HeaderText = "المبلغ الأجمالي";
                dgvPruchase.Columns[2].Width = 120;

                dgvPruchase.Columns[3].HeaderText = "الخصم";
                dgvPruchase.Columns[3].Width = 100;


                dgvPruchase.Columns[4].HeaderText = "الميلغ الصافي";
                dgvPruchase.Columns[4].Width = 120;

                dgvPruchase.Columns[5].HeaderText = "أسم المورد";
                dgvPruchase.Columns[5].Width = 120;


                dgvPruchase.Columns[6].HeaderText = "رقم المستخدم";
                dgvPruchase.Columns[6].Width = 120;

                dgvPruchase.Columns[7].HeaderText = "حالة الدفع الفاتورة";
                dgvPruchase.Columns[7].Width = 120;

                dgvPruchase.Columns[8].HeaderText = "نوع العملة";
                dgvPruchase.Columns[8].Width = 120;
            
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPurncasingBill frm = new frmShowPurncasingBill((int)dgvPruchase.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefresPrudctionlList();

        }

        private void AddNewBilltoolStripMenuIt_Click(object sender, EventArgs e)
        {
            frmAddAndUpdatePurncasing frm = new frmAddAndUpdatePurncasing();
            frm.ShowDialog();
            _RefresPrudctionlList();

        }

        private void editBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddAndUpdatePurncasing frm = new frmAddAndUpdatePurncasing((int)dgvPruchase.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefresPrudctionlList();

        }


        private void btnEditBill_Click(object sender, EventArgs e)
        {
            frmFilterAndEditPurncasingBill_ frm = new frmFilterAndEditPurncasingBill_();
            frm.ShowDialog();
            _RefresPrudctionlList();

        }

        private void btnAddNewBill_Click(object sender, EventArgs e)
        {
            frmAddAndUpdatePurncasing frm = new frmAddAndUpdatePurncasing();
            frm.ShowDialog();
            _RefresPrudctionlList();

        }

        private void txSearchBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilter.Text)
            {
                case "رقم الفاتورة":
                    FilterColumn = "PurchaseID";
                    break;


                case "اسم المورد":
                    FilterColumn = "Name";
                    break;


            }

            if (txSearchBy.Text.Trim() == "")
            {
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] >= #{1}# AND [{0}] <= #{2}#",
                         "PurchaseDate",
                         dtFrom.Value.ToString("MM/dd/yyyy"),
                         dtTo.Value.ToString("MM/dd/yyyy"))
                    ; lblRecordsCountPruchases.Text = dgvPruchase.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "PurchaseID")

                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txSearchBy.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%' AND [{2}] >= #{3}# AND [{2}] <= #{4}#",
                                    FilterColumn, txSearchBy.Text.Trim(),
                                    "PurchaseDate",
                                dtFrom.Value.ToString("MM/dd/yyyy"),
                                dtTo.Value.ToString("MM/dd/yyyy"));

            lblRecordsCountPruchases.Text = dgvPruchase.Rows.Count.ToString();
        }

        private void cbPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SearchTypeName();

        }

        private void cbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SearchTypeCurrency();

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

        private void deleteBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انته متأكد أنك تريد حذف هذا الفاتورة [" + dgvPruchase.CurrentRow.Cells[0].Value + "]", "تأكيد الحذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {
                clsPurchase _Purchase = clsPurchase.Find((int)dgvPruchase.CurrentRow.Cells[0].Value);


                if (clsPurchase.DeletePurchase((int)dgvPruchase.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("تم حذف الفاتورة بنجاح", "تم بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefresPrudctionlList();
                }

                else
                    MessageBox.Show("لم يتم حذف الفاتورة لديها معلومات مرتبظه بجدول اخر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void txSearchBy_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (cbFilter.Text == "رقم الفاتورة")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
