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

namespace WindowsFormsApp1.Sales_Department.Control
{
    public partial class clsSaleInformaiton : UserControl
    {
        public clsSaleInformaiton()
        {
            InitializeComponent();
        }

        private clsSale _Sale;

        private int? _SaleID = -1;

        public int? SaleID
        {
            get { return _SaleID; }
        }

        public clsSale SelectedSaleInfo
        {
            get { return _Sale; }
        }

        public void LoadSaleInfo(int? SaleID)
        {


            _Sale = clsSale.Find(SaleID);
            if (_Sale == null)
            {
                ResetSaleInfo();
                MessageBox.Show(" لا يوجد شخص بهذا الرقم = " + SaleID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillSaleInfo();
        }

        private void _FillSaleInfo()
        {
            _SaleID = _Sale.SaleID;
            lbID.Text = _Sale.SaleID.ToString();
            lblDate.Text = _Sale.SaleDate.ToShortDateString();
            lblName.Text = _Sale.personInfo.Name;
            lblPayment.Text = _Sale.paymentStatuInfo.TypeName;
            lblCurrency.Text = _Sale.currencyTypInfo.Name;
            lblTotal.Text = _Sale.NetAmount.ToString();
            InitializeSaleItemGrid();
            _LoadSaleItems();

        }

        public void ResetSaleInfo()
        {
            _SaleID = -1;
            lbID.Text = "[????]";
            lblDate.Text = "[????]";
            lblName.Text = "[????]";
            lblPayment.Text = "[????]";
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
            colProductName.HeaderText = "أسم المنتج";
            colProductName.Width = 100;
            dgvٍSaleItem.Columns.Add(colProductName);

            DataGridViewTextBoxColumn colQuantity = new DataGridViewTextBoxColumn();
            colQuantity.HeaderText = "الكمية";
            colQuantity.Width = 120;
            dgvٍSaleItem.Columns.Add(colQuantity);

            DataGridViewTextBoxColumn colUnitPrice = new DataGridViewTextBoxColumn();
            colUnitPrice.HeaderText = "سعر الحبة";
            colUnitPrice.Width = 100;
            dgvٍSaleItem.Columns.Add(colUnitPrice);

            DataGridViewTextBoxColumn colTotalPrice = new DataGridViewTextBoxColumn();
            colTotalPrice.HeaderText = "السعر الأجمالي";
            colTotalPrice.Width = 120;
            dgvٍSaleItem.Columns.Add(colTotalPrice);
        }
        private void _LoadSaleItems()
        {

            DataTable _dtAllSales = clsSaleItem.GetAllSaleItems(_SaleID);

            foreach (DataRow Row in _dtAllSales.Rows)
            {
                dgvٍSaleItem.Rows.Add(Row["SaleItemID"], Row["ProductName"], Row["Amount"], Row["UnitPrice"], Row["Price"]);

            }
        }

     
        private void clsSaleInformaiton_Load(object sender, EventArgs e)
        {

        }


        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
