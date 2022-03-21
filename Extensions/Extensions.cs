using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Контрольная_21_03_2022
{
    public static class Extensions
    {
        public static void Print(this object source, ConsoleColor color = ConsoleColor.White)
        {
            var prevColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(source);
            Console.ForegroundColor = prevColor;
        }
    }
}
