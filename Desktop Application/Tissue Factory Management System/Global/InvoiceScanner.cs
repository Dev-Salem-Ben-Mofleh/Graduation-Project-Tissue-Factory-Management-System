using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TwainDotNet;
using TwainDotNet.Win32;
using TwainDotNet.WinFroms;

public class InvoiceScanner
{
    private Twain _twain;
    private bool _scanning;

    public InvoiceScanner()
    {
        _twain = new Twain(new WinFormsWindowMessageHook(new Form()));
        _twain.TransferImage += OnTransferImage;
        _twain.ScanningComplete += OnScanningComplete;
    }


    public void StartScan()
    {
        _twain.SelectSource(); // لإظهار نافذة اختيار جهاز السكانر

        var settings = new ScanSettings
        {
            UseDocumentFeeder = false,
            ShowTwainUI = true,
            ShowProgressIndicatorUI = true,
            UseDuplex = false,
            Resolution = ResolutionSettings.Fax,
            Area = null,
            ShouldTransferAllPages = false
        };

        _twain.StartScanning(settings);
        _scanning = true;
        Application.Run(); // إبقاء التطبيق يعمل حتى تنتهي العملية
    }

    private void OnTransferImage(object sender, TransferImageEventArgs e)
    {
        if (e.Image != null)
        {
            SaveScannedImage(e.Image);
        }
    }

    private void SaveScannedImage(Image image)
    {
        string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "صور فواتير المشتريات");

        // أنشئ المجلد إن لم يكن موجودًا
        if (!Directory.Exists(folderPath))
            Directory.CreateDirectory(folderPath);

        // احفظ الصورة
        string fileName = "Invoice_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".jpg";
        string fullPath = Path.Combine(folderPath, fileName);
        image.Save(fullPath, System.Drawing.Imaging.ImageFormat.Jpeg);

        MessageBox.Show("تم حفظ الفاتورة في: " + fullPath);
    }

    private void OnScanningComplete(object sender, EventArgs e)
    {
        _scanning = false;
        Application.ExitThread();
    }
}
