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
using WindowsFormsApp1.Purncasing_Departmnet;
using WindowsFormsApp1.Purncasing_Departmnet.control;

namespace WindowsFormsApp1.Expenses_Management.control
{
    public partial class clsExpensesSearch : UserControl
    {
        public clsExpensesSearch()
        {
            InitializeComponent();
        }

        public event Action<int?> OnExpensSelected;
        protected virtual void PersonSelected(int? ExpensID)
        {
            Action<int?> handler = OnExpensSelected;
            if (handler != null)
            {
                handler(ExpensID);
            }
        }



        private bool _ShowAddExpense = true;
        public bool ShowAddSale
        {
            get
            {
                return _ShowAddExpense;
            }
            set
            {
                _ShowAddExpense = value;
                btnAddNewBill.Visible = _ShowAddExpense;
            }
        }


        private int? _SaleID = -1;

        public int? SaleID
        {
            get { return clsExpensesInformation1.ExpenseID; }
        }

        public clsExpense SelectedPurchaseInfo
        {
            get { return clsExpensesInformation1.SelectedExpenseInfo; }
        }

        public void LoadPersonInfo(int? ExpenseID)
        {

            txSearchBy.Text = ExpenseID.ToString();
            FindNow();
        }

        private void FindNow()
        {
            clsExpensesInformation1.LoadExpbenseInfo(int.Parse(txSearchBy.Text));


            if (OnExpensSelected != null)
                OnExpensSelected(clsExpensesInformation1.ExpenseID);
        }


        private void btnAddNewMember_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("بعض الحقول لديها أخطاء ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            FindNow();
        }
        private void DataBackEvent(object sender, int? PurchaseID)
        {

            txSearchBy.Text = PurchaseID.ToString();
            clsExpensesInformation1.LoadExpbenseInfo(PurchaseID);
        }

        private void btnAddNewBill_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateExpenses frm1 = new frmAddAndUpdateExpenses();
            frm1.DataBack += DataBackEvent; // Subscribe to the event
            frm1.ShowDialog();
        }

        private void clsExpensesSearch_Load(object sender, EventArgs e)
        {
            txSearchBy.Focus();

        }

        private void txSearchBy_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txSearchBy.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txSearchBy, "يجب تعبئة هذا الحقل");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txSearchBy, null);
            }
        }

        private void txSearchBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
