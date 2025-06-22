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

namespace WindowsFormsApp1.Management_Boxes
{
    public partial class cltBoxInfo : UserControl
    {
        public cltBoxInfo()
        {
            InitializeComponent();
        }

        public void LoadInfo()
        {
            clsBasicBoxe basicBoxe = clsBasicBoxe.Find(2);

            lblName.Text = basicBoxe.BoxName;
            lblCurrency.Text = basicBoxe.balance.ToString();
            lblstatute.Text = basicBoxe.box_status == 1 ? "نشط" : "غير نشط";
        }
        private void cltBoxInfo_Load(object sender, EventArgs e)
        {
            
        }
    }
}
