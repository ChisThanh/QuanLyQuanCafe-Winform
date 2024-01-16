using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom9_QuanLyQuanCafe.Helpers
{
    public static class Hp
    {
        public static string GetLastWord(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }

            int lastSpaceIndex = input.LastIndexOf(' ');

            if (lastSpaceIndex != -1)
            {
                return input.Substring(lastSpaceIndex + 1);
            }
            else
            {
                return input;
            }
        }

        public static string FormatCurrency(int amount)
        {
            if (amount >= 1000000000)
            {
                double trillions = amount / 1000000000.0;
                return trillions.ToString("0.##") + "Tỉ";
            }
            else if (amount >= 1000000)
            {
                double trillions = amount / 1000000.0;
                return trillions.ToString("0.##") + "Tr";
            }
            else if (amount >= 1000)
            {
                double thousands = amount / 1000.0;
                return thousands.ToString("0.##") + "K";
            }
            else
            {
                return amount + " VND";
            }
        }
    }
}
