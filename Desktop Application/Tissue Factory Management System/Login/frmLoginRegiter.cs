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

namespace WindowsFormsApp1.Login
{
    public partial class frmLoginRegiter : Form
    {
        public frmLoginRegiter()
        {
            InitializeComponent();
        }
        private static DataTable _dtAllProducts = clslogin_registe.GetAlllogin_register();

        private DataTable _dtProduct = _dtAllProducts.DefaultView.ToTable(false, "LoginID", "Name",
            "DateLogin");

        private void _RefresPrudctionlList()
        {
            _dtAllProducts = clslogin_registe.GetAlllogin_register();
            _dtProduct = _dtAllProducts.DefaultView.ToTable(false, "LoginID", "Name",
            "DateLogin");

            dgvProducts.DataSource = _dtProduct;
            lblRecordsCountProducts.Text = dgvProducts.Rows.Count.ToString();
            cbFilter.SelectedIndex = 0;
        }

        private void _SearchByDate()
        {
            string FilterColumn = "DateLogin";
            string FilterValue = cbFilter.Text;

            DateTime fromDate = dtFrom.Value.Date;
            DateTime toDate = fromDate.AddDays(1);

            _dtProduct.DefaultView.RowFilter = string.Format("[{0}] >= #{1}# AND [{0}] < #{2}#",
                FilterColumn,
                fromDate.ToString("MM/dd/yyyy"),
                toDate.ToString("MM/dd/yyyy"));

            lblRecordsCountProducts.Text = _dtProduct.Rows.Count.ToString();
        }

        private void frmLoginRegiter_Load(object sender, EventArgs e)
        {
            _RefresPrudctionlList();
            dtFrom.Visible = false;
            txSearchBy.Visible = true;
            dgvProducts.DataSource = _dtProduct;
            dtFrom.Value=DateTime.Now;
            cbFilter.SelectedIndex = 0;
            lblRecordsCountProducts.Text = dgvProducts.Rows.Count.ToString();
            if (dgvProducts.Rows.Count > 0)
            {

                dgvProducts.Columns[0].HeaderText = "رقم السجل";
                dgvProducts.Columns[0].Width = 110;

                dgvProducts.Columns[1].HeaderText = "أسم المستخدم";
                dgvProducts.Columns[1].Width = 100;


                dgvProducts.Columns[2].HeaderText = "تاريخ تسجيل الدخول";
                dgvProducts.Columns[2].Width = 120;

            }
        }

        private void txSearchBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
          
            switch (cbFilter.Text)
            {
                case "رقم السجل":
                    FilterColumn = "LoginID";
                    break;


                case "أسم المستخدم":
                    FilterColumn = "Name";
                    break;

                case "التاريخ":
                    FilterColumn = "DateLogin";
                    break;
            }

            if (txSearchBy.Text.Trim() == "")
            {
                _dtProduct.DefaultView.RowFilter = "";
                lblRecordsCountProducts.Text = dgvProducts.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "LoginID")
            {
                _dtProduct.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txSearchBy.Text.Trim());
               
            }
            else
                if (FilterColumn == "DateLogin")
            {
                return;
            }
            else
            {
                _dtProduct.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txSearchBy.Text.Trim());
               
            }

            lblRecordsCountProducts.Text = dgvProducts.Rows.Count.ToString();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txSearchBy.Text = "";
            txSearchBy.Focus();

            if (cbFilter.Text == "التاريخ")
            {
                dtFrom.Visible = true;
                txSearchBy.Visible = false;
            }
            else
            {
                dtFrom.Visible = false;
                txSearchBy.Visible = true;
            }

        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtFrom_MouseLeave(object sender, EventArgs e)
        {

        }

        private void dtFrom_Leave(object sender, EventArgs e)
        {

        }

        private void dtFrom_Leave_1(object sender, EventArgs e)
        {
            _SearchByDate();

        }
    }
}
