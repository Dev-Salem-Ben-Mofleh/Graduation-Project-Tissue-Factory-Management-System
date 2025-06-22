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
using WindowsFormsApp1.Sales_Department.Control;

namespace WindowsFormsApp1.Purncasing_Departmnet.control
{
    public partial class clsSearchPurncasing : UserControl
    {
        public clsSearchPurncasing()
        {
            InitializeComponent();
        }

        public event Action<int?> OnPurchaseSelected;
        protected virtual void PersonSelected(int? Purchase)
        {
            Action<int?> handler = OnPurchaseSelected;
            if (handler != null)
            {
                handler(Purchase);
            }
        }



        private bool _ShowAddPurchase = true;
        public bool ShowAddSale
        {
            get
            {
                return _ShowAddPurchase;
            }
            set
            {
                _ShowAddPurchase = value;
                btnAddNewBill.Visible = _ShowAddPurchase;
            }
        }


        private int? _SaleID = -1;

        public int? SaleID
        {
            get { return clsPurncasingInformation1.PurchaseID; }
        }

        public clsPurchase SelectedPurchaseInfo
        {
            get { return clsPurncasingInformation1.SelectedSaleInfo; }
        }

        public void LoadPersonInfo(int? PurchaseID)
        {

            txSearchBy.Text = PurchaseID.ToString();
            FindNow();
        }

        private void FindNow()
        {
            clsPurncasingInformation1.LoadPurchaseInfo(int.Parse(txSearchBy.Text));


            if (OnPurchaseSelected != null)
                OnPurchaseSelected(clsPurncasingInformation1.PurchaseID);
        }

        private void gbFilters_Enter(object sender, EventArgs e)
        {

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
            clsPurncasingInformation1.LoadPurchaseInfo(PurchaseID);
        }


        private void btnAddNewBill_Click(object sender, EventArgs e)
        {
            frmAddAndUpdatePurncasing frm1 = new frmAddAndUpdatePurncasing();
            frm1.DataBack += DataBackEvent; // Subscribe to the event
            frm1.ShowDialog();
        }

        private void clsSearchPurncasing_Load(object sender, EventArgs e)
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
