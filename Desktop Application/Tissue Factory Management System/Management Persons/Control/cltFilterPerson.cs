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

namespace WindowsFormsApp1.Management_Persons.Control
{
    public partial class cltFilterPerson : UserControl
    {
        public event Action<int?> OnPersonSelected;
        protected virtual void PersonSelected(int? PersonID)
        {
            Action<int?> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(PersonID); 
            }
        }



        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get
            {
                return _ShowAddPerson;
            }
            set
            {
                _ShowAddPerson = value;
                btnAddNewPerso.Visible = _ShowAddPerson;
            }
        }


        private int? _PersonID = -1;

        public int? PersonID
        {
            get { return ctlPersonCard1.PersonID; }
        }

        public clsPerson SelectedPersonInfo
        {
            get { return ctlPersonCard1.SelectedPersonInfo; }
        }

        public void LoadPersonInfo(int PersonID)
        {

            txSearchBy.Text = PersonID.ToString();
            FindNow();

        }

        private void FindNow()
        {
            ctlPersonCard1.LoadPersonInfo(int.Parse(txSearchBy.Text));


            if (OnPersonSelected != null )
                OnPersonSelected(ctlPersonCard1.PersonID);
        }

        public cltFilterPerson()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("بعض الحقول لديها أخطاء ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            FindNow();
        }

        private void btnAddNewPerso_Click(object sender, EventArgs e)
        {
             frmAddAndUpdatePerson frm1 = new frmAddAndUpdatePerson();
            frm1.DataBack += DataBackEvent; // Subscribe to the event
            frm1.ShowDialog();
        }

        private void DataBackEvent(object sender, int? PersonID)
        {
            txSearchBy.Text = PersonID.ToString();
            ctlPersonCard1.LoadPersonInfo(PersonID);
        }

        private void cltFilterPerson_Load(object sender, EventArgs e)
        {
           txSearchBy.Focus();

        }

        private void txSearchBy_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txSearchBy.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txSearchBy, "يجب تعبئة هذا الحقل");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txSearchBy, null);
            }
        }

        private void txSearchBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txSearchBy_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
