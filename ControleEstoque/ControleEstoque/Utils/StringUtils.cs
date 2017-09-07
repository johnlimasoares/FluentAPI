using System;
using System.Text.RegularExpressions;

namespace ControleEstoque.Utils
{
    public static class StringUtils
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool DiferenteDeZero(this string value)
        {
            return value != "0";
        }

        public static int ToInteger(this string value)
        {
            return Convert.ToInt16(value);
        }

        public static decimal ToDecimal(this string value)
        {
            return Convert.ToDecimal(value).Round();
        }

        public static Decimal Round(this Decimal value, int decimals = 2)
        {
            return Math.Round(value, decimals);
        }

        public static string ApenasNumeros(this string value) {
            return value.Replace(",", "").Replace(".", "");
        }
    }
}
