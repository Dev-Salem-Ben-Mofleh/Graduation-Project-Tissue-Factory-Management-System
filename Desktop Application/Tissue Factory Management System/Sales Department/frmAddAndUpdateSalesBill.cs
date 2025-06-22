using InstituteBussiness;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.IO;
using PdfSharp.Pdf;
using System.Diagnostics;
using PdfSharp.Drawing;
using WindowsFormsApp1.Management_Persons;
using WindowsFormsApp1.Sales_Department.Control;
using WindowsFormsApp1.Global;

namespace WindowsFormsApp1.Sales_Department
{
    public partial class frmAddAndUpdateSalesBill : Form
    {

        public delegate void DataBackEventHandler(object sender, int? SaleID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;
        private int? _SaleID = -1;
        private int? _PersonID = -1;
        private decimal _balance = 0M;
        private decimal _YamaniTotal;
        private bool _IsReturn = true;
        List<string> ProductsNames = new List<string>();
        List<string> allNames = new List<string>();
        clsSale _Sale;
        int _counter = 0;

        private void _FillNameProducts()
        {
            DataTable ProudctName = clsProduct.GetAllProducts();
            foreach (DataRow Row in ProudctName.Rows)
            {
                cbNameProduct.Items.Add(Row["ProductName"]);
            }
        }
        private void _FillPayments()
        {
            DataTable RawName = clsPaymentStatu.GetAllPaymentStatus();
            foreach (DataRow Row in RawName.Rows)
            {
                cbStateSales.Items.Add(Row["TypeName"]);
            }
        }
        private void _FillPersonsNAme()
        {
            DataTable RawName = clsPerson.GetAllClients();
            foreach (DataRow Row in RawName.Rows)
            {
                //cbClintName.Items.Add(Row["Name"]);
                allNames.Add(Row["Name"].ToString());
            }

            cbClintName.DropDownStyle = ComboBoxStyle.DropDown;
            cbClintName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbClintName.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbClintName.Items.AddRange(allNames.ToArray());
        }
        public frmAddAndUpdateSalesBill()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;

        }
        public frmAddAndUpdateSalesBill(int? SaleID)
        {
            InitializeComponent();
            _SaleID = SaleID;
            _Mode = enMode.Update;
        }
        private void _ResetDefualtValues()
        {
            _FillNameProducts();
            _FillPayments();
            _FillPersonsNAme();
            cbNameProduct.SelectedIndex = 0;
            cbStateSales.SelectedIndex = 0;
            cbCurrencyType.SelectedIndex = 0;

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "إضافة  فاتورة جديدة ";
                _Sale = new clsSale();
            }
            else
            {
                lblTitle.Text = " تحديث  فاتورة  ";
            }

            dtDate.Value = DateTime.Now;

            ndQuqntity.Value = 1;
            lblNetAmount.Text = "0";
            lblTotal.Text = "0";
            lblSaleBillId.Text = "???";


        }

        private void _ResetTextMoney(string CurrencyType)
        {


            switch (CurrencyType)
            {

                case "الريال اليمني":
                    lblCurreny.Text = "الريال اليمني";
                    lblCurreny2.Text = "الريال اليمني";
                    lblCurreny3.Text = "الريال اليمني";
                    break;

                case "الريال السعودي":
                    lblCurreny.Text = "الريال السعودي";
                    lblCurreny2.Text = "الريال السعودي";
                    lblCurreny3.Text = "الريال السعودي";
                    break;

                case "الدولار الأمريكي":
                    lblCurreny.Text = "الدولار الأمريكي";
                    lblCurreny2.Text = "الدولار الأمريكي";
                    lblCurreny3.Text = "الدولار الأمريكي";
                    break;

            }


        }

        private void _ReturnTotal()
        {
            _YamaniTotal = 0;
            if (!_IsReturn)
            {
                if (_Mode == enMode.Update)
                {
                    DataTable RawName = clsSaleItem.GetAllSaleItems(_SaleID);
                    foreach (DataRow Row in RawName.Rows)
                    {
                        _YamaniTotal += (decimal)Row["Price"];

                    }
                }
                _IsReturn = true;
            }
            else
            {
                foreach (DataGridViewRow row in dgvٍSaleItem.Rows)
                {
                    if (row.IsNewRow)
                        continue;
                    _YamaniTotal += (decimal)row.Cells[4].Value;

                }
            }
        }

        private decimal _ConvertToYamani(ref decimal nntAmount, ref decimal Discount)
        {
            decimal yamani = 0M;
            foreach (DataGridViewRow row in dgvٍSaleItem.Rows)
            {
                if (row.IsNewRow)
                    continue;
                yamani += (decimal)row.Cells[4].Value;

            }
            if (yamani > 1000000)
                Discount = (decimal)((double)yamani * 0.1);
            else
                Discount = 0;

            nntAmount = yamani - Discount;

            return yamani;
        }

        private void _ResetMoney()
        {

            if (lblNetAmount.Text == "[???]")
                return;

            clsCurrencyTyp Saudi = clsCurrencyTyp.Find(2);
            clsCurrencyTyp Dollar = clsCurrencyTyp.Find(3);


            decimal nntAmount = Convert.ToDecimal(lblNetAmount.Text);
            decimal total = Convert.ToDecimal(lblTotal.Text);
            decimal Discount = lblDiscount.Text == "[???]" ? 0M : Convert.ToDecimal(lblDiscount.Text);

            if (total == 0 || nntAmount == 0)
                return;


            if (cbCurrencyType.Text == "الريال اليمني")
            {
                decimal total2, discount, net;

                total2 = CalculateTotal();
                if (total2 > 1000000)
                    discount = (decimal)((double)total2 * 0.1);
                else
                    discount = 0;

                net = total2 - discount;

                lblTotal.Text = total2.ToString();
                lblDiscount.Text = discount.ToString();
                lblNetAmount.Text = net.ToString();
                _ResetTextMoney(cbCurrencyType.Text);
                return;
            }

            switch (cbCurrencyType.Text)
            {


                case "الريال السعودي":
                    total = _ConvertToYamani(ref nntAmount, ref Discount);
                    lblNetAmount.Text = (Saudi.Amount * nntAmount).ToString();
                    lblTotal.Text = (Saudi.Amount * total).ToString();
                    lblDiscount.Text = (Saudi.Amount * Discount).ToString();
                    break;

                case "الدولار الأمريكي":
                    total = _ConvertToYamani(ref nntAmount, ref Discount);
                    lblNetAmount.Text = (Dollar.Amount * nntAmount).ToString();
                    lblTotal.Text = (Dollar.Amount * total).ToString();
                    lblDiscount.Text = (Dollar.Amount * Discount).ToString();
                    break;

            }
            _ResetTextMoney(cbCurrencyType.Text);

        }

        private void _LoadData()
        {

            _Sale = clsSale.Find(_SaleID);

            if (_Sale == null)
            {
                MessageBox.Show("No Person with ID = " + _SaleID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblSaleBillId.Text = _SaleID.ToString();
            cbClintName.Text = _Sale.personInfo.Name;
            cbClintName.Enabled = false;
            dtDate.Value = _Sale.SaleDate;
            cbStateSales.SelectedIndex = cbStateSales.FindString(_Sale.paymentStatuInfo.TypeName);
            cbStateSales.Enabled = false;
            lblNetAmount.Text = _Sale.NetAmount.ToString();
            dtDate.Value = _Sale.SaleDate;
            lblDiscount.Text = _Sale.Discount.ToString();
            lblTotal.Text = _Sale.TotalAmount.ToString();
            _balance = _Sale.NetAmount;
            _PersonID = _Sale.PersonID;
            _LoadSaleItems();
            cbCurrencyType.SelectedIndex = cbCurrencyType.FindString(_Sale.currencyTypInfo.Name);
            _IsReturn = false;
            _ReturnTotal();
            SaveAllProducts();
        }
        private void _LoadSaleItems()
        {

            DataTable _dtAllSales = clsSaleItem.GetAllSaleItems(_SaleID);

            foreach (DataRow Row in _dtAllSales.Rows)
            {
                dgvٍSaleItem.Rows.Add(Row["SaleItemID"], Row["ProductName"], Row["Amount"], Row["UnitPrice"], Row["Price"]);

            }
        }
        private void SaveAllProducts()
        {

            foreach (DataGridViewRow row in dgvٍSaleItem.Rows)
            {
                if (row.IsNewRow)
                    continue;
                ProductsNames.Add(row.Cells[1].Value.ToString());
            }
        }

        private void SaveAllSaleItmes(DataGridView dgv)
        {

            if (_Mode == enMode.Update)
            {
                clsSaleItem.DeleteAllSaleItem(_SaleID);
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow)
                    continue;
                clsSaleItem saleItem = new clsSaleItem();
                saleItem.ProductID = clsProduct.Find(row.Cells[1].Value.ToString()).ProductID;
                saleItem.Amount = Convert.ToDecimal( row.Cells[2].Value);
                saleItem.Price = Convert.ToDecimal(row.Cells[4].Value);
                saleItem.SaleID = _SaleID;
                saleItem.Save();
            }
        }
        private int? SaveBoxMovments()
        {
            clsBoxMovement boxMovement = new clsBoxMovement();

            if (_Mode == enMode.Update)
            {
                boxMovement = clsBoxMovement.Find(_Sale.BoxMovementID);
                boxMovement.Amount = Convert.ToDecimal(lblNetAmount.Text);
                boxMovement.UserID = clsGlobal.CurrentUser.UserID;
                boxMovement.Save();
            }
            else
            {
                boxMovement.BoxMovementDate = dtDate.Value;
                boxMovement.Amount = Convert.ToDecimal(lblNetAmount.Text);
                boxMovement.MovementType = 2;
                boxMovement.Description = null;
                boxMovement.BoxID = 2;
                boxMovement.UserID = clsGlobal.CurrentUser.UserID;
                boxMovement.Save();
            }


            return boxMovement.BoxMovementID;

        }
        private void _UpdateStocks()
        {
            clsCurrencyTyp Saudi = clsCurrencyTyp.Find(2);
            clsProduct product = new clsProduct();
            clsStockMovement stockMovementProduct = new clsStockMovement();
            clsBasicBoxe basicBoxe = clsBasicBoxe.Find(2);

            foreach (var item in ProductsNames)
            {
                product = clsProduct.Find(item);
                stockMovementProduct = clsStockMovement.FindBySaleID(_SaleID, product.ProductID);
                product.Quantity += stockMovementProduct.Quantity;
                clsStockMovement.DeleteStockMovement(stockMovementProduct.StockMovementID);
                product.Save();

            }

            if (basicBoxe.balance == 0)
                return;

            _YamaniTotal = _YamaniTotal * Saudi.Amount;
            basicBoxe.balance -= _YamaniTotal;
            basicBoxe.Save();



        }
        private void _SaveStocks()
        {
            clsCurrencyTyp Saudi = clsCurrencyTyp.Find(2);
            clsProduct product = new clsProduct();
            int Quantity = 0;
            bool isDelete = false;

            foreach (DataGridViewRow row in dgvٍSaleItem.Rows)
            {
                if (row.IsNewRow)
                    continue;

                product = clsProduct.Find(row.Cells[1].Value.ToString());
                Quantity = Convert.ToInt32(row.Cells[2].Value);

                if (_Mode == enMode.Update)
                {
                    if (!isDelete)
                        _UpdateStocks();

                    isDelete = true;
                    clsStockMovement stockMovementProduct = new clsStockMovement();
                    product = clsProduct.Find(row.Cells[1].Value.ToString());

                    stockMovementProduct.Quantity = Quantity;
                    stockMovementProduct.StockMovementDate = _Sale.SaleDate;
                    stockMovementProduct.StockMovementType = 2;
                    stockMovementProduct.MaterialID = null;
                    stockMovementProduct.ProductID = product.ProductID;
                    stockMovementProduct.UserID = clsGlobal.CurrentUser.UserID;
                    stockMovementProduct.TypeOfOperation = 1;
                    stockMovementProduct.SaleID = _SaleID;
                    stockMovementProduct.Save();

                    product.Quantity -= Quantity;
                    product.Save();

                }

                else
                {

                    clsStockMovement stockMovementProduct = new clsStockMovement();

                    stockMovementProduct.Quantity = Quantity;
                    stockMovementProduct.StockMovementDate = dtDate.Value;
                    stockMovementProduct.StockMovementType = 2;
                    stockMovementProduct.MaterialID = null;
                    stockMovementProduct.ProductID = product.ProductID;
                    stockMovementProduct.UserID = clsGlobal.CurrentUser.UserID;
                    stockMovementProduct.TypeOfOperation = 1;
                    stockMovementProduct.SaleID = _SaleID;
                    stockMovementProduct.Save();

                    product.Quantity -= Quantity;
                    product.Save();

                }
            }
            clsBasicBoxe basicBoxe = clsBasicBoxe.Find(2);
            _ReturnTotal();
            _YamaniTotal = _YamaniTotal * Saudi.Amount;
            basicBoxe.balance += Convert.ToDecimal(_YamaniTotal);
            basicBoxe.Save();

        }
        private void _Save()
        {
            btnSave.Enabled = false;
            btnCalnsel.Enabled = false;
            btnClose.Enabled = false;

            if (!this.ValidateChildren() || dgvٍSaleItem.RowCount == 0) 
            {
                MessageBox.Show(" بعض الحقول يوجد فيها أخطاء او قائمة منتجات البيع فارغة  ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = true;
                btnCalnsel.Enabled = true;
                btnClose.Enabled = true;
                return;
            }

            if (_Mode == enMode.Update)
            {
                _Sale.TotalAmount = Convert.ToDecimal(lblTotal.Text);
                _Sale.Discount = Convert.ToDecimal(lblDiscount.Text); ;
                _Sale.NetAmount = Convert.ToDecimal(lblNetAmount.Text); ;
                _Sale.UserID = clsGlobal.CurrentUser.UserID;
                _Sale.PersonID = _PersonID;
                _Sale.PaymentStatuID = cbStateSales.SelectedIndex + 1;
                _Sale.CurrencyID = cbCurrencyType.SelectedIndex + 1;
                _Sale.BoxMovementID = SaveBoxMovments();
            }
            else
            {
                _Sale.SaleDate = dtDate.Value;
                _Sale.TotalAmount = Convert.ToDecimal(lblTotal.Text);
                _Sale.Discount = Convert.ToDecimal(lblDiscount.Text); ;
                _Sale.NetAmount = Convert.ToDecimal(lblNetAmount.Text); ;
                _Sale.UserID = clsGlobal.CurrentUser.UserID;
                _Sale.PersonID = _PersonID;
                _Sale.PaymentStatuID = cbStateSales.SelectedIndex + 1;
                _Sale.CurrencyID = cbCurrencyType.SelectedIndex + 1;
                _Sale.BoxMovementID = SaveBoxMovments();
            }


            if (_Sale.Save())
            {
                lblSaleBillId.Text = _Sale.SaleID.ToString();
                _SaleID = _Sale.SaleID;
                btnSave.Enabled = false;

                SaveAllSaleItmes(dgvٍSaleItem);

                _SaveStocks();
                _Mode = enMode.Update;

                MessageBox.Show("تم حفظ البيانات بشكل صحيح", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(this, _Sale.SaleID);


            }
            else
                MessageBox.Show("خظأ:  لم يتم حفظ البيانات بشكل صحيح ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            btnCalnsel.Enabled = true;
            btnClose.Enabled = true;

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeSaleItemGrid()
        {
            dgvٍSaleItem.Columns.Clear();

            DataGridViewTextBoxColumn colItemNumber = new DataGridViewTextBoxColumn();
            colItemNumber.Name = "رقم السلعة";
            colItemNumber.HeaderText = "رقم السلعة";
            colItemNumber.Width = 110;
            colItemNumber.ReadOnly = true;
            dgvٍSaleItem.Columns.Add(colItemNumber);

            DataGridViewTextBoxColumn colProductName = new DataGridViewTextBoxColumn();
            colProductName.Name = "أسم المنتج";
            colProductName.HeaderText = "أسم المنتج";
            colProductName.Width = 100;
            colProductName.ReadOnly = true;
            dgvٍSaleItem.Columns.Add(colProductName);

            DataGridViewTextBoxColumn colQuantity = new DataGridViewTextBoxColumn();
            colQuantity.Name = "الكمية";
            colQuantity.HeaderText = "الكمية";
            colQuantity.Width = 120;
            colQuantity.ReadOnly = false;
            dgvٍSaleItem.Columns.Add(colQuantity);

            DataGridViewTextBoxColumn colUnitPrice = new DataGridViewTextBoxColumn();
            colUnitPrice.Name = "سعر الحبة";
            colUnitPrice.HeaderText = "سعر الحبة";
            colUnitPrice.Width = 100;
            colUnitPrice.ReadOnly = true;
            dgvٍSaleItem.Columns.Add(colUnitPrice);

            DataGridViewTextBoxColumn colTotalPrice = new DataGridViewTextBoxColumn();
            colTotalPrice.Name = "السعر الأجمالي";
            colTotalPrice.HeaderText = "السعر الأجمالي";
            colTotalPrice.Width = 120;
            colTotalPrice.ReadOnly = true;
            dgvٍSaleItem.Columns.Add(colTotalPrice);
        }

        private void frmAddAndUpdateSalesBill_Load(object sender, EventArgs e)
        {

            _ResetDefualtValues();
           InitializeSaleItemGrid();
            dgvٍSaleItem.CellEndEdit += dgvٍSaleItem_CellEndEdit;
            if (_Mode == enMode.Update)
                _LoadData();

        }

        private void btnCalnsel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private bool CheckIsProductReapet()
        {

                foreach (DataGridViewRow row in dgvٍSaleItem.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                if (cbNameProduct.Text == row.Cells[1].Value.ToString())
                    return false;
                }

            return true;
        }

        private void AddRowWithFields()
        {

            if(!CheckIsProductReapet())
            {
                MessageBox.Show("لا يمكنك أضافة نفس المنتج مرتين", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!this.ValidateChildren())
            {
                MessageBox.Show("بعض الحقول يوجد فيها أخطاء", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Mode == enMode.Update)
                _counter = dgvٍSaleItem.Rows.Count;

            int itemNumber = ++_counter;
            string productName = cbNameProduct.Text;

            decimal quantity = (int)ndQuqntity.Value;
            decimal unitPriceStr = clsProduct.Find(cbNameProduct.Text).UnitPrice;
            decimal totalPrice = (decimal)quantity * unitPriceStr;



            dgvٍSaleItem.Rows.Add(itemNumber, productName, quantity, unitPriceStr, totalPrice);

            CalculateAmounts();

            cbStateSales.Enabled = false;

        }
        public decimal CalculateTotal()
        {
            decimal totoal = 0;
            foreach (DataGridViewRow row in dgvٍSaleItem.Rows)
            {
                if (row.IsNewRow)
                    continue;

                totoal += (decimal)row.Cells[4].Value;
            }
            return totoal;
        }
        private void CalculateAmounts()
        {
            decimal total, discount, net;

            total = CalculateTotal();
            if (total > 1000000)
                discount = (decimal)((double)total * 0.1);
            else
                discount = 0;

            net = total - discount;

            lblTotal.Text = total.ToString();
            lblDiscount.Text = discount.ToString();
            lblNetAmount.Text = net.ToString();
            _ResetMoney();

        }

        private void btnAddToBill_Click(object sender, EventArgs e)
        {
            AddRowWithFields();
        }

        private void DataBackEvent(object sender, int? PersonID)
        {
            if (PersonID == -1)
                return;
            // Handle the data received 
            if (clsPerson.Find(PersonID).TypeName==2)
            {
                MessageBox.Show("هذا الشخص موردوليس عميل", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cbClintName.Items.Add(clsPerson.Find(PersonID).Name);
            cbClintName.SelectedIndex = cbClintName.Items.Count-1;
            cbClintName.Enabled = false;
            _PersonID = PersonID;
        }

        private void ndQuqntity_Validating(object sender, CancelEventArgs e)
        {

            int? Quanatity = clsProduct.Find(cbNameProduct.Text).Quantity;

            if (ndQuqntity.Value <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(ndQuqntity, " 0 = لا يجب ترك الحقل ");
            }
            else
            if (ndQuqntity.Value > Quanatity)
            {
                e.Cancel = true;
                errorProvider1.SetError(ndQuqntity, $"{Quanatity}  = لم يعد هناك ما يكفي من الكمية في مخزون المنتجات الكمية المتبقية هي ");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(ndQuqntity, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void حذقسلعةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvٍSaleItem.Rows.Remove(dgvٍSaleItem.CurrentRow);
            CalculateAmounts();
        }

        private void cbCurrencyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ResetMoney();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (_SaleID <= 0)
            {
                MessageBox.Show("يجب عليك اولا حفظ الفاتورة في النظام", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            invoicBill frm = new invoicBill(_SaleID, lblTotal.Text, lblDiscount.Text, lblNetAmount.Text);
            frm.ShowDialog();


        }

        private void dgvٍSaleItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void cbClintName_Validating_1(object sender, CancelEventArgs e)
        {
            if (_PersonID.Value <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cbClintName, "يجب عليك أختيار عميل أولا");
            }

            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(cbClintName, null);
            }
        }

        private void cbClintName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClintName.Text == "")
                return;

            if (cbClintName.Text == "أضافة عميل جديد")
            {
                frmAddAndUpdatePerson frm = new frmAddAndUpdatePerson();
                frm.DataBack += DataBackEvent; // Subscribe to the event
                frm.ShowDialog();
            }
            else
            {
                _PersonID = clsPerson.Find(cbClintName.Text).PersonID;
            }
        }


        private void dgvٍSaleItem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dgvٍSaleItem.Columns["الكمية"].Index)
                {
                var quantity = dgvٍSaleItem.Rows[e.RowIndex].Cells[2].Value; 

                if (quantity != null && int.TryParse(quantity.ToString(), out int qty))
                    {
                    var unitPrice = dgvٍSaleItem.Rows[e.RowIndex].Cells[3].Value;  

                    if (unitPrice != null && decimal.TryParse(unitPrice.ToString(), out decimal price))
                        {
                            decimal totalPrice = qty * price;

                        dgvٍSaleItem.Rows[e.RowIndex].Cells[4].Value = totalPrice;  
                    }
                    else
                        {
                            MessageBox.Show("سعر الحبة غير صالح.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("الكمية غير صالحة.");
                    }
                }
            CalculateAmounts();
        }
    }
}