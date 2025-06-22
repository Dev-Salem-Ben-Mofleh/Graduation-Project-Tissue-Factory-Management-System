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

namespace WindowsFormsApp1.Inventory_management
{
    public partial class frmStockMovement : Form
    {
        public frmStockMovement()
        {
            InitializeComponent();
        } 

        private static DataTable _dtAllStoockMovemnts = clsStockMovement.GetAllStockMovements();

        private DataTable _dtPeople = _dtAllStoockMovemnts.DefaultView.ToTable(false, "StockMovementID", "StockMovementType",
            "Quantity", "StockMovementDate", "Name", "UserID"
            , "TypeOfOperation");

        private void _RefresPrudctionlList()
        {
            _dtAllStoockMovemnts = clsStockMovement.GetAllStockMovements();
            _dtPeople = _dtAllStoockMovemnts.DefaultView.ToTable(false, "StockMovementID", "StockMovementType",
            "Quantity", "StockMovementDate", "Name", "UserID"
            , "TypeOfOperation");

            dgvStocks.DataSource = _dtPeople;
            lblRecordsCountStocks.Text = dgvStocks.Rows.Count.ToString();
            cbFilter.SelectedIndex = 0;
            cbTypeMove.SelectedIndex = 0;
           
        }

        private void _SearchByDate()
        {
            string FilterColumn = "StockMovementDate";
            string FilterValue = cbFilter.Text;

                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] >= #{1}# AND [{0}] <= #{2}#",
                    FilterColumn,
                    dtFrom.Value.ToString("MM/dd/yyyy"),
                    dtTo.Value.ToString("MM/dd/yyyy"));

            lblRecordsCountStocks.Text = _dtAllStoockMovemnts.Rows.Count.ToString();
        }

        private void _SearchTypeName()
        {
            string FilterColumn = "StockMovementType";
            string FilterValue = cbTypeMove.Text;


            if (FilterValue == "الكل")
                _dtPeople.DefaultView.RowFilter = "";
            else
            _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%' AND [{2}] >= #{3}# AND [{2}] <= #{4}#",
                    FilterColumn, cbTypeMove.Text.Trim(),
                               "StockMovementDate",
                               dtFrom.Value.ToString("MM/dd/yyyy"),
                               dtTo.Value.ToString("MM/dd/yyyy"));

            lblRecordsCountStocks.Text = _dtAllStoockMovemnts.Rows.Count.ToString();
        }

        private void frmStockMovement_Load(object sender, EventArgs e)
        {
            _RefresPrudctionlList();

            dgvStocks.DataSource = _dtPeople;
            cbFilter.SelectedIndex = 0;
            cbTypeMove.SelectedIndex = 0;
            dtFrom.Value = DateTime.Now.AddMonths(-1);
            dtTo.Value = DateTime.Now;
            lblRecordsCountStocks.Text = dgvStocks.Rows.Count.ToString();


                dgvStocks.Columns[0].HeaderText = "رقم حركة المخزون";
                dgvStocks.Columns[0].Width = 150;

                dgvStocks.Columns[1].HeaderText = "نوع الحركة ";
                dgvStocks.Columns[1].Width = 100;


                dgvStocks.Columns[2].HeaderText = "الكمية";
                dgvStocks.Columns[2].Width = 120;

                dgvStocks.Columns[3].HeaderText = "تاريخ الحركة";
                dgvStocks.Columns[3].Width = 100;

                dgvStocks.Columns[4].HeaderText =  "أسم المادة الخام أو المنتج";
                dgvStocks.Columns[4].Width = 200;

                dgvStocks.Columns[5].HeaderText = "رقم المستخدم";
                dgvStocks.Columns[5].Width = 100;


                dgvStocks.Columns[6].HeaderText = "نوع العملية";
                dgvStocks.Columns[6].Width = 120;


        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txSearchBy.Text = "";
            txSearchBy.Focus();
        }

        private void txSearchBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilter.Text)
            {
                case "رقم حركة المخزون":
                    FilterColumn = "StockMovementID";
                    break;


                case "أسم المادة الخام أو المنتج":
                    FilterColumn = "Name";
                    break;

            }

            if (txSearchBy.Text.Trim() == "")
            {
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] >= #{1}# AND [{0}] <= #{2}#",
                               "StockMovementDate",
                               dtFrom.Value.ToString("MM/dd/yyyy"),
                               dtTo.Value.ToString("MM/dd/yyyy"));
                lblRecordsCountStocks.Text = _dtAllStoockMovemnts.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "StockMovementID")

                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txSearchBy.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%' AND [{2}] >= #{3}# AND [{2}] <= #{4}#",
        FilterColumn, txSearchBy.Text.Trim(),
                   "StockMovementDate",
                   dtFrom.Value.ToString("MM/dd/yyyy"),
                   dtTo.Value.ToString("MM/dd/yyyy"));

            lblRecordsCountStocks.Text = dgvStocks.Rows.Count.ToString();

        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            _SearchByDate();
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            _SearchByDate();

        }

        private void cbTypeMove_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SearchTypeName();
        }

        private void txSearchBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "رقم حركة المخزون")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
