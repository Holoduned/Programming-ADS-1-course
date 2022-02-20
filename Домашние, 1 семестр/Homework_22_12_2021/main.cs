//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;

//namespace Study.Homework.Homework_22_12_2021
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var a = new Vector3D(4, 6, 8);
//            var b = new Vector3D(4, 5, 6);
//            Console.WriteLine(a.GetHashCode());
//            Console.WriteLine(a.ToString());
//            Console.WriteLine(a.Equals(b));

//            Console.WriteLine("Введите данные о самолете в формате 'пункт - номер - тип'");
//            var airport = new AEROFLOT().PlaneInput();
//            AEROFLOT.Sort(airport);
//            Console.WriteLine("Введите нужный пункт назначения");
//            string destination = Console.ReadLine();
//            AEROFLOT.CheckDestination(airport, destination);

//            Console.WriteLine("Введите данные о поезде в формате 'пункт - номер - время'");
//            var train_station = new Train().TrainInput();
//            Train.Sort(train_station);
//            Console.WriteLine("Введите нужный номер поезда");
//            int n = Convert.ToInt32(Console.ReadLine());
//            Train.CheckDestination(train_station, n);

//            Files.FileCreate();
//            Files.FilePrint();

//            var matches = MatchManager.FileRead();
//            Match.Print(matches);
//            DateTime begin = new DateTime(2021, 10, 10);
//            DateTime end = new DateTime(2021, 10, 15);
//            MatchManager.Sort(matches);
//            MatchManager.FoundLeafer(begin, end, matches);

//            var exams = ExamManager.FileRead();
//            var listexams = exams.ToList();
//            listexams = ExamManager.Sort(listexams);
//            Exam.Print(listexams);
//            var listexamsarr = listexams.ToArray(); 
//            listexams = ExamManager.Table(listexamsarr);
//            Exam.Print(listexams);

//            Console.ReadKey();
//        }
//    }
//}
