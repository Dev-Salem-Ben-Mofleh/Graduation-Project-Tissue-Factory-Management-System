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
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1.DashBoard.Controls
{
    public partial class clsPurchasesReports : UserControl
    {
        public clsPurchasesReports()
        {
            InitializeComponent();
        }
        private void _LoadChartCircle(DateTime dateFrom, DateTime dateTo)
        {
            int paid = 0;
            int noPaid = 0;
            int total = 0;
            decimal paidM = 0;
            decimal noPaidM = 0;
            decimal totalM = 0;

            DataTable Paid = clsPurchase.GetPruchesPaid(dateFrom, dateTo);
            DataTable NoPaid = clsPurchase.GetPurchesNoPaid(dateFrom, dateTo);
            DataTable Total = clsPurchase.GetPurcheseTotal(dateFrom, dateTo);

            foreach (DataRow Row in Paid.Rows)
            {
                paid = Convert.ToInt32(Row["numberBills"]);
                paidM = Convert.ToDecimal(Row["Paid"]);
            }

            foreach (DataRow Row in NoPaid.Rows)
            {
                noPaid = Convert.ToInt32(Row["numberBills"]);
                noPaidM = Convert.ToDecimal(Row["NoPaid"]);
            }

            foreach (DataRow Row in Total.Rows)
            {
                total = Convert.ToInt32(Row["numberBills"]);
                totalM = Convert.ToDecimal(Row["Total"]);
            }

            chart1.Series.Clear();
            chart1.Series.Add("Invoices");
            chart1.Series["Invoices"].ChartType = SeriesChartType.Pie;

            // فقط المدفوعة وغير المدفوعة
            chart1.Series["Invoices"].Points.AddXY("غير مدفوعة", noPaid);
            chart1.Series["Invoices"].Points.AddXY("مدفوعة", paid);

            // النسبة المئوية بدل الرقم
            chart1.Series["Invoices"].Label = "#PERCENT{P0}";
            chart1.Series["Invoices"].IsValueShownAsLabel = true;

            // تلوين القطاعات
            chart1.Series["Invoices"].Points[0].Color = Color.Red;
            chart1.Series["Invoices"].Points[1].Color = Color.Blue;

            // تحديث النصوص
            btnPaid.Text = "المبلغ المدفوع: " + paidM.ToString("N0") + " ريال يمني";
            btnNoPaid.Text = "المبلغ المتبقي: " + noPaidM.ToString("N0") + " ريال يمني";
            btnTotal.Text = "المبلغ الإجمالي: " + totalM.ToString("N0") + " ريال يمني";

            // إظهار الإجمالي كنص أعلى الدائرة
            Title title = new Title();
            title.Text = $"الإجمالي: {total} فاتورة";
            title.Font = new Font("Arial", 12, FontStyle.Bold);
            title.ForeColor = Color.DarkGreen;
            title.Alignment = ContentAlignment.TopCenter;
            chart1.Titles.Clear();
            chart1.Titles.Add(title);
        }
        private void _LoadChartLine(DateTime dateFrom, DateTime dateTo)
        {

            DataTable AllInfo = clsPurchase.GetPurchesReportForDashboard(dateFrom, dateTo);

            chart2.Series.Clear();

            chart2.Series.Add("أجمالي المشتريات");
            chart2.Series.Add("الفواتير المدفوعة");
            chart2.Series.Add("الفواتير غير المدفوعة");

            foreach (var series in chart2.Series)
            {
                series.ChartType = SeriesChartType.Column;
                series.BorderWidth = 3;
            }



            List<string> days = new List<string>();
            List<int> totalInvoices = new List<int>();
            List<int> soldInvoices = new List<int>();
            List<int> paidInvoices = new List<int>();
            List<int> unpaidInvoices = new List<int>();


            foreach (DataRow Row in AllInfo.Rows)
            {
                days.Add(Convert.ToDateTime(Row["PurchaseDate"]).ToString("dd-MM"));

                totalInvoices.Add(Convert.ToInt32(Row["numberBills"]));
                unpaidInvoices.Add(Convert.ToInt32(Row["NoPaid"]));
                paidInvoices.Add(Convert.ToInt32(Row["Paid"]));
            }



            for (int i = 0; i < days.Count; i++)
            {
                chart2.Series["أجمالي المشتريات"].Points.AddXY(days[i], totalInvoices[i]);
                chart2.Series["الفواتير المدفوعة"].Points.AddXY(days[i], paidInvoices[i]);
                chart2.Series["الفواتير غير المدفوعة"].Points.AddXY(days[i], unpaidInvoices[i]);
            }

            chart2.Series["أجمالي المشتريات"].Color = Color.Green;
            chart2.Series["الفواتير المدفوعة"].Color = Color.Blue;
            chart2.Series["الفواتير غير المدفوعة"].Color = Color.Red;

            foreach (var series in chart2.Series)
            {
                series.IsValueShownAsLabel = true;
                series.MarkerStyle = MarkerStyle.Circle;
                series.MarkerSize = 8;
            }


            chart2.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart2.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            chart2.ChartAreas[0].AxisX.ScrollBar.Size = 10;

            chart2.ChartAreas[0].AxisX.ScaleView.Size = 7;

            chart2.ChartAreas[0].AxisX.ScaleView.Position = 0;
            chart2.ChartAreas[0].AxisX.Interval = 1;
        }
        public void LoadData(DateTime dateFrom, DateTime dateTo)
        {
            _LoadChartCircle(dateFrom, dateTo);
            _LoadChartLine(dateFrom, dateTo);

        }
    }
}
