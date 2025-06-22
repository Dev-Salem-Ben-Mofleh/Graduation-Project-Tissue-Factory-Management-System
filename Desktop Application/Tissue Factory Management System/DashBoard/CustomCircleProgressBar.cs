using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.DashBoard
{
    public class CustomCircleProgressBar: Guna2CircleProgressBar
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int totalInvoices = 100;  // إجمالي الفواتير
            int paidInvoices = 40;    // الفواتير المدفوعة
            int unpaidInvoices = 50;  // الفواتير غير المدفوعة
            int pendingInvoices = totalInvoices - (paidInvoices + unpaidInvoices); // الفواتير المعلقة

            // حساب النسب
            float paidPercentage = (float)paidInvoices / totalInvoices;
            float unpaidPercentage = (float)unpaidInvoices / totalInvoices;
            float pendingPercentage = (float)pendingInvoices / totalInvoices;

            // حساب الزوايا لكل قسم
            float paidAngle = 360f * paidPercentage;
            float unpaidAngle = 360f * unpaidPercentage;
            float pendingAngle = 360f * pendingPercentage;

            // الألوان لكل قسم
            Color[] sectionColors = { Color.Green, Color.Red, Color.Blue }; // مدفوع، غير مدفوع، معلق
            float startAngle = -90f; // بدء الرسم من الأعلى

            float[] angles = { paidAngle, unpaidAngle, pendingAngle };
            Rectangle outerCircle = new Rectangle(10, 10, Width - 20, Height - 20);

            for (int i = 0; i < 3; i++)
            {
                using (SolidBrush brush = new SolidBrush(sectionColors[i]))
                {
                    g.FillPie(brush, outerCircle, startAngle, angles[i]);
                }
                startAngle += angles[i]; // تحديث زاوية البدء للقسم التالي
            }

            // رسم دائرة أصغر في المنتصف لعمل الفراغ
            int holeSize = Width / 4; // حجم الفراغ في المنتصف كنسبة من الحجم الكلي
            Rectangle innerCircle = new Rectangle((Width - holeSize) / 2, (Height - holeSize) / 2, holeSize, holeSize);

            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                g.FillEllipse(brush, innerCircle);
            }
        }
    }
}
