using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HelperClasses
{
    public static class StringFunctions
    {
        private const string defaultPattern = "[^-a-zA-ZÀÁÂÃÄÅÇÈÉÊËÌÍÎÏÑÒÓÔÕÖÙÚÛÜÝàáâãäåçèéêëìíîïðòóôõöùúûüýÿñ£$%&! ,./0-9:=\\#()]";

        public static string DefaultPattern => defaultPattern;

        public static string CleanString(string expression, string replace)
        {
            return CleanString(expression, replace, defaultPattern);
        }

        public static string CleanString(string expression, string replace, string pattern)
        {
            if (string.IsNullOrEmpty(expression) || string.IsNullOrEmpty(replace))
            {
                return string.Empty;
            }
            Regex regex = new Regex(pattern);

            return regex.Replace(expression, replace);
        }
    }
}
