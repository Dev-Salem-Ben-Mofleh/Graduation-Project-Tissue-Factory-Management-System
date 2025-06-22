using BussinesLayer;
using Guna.UI2.WinForms;
using InstituteBussiness;
using Microsoft.Win32;
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
using System.Xml.Linq;
using TheArtOfDevHtmlRenderer.Adapters;
using WindowsFormsApp1.Global;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1.Management_Persons
{

    public partial class frmAddAndUpdatePerson : Form
    {
        public delegate void DataBackEventHandler(object sender, int? PeronsID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;
        private int? _PersonID = -1;
        clsPerson _person;


        private void _FillLocations()
        {
            DataTable RanksName = clsLocation.GetAllLocations();
            foreach (DataRow Row in RanksName.Rows)
            {
                cbLocations.Items.Add(Row["LocationName"]);
            }
        }

        public frmAddAndUpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;

        }
        public frmAddAndUpdatePerson(int? PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _Mode = enMode.Update;
        }

        private void _ResetDefualtValues()
        {
            _FillLocations();
            cbLocations.SelectedIndex = 0;
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "أضافة شخص جديد";
                _person = new clsPerson();
            }
            else
            {
                lblTitle.Text = "تحديث معلومات شخص ";
            }


            txtName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";

        }

        private void _LoadData()
        {

            _person = clsPerson.Find(_PersonID);

            if (_person == null)
            {
                MessageBox.Show("No Person with ID = " + _PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblID.Text = _PersonID.ToString();
            txtName.Text = _person.Name;
            txtEmail.Text = _person.Email;
            txtPhone.Text = _person.PhoneNumber.ToString();
            cbLocations.SelectedIndex = cbLocations.FindString(_person.locationInfo.LocationName);
            cbTypePerson.SelectedIndex =(int)(_person.TypeName-1);
            

        }
        
        private void _Save()
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("بعض الحقول يوجد فيها أخطاء", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        

            _person.Name = txtName.Text.Trim();
            _person.Email = txtEmail.Text.Trim();
            _person.PhoneNumber =txtPhone.Text.Trim();
            _person.TypeName = cbTypePerson.SelectedIndex + 1;
            _person.Location = cbLocations.SelectedIndex + 1;


            if (_person.Save())
            {
                lblID.Text = _person.PersonID.ToString();

                _Mode = enMode.Update;
                lblTitle.Text = "تحديث معلومات شخص";

                MessageBox.Show("تم حفظ البيانات بشكل صحيح", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(this, _person.PersonID);
                this.Close();
            }
            else
                MessageBox.Show("خظأ:  لم يتم حفظ البيانات بشكل صحيح ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
        private void btnCalnsel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void frmAddAndUpdatePerson_Load(object sender, EventArgs e)
        {
           
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "لا يجب ترك الحقل فارغ");
                return;
            }
           else
            if (!clsValidation.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "تنسيق الأيميل خاطئ");
                return;

            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            };


        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            Guna2TextBox Temp = ((Guna2TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "لا يجب ترك الحقل فارغ");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPhone, "لا يجب ترك الحقل فارغ");
            }
            if (!clsValidation.PhoneNumber(txtPhone.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPhone, "يجب ان يكون عدد الارقام صحيح");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtPhone, null);
            }
        }
    }
}
