//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;

//namespace Study.Контрольная_15_12_2021
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var technic1 = new KitchenTechnic("Холодильник", "LG", "A", 800, "Встраиваемая");
//            var technic2 = new KitchenTechnic("Духовой шкаф", "Hansa", "B", 600, "Не встраиваемая");
//            var technic3 = new KitchenTechnic("Микроволновая печь", "Samsung", "C", 300, "Встраиваемая");

//            Console.WriteLine(technic1.GetHashCode());
//            Console.WriteLine(technic1.ToString());
//            Console.WriteLine(technic1.Equals(technic2));

//            var queue = new Queue();
//            queue.Add(technic1);
//            queue.Add(technic2);
//            var queueClone = (Queue)queue.Clone();
//            queue.Add(technic3);
//            queueClone.Add(technic1);

//            queueClone.QueuePrint();
//            Console.WriteLine("");
//            queue.QueuePrint();
//            Console.WriteLine("");

//            queue.Read().Installation();
//            queue.Read().Installation();

//            var technicRenovation = queue.Read();
//            var file = new StreamWriter(@"C:\Users\79625\Desktop\filestask\txt.txt", true);
//            file.Write($"Стоимость ремонта {technicRenovation.Name} производителя {technicRenovation.Manufacturer} равна {technicRenovation.Renovation()}");
//            file.Dispose();
//        }
//    }
//}
