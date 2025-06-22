using InstituteBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Global;

namespace WindowsFormsApp1.Sales_Department.Control
{
    public partial class invoicBill : Form
    {
        Bitmap memoryImage;
        int? _SaleID;
        string _Total;
        string _Discount;
        string _NetAmoutn;

        clsSale Sale;
        clsSaleItem saleItem;
        
        public invoicBill(int? SaleID, string Total, string Discount, string NetAmoutn)
        {
            InitializeComponent();
            _SaleID = SaleID;
            _Total = Total;
            _Discount = Discount;
            _NetAmoutn = NetAmoutn;
        }

        private void _LoadAllProudcts()
        {
            DataTable dataTable = clsSaleItem.GetAllSaleItems(_SaleID);
            clsProduct product;

            foreach (DataRow Row in dataTable.Rows)
            {
                product = clsProduct.Find( Row["ProductName"].ToString());

                TxtNumberProdu.Text += product.ProductID.ToString();
                TxtNumberProdu.Text+=Environment.NewLine;
                txtNameProd.Text += product.ProductName;
                txtNameProd.Text+= Environment.NewLine;
                txtUnit.Text += product.UnitMeasurement;
                txtUnit.Text += Environment.NewLine;
                txtQuantity.Text += Row["Amount"].ToString();
                txtQuantity.Text += Environment.NewLine;
                txtUintPrice.Text += product.UnitPrice;
                txtUintPrice.Text += Environment.NewLine;
                txtTotalProd.Text += Row["Price"].ToString();
                txtTotalProd.Text += Environment.NewLine;
            }
            Sale = clsSale.Find(_SaleID);
            txtTotlaBillstring.Text = ConvertCurrenciesTotString.Convert(Convert.ToInt32(Sale.TotalAmount)) +" "+ Sale.currencyTypInfo.Name;
            txtNetAmouuntString.Text = ConvertCurrenciesTotString.Convert(Convert.ToInt32(Sale.NetAmount)) + " " + Sale.currencyTypInfo.Name;
            txtDiscountString.Text = Sale.Discount != 0 ? ConvertCurrenciesTotString.Convert(Convert.ToInt32(Sale.Discount)) + " " + Sale.currencyTypInfo.Name
                : "0";
        }

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
            this.Close();

        }

        private void invoicBill_Load(object sender, EventArgs e)
        {
            Sale = clsSale.Find(_SaleID);

            txtDate.Text = DateTime.Now.ToShortDateString();
            txtID.Text = _SaleID.ToString();
            txtDiscount.Text = _Discount;
            txtNetAmouunt.Text = _NetAmoutn;
            txtTotalBiil.Text = _Total;
            txtName.Text += Sale.personInfo.Name;
            txtTypeBill.Text += Sale.paymentStatuInfo.TypeName;
            _LoadAllProudcts();


        }

        private void invoicBill_DoubleClick(object sender, EventArgs e)
        {
            CaptureScreen();
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
            this.Close();

        }

        private void invoicBill_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //CaptureScreen();
            //PrintDocument pd = new PrintDocument();
            //pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            //PrintDialog printDialog = new PrintDialog();
            //printDialog.Document = pd;

            //if (printDialog.ShowDialog() == DialogResult.OK)
            //{
            //    pd.Print();
            //}
            //this.Close();

        }

    }
}
