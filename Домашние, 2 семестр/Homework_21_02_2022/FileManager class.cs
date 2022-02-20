using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Домашние__2_семестр.Homework_21_02_2022
{
    public class FileManager
    {
        public static string ReadFile(string path)
        {

            while (!File.Exists(path) || !Directory.Exists(Path.GetDirectoryName(path)) || path == null)
            {
                Console.WriteLine("Директории или файла не существует или не был введен путь к файлу.");
                path = Console.ReadLine();
            }

            return String.Join(" ", File.ReadLines(path));
        }
    }
}
