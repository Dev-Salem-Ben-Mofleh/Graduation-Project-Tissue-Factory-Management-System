using Guna.UI2.WinForms;
using InstituteBussiness;
using Microsoft.Office.Interop.Excel;
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

namespace WindowsFormsApp1.Management_Boxes
{
    public partial class frmUpdateCurrncy : Form
    {
        public frmUpdateCurrncy()
        {
            InitializeComponent();
        }
        clsCurrencyTyp currencyTypSaudi;
        clsCurrencyTyp currencyTypAmrican;
        private void _LoadData()
        {
             currencyTypSaudi = clsCurrencyTyp.Find(2);
             currencyTypAmrican = clsCurrencyTyp.Find(3);


            ndS.Text = currencyTypSaudi.Amount.ToString();
            ndD.Text = currencyTypAmrican.Amount.ToString();

        }

        private void _Save()
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("بعض الحقول يوجد فيها أخطاء", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            currencyTypSaudi.Amount =Convert.ToDecimal( ndS.Text);
            currencyTypAmrican.Amount = Convert.ToDecimal( ndD.Text);

            if (currencyTypSaudi.Save()&& currencyTypAmrican.Save())
            {
                _LoadData();
                MessageBox.Show("تم حفظ البيانات بشكل صحيح", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("خظأ:  لم يتم حفظ البيانات بشكل صحيح ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void btnCalnsel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

     
        private void frmUpdateCurrncy_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void ndS_TextChanged(object sender, EventArgs e)
        {

        }

        private void ndS_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox Temp = ((Guna2TextBox)sender);

            if (Temp.Text =="")
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "لا يجب ترك الحقل فارغا");
            }

            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }
        }
    }
}
