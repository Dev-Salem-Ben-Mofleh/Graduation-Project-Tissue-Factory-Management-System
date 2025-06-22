using InstituteBussiness;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;

namespace WindowsFormsApp1.ManagmentReports
{
    public partial class frmSalingR : Form
    {
        public frmSalingR()
        {
            InitializeComponent();
        }
        DateTime date;
        private static readonly HttpClient client = new HttpClient();


        private static DataTable _dtAllReports;

        private DataTable _dtPeople;

        private void calculate(DataTable dt)
        {
            decimal totalSum = 0;

            foreach (DataRow row in dt.Rows)
            {
                if (row["Total"] != DBNull.Value)
                {
                    totalSum += Convert.ToDecimal(row["Total"]);
                }
            }

            btnPaid.Text = "ريال يمني" + " " + totalSum;
        }
        private void _RefresPrudctionlList(string typeofSearch,DateTime date)
        {
            _dtAllReports = clsSale.GetReports(typeofSearch, date);
            if (_dtAllReports.DefaultView.Count == 0)
            {
                dgvSaleR.Columns.Clear();
                lblnotfound.Visible = true;
                return;
            }

            lblnotfound.Visible = false;

            _dtPeople = _dtAllReports.DefaultView.ToTable(false, "SaleDate", "Total", "CountBills",
            "Proudct", "Name", "PaidBill", "NotPaidBill");

            dgvSaleR.DataSource = _dtPeople;
            lblRecordsCountStocks.Text = dgvSaleR.Rows.Count.ToString();
            

                dgvSaleR.Columns[0].HeaderText = "التاريخ";
                dgvSaleR.Columns[0].Width = 150;

                dgvSaleR.Columns[1].HeaderText = "أجمالي المبيعات";
                dgvSaleR.Columns[1].Width = 150;

                dgvSaleR.Columns[2].HeaderText = "عدد الفواتير";
                dgvSaleR.Columns[2].Width = 100;


                dgvSaleR.Columns[3].HeaderText = "أفضل منتج مبيعا";
                dgvSaleR.Columns[3].Width = 120;

                dgvSaleR.Columns[4].HeaderText = "أفضل عميل شراء";
                dgvSaleR.Columns[4].Width = 100;

                dgvSaleR.Columns[5].HeaderText = "المبلغ المدفوع";
                dgvSaleR.Columns[5].Width = 200;

                dgvSaleR.Columns[6].HeaderText = "المبلغ المتبقي";
                dgvSaleR.Columns[6].Width = 100;


            calculate(_dtPeople);

        }

        private void frmSalingR_Load(object sender, EventArgs e)
        {

            cbTypeMove.SelectedIndex = 0;
            dtFrom.Value = DateTime.Now;

            _RefresPrudctionlList(cbTypeMove.Text,DateTime.Now);
   
        }

        private void cbTypeMove_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtFrom.Focus();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            date = dtFrom.Value;
            _RefresPrudctionlList(cbTypeMove.Text, date);
        }
       
        private void _GenerateClientReport(bool saveAsExcel)
        {
            string date = cbTypeMove.SelectedIndex == 0 ? dtFrom.Value.ToString("yyyy-MM-dd") : cbTypeMove.SelectedIndex == 1 ?
                dtFrom.Value.ToString("yyyy-MM") :
                dtFrom.Value.ToString("yyyy");


            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            string templatePath = @"F:\تقارير المبيعات.xlsx";

            string fileExtension = saveAsExcel ? ".xlsx" : ".pdf";
            string outputPath = $@"F:\مشروع التخرج\Sale Reports\تقارير المبيعات_ال{cbTypeMove.Text}_لتاريخ_{date}{fileExtension}";

            FileInfo fileInfo = new FileInfo(templatePath);
            FileInfo newFile = new FileInfo(outputPath);

            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; 
                int row = 2; 


                if (_dtPeople.Rows.Count == 0)
                {
                    MessageBox.Show("لم يتم تصدير لأنة لا توجد بيانات للتصدير", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                foreach (DataGridViewRow Row in dgvSaleR.Rows)
                {
                    worksheet.Cells[row, 1].Value = Convert.ToDateTime(Row.Cells[0].Value).ToString("yyyy-MM-dd");
                    worksheet.Cells[row, 2].Value = Row.Cells[1].Value.ToString();
                    worksheet.Cells[row, 3].Value = Row.Cells[2].Value.ToString(); 
                    worksheet.Cells[row, 4].Value = Row.Cells[3].Value.ToString();
                    worksheet.Cells[row, 5].Value = Row.Cells[4].Value.ToString();
                    worksheet.Cells[row, 6].Value = Row.Cells[5].Value.ToString();
                    worksheet.Cells[row, 7].Value = Row.Cells[6].Value.ToString();

                    row++;

                }


                if (saveAsExcel)
                {
                    package.SaveAs(newFile);
                }
                else
                {
                    string tempExcelPath = outputPath.Replace(".pdf", ".xlsx");
                    package.SaveAs(new FileInfo(tempExcelPath));

                    _ConvertExcelToPdf(tempExcelPath, outputPath);

                    if (File.Exists(tempExcelPath))
                        File.Delete(tempExcelPath);
                }
            }

            MessageBox.Show($"✅ تم إنشاء التقرير  بنجاح بصيغة {fileExtension.ToUpper()}", "تم بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void _ConvertExcelToPdf(string excelPath, string pdfPath)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(excelPath);

            try
            {
                workbook.ExportAsFixedFormat(Excel.XlFixedFormatType.xlTypePDF, pdfPath);
            }
            finally
            {
                workbook.Close(false);
                excelApp.Quit();
            }
        }


        private async Task SendReportsAsync()
        {
            _dtAllReports = clsSale.GetReports("يومي", dtFrom.Value);
            if (_dtAllReports.DefaultView.Count == 0)
            {
                return;
            }
            _dtPeople = _dtAllReports.DefaultView.ToTable(false, "SaleDate", "Total", "CountBills",
            "Proudct", "Name", "PaidBill", "NotPaidBill");

            foreach (DataRow row in _dtPeople.Rows)
            {
                var saleReport = new
                {
                    saleDate = Convert.ToDateTime(row["SaleDate"]),
                    countBills = Convert.ToInt32(row["CountBills"]),
                    total = Convert.ToDecimal(row["Total"]),
                    proudct = row["Proudct"].ToString(),
                    name = row["Name"].ToString(),
                    paidBill = Convert.ToDecimal(row["PaidBill"]),
                    notPaidBill = Convert.ToDecimal(row["NotPaidBill"])
                };

                string json = JsonSerializer.Serialize(saleReport);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    HttpResponseMessage response = await client.PostAsync("https://tissue.runasp.net/api/Tissue/AddSaleReport", content);

                    if (response.IsSuccessStatusCode)
                    {
                        return;
                    }
                    else
                    {
                        MessageBox.Show("خطأ في الاتصال", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ في الاتصال", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public async Task<bool> CheckIfSaleExistsAsync(DateTime date)
        {
            string formattedDate = date.ToString("yyyy-MM-dd"); 
            string url = $"https://tissue.runasp.net/api/Tissue/existsS/{formattedDate}";

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في الاتصال", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine("خطأ: " + ex.Message);
                return false;
            }
        }
        private async void btnPrint_Click(object sender, EventArgs e)
        {
            if(cbTypePrint.SelectedIndex==3)
            {
                if(cbTypeMove.SelectedIndex==0)
                {
                   bool isFound = await CheckIfSaleExistsAsync(dtFrom.Value);
                    if(isFound)
                    {
                        await SendReportsAsync();
                        MessageBox.Show("لقد تم الارسال بنجاح", "نجاح",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("لقد تم ارسال هذه التقارير في وقت سابق", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("أذا اردت ارسال التقرير اليومي للمدير لابد ان تختار نوع البحث للتاريخ يومي ثم تختار التاريخ وتقوم بالارسال", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            if (cbTypePrint.SelectedIndex == 0)
                _GenerateClientReport(true);
            else
            if (cbTypePrint.SelectedIndex == 1)
                _GenerateClientReport(false);
            else
            if (cbTypePrint.SelectedIndex == 2)
                return;
        }
    }
}
