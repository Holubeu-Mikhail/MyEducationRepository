using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodewarsTasks
{
    public static class Kata
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            var c = new ArrayList();

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[i])
                    {
                        break;
                    }
                }
            }

            return c.OfType<int>().ToArray();
        }

        public static string Disemvowel(string str)
        {
            string vowels = "aeiouAEIOU";
            str = new string(str.Where(c => !vowels.Contains(c)).ToArray());

            return str;
        }

        public static string Accum(string str)
        {
            var result = string.Empty;
            str = str.ToLower();

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0)
                    {
                        result += str[i].ToString().ToUpper();
                    }
                    else
                    {
                        result += str[i];
                    }
                }

                if (i != str.Length - 1)
                {
                    result += "-";
                }
            }

            return result;
        }

        public static string GetMiddle(string str)
        {
            var result = string.Empty;

            if (str.Length % 2 == 1)
            {
                result += str[str.Length / 2];
            }
            else
            {
                result += str[str.Length / 2 - 1];
                result += str[str.Length / 2];
            }

            return result;
        }

        public static bool IsDigit(this string str)
        {
            return Regex.IsMatch(str, "^\\d\\z");
        }

        public static string ShowWhoLikesPost(string[] name)
        {
            switch (name.Length)
            {
                case 0:
                    return "no one likes this";
                case 1:
                    return $"{name.ElementAt(0)} likes this";
                case 2:
                    return $"{name.ElementAt(0)} and {name.ElementAt(1)} like this";
                case 3:
                    return $"{name.ElementAt(0)}, {name.ElementAt(1)} and {name.ElementAt(2)} like this";
                case >3:
                    return $"{name.ElementAt(0)}, {name.ElementAt(1)} and {name.Length - 2} others like this";
                default:
                    return "No info";
            }
        }

        public static bool XO(string input)
        {
            return Regex.Matches(input, "x", RegexOptions.IgnoreCase).Count == Regex.Matches(input, "o", RegexOptions.IgnoreCase).Count;
        }

        public static bool ValidatePin(string pin)
        {
            return Regex.IsMatch(pin, @"^(\d{4}|\d{6})\z");
        }

        public static bool ValidateUsr(string username)
        {
            return Regex.IsMatch(username, @"^[a-z\d_]{4,16}$");
        }

        public static bool EightBitNumber(this string str)
        {
            return Regex.IsMatch(str, @"^([0-9]|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\z");
        }

        public static bool SixBitNumber(this string str)
        {
            return Regex.IsMatch(str, @"^([0-9]|[1-5]\d|6[0-3])\z");
        }

        public static bool IsVowel(this string s)
        {
            return Regex.IsMatch(s, @"^[aeiou]\z", RegexOptions.IgnoreCase);
        }

        public static int LowercaseCountCheck(string s)
        {
            return Regex.Matches(s, @"[a-z]").Count;
        }

        public static bool StartsWith123(string code)
        {
            return Regex.IsMatch(code, @"^[1-3]");
        }

        public static int? ToCents(this string price)
        {
            return Regex.Matches(price, @"^\$\d*\.\d{2}\z").Count == 0 ? 
                null : 
                int.Parse(Regex.Match(price, @"(?<=\$)\d*").Value) * 100 + int.Parse(Regex.Match(price, @"(?<=\.)\d*").Value);
        }

        public static int? ToSeconds(this string time)
        {
            return Regex.Matches(time, @"^\d{2}\:[0-5][0-9]\:[0-5][0-9]\z").Count == 0 ?
                null :
                int.Parse(Regex.Match(time, @"\d{2}").Value) * 3600 
                + int.Parse(Regex.Match(time, @"(?<=\:)\d{2}(?=\:)").Value) * 60 
                + int.Parse(Regex.Match(time, @"(?<=\:)\d{2}\z").Value);
}
    }
}
