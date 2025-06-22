using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Expenses_Management;
using WindowsFormsApp1.Management_Persons;
using WindowsFormsApp1.Production_mamagment;
using WindowsFormsApp1.Purncasing_Departmnet;
using WindowsFormsApp1.Sales_Department;

namespace WindowsFormsApp1.DashBoard
{
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()
        {
            InitializeComponent();
        }

        DateTime Datefrom;
        DateTime Dateto;



        private void btnAddSaleBill_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateSalesBill frm=new frmAddAndUpdateSalesBill();
            frm.ShowDialog();
        }

        private void btnAddPurncBill_Click(object sender, EventArgs e)
        {
            frmAddAndUpdatePurncasing frm = new frmAddAndUpdatePurncasing();
            frm.ShowDialog();
        }

        private void btnAddProductionBill_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateProduction frm = new frmAddAndUpdateProduction();
            frm.ShowDialog();
        }

        private void btnAddExpensesBill_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateExpenses frm = new frmAddAndUpdateExpenses();
            frm.ShowDialog();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddAndUpdatePerson frm = new frmAddAndUpdatePerson();
            frm.ShowDialog();
        }

        private void btn7Days_Click(object sender, EventArgs e)
        {
            Datefrom = DateTime.Now.AddDays(-7);
            Dateto = DateTime.Now;
            clsSaleReports1.LoadData(Datefrom, Dateto);
            clsPurchasesReports1.LoadData(Datefrom, Dateto);

        }

        private void btn1Month_Click(object sender, EventArgs e)
        {
            Datefrom = DateTime.Now.AddMonths(-1);
            Dateto = DateTime.Now;
            clsSaleReports1.LoadData(Datefrom, Dateto);
            clsPurchasesReports1.LoadData(Datefrom, Dateto);

        }

        private void btn3Months_Click(object sender, EventArgs e)
        {
            Datefrom = DateTime.Now.AddMonths(-3);
            Dateto = DateTime.Now;
            clsSaleReports1.LoadData(Datefrom, Dateto);
            clsPurchasesReports1.LoadData(Datefrom, Dateto);

        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            Datefrom = DateTime.Now.AddDays(-7);
            Dateto = DateTime.Now;
            clsSaleReports1.LoadData(Datefrom, Dateto);
            clsPurchasesReports1.LoadData(Datefrom, Dateto);

        }
    }
}
