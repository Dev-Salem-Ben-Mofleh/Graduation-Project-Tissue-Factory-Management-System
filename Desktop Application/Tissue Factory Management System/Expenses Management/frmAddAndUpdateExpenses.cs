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
using WindowsFormsApp1.Global;

namespace WindowsFormsApp1.Expenses_Management
{
    public partial class frmAddAndUpdateExpenses : Form
    {


        public delegate void DataBackEventHandler(object sender, int? SaleID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;
        private int? _ExpensesID = -1;
        private decimal _balance;
        private bool _IsReturn = true;
        clsExpense _Expense;
        int _counter = 0;


        private void _FillTypesOfExpenses()
        {
            DataTable RawName = clsTypesOfExpense.GetAllTypesOfExpenses();
            foreach (DataRow Row in RawName.Rows)
            {
                cbTypeOf.Items.Add(Row["Name"]);
            }
        }

        public frmAddAndUpdateExpenses()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;

        }
        public frmAddAndUpdateExpenses(int? ExpensesID)
        {
            InitializeComponent();
            _ExpensesID = ExpensesID;
            _Mode = enMode.Update;
        }
        private void _ResetDefualtValues()
        {
            _FillTypesOfExpenses();
            cbTypeOf.SelectedIndex = 0;

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "إضافة  فاتورة جديدة ";
                _Expense = new clsExpense();
            }
            else
            {
                lblTitle.Text = " تحديث  فاتورة  ";
            }

            dtDate.Value = DateTime.Now;

            ndTotal.Value = 0;

        }
        private void _LoadData()
        {

            _Expense = clsExpense.Find(_ExpensesID);

            if (_Expense == null)
            {
                MessageBox.Show("No Person with ID = " + _ExpensesID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblSaleBillId.Text = _ExpensesID.ToString();
            dtDate.Value = _Expense.ExpenseDate;
            cbTypeOf.SelectedIndex = cbTypeOf.FindString(_Expense.typesOfExpenseInfo.Name);
            ndTotal.Value = _Expense.Amount;
            _balance = _Expense.Amount;
            txtDes.Text = _Expense.Description == null ? "لا وصف" : _Expense.Description;
            _IsReturn = false;
        }

        private int? SaveBoxMovments()
        {
            clsBoxMovement boxMovement = new clsBoxMovement();

            if (_Mode == enMode.Update)
            {
                boxMovement = clsBoxMovement.Find(_Expense.BoxMovementID);
                boxMovement.Amount = ndTotal.Value;
                boxMovement.UserID = clsGlobal.CurrentUser.UserID;
                boxMovement.Save();
            }
            else
            {
                boxMovement.BoxMovementDate = dtDate.Value;
                boxMovement.Amount = ndTotal.Value;
                boxMovement.MovementType = 2;
                boxMovement.Description = null;
                boxMovement.BoxID = 2;
                boxMovement.UserID = clsGlobal.CurrentUser.UserID;
                boxMovement.Save();
            }


            return boxMovement.BoxMovementID;

        }

        private void _UpdateBox()
        {
            clsCurrencyTyp Saudi = clsCurrencyTyp.Find(2);
            clsBasicBoxe basicBoxe = clsBasicBoxe.Find(2);

            if (basicBoxe.balance == 0)
                return;

            _balance = _balance * Saudi.Amount;
            basicBoxe.balance += _balance;
            basicBoxe.Save();



        }
        private void _SaveBox()
        {
            clsCurrencyTyp Saudi = clsCurrencyTyp.Find(2);
            bool isDelete = false;

                if (_Mode == enMode.Update)
                {
                if (!isDelete)
                    _UpdateBox();

                isDelete = true;
                }


            clsBasicBoxe basicBoxe = clsBasicBoxe.Find(2);
            _balance = ndTotal.Value * Saudi.Amount;
            basicBoxe.balance -= _balance;
            basicBoxe.Save();
        }

        private void _Save()
        {


            btnSave.Enabled = false;
            btnCalnsel.Enabled = false;
            btnClose.Enabled = false;

            if (!this.ValidateChildren())
            {
                MessageBox.Show("بعض الحقول يوجد فيها أخطاء", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = true;
                btnCalnsel.Enabled = true;
                btnClose.Enabled = true;
                return;
            }

            if (_Mode == enMode.Update)
            {
                _Expense.Amount = ndTotal.Value;
                _Expense.UserID = clsGlobal.CurrentUser.UserID;
                _Expense.Description = txtDes.Text == "" ? null : txtDes.Text;
                _Expense.TypesOfExpenseID = cbTypeOf.SelectedIndex + 1;
                _Expense.BoxMovementID = SaveBoxMovments();
            }
            else
            { 
            _Expense.ExpenseDate = dtDate.Value;
                _Expense.Amount = ndTotal.Value;
                _Expense.UserID = clsGlobal.CurrentUser.UserID;
                _Expense.Description = txtDes.Text == "" ? null : txtDes.Text;
                _Expense.TypesOfExpenseID = cbTypeOf.SelectedIndex + 1;
                _Expense.BoxMovementID = SaveBoxMovments();
            }

            if (_Expense.Save())
            {
                lblSaleBillId.Text = _Expense.ExpenseID.ToString();
                _ExpensesID = _Expense.ExpenseID;
                btnSave.Enabled = false;


                _SaveBox();
                _Mode = enMode.Update;

                MessageBox.Show("تم حفظ البيانات بشكل صحيح", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(this, _Expense.ExpenseID);


            }
            else
                MessageBox.Show("خظأ:  لم يتم حفظ البيانات بشكل صحيح ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            btnCalnsel.Enabled = true;
            btnClose.Enabled = true;

        }

        private void frmAddAndUpdateExpenses_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();

        }

        private void btnCalnsel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ndTotal_Validating(object sender, CancelEventArgs e)
        {
            clsBasicBoxe basicBoxe = clsBasicBoxe.Find(2);

            if (ndTotal.Value <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(ndTotal, " 0 = لا يجب ترك الحقل ");
            }
            else
            if ((ndTotal.Value * clsCurrencyTyp.Find(2).Amount) > basicBoxe.balance)
            {
                MessageBox.Show($"{basicBoxe.balance} = لم يعد لديك المال الكافي للشراءالمتبقي هو ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;

            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(ndTotal, null);
            }
        }
    }
}
