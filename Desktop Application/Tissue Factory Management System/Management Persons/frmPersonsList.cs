using InstituteBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using WindowsFormsApp1.Products_management;

namespace WindowsFormsApp1.Management_Persons
{
    public partial class frmPersonsList : Form
    {
        public frmPersonsList()
        {
            InitializeComponent();
        }
        private static DataTable _dtAllPeople = clsPerson.GetAllPersons();

        //only select the columns that you want to show in the grid
        private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID","Name",
                                                         "Email", "LocationName", "PhoneNumber", "PersonType"
                                                         );

        private void _RefreshPeoplList()
        {
            _dtAllPeople = clsPerson.GetAllPersons();
            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "Name",
                                                         "Email", "LocationName", "PhoneNumber", "PersonType"
                                                         );

            dgvPersons.DataSource = _dtPeople;
            lblRecordsCountPersons.Text = dgvPersons.Rows.Count.ToString();
            cbFilterType.SelectedIndex = 0;
            cbSearchBy.SelectedIndex = 0;
        }

        private void _SearchTypeName()
        {
            string FilterColumn = "PersonType";
            string FilterValue = cbFilterType.Text;


            if (FilterValue == "الكل")
                _dtPeople.DefaultView.RowFilter = "";
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, cbFilterType.Text.Trim());

            lblRecordsCountPersons.Text = _dtAllPeople.Rows.Count.ToString();
        }

        private void frmPersonsList_Load(object sender, EventArgs e)
        {
            
            dgvPersons.DataSource = _dtPeople;
            cbSearchBy.SelectedIndex = 0;
            cbFilterType.SelectedIndex = 0;
            lblRecordsCountPersons.Text = dgvPersons.Rows.Count.ToString();
           

                dgvPersons.Columns[0].HeaderText = "رقم الشخص";
                dgvPersons.Columns[0].Width = 110;

                dgvPersons.Columns[1].HeaderText = "الأسم";
                dgvPersons.Columns[1].Width = 200;


                dgvPersons.Columns[2].HeaderText = "الأيميل";
                dgvPersons.Columns[2].Width = 120;

                dgvPersons.Columns[3].HeaderText = "المنطقه";
                dgvPersons.Columns[3].Width = 120;

                dgvPersons.Columns[4].HeaderText = "رقم التلفون";
                dgvPersons.Columns[4].Width = 120;


                dgvPersons.Columns[5].HeaderText = "نوع الشخص";
                dgvPersons.Columns[5].Width = 120;
        }

        private void cbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
                txSearchValue.Text = "";
                txSearchValue.Focus();

        }

        private void txSearchValue_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = "";
            
            switch (cbSearchBy.Text)
            {
                case "رقم المميز":
                    FilterColumn = "PersonID";
                    break;

                case "الأسم":
                    FilterColumn = "Name";
                    break;


                case "رقم التلفون":
                    FilterColumn = "PhoneNumber";
                    break;


            }

            if (txSearchValue.Text.Trim() == "" )
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblRecordsCountPersons.Text = dgvPersons.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "PersonID")

                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txSearchValue.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txSearchValue.Text.Trim());

            lblRecordsCountPersons.Text = dgvPersons.Rows.Count.ToString();
        }

        private void cbFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SearchTypeName();
        }

        private void btnAddPersons_Click(object sender, EventArgs e)
        {
            frmAddAndUpdatePerson frm = new frmAddAndUpdatePerson();
            frm.ShowDialog();
            _RefreshPeoplList();
        }

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            frmSearchPerson frm = new frmSearchPerson();
            frm.ShowDialog();
            _RefreshPeoplList();

        }

        private void AddNewPersonoolStripMenuIt_Click(object sender, EventArgs e)
        {
            frmAddAndUpdatePerson frm = new frmAddAndUpdatePerson();
            frm.ShowDialog();
            _RefreshPeoplList();

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonsDetails frm = new frmShowPersonsDetails((int)dgvPersons.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeoplList();

        }

        private void editPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddAndUpdatePerson frm = new frmAddAndUpdatePerson((int)dgvPersons.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeoplList();


        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انته متأكد أنك تريد حذف هذا الشخص [" + dgvPersons.CurrentRow.Cells[0].Value + "]", "تأكيد الحذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {
                 clsPerson Person = clsPerson.Find((int)dgvPersons.CurrentRow.Cells[0].Value);


                if (clsPerson.DeletePerson((int)dgvPersons.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("تم حذف الشخص بنجاح", "تم بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeoplList();
                }

                else
                    MessageBox.Show("لم يتم حذف الشخص لدية معلومات مرتبظه بجدول اخر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void AccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(dgvPersons.CurrentRow.Cells[5].Value.ToString()=="عميل")
            {
                frmAccountDetails frm = new frmAccountDetails((int)dgvPersons.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
            }
            else
            {
                frmAccountDetailsSilppers frm = new frmAccountDetailsSilppers((int)dgvPersons.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
            }


        }

        private void txSearchValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbSearchBy.Text == "رقم المميز" || cbSearchBy.Text == "رقم التلفون")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
