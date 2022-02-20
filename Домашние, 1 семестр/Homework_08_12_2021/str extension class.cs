using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Homework.Homework_08_12_2021
{
    public static class StringExtension
    {
        public static string StringAdd(this string s, string s2)
        {
            string[] string1 = s.Split(' '); string[] string2 = s2.Split(' ');
            string[] res_string = new string[Math.Max(s.Length, s2.Length)];

            if (string1.Length == string2.Length)
            {
                for (int i = 0; i < string1.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        res_string[i] = string1[i];
                    }
                    else
                    {
                        res_string[i] = string2[i];
                    }
                }
            }
            else if (string1.Length > string2.Length)
            {
                for (int i = 0; i < string2.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        res_string[i] = string1[i];
                    }
                    else
                    {
                        res_string[i] = string2[i];
                    }
                    }
                for (int i = string2.Length + 1; i <= string1.Length; i++)
                {
                    res_string[i] = string1[i - 1];
                }
            }

            else if (string2.Length > string1.Length)
            {
                for (int i = 0; i < string1.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        res_string[i] = string1[i];
                    }
                    else
                    {
                        res_string[i] = string2[i];
                    }
                }
                for (int i = string1.Length + 1; i <= string2.Length; i++)
                {
                    res_string[i] = string2[i - 1];
                }
            }

            return String.Join(" ", res_string);
        }
    }
}
