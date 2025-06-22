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

namespace WindowsFormsApp1.Purncasing_Departmnet.control
{
    public partial class clsPurncasingInformation : UserControl
    {
        public clsPurncasingInformation()
        {
            InitializeComponent();
        }


        private clsPurchase _Purchase;

        private int? _PurchaseID = -1;

        public int? PurchaseID
        {
            get { return _PurchaseID; }
        }

        public clsPurchase SelectedSaleInfo
        {
            get { return _Purchase; }
        }

        public void LoadPurchaseInfo(int? PurchaseID)
        {


            _Purchase = clsPurchase.Find(PurchaseID);
            if (_Purchase == null)
            {
                ResetSaleInfo();
                MessageBox.Show(" لا توجد فاتورة بهذا الرقم = " + PurchaseID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPurchaseInfo();
        }

        private void _FillPurchaseInfo()
        {
            _PurchaseID = _Purchase.PurchaseID;
            lblID.Text = _Purchase.PurchaseID.ToString();
            lblDate.Text = _Purchase.PurchaseDate.ToShortDateString();
            lblName.Text = _Purchase.personInfo.Name;
            lblPAyment.Text = _Purchase.paymentStatuInfo.TypeName;
            lblCurrency.Text = _Purchase.currencyTypInfo.Name;
            lblTotal.Text = _Purchase.NetAmount.ToString();
            InitializeSaleItemGrid();
            _LoadPurchaseItems();

        }

        public void ResetSaleInfo()
        {
            _PurchaseID = -1;
            lblID.Text = "[????]";
            lblDate.Text = "[????]";
            lblName.Text = "[????]";
            lblPAyment.Text = "[????]";
            lblCurrency.Text = "[????]";
            lblTotal.Text = "[????]";

        }

        private void InitializeSaleItemGrid()
        {
            dgvٍSaleItem.Columns.Clear();

            DataGridViewTextBoxColumn colItemNumber = new DataGridViewTextBoxColumn();
            colItemNumber.HeaderText = "رقم السلعة";
            colItemNumber.Width = 110;
            dgvٍSaleItem.Columns.Add(colItemNumber);

            DataGridViewTextBoxColumn colProductName = new DataGridViewTextBoxColumn();
            colProductName.HeaderText = "أسم المادة الخام";
            colProductName.Width = 140;
            dgvٍSaleItem.Columns.Add(colProductName);

            DataGridViewTextBoxColumn colQuantity = new DataGridViewTextBoxColumn();
            colQuantity.HeaderText = "الكمية";
            colQuantity.Width = 120;
            dgvٍSaleItem.Columns.Add(colQuantity);

            DataGridViewTextBoxColumn colUnitPrice = new DataGridViewTextBoxColumn();
            colUnitPrice.HeaderText = "سعر الوحدة";
            colUnitPrice.Width = 100;
            dgvٍSaleItem.Columns.Add(colUnitPrice);

            DataGridViewTextBoxColumn colTotalPrice = new DataGridViewTextBoxColumn();
            colTotalPrice.HeaderText = "السعر الأجمالي";
            colTotalPrice.Width = 120;
            dgvٍSaleItem.Columns.Add(colTotalPrice);
        }
        private void _LoadPurchaseItems()
        {

            DataTable _dtAllSales = clsPurchaseItem.GetAllPurchaseItems(_PurchaseID);

            foreach (DataRow Row in _dtAllSales.Rows)
            {
                dgvٍSaleItem.Rows.Add(Row["PurchaseItemID"], Row["Material_Name"], Row["Qauntity"], Row["Unit_cost"], Row["Price"]);

            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
