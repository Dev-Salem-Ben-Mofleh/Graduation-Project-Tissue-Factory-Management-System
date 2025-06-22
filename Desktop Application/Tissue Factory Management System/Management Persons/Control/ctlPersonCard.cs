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
using static WindowsFormsApp1.Management_Persons.frmAddAndUpdatePerson;
using WindowsFormsApp1.Properties;
using BussinesLayer;

namespace WindowsFormsApp1.Management_Persons
{
    public partial class ctlPersonCard : UserControl
    {
        private clsPerson _Person;

        private int? _PersonID = -1;

        public int? PersonID
        {
            get { return _PersonID; }
        }

        public clsPerson SelectedPersonInfo
        {
            get { return _Person; }
        }

        public void LoadPersonInfo(int? PersonID)
        {


            _Person = clsPerson.Find(PersonID);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show(" لا يوجد شخص بهذا الرقم = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }

        public void LoadPersonInfo(string Name)
        {


            _Person = clsPerson.Find(Name);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show(" لا يوجد شخص بهذا الرقم = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }


        private void _FillPersonInfo()
        {
            lbkUpdatePerson.Enabled = true;
            _PersonID = _Person.PersonID;
            lblID.Text = _Person.PersonID.ToString();
            lblEmail.Text = _Person.Email;
            lblName.Text = _Person.Name;
            lblPhoneNumber.Text = _Person.PhoneNumber.ToString();
            lblLocation.Text = _Person.locationInfo.LocationName;

            if (_Person.TypeName == 1)
                lblPersonType.Text = "عميل";
            else
            if (_Person.TypeName == 2)
                lblPersonType.Text = "مورد";
            else
                lblPersonType.Text = "مستخدم";


        }

        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblID.Text = "[????]";
            lblPersonType.Text = "[????]";
            lblName.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhoneNumber.Text = "[????]";
            lblLocation.Text = "[????]";

        }

        public ctlPersonCard()
        {
            InitializeComponent();
        }

        private void lbkUpdatePerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddAndUpdatePerson frm = new frmAddAndUpdatePerson(_PersonID);
            frm.ShowDialog();

            LoadPersonInfo(_PersonID);
        }


    }
}
