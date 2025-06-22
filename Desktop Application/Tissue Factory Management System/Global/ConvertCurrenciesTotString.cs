using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Global
{
    public  static class ConvertCurrenciesTotString
    {
        private static string[] ones =
        {
        "", "واحد", "اثنان", "ثلاثة", "أربعة", "خمسة", "ستة", "سبعة", "ثمانية", "تسعة",
        "عشرة", "أحد عشر", "اثنا عشر", "ثلاثة عشر", "أربعة عشر", "خمسة عشر",
        "ستة عشر", "سبعة عشر", "ثمانية عشر", "تسعة عشر"
    };

        private static string[] tens =
        {
        "", "", "عشرون", "ثلاثون", "أربعون", "خمسون", "ستون", "سبعون", "ثمانون", "تسعون"
    };

        private static string[] thousandsGroups =
        {
        "", "ألف", "مليون", "مليار"
    };

        public static string Convert(int number)
        {
            if (number == 0)
                return "صفر";

            if (number < 0)
                return "سالب " + Convert(-number);

            StringBuilder words = new StringBuilder();

            int group = 0;

            while (number > 0)
            {
                int numberInGroup = number % 1000;

                if (numberInGroup != 0)
                {
                    string groupText = ConvertGroup(numberInGroup);

                    if (group > 0)
                    {
                        groupText += " " + thousandsGroups[group];
                    }

                    if (words.Length > 0)
                        words.Insert(0, " و ");

                    words.Insert(0, groupText);
                }

                number /= 1000;
                group++;
            }

            return words.ToString();
        }

        private static string ConvertGroup(int number)
        {
            StringBuilder groupText = new StringBuilder();

            int hundreds = number / 100;
            int remainder = number % 100;

            if (hundreds > 0)
            {
                if (hundreds == 1)
                    groupText.Append("مائة");
                else if (hundreds == 2)
                    groupText.Append("مائتان");
                else
                    groupText.Append(ones[hundreds] + " مائة");

                if (remainder > 0)
                    groupText.Append(" و ");
            }

            if (remainder > 0)
            {
                if (remainder < 20)
                    groupText.Append(ones[remainder]);
                else
                {
                    int unit = remainder % 10;
                    int ten = remainder / 10;

                    if (unit > 0)
                        groupText.Append(ones[unit] + " و ");

                    groupText.Append(tens[ten]);
                }
            }

            return groupText.ToString();
        }


    }
}
