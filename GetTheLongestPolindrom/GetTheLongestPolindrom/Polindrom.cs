using System;
using System.Collections.Generic;
using System.Linq;

namespace GetTheLongestPolindrom
{
    static class Polindrom
    {
        static List<string> ToSubstrings(string str)
        {
            List<string> arrayStrs = new List<string>();

            for (var i = 0; i < str.Length; i++)
            {
                var charToString = str[i].ToString();
                string value = charToString;
                arrayStrs.Add(charToString);

                for (var j = i; j < str.Length; j++)
                {
                    if (j == i)
                        continue;

                    value = value + str[j];
                    arrayStrs.Add(value);
                }

            }

            return arrayStrs;
        }

        public static string GetLongestPolindrom(this List<string> polindroms)
        {
            var length = polindroms.Max(s => s.Length);
            return polindroms.FirstOrDefault(s => s.Length == length);
        }

        public static string GetPolindrom(this string initialStr)
        {
            List<string> polindroms = new List<string>();
            var list = ToSubstrings(initialStr);
            var newValue = String.Empty;

            for (var i = 0; i < list.Count; i++)
            {
                var item = list[i];
                var reverse = item.Reverse().ToList();
                var isPolindrom = true;

                for (var j = 0; j < item.Length; j++)
                {
                    if (item[j] != reverse[j])
                    {
                        isPolindrom = false;
                    }
                }

                if (isPolindrom)
                {
                    polindroms.Add(item);
                }
            }

            return GetLongestPolindrom(polindroms);
        }
    }
}
