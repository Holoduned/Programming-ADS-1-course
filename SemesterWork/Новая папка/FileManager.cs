using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterWork
{
    public class FileManager
    {
        public static void DataGeneration()
        {
            var random = new Random();
            int DataCount = new Random().Next(50, 100);
            string[] Data = new string[DataCount];

            for (int data = 0; data < DataCount; data++)
            {
                int VertexCount = new Random().Next(100, 1000);
                int EdgeCount = new Random().Next(0, VertexCount * (VertexCount - 1) / 2);
                Console.WriteLine(data);
                var sb = new StringBuilder();
                for (int i = 0; i < EdgeCount; i++)
                {
                    sb.Append(new Random().Next(1, VertexCount) + " " + new Random().Next(1, VertexCount) + " " + new Random().Next(1, 100) + ",");
                }
                Data[data] = sb.ToString();
            }

            File.WriteAllLines(@"C:\Users\79625\Desktop\файлики семестровка\new.txt", Data);

        }
    }
}
