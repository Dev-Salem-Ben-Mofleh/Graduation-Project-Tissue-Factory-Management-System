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

namespace WindowsFormsApp1.Expenses_Management.control
{
    public partial class clsExpensesInformation : UserControl
    {
        public clsExpensesInformation()
        {
            InitializeComponent();
        }

        private clsExpense s_Expenses;

        private int? _ExpensID = -1;

        public int? ExpenseID
        {
            get { return _ExpensID; }
        }

        public clsExpense SelectedExpenseInfo
        {
            get { return s_Expenses; }
        }

        public void LoadExpbenseInfo(int? ExpenseID)
        {


            s_Expenses = clsExpense.Find(ExpenseID);
            if (s_Expenses == null)
            {
                ResetSaleInfo();
                MessageBox.Show(" لا توجد فاتورة بهذا الرقم = " + ExpenseID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillExpneseInfo();
        }

        private void _FillExpneseInfo()
        {
            _ExpensID = s_Expenses.ExpenseID;
            lblID.Text = s_Expenses.ExpenseID.ToString();
            lblDate.Text = s_Expenses.ExpenseDate.ToShortDateString();
            lblTypeOfExpense.Text = s_Expenses.typesOfExpenseInfo.Name;
            lblTotal.Text = s_Expenses.Amount.ToString();
            lblDes.Text = s_Expenses.Description == null ? "لا يوجد وصف" : s_Expenses.Description;
        }

        public void ResetSaleInfo()
        {
            _ExpensID = -1;
            lblID.Text = "[????]";
            lblDate.Text = "[????]";
            lblTotal.Text = "[????]";
            lblTypeOfExpense.Text = "[????]";
            lblDes.Text = "[????]";

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
