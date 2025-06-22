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
using WindowsFormsApp1.Purncasing_Departmnet;

namespace WindowsFormsApp1.Users_management
{
    public partial class frmUserList : Form
    {
        public frmUserList()
        {
            InitializeComponent();
        }

        private static DataTable _dtAllUsers= clsUser.GetAllUsers();
        
        //only select the columns that you want to show in the grid
        private DataTable _dtUsers = _dtAllUsers.DefaultView.ToTable(false, "UserID", "Name",
                                                         "UserName", "LocationName", "PhoneNumber", "Email", "IsActive"
                                                         );

        private void _RefresUserlList()
        {
            _dtAllUsers = clsUser.GetAllUsers();
            _dtUsers = _dtAllUsers.DefaultView.ToTable(false,"UserID", "Name",
                                                         "UserName", "LocationName", "PhoneNumber", "Email", "IsActive"
                                                         );

            dgvUsers.DataSource = _dtUsers;
            lblRecordsCountUsers.Text = dgvUsers.Rows.Count.ToString();
            cbFilterBy.SelectedIndex = 0;
            cbIsActive.SelectedIndex = 0;
        }

        private void _SearchIsActive()
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbIsActive.Text;

            switch (FilterValue)
            {
                case "الكل":
                    break;
                case "نشط":
                    FilterValue = "1";
                    break;
                case "غير نشط":
                    FilterValue = "0";
                    break;
            }


            if (FilterValue == "الكل")
                _dtAllUsers.DefaultView.RowFilter = "";
            else
            _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

          lblRecordsCountUsers.Text = _dtAllUsers.Rows.Count.ToString();
        }

        private void frmUserList_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = _dtUsers;
            cbFilterBy.SelectedIndex = 0;
            cbIsActive.SelectedIndex = 0;
            lblRecordsCountUsers.Text = dgvUsers.Rows.Count.ToString();


                dgvUsers.Columns[0].HeaderText = "رقم المستخدم";
                dgvUsers.Columns[0].Width = 110;

                dgvUsers.Columns[1].HeaderText = "أسم الشخص";
                dgvUsers.Columns[1].Width = 200;


                dgvUsers.Columns[2].HeaderText = "اسم المستخدم";
                dgvUsers.Columns[2].Width = 100;

                dgvUsers.Columns[3].HeaderText = "المدينة";
                dgvUsers.Columns[3].Width = 100;


                dgvUsers.Columns[4].HeaderText = "رقم التلفون";
                dgvUsers.Columns[4].Width = 100;


                dgvUsers.Columns[5].HeaderText = "الايميل";
                dgvUsers.Columns[5].Width = 120;

                dgvUsers.Columns[6].HeaderText = "المستخدم نشط";
                dgvUsers.Columns[6].Width = 120;
            
        }
      
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserDetails frm = new frmShowUserDetails((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefresUserlList();
        }

      

        private void AddNewBilltoolStripMenuIt_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateUser frm = new frmAddAndUpdateUser();
            frm.ShowDialog();
            _RefresUserlList();

        }

        private void editBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateUser frm = new frmAddAndUpdateUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefresUserlList();

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txSearchBy.Text = "";
            txSearchBy.Focus();
        }

        private void txSearchBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            

            switch (cbFilterBy.Text)
            {
                case "رقم المستخدم":
                    FilterColumn = "UserID";
                    break;

                case "أسم المستخدم":
                    FilterColumn = "UserName";
                    break;


                case "رقم التلفون":
                    FilterColumn = "PhoneNumber";
                    break;



                case "الأسم":
                    FilterColumn = "Name";
                    break;


            }

            if (txSearchBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtUsers.DefaultView.RowFilter = "";
                lblRecordsCountUsers.Text = dgvUsers.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "UserID" )

                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txSearchBy.Text.Trim());
            else
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txSearchBy.Text.Trim());

            lblRecordsCountUsers.Text = dgvUsers.Rows.Count.ToString();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SearchIsActive();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateUser frm = new frmAddAndUpdateUser();
            frm.ShowDialog();
            _RefresUserlList();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انته متأكد أنك تريد حذف هذا المسستخدم [" + dgvUsers.CurrentRow.Cells[0].Value + "]", "تأكيد الحذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {
                clsPerson Person = clsPerson.Find((int)dgvUsers.CurrentRow.Cells[0].Value);


                if (clsUser.DeleteUser((int)dgvUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("تم حذف المستخدم بنجاح", "تم بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefresUserlList();
                }

                else
                    MessageBox.Show("لم يتم حذف المستخدم لدية معلومات مرتبظه بجدول اخر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txSearchBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "رقم المستخدم" || cbFilterBy.Text == "رقم التلفون")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
