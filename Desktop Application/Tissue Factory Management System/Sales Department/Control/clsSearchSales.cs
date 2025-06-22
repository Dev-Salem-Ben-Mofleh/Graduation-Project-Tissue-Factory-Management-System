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

namespace WindowsFormsApp1.Sales_Department.Control
{
    public partial class clsSearchSales : UserControl
    {
        public clsSearchSales()
        {
            InitializeComponent();
        }
        public event Action<int?> OnSaleSelected;
        protected virtual void PersonSelected(int? SaleID)
        {
            Action<int?> handler = OnSaleSelected;
            if (handler != null)
            {
                handler(SaleID);
            }
        }



        private bool _ShowAddSale = true;
        public bool ShowAddSale
        {
            get
            {
                return _ShowAddSale;
            }
            set
            {
                _ShowAddSale = value;
                btnAddNewBill.Visible = _ShowAddSale;
            }
        }


        private int? _SaleID = -1;

        public int? SaleID
        {
            get { return clsSaleInformaiton1.SaleID; }
        }

        public clsSale SelectedSaleInfo
        {
            get { return clsSaleInformaiton1.SelectedSaleInfo; }
        }

        public void LoadPersonInfo(int? SaleID)
        {

            txSearchBy.Text = SaleID.ToString();
            FindNow();
        }

        private void FindNow()
        {
            clsSaleInformaiton1.LoadSaleInfo(int.Parse(txSearchBy.Text));


            if (OnSaleSelected != null)
                OnSaleSelected(clsSaleInformaiton1.SaleID);
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("بعض الحقول لديها أخطاء ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            FindNow();
        }

        

        
        private void DataBackEvent(object sender, int? SaleID)
        {

            txSearchBy.Text = SaleID.ToString();
            clsSaleInformaiton1.LoadSaleInfo(SaleID);
        }

        private void clsSearchSales_Load(object sender, EventArgs e)
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

        private void btnAddNewBill_Click_1(object sender, EventArgs e)
        {
            frmAddAndUpdateSalesBill frm1 = new frmAddAndUpdateSalesBill();
            frm1.DataBack += DataBackEvent; // Subscribe to the event
            frm1.ShowDialog();
        }
    }
}
