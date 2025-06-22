using BussinesLayer;
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
using System.Xml.Linq;
using WindowsFormsApp1.Global;

namespace WindowsFormsApp1.Production_mamagment
{
    public partial class frmAddAndUpdateProduction : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;
        private int? _ProductionID = -1;
        clsProduction _production;


        private void _FillNameProducts()
        {
            DataTable ProudctName = clsProduct.GetAllProducts();
            foreach (DataRow Row in ProudctName.Rows)
            {
                cbProductss.Items.Add(Row["ProductName"]);
            }
        }
        private void _FillNameRaws()
        {
            DataTable RawName = clsRawMaterial.GetAllRawMaterials();
            foreach (DataRow Row in RawName.Rows)
            {
                cbRaws.Items.Add(Row["Material_Name"]);
            }
        }
        public frmAddAndUpdateProduction()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;

        }
        public frmAddAndUpdateProduction(int? ProductionID)
        {
            InitializeComponent();
            _ProductionID = ProductionID;
            _Mode = enMode.Update;
        }
        private void _ResetDefualtValues()
        {
            _FillNameProducts();
            _FillNameRaws();

            cbProductss.SelectedIndex = 0;
            cbRaws.SelectedIndex = 0;

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "إضافة عملية أنتاج جديدة ";
                _production = new clsProduction();
            }
            else
            {
                lblTitle.Text = " تحديث عملية أنتاج   ";
            }

            dtDate.Value= DateTime.Now;
            dtDate.Enabled = false;
            nuQuanatityDamaged.Value = 0;
            ndQuqntity.Value = 0;
            ndQuantityRaws.Value = 0;
        }
        private void _LoadData()
        {

            _production = clsProduction.Find(_ProductionID);

            if (_production == null)
            {
                MessageBox.Show("No Person with ID = " + _ProductionID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblID.Text = _ProductionID.ToString();
            nuQuanatityDamaged.Value =(int)_production.DamagedQuantity;
            ndQuqntity.Value = (int)_production.Quantity;
            ndQuantityRaws.Value = (int)_production.RawAmount;
            cbProductss.SelectedIndex = cbProductss.FindString( _production.productInfo.ProductName);
            cbRaws.SelectedIndex = cbRaws.FindString(_production.rawMaterialInfo.Material_Name); ;
            dtDate.Value = _production.ProductionDate;
            dtDate.Enabled = false;


        }
        private void _Save()
        {
            clsRawMaterial rawMaterial = clsRawMaterial.Find(cbRaws.Text);
            clsProduct product = clsProduct.Find(cbProductss.Text);

            if (!this.ValidateChildren())
            {
                MessageBox.Show("بعض الحقول يوجد فيها أخطاء", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_handleRawsAndProducts(rawMaterial))
                return;

            clsStockMovement stockMovementRaw = new clsStockMovement();
            clsStockMovement stockMovementProduct = new clsStockMovement();

            if ( _Mode == enMode.Update)
            {
                stockMovementRaw = clsStockMovement.Find(_production.StockMovementIDMaterial);
                stockMovementRaw.Quantity = (int)ndQuantityRaws.Value;
                stockMovementRaw.MaterialID = rawMaterial.MaterialID;
                stockMovementRaw.UserID = clsGlobal.CurrentUser.UserID;
                stockMovementRaw.Save();

                stockMovementProduct = clsStockMovement.Find(_production.StockMovementIDProduct);
                stockMovementProduct.Quantity = (int)ndQuqntity.Value;
                stockMovementProduct.ProductID = product.ProductID;
                stockMovementProduct.UserID = clsGlobal.CurrentUser.UserID;
                stockMovementProduct.Save();

                product.Quantity -= (_production.Quantity - _production.DamagedQuantity);
                product.Quantity += (int)(ndQuqntity.Value - nuQuanatityDamaged.Value);
                    product.Save();

                rawMaterial.Quantity += _production.RawAmount ;
                rawMaterial.Quantity -= (int)ndQuantityRaws.Value;
                rawMaterial.Save();

                _production.DamagedQuantity = (int)nuQuanatityDamaged.Value;
                _production.Quantity = (int)ndQuqntity.Value;
                _production.RawAmount = (int)ndQuantityRaws.Value;
                _production.UserID = 1;
                _production.MaterialID =rawMaterial.MaterialID ;
                _production.ProductID =product.ProductID;

            }
            else
            {
                stockMovementRaw.Quantity = (int)ndQuantityRaws.Value;
                stockMovementRaw.StockMovementType = 1;
                stockMovementRaw.StockMovementDate = dtDate.Value;
                stockMovementRaw.MaterialID = rawMaterial.MaterialID;
                stockMovementRaw.ProductID = null;
                stockMovementRaw.UserID = clsGlobal.CurrentUser.UserID;
                stockMovementRaw.TypeOfOperation = 1;
                stockMovementRaw.Save();

                stockMovementProduct.Quantity = (int)ndQuqntity.Value;
                stockMovementProduct.StockMovementType = 2;
                stockMovementProduct.StockMovementDate = dtDate.Value;
                stockMovementProduct.MaterialID = null;
                stockMovementProduct.ProductID = product.ProductID;
                stockMovementProduct.UserID = clsGlobal.CurrentUser.UserID;
                stockMovementProduct.TypeOfOperation = 2;
                stockMovementProduct.Save();

                product.Quantity += (int)(ndQuqntity.Value-nuQuanatityDamaged.Value);
                product.Save();

                rawMaterial.Quantity -= (int)ndQuantityRaws.Value;
                rawMaterial.Save();

                _production.DamagedQuantity = (int)nuQuanatityDamaged.Value;
                _production.Quantity = (int)ndQuqntity.Value;
                _production.RawAmount = (int)ndQuantityRaws.Value;
                _production.ProductionDate = dtDate.Value;
                _production.UserID = clsGlobal.CurrentUser.UserID;
                _production.MaterialID = rawMaterial.MaterialID;
                _production.ProductID = product.ProductID;
                _production.StockMovementIDMaterial = stockMovementRaw.StockMovementID;
                _production.StockMovementIDProduct = stockMovementProduct.StockMovementID;

            }


            if (_production.Save())
            {
                lblID.Text = _production.ProductionID.ToString();
                _ProductionID = _production.ProductionID;

                _Mode = enMode.Update;
                lblTitle.Text = "تحديث عملية أنتاج";
                _LoadData();

                MessageBox.Show("تم حفظ البيانات بشكل صحيح", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("خظأ:  لم يتم حفظ البيانات بشكل صحيح ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private bool _handleRawsAndProducts(clsRawMaterial rawMaterial)
        {

            if (rawMaterial.Quantity<ndQuantityRaws.Value)
            {
                MessageBox.Show($"{rawMaterial.Quantity} كمية المادة الخام التي أخترتها أكثر من الكمية الموجودة في المخزون", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalnsel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmAddAndUpdateProduction_Load(object sender, EventArgs e)
        {

            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void ndQuantityRaws_Validating(object sender, CancelEventArgs e)
        {
            Guna2NumericUpDown Temp = ((Guna2NumericUpDown)sender);
            if (Temp.Value<=0)
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, " 0=لا يجب ترك الحقل ");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }
        }

        private void cbProductss_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

