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
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1.Management_Persons.Control
{
    public partial class cltSilpers : UserControl
    {
        public cltSilpers()
        {
            InitializeComponent();
            dtFrom.Value = DateTime.Now.AddDays(-30);
            dtTo.Value = DateTime.Now;
        }
        private static System.Data.DataTable _dtAllPeople;
        private System.Data.DataTable _dtPeople;
        private clsPerson _Person = null;
        decimal total = 0M;
        decimal Paid = 0M;
        bool isSearch = false;

        private int? _PersonID = -1;
        public int? PersonID
        {
            get { return _PersonID; }
        }

        public clsPerson SelectedPersonInfo
        {
            get { return _Person; }
        }
        private void _SearchTypeName()
        {
            if (_PersonID < 0)
                return;

            string FilterColumn = "PurchaseDate";
            _dtPeople.DefaultView.RowFilter = string.Format("[{0}] >= #{1}# AND [{0}] <= #{2}#",
               FilterColumn,
               dtFrom.Value.ToString("MM/dd/yyyy"),
               dtTo.Value.ToString("MM/dd/yyyy"));


            if (isSearch)
            {
                total = 0M;
                Paid = 0M;
                dgvAccount.DataSource = _dtPeople;

                foreach (DataGridViewRow row in dgvAccount.Rows)
                {
                    total += Convert.ToDecimal(row.Cells[2].Value);
                    if (row.Cells[3].Value.ToString() == "آجل")
                        Paid += Convert.ToDecimal(row.Cells[2].Value);
                }

                lblTotal.Text = total.ToString();
                lblDeservePrice.Text = Paid.ToString();
                lblPaid.Text = (total - Paid).ToString();

            }

            isSearch = true;

        }

        public void LoadAccountInfo(int? PersonID)
        {
            _dtAllPeople = clsPerson.GetAllSippers(PersonID);

            if (_dtAllPeople.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد لهذا للمورد اي حساب في هذا التاريخ  او لا توجد اي عملية شراء من هذا المورد", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            _PersonID = PersonID;
            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PurchaseID", "PurchaseDate",
                                                         "NetAmount", "PaymentStatuID"
                                                         );


            if (!isSearch)
                _SearchTypeName();


            dgvAccount.DataSource = _dtPeople;
            foreach (DataGridViewRow row in dgvAccount.Rows)
            {
                total += Convert.ToDecimal(row.Cells[2].Value);
                if (row.Cells[3].Value.ToString() == "آجل")
                    Paid += Convert.ToDecimal(row.Cells[2].Value);
            }

            lblTotal.Text = total.ToString();
            lblDeservePrice.Text = Paid.ToString();
            lblPaid.Text = (total - Paid).ToString();

            cbTypePrint.SelectedIndex = 0;

            dgvAccount.Columns[0].HeaderText = "رقم الفاتورة";
            dgvAccount.Columns[0].Width = 150;

            dgvAccount.Columns[1].HeaderText = "تاريخ الفاتورة";
            dgvAccount.Columns[1].Width = 150;


            dgvAccount.Columns[2].HeaderText = "المبلغ الصافي";
            dgvAccount.Columns[2].Width = 150;

            dgvAccount.Columns[3].HeaderText = "نوع الفاتورة";
            dgvAccount.Columns[3].Width = 150;

            _Person = clsPerson.Find(PersonID);
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
            _PersonID = _Person.PersonID;
            lblID.Text = _Person.PersonID.ToString();
            lblName.Text = _Person.Name;
            lblPhone.Text = _Person.PhoneNumber.ToString();
            lblLoaction.Text = _Person.locationInfo.LocationName;

        }

        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblID.Text = "[????]";
            lblName.Text = "[????]";
            lblPhone.Text = "[????]";
            lblLoaction.Text = "[????]";

        }

        private void _GenerateClientReport(bool saveAsExcel)
        {



            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            // 🔹 مسار القالب الأصلي
            string templatePath = @"F:\حساب المورد.xlsx";

            // 🔹 تحديد امتداد الملف بناءً على الاختيار
            string fileExtension = saveAsExcel ? ".xlsx" : ".pdf";
            string outputPath = $@"F:\مشروع التخرج\AccountsClients\{_Person.PersonID}_{_Person.Name}_{DateTime.Now.ToString("yyyy-MM-dd")}_حساب المورد{fileExtension}";

            // 🔹 تحميل القالب
            FileInfo fileInfo = new FileInfo(templatePath);
            FileInfo newFile = new FileInfo(outputPath);

            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // اختيار أول ورقة
                int row = 10; // 🟢 ابدأ من الصف العاشر


                if (_dtPeople.Rows.Count == 0)
                {
                    MessageBox.Show("لم يتم تصدير لأنة لا توجد بيانات للتصدير", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                foreach (DataGridViewRow Row in dgvAccount.Rows)
                {
                    worksheet.Cells[row, 1].Value = Convert.ToDateTime(Row.Cells[1].Value).ToString("yyyy-MM-dd"); // التاريخ
                    worksheet.Cells[row, 2].Value = "فاتورة " + Row.Cells[3].Value.ToString(); // المعاملة
                    worksheet.Cells[row, 3].Value = "شراء مادة خام"; // التفاصيل
                    worksheet.Cells[row, 4].Value = Row.Cells[3].Value.ToString() == "آجل" ? Row.Cells[2].Value.ToString() : "0"; // مدين
                    worksheet.Cells[row, 5].Value = Row.Cells[3].Value.ToString() == "مقدما" ? Row.Cells[2].Value.ToString() : "0"; // دائن
                    row++;

                }

                worksheet.Cells[1, 2].Value = _Person.Name;
                worksheet.Cells[1, 5].Value = DateTime.Now.ToString("yyyy-MM-dd");
                worksheet.Cells[4, 2].Value = total.ToString();
                worksheet.Cells[5, 2].Value = (total - Paid).ToString();
                worksheet.Cells[6, 2].Value = Paid.ToString();
                worksheet.Cells[42, 5].Value = total.ToString();

                // 🔹 إذا كان Excel، نحفظ الملف مباشرة
                if (saveAsExcel)
                {
                    package.SaveAs(newFile);
                }
                else
                {
                    // حفظ كـ Excel مؤقتًا ثم تحويله إلى PDF
                    string tempExcelPath = outputPath.Replace(".pdf", ".xlsx");
                    package.SaveAs(new FileInfo(tempExcelPath));

                    // تحويل Excel إلى PDF
                    _ConvertExcelToPdf(tempExcelPath, outputPath);

                    // حذف الملف المؤقت بعد التحويل
                    if (File.Exists(tempExcelPath))
                        File.Delete(tempExcelPath);
                }
            }

            MessageBox.Show($"✅ تم إنشاء كشف الحساب بنجاح بصيغة {fileExtension.ToUpper()}", "تم بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (cbTypePrint.SelectedIndex == 0)
                _GenerateClientReport(true);
            else
                _GenerateClientReport(false);
        }

        private void dtTo_Leave(object sender, EventArgs e)
        {
            _SearchTypeName();

        }

        private void dtFrom_Leave(object sender, EventArgs e)
        {
            _SearchTypeName();

        }
    }
}
