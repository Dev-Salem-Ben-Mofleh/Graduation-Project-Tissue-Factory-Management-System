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

namespace WindowsFormsApp1.Electricity_Department
{
    public partial class frmAddAndUpdateElectricity : Form
    {

        public enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;
        private int? _ElcID = -1;
        private decimal _balance;
        private bool _IsReturn = true;
        clsElectricite _Elct;
    
        public frmAddAndUpdateElectricity()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;

        }
        public frmAddAndUpdateElectricity(int? ElcID)
        {
            InitializeComponent();
            _ElcID = ElcID;
            _Mode = enMode.Update;
        }
        private void _ResetDefualtValues()
        {
            cbType.SelectedIndex = 0;

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "إضافة  سجل جديدة ";
                _Elct = new clsElectricite();
            }
            else
            {
                lblTitle.Text = " تحديث  سجل  ";
            }

            dtDate.Value = DateTime.Now;
            dtDate.Enabled = false;
            ndQuantity.Value = 0;

        }
        private void _LoadData()
        {

            _Elct = clsElectricite.Find(_ElcID);

            if (_Elct == null)
            {
                MessageBox.Show("No Person with ID = " + _ElcID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblSaleBillId.Text = _ElcID.ToString();
            dtDate.Value = _Elct.date;
            cbType.Text = _Elct.TypeOf;
            lblTotal.Text = _Elct.Total.ToString();
            _balance = _Elct.Total;
            ndUintPrice.Value=(decimal)_Elct.UintPrice;
            ndQuantity.Value = Convert.ToInt32(_Elct.Quantity);
            _IsReturn = false;
        }

        private int? SaveBoxMovments()
        {
            clsBoxMovement boxMovement = new clsBoxMovement();

            if (_Mode == enMode.Update)
            {
                boxMovement = clsBoxMovement.Find(_Elct.BoxMovementID);
                boxMovement.Amount =Convert.ToDecimal( lblTotal.Text);
                boxMovement.UserID = clsGlobal.CurrentUser.UserID;
                boxMovement.Save();
            }
            else
            {
                boxMovement.BoxMovementDate = dtDate.Value;
                boxMovement.Amount = Convert.ToDecimal(lblTotal.Text);
                boxMovement.MovementType = clsGlobal.CurrentUser.UserID;
                boxMovement.Description = null;
                boxMovement.BoxID = 2;
                boxMovement.UserID = 1;
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
            _balance = Convert.ToDecimal(lblTotal.Text) * Saudi.Amount;
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
                _Elct.Total = Convert.ToDecimal(lblTotal.Text);
                _Elct.UserID = clsGlobal.CurrentUser.UserID;
                _Elct.TypeOf = cbType.Text;
                _Elct.UintPrice = Convert.ToInt32(ndUintPrice.Value);
                _Elct.BoxMovementID = SaveBoxMovments();
            }
            else
            {
                _Elct.date = dtDate.Value;
                _Elct.Total = Convert.ToDecimal(lblTotal.Text);
                _Elct.UserID = clsGlobal.CurrentUser.UserID;
                _Elct.TypeOf = cbType.Text;
                _Elct.UintPrice = Convert.ToInt32(ndUintPrice.Value);
                _Elct.Quantity = Convert.ToInt32(ndQuantity.Value);
                _Elct.BoxMovementID = SaveBoxMovments();
            }

            if (_Elct.Save())
            {
                lblSaleBillId.Text = _Elct.ElectrictyID.ToString();
                _ElcID = _Elct.ElectrictyID;
                btnSave.Enabled = false;


                _SaveBox();
                _Mode = enMode.Update;

                MessageBox.Show("تم حفظ البيانات بشكل صحيح", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
                MessageBox.Show("خظأ:  لم يتم حفظ البيانات بشكل صحيح ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            btnCalnsel.Enabled = true;
            btnClose.Enabled = true;

        }
        private void btnCalnsel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void ndUintPrice_Validating(object sender, CancelEventArgs e)
        {
            
            if (ndUintPrice.Value <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(ndUintPrice, " 0 = لا يجب ترك الحقل ");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(ndUintPrice, null);
            }
        }

        private void lblTotal_Validating(object sender, CancelEventArgs e)
        {
            clsBasicBoxe basicBoxe = clsBasicBoxe.Find(2);

            if (Convert.ToDecimal( lblTotal.Text) <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(lblTotal, " 0 = لا يجب ترك الحقل ");
            }
            else
            if ((Convert.ToDecimal(lblTotal.Text) * clsCurrencyTyp.Find(2).Amount) > basicBoxe.balance)
            {
                MessageBox.Show($"{basicBoxe.balance} = لم يعد لديك المال الكافي للشراءالمتبقي هو ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;

            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(lblTotal, null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ndUintPrice_ValueChanged(object sender, EventArgs e)
        {
            lblTotal.Text=(ndUintPrice.Value*ndQuantity.Value).ToString();
        }

        private void frmAddAndUpdateElectricity_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void ndQuantity_ValueChanged(object sender, EventArgs e)
        {
            lblTotal.Text = (ndUintPrice.Value * ndQuantity.Value).ToString();

        }

        private void ndQuantity_MouseLeave(object sender, EventArgs e)
        {
            lblTotal.Text = (ndUintPrice.Value * ndQuantity.Value).ToString();

        }

        private void ndUintPrice_MouseLeave(object sender, EventArgs e)
        {
            lblTotal.Text = (ndUintPrice.Value * ndQuantity.Value).ToString();

        }

        private void dtDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ndQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (ndQuantity.Value <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(ndQuantity, " 0 = لا يجب ترك الحقل ");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(ndQuantity, null);
            }
        }
    }
}
