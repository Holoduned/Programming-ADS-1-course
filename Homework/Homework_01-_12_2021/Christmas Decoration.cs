//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Study.Homework.Homework_01__12_2021
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var XMasTree = new ChristmasTree(40, 10, 3);
//            XMasTree.PrintTree();


//            var showcase = new Showcase(20, 10);
//            showcase.PrintShowcase();


//            var garland_1 = new Garland(21, 1, 1, 1);
            
//            var garland_2 = new Garland(7, 1, 1, 1);
//            var garland_3 = new Garland(4, 1, 1, 1);

//            Garland[] garlands = new Garland[] { garland_1, garland_2, garland_3 };


//            var toy_1 = new Toy(5, 1, 1, 1);
//            var toy_2 = new Toy(19, 1, 1, 1);
//            var toy_3 = new Toy(1, 1, 1, 1);


//            Toy[] toys = new Toy[] { toy_1, toy_2, toy_3 };

//            var decor = new DecorationProcess();
//            Console.WriteLine("Декорирование ёлки: ");
//            decor.DecorationTree(XMasTree, garlands, toys);
//            Console.WriteLine("Декорирование витрины, используя неиспользованные игрушки и гирлянды:");
//            decor.DecorationShowCase(showcase, garlands, toys);

//            Console.ReadKey();


//        }
//    }
//}
