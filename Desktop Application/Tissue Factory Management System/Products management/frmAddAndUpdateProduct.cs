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
using static System.Windows.Forms.AxHost;

namespace WindowsFormsApp1.Products_management
{
    public partial class frmAddAndUpdateProduct : Form
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enum enGendor { Female = 0, Male = 1 };

        private enMode _Mode;
        private int? _ProductID = -1;
        clsProduct _product;

        public frmAddAndUpdateProduct()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;

        }
        public frmAddAndUpdateProduct(int? ProductID)
        {
            InitializeComponent();
            _ProductID = ProductID;
            _Mode = enMode.Update;
        }
        private void _ResetDefualtValues()
        {

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "إضافة  منتج جديد ";
                _product = new clsProduct();
            }
            else
            {
                lblTitle.Text = " تحديث  منتج   ";
            }

            nuUintPrice.Value = 0;
            cbunitm.SelectedIndex = 0;
            txtDes.Text = "";
            txtNameProudct.Text = "";

        }
        private void _LoadData()
        {

            _product = clsProduct.Find(_ProductID);

            if (_product == null)
            {
                MessageBox.Show("No Person with ID = " + _ProductID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblID.Text = _ProductID.ToString();
            nuUintPrice.Value = (int)_product.UnitPrice;
            cbunitm.SelectedIndex = cbunitm.FindString( _product.UnitMeasurement);
            txtNameProudct.Text = _product.ProductName;
            txtDes.Text = _product.description==null?"": _product.description;
        }
        private void _Save()
        {
            
            if (!this.ValidateChildren())
            {
                MessageBox.Show("بعض الحقول يوجد فيها أخطاء", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (_Mode == enMode.AddNew)
                _product.Quantity = 0;

                _product.ProductName = txtNameProudct.Text;
                _product.UnitPrice = (decimal)nuUintPrice.Value;
                _product.UnitMeasurement = cbunitm.Text;
                _product.description = txtDes.Text==""?null: txtDes.Text;



            if (_product.Save())
            {
                lblID.Text = _product.ProductID.ToString();
                _ProductID = _product.ProductID;
                _Mode = enMode.Update;
                lblTitle.Text = "تحديث منتج ";
                _LoadData();

                MessageBox.Show("تم حفظ البيانات بشكل صحيح", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("خظأ:  لم يتم حفظ البيانات بشكل صحيح ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
        private void btnCalnsel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmAddAndUpdateProduct_Load(object sender, EventArgs e)
        {

            _ResetDefualtValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtNameProudct_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNameProudct.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNameProudct, "لا يجب ترك الحقل فارغ");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNameProudct, null);
            };
        }

        private void nuUintMeasur_Validating(object sender, CancelEventArgs e)
        {
            Guna2NumericUpDown Temp = ((Guna2NumericUpDown)sender);
            if (Temp.Value <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, " 0 = لا يجب ترك الحقل ");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }
    }
}
