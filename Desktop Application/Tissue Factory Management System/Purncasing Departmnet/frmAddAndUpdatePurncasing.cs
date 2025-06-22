using Guna.UI2.WinForms;
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
using WindowsFormsApp1.Management_Persons;

namespace WindowsFormsApp1.Purncasing_Departmnet
{
    public partial class frmAddAndUpdatePurncasing : Form
    {
        public delegate void DataBackEventHandler(object sender, int? SaleID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;
        private int? _PurchaseID = -1;
        private int? _PersonID = -1;
        private decimal _balance = 0M;
        private decimal _YamaniTotal;
        private bool _IsReturn = true;
        clsPurchase _Purchase;
        List<string> allNames = new List<string>();
        int _counter = 0;


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
            DataTable RawName = clsPerson.GetAllSlipers();
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
        public frmAddAndUpdatePurncasing()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;

        }
        public frmAddAndUpdatePurncasing(int? PurchaseID)
        {
            InitializeComponent();
            _PurchaseID = PurchaseID;
            _Mode = enMode.Update;
        }
        private void _ResetDefualtValues()
        {
            _FillPayments();
            _FillPersonsNAme();
            cbStateSales.SelectedIndex = 0;
            cbCurrencyType.SelectedIndex = 0;

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "إضافة  فاتورة جديدة ";
                _Purchase = new clsPurchase();
            }
            else
            {
                lblTitle.Text = " تحديث  فاتورة  ";
            }

            dtDate.Value = DateTime.Now;
        }
        private void _LoadData()
        {

            _Purchase = clsPurchase.Find(_PurchaseID);

            if (_Purchase == null)
            {
                MessageBox.Show("No Person with ID = " + _PurchaseID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblSaleBillId.Text = _PurchaseID.ToString();
            cbClintName.Text = _Purchase.personInfo.Name;
            cbClintName.Enabled = false;
            dtDate.Value = _Purchase.PurchaseDate;
            cbStateSales.SelectedIndex = cbStateSales.FindString(_Purchase.paymentStatuInfo.TypeName);
            cbStateSales.Enabled = false;
            ndNetAmount.Value = _Purchase.NetAmount;
            ndDisccount.Value = _Purchase.Discount;
            ndTotal.Value = _Purchase.TotalAmount;
            _balance = _Purchase.NetAmount;
            _PersonID = _Purchase.PersonID;
            _LoadPurchaseItems();
            cbCurrencyType.SelectedIndex = cbCurrencyType.FindString(_Purchase.currencyTypInfo.Name);
            _IsReturn = false;
        }
        private void _LoadPurchaseItems()
        {

            DataTable _dtAllSales = clsPurchaseItem.GetAllPurchaseItems(_PurchaseID);

            foreach (DataRow Row in _dtAllSales.Rows)
            {
                dgvٍSaleItem.Rows.Add(Row["PurchaseItemID"], Row["Material_Name"], Row["Qauntity"], Row["Unit_cost"], Row["Price"]);

            }
        }

        private bool CheckMatairalisHerOrNot(string name)
        {
            return clsRawMaterial.DoesRawMaterialExist(name);
        }

        private int? _SaveRawMatrialorUpdate(string name,bool what,int? quantity,decimal UintPrice)
        {
            if(what)
            {
                clsRawMaterial rawMaterial = new clsRawMaterial();
                rawMaterial.Material_Name= name;
                rawMaterial.DeliveryDate=DateTime.Now;
                rawMaterial.Unit_cost = UintPrice;
                rawMaterial.UnitMeasurement = 1;
                rawMaterial.Quantity = quantity;
                rawMaterial.Save();
                return rawMaterial.MaterialID;

            }
            else
            {
                clsRawMaterial rawMaterial =  clsRawMaterial.Find(name);
                rawMaterial.DeliveryDate = DateTime.Now;
                rawMaterial.Unit_cost = UintPrice;
                rawMaterial.UnitMeasurement = 1;
                rawMaterial.Quantity += quantity;
                rawMaterial.Save();

            }
            return 0;

        }

        private void SaveAllPruchasetmes(DataGridView dgv)
        {

            if (_Mode == enMode.Update)
            {
                DataTable RawName = clsPurchaseItem.GetAllPurchaseItems(_PurchaseID);
                foreach (DataRow Row in RawName.Rows)
                {
                    clsRawMaterial rawMaterial = clsRawMaterial.Find(Row["Material_Name"].ToString());
                    rawMaterial.Quantity -= (int)Row["Qauntity"];
                    rawMaterial.Save();
                }

                clsPurchaseItem.DeletePurchaseItem(_PurchaseID);

            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow)
                    continue;
                clsPurchaseItem PurchaseItem = new clsPurchaseItem();

                if (CheckMatairalisHerOrNot(row.Cells[1].Value.ToString()))
                {
                    PurchaseItem.MaterialID = clsRawMaterial.Find(row.Cells[1].Value.ToString()).MaterialID;
                    _SaveRawMatrialorUpdate(row.Cells[1].Value.ToString(), false, Convert.ToInt32( row.Cells[2].Value),
                        Convert.ToDecimal(row.Cells[3].Value));
                }
                else
                {
                    PurchaseItem.MaterialID = _SaveRawMatrialorUpdate(row.Cells[1].Value.ToString(),true,Convert.ToInt32(
                        row.Cells[2].Value), Convert.ToDecimal(row.Cells[3].Value));
                }

                PurchaseItem.Price = (decimal)row.Cells[4].Value;
                PurchaseItem.Qauntity = Convert.ToInt32( row.Cells[2].Value);
                PurchaseItem.PurchaseID = _PurchaseID;
                PurchaseItem.Save();
            }
        }
        private int? SaveBoxMovments()
        {
            clsBoxMovement boxMovement = new clsBoxMovement();

            if (_Mode == enMode.Update)
            {
                boxMovement = clsBoxMovement.Find(_Purchase.BoxMovementID);
                boxMovement.Amount = ndNetAmount.Value;
                boxMovement.UserID = clsGlobal.CurrentUser.UserID;
                boxMovement.Save();
            }
            else
            {
                boxMovement.BoxMovementDate = dtDate.Value;
                boxMovement.Amount = ndNetAmount.Value;
                boxMovement.MovementType = 1;
                boxMovement.Description = null;
                boxMovement.BoxID = 2;
                boxMovement.UserID = clsGlobal.CurrentUser.UserID;
                boxMovement.Save();
            }


            return boxMovement.BoxMovementID;

        }

        private void _ReturnTotal()
        {
            _YamaniTotal = 0;
                foreach (DataGridViewRow row in dgvٍSaleItem.Rows)
                {
                    if (row.IsNewRow)
                        continue;
                    _YamaniTotal += (decimal)row.Cells[4].Value;

            }
        }
        private void _UpdateStocks()
        {
            clsCurrencyTyp Saudi = clsCurrencyTyp.Find(2);
            clsStockMovement stockMovementProduct = new clsStockMovement();
            clsBasicBoxe basicBoxe = clsBasicBoxe.Find(2);


            clsStockMovement.DeleteStockMovementByPurchaseID(_PurchaseID);

            if (basicBoxe.balance == 0)
                return;

            
            _ReturnTotal();
            _YamaniTotal -= ndDisccount.Value;
            _YamaniTotal = _YamaniTotal * Saudi.Amount;
            basicBoxe.balance += _YamaniTotal;
            basicBoxe.Save();



        }
        private void _SaveStocks()
        {
            clsCurrencyTyp Saudi = clsCurrencyTyp.Find(2);
            clsRawMaterial rawMaterial=new clsRawMaterial();
            bool isDelete = false;

            foreach (DataGridViewRow row in dgvٍSaleItem.Rows)
            {
                if (row.IsNewRow)
                    continue;


                if (_Mode == enMode.Update)
                {
                    if (!isDelete)
                        _UpdateStocks();

                    isDelete = true;
                    clsStockMovement stockMovementRaws = new clsStockMovement();
                    rawMaterial = clsRawMaterial.Find(row.Cells[1].Value.ToString());

                    stockMovementRaws.Quantity = Convert.ToInt32(row.Cells[2].Value);
                    stockMovementRaws.StockMovementDate = _Purchase.PurchaseDate;
                    stockMovementRaws.StockMovementType = 1;
                    stockMovementRaws.ProductID = null;
                    stockMovementRaws.MaterialID = rawMaterial.MaterialID;
                    stockMovementRaws.UserID = clsGlobal.CurrentUser.UserID;
                    stockMovementRaws.TypeOfOperation = 2;
                    stockMovementRaws.PurchaseID = _PurchaseID;
                    stockMovementRaws.Save();



                }

                else
                {

                    clsStockMovement stockMovementRaws = new clsStockMovement();
                    rawMaterial = clsRawMaterial.Find(row.Cells[1].Value.ToString());


                    stockMovementRaws.Quantity = Convert.ToInt32(row.Cells[2].Value);
                    stockMovementRaws.StockMovementDate =dtDate.Value;
                    stockMovementRaws.StockMovementType = 1;
                    stockMovementRaws.ProductID = null;
                    stockMovementRaws.MaterialID = rawMaterial.MaterialID;
                    stockMovementRaws.UserID = clsGlobal.CurrentUser.UserID;
                    stockMovementRaws.TypeOfOperation = 2;
                    stockMovementRaws.PurchaseID = _PurchaseID;
                    stockMovementRaws.Save();

                }
            }
            clsBasicBoxe basicBoxe = clsBasicBoxe.Find(2);
            _ReturnTotal();
            _YamaniTotal -= ndDisccount.Value;
            _YamaniTotal = _YamaniTotal * Saudi.Amount;
            basicBoxe.balance -= Convert.ToDecimal(_YamaniTotal);
            basicBoxe.Save();

        }
        private void _Save()
        {
     
            btnSave.Enabled = false;
            btnCalnsel.Enabled = false;
            btnClose.Enabled = false;

            if (!this.ValidateChildren() || dgvٍSaleItem.RowCount == 0)
            {
                MessageBox.Show(" او قائمة منتجات البيع فارغة بعض الحقول يوجد فيها أخطاء", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = true;
                btnCalnsel.Enabled = true;
                btnClose.Enabled = true;
                return;
            }

            if (_Mode == enMode.Update)
            {
                _Purchase.TotalAmount = ndTotal.Value;
                _Purchase.Discount = ndDisccount.Value;
                _Purchase.NetAmount = ndNetAmount.Value;
                _Purchase.UserID = clsGlobal.CurrentUser.UserID;
                _Purchase.PersonID = _PersonID;
                _Purchase.PaymentStatuID = cbStateSales.SelectedIndex + 1;
                _Purchase.CurrencyTypeID = cbCurrencyType.SelectedIndex + 1;
                _Purchase.BoxMovementID = SaveBoxMovments();
            }
            else
            {
                _Purchase.PurchaseDate = dtDate.Value;
                _Purchase.TotalAmount = ndTotal.Value;
                _Purchase.Discount = ndDisccount.Value;
                _Purchase.NetAmount = ndNetAmount.Value;
                _Purchase.UserID = clsGlobal.CurrentUser.UserID;
                _Purchase.PersonID = _PersonID;
                _Purchase.PaymentStatuID = cbStateSales.SelectedIndex + 1;
                _Purchase.CurrencyTypeID = cbCurrencyType.SelectedIndex + 1;
                _Purchase.BoxMovementID = SaveBoxMovments();

            }
            if (_Purchase.Save())
            {
                lblSaleBillId.Text = _Purchase.PurchaseID.ToString();
                _PurchaseID = _Purchase.PurchaseID;
                btnSave.Enabled = false;

                SaveAllPruchasetmes(dgvٍSaleItem);

                _SaveStocks();
                _Mode = enMode.Update;

                MessageBox.Show("تم حفظ البيانات بشكل صحيح", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(this, _Purchase.PurchaseID);

                this.Close();
            }
            else
                MessageBox.Show("خظأ:  لم يتم حفظ البيانات بشكل صحيح ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            btnCalnsel.Enabled = true;
            btnClose.Enabled = true;

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
            colProductName.Name = "أسم المادة الخام";
            colProductName.HeaderText = "أسم المادة الخام";
            colProductName.Width = 140;
            colProductName.ReadOnly = true;
            dgvٍSaleItem.Columns.Add(colProductName);

            DataGridViewTextBoxColumn colQuantity = new DataGridViewTextBoxColumn();
            colQuantity.Name = "الكمية";
            colQuantity.HeaderText = "الكمية";
            colQuantity.Width = 120;
            colQuantity.ReadOnly = false;
            dgvٍSaleItem.Columns.Add(colQuantity);

            DataGridViewTextBoxColumn colUnitPrice = new DataGridViewTextBoxColumn();
            colUnitPrice.Name = "سعر الوحدة";
            colUnitPrice.HeaderText = "سعر الوحدة";
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
        private void btnCalnsel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

      
        private void frmAddAndUpdatePurncasing_Load(object sender, EventArgs e)
        {

            _ResetDefualtValues();
            InitializeSaleItemGrid();
            dgvٍSaleItem.CellEndEdit += dgvٍSaleItem_CellEndEdit;

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnAddToBill_Click(object sender, EventArgs e)
        {
            AddRowWithFields();
        }

        private void AddRowWithFields()
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("بعض الحقول يوجد فيها أخطاء", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Mode == enMode.Update)
                _counter = dgvٍSaleItem.Rows.Count;

            int itemNumber = ++_counter;

            decimal quantity = ndQuantity.Value;
            decimal totalPrice = quantity *ndUintPrice.Value ;


            ndDisccount.Enabled = false;
            ndNetAmount.Enabled = false;
            ndTotal.Enabled = false;
            cbCurrencyType.Enabled = false;
            cbStateSales.Enabled = false;


            dgvٍSaleItem.Rows.Add(itemNumber, txtRawName.Text, quantity, ndUintPrice.Value, totalPrice);

            cbStateSales.Enabled = false;

        }

        private void DataBackEvent(object sender, int? PersonID)
        {
            if (PersonID == null)
                return;
            // Handle the data received
            clsPerson person = clsPerson.Find(PersonID);
            if (person.TypeName == 1)
            {
                MessageBox.Show("خذا الشخص عميل أختر مورد صحيح", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cbClintName.Items.Add(clsPerson.Find(PersonID).Name);
            cbClintName.SelectedIndex = cbClintName.Items.Count - 1;
            _PersonID = PersonID;
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

        private void txtRawName_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtRawName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtRawName, "لا يجب ترك الحقل فارغ");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtRawName, null);
            }
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

        private void ndDisccount_Validating(object sender, CancelEventArgs e)
        {
            if (ndDisccount.Value <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(ndDisccount, " 0 = لا يجب ترك الحقل ");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(ndDisccount, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void ndNetAmount_Validating(object sender, CancelEventArgs e)
        {
            clsBasicBoxe basicBoxe = clsBasicBoxe.Find(2);

            if (ndNetAmount.Value <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(ndNetAmount, " 0 = لا يجب ترك الحقل ");
            }
            else
            if((ndNetAmount.Value*clsCurrencyTyp.Find(2).Amount)> basicBoxe.balance)
            {
                MessageBox.Show($"{basicBoxe.balance} = لم يعد لديك المال الكافي للشراءالمتبقي هو ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;

            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(ndNetAmount, null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void حذقسلعةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvٍSaleItem.Rows.Remove(dgvٍSaleItem.CurrentRow);

        }

        private void ndTotal_Validating_1(object sender, CancelEventArgs e)
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
        }

        private void cbClintName_Validating(object sender, CancelEventArgs e)
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

            if (cbClintName.Text == "أضافة مورد جديد")
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

        [STAThread]
        private void btnScanned_Click(object sender, EventArgs e)
        {
            InvoiceScanner scanner = new InvoiceScanner();
            scanner.StartScan();
        }
    }


}
