using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Study.Homework.Homework_22_12_2021
{
    #region Пространство
    public class Vector3D
    {
        public int X, Y, Z;
        public Vector3D(int x, int y, int z)
        {
            X = x; Y = y; Z = z;
        }

        public override int GetHashCode()
        {
            return (X * Y * Z) % 10;
        }

        public override string ToString()
        {
            return $"{X}, {Y}, {Z}";
        }

        public override bool Equals(object obj)
        {
            var compare = obj as Vector3D;
            if (compare.X == X && compare.Y == Y && compare.Z == Z)
            {
                return true;
            }
            return false;
        }
    }
    #endregion

    #region Аэропорт
    public struct AEROFLOT
    {
        public string destination, plane_type;
        public int flight_number;

        public AEROFLOT(string dest, int num, string type)
        {
            destination = dest; plane_type = type; flight_number = num;
        }

        public AEROFLOT[] PlaneInput()
        {
            AEROFLOT[] flights = new AEROFLOT[7];
            for (int i = 0; i < 7; i++)
            {
                flights[i] = new AEROFLOT(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Console.ReadLine());
            }
            return flights;
        }

        public static void CheckDestination(AEROFLOT[] mas, string s)
        {
            int count = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i].destination == s)
                {
                    Console.WriteLine($"Номер самолета - {mas[i].flight_number}, тип самолета - {mas[i].plane_type}");
                    count++;
                }
            }
            if (count  == 0) { Console.WriteLine("Рейсов не найдено"); }
        }

        public static AEROFLOT[] Sort(AEROFLOT[] mas)
        {
            AEROFLOT temp;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i].flight_number > mas[j].flight_number)
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }
    }
    #endregion

    #region Поезда
    public struct Train
    {
        public string destination, dep_time;
        public int train_number;

        public Train(string dest, int num, string time)
        {
            destination = dest; dep_time = time; train_number = num;
        }

        public Train[] TrainInput()
        {
            Train[] trains = new Train[8];
            for (int i = 0; i < 8; i++)
            {
                trains[i] = new Train(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Console.ReadLine());
            }
            return trains;
        }

        public static void CheckDestination(Train[] mas, int n)
        {
            int count = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i].train_number == n)
                {
                    Console.WriteLine($"Пункт назначение - {mas[i].destination}, номер поезда - {mas[i].train_number}, время отправления - {mas[i].dep_time}");
                    count++;
                }
            }
            if (count == 0) { Console.WriteLine("Рейсов не найдено"); }
        }

        public static Train[] Sort(Train[] mas)
        {
            Train temp;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i].train_number > mas[j].train_number)
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }
    }
    #endregion

    #region Файл и дата
    public class Files
    {
        public static void FileCreate()
        {
            File.WriteAllText(@"C:\Users\79625\Desktop\filestask\task4(1)", DateTime.Now.ToString());
            File.WriteAllText(@"C:\Users\79625\Desktop\filestask\task4(2)", DateTime.Now.ToString());
            File.WriteAllText(@"C:\Users\79625\Desktop\filestask\task4(3)", DateTime.Now.ToString());
        }

        public static void FilePrint()
        {
            string[] mas_files = Directory.GetFiles(@"C:\Users\79625\Desktop\filestask");
            string newest = mas_files[0];
            foreach (string s in mas_files)
            {
                if (File.GetLastWriteTime(s) > File.GetLastWriteTime(newest))
                {
                    newest = s;
                }
            }
            Console.WriteLine(File.GetLastWriteTime(newest));
        }
    }
    #endregion

    #region Футболл
    public struct Match
    {
        public string Name; public int points; public DateTime gamedate;

        public Match(string name, int point, DateTime date)
        {
            this.Name = name; this.points = point; this.gamedate = date;
        }

        public static void Print(Match[] matches)
        {
            for (int i = 0; i < matches.Length; i++)
            {
                Console.WriteLine($"{matches[i].Name}, {matches[i].gamedate}, {matches[i].points}");
            }
        }
    }

    class MatchManager
    {
        public static Match[] FileRead()
        {
            string[] lines = File.ReadAllLines(@"C:\git\Homework\Homework_22_12_2021\футбол.txt");
            Match[] matches = new Match[lines.Length];

            for (int i = 0; i < matches.Length; i++)
            {
                string[] line = lines[i].Split(' ');
                string[] date = line[1].Split('.');
                matches[i] = new Match(line[0], Convert.ToInt32(line[2]), new DateTime(Convert.ToInt32(date[0]), Convert.ToInt32(date[1]), Convert.ToInt32(date[2]), Convert.ToInt32(date[3]), Convert.ToInt32(date[4]), Convert.ToInt32(date[5])));
            }
            return matches;
        }

        public static void FoundLeafer(DateTime a, DateTime b, Match[] matches)
        {
            Match[] periodmatch = new Match[matches.Length];
            Console.WriteLine("В данный период играли команды: ");
            for (int i = 0; i < matches.Length; i++)
            {
                if (a < matches[i].gamedate && matches[i].gamedate < b)
                {
                    periodmatch[i] = matches[i];
                    Console.WriteLine($"{matches[i].Name}");
                }
            }
            Console.WriteLine($"Победила команда {periodmatch[periodmatch.Length - 1].Name}");
        }

        public static Match[] Sort(Match[] matches)
        {
            Match temp;
            for (int i = 0; i < matches.Length - 1; i++)
            {
                for (int j = i + 1; j < matches.Length; j++)
                {
                    if (matches[i].points > matches[j].points)
                    {
                        temp = matches[i];
                        matches[i] = matches[j];
                        matches[j] = temp;
                    }
                }
            }
            return matches;
        }
    }
    #endregion

    #region Экзамены
    public struct Exam
    {
        public string Name; public DateTime Examdate;

        public Exam(string name, DateTime date)
        {
            this.Name = name; this.Examdate = date;
        }

        public static void Print(List<Exam> exams)
        {
            for (int i = 0; i < exams.Count; i++)
            {
                Console.WriteLine($"{exams[i].Name}, {exams[i].Examdate}");
            }
        }
    }

    class ExamManager
    {
        public static Exam[] FileRead()
        {
            string[] lines = File.ReadAllLines(@"C:\git\Homework\Homework_22_12_2021\Экзамены.txt");
            Exam[] exams = new Exam[lines.Length];

            for (int i = 0; i < exams.Length; i++)
            {
                string[] line = lines[i].Split(' ');
                string[] date = line[1].Split('.');
                exams[i] = new Exam(line[0], new DateTime(Convert.ToInt32(date[0]), Convert.ToInt32(date[1]), Convert.ToInt32(date[2]), Convert.ToInt32(date[3]), Convert.ToInt32(date[4]), Convert.ToInt32(date[5])));
            }
            return exams;
        }

        public static List<Exam> Table(Exam[] exams)
        {
            List<Exam> examsTable = new List<Exam>();
            List<DateTime> dates = new List<DateTime>();
            for (int i = 0; i < exams.Length; i++)
            {
                if (dates.Contains(exams[i].Examdate))
                {
                    while (dates.Contains(exams[i].Examdate))
                    {
                        var nedate = exams[i].Examdate.AddDays(1);
                        exams[i].Examdate = nedate;
                    }
                    examsTable.Add(exams[i]);
                    dates.Add(exams[i].Examdate);
                }
                else
                {
                    dates.Add(exams[i].Examdate);
                    examsTable.Add(exams[i]);
                }
            }
            return examsTable;
        }

        public static List<Exam> Sort(List<Exam> exams)
        {
            Exam temp;
            for (int i = 0; i < exams.Count - 1; i++)
            {
                for (int j = i + 1; j < exams.Count; j++)
                {
                    if (exams[i].Examdate > exams[j].Examdate)
                    {
                        temp = exams[i];
                        exams[i] = exams[j];
                        exams[j] = temp;
                    }
                }
            }
            return exams;
        }

    }
    #endregion
}