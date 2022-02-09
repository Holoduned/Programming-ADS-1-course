using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Homework.Homework_27_10_2021
{
    #region №1 класс студент
    public class Student
    {
        public string Name, Surname, Patronymic, DayOfBirth, Performance, SNOaffiliation;
        public int Group;

        public Student(string name, string surname, string patronymic, string dob, int group, string APerformance, string affiliation)
        {
            Name = name; Surname = surname; Patronymic = patronymic; DayOfBirth = dob; Group = group;
            Performance = APerformance; SNOaffiliation = affiliation;
        }

        public void GetInfo()
        {
            Console.WriteLine($"ФИО студента: {Name} {Surname} {Patronymic}");
            Console.WriteLine($"Дата рождения студента: {DayOfBirth}");
            Console.WriteLine($"Номер группы студента: {Group}");
            Console.WriteLine($"Успеваемость студента: {Performance}");
            Console.WriteLine($"Принадлежность студента к СНО: {SNOaffiliation}");
        }

        public static Student[] InputInfo(int n)
        {
            Student[] students = new Student[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите имя студента: ");
                string name = Console.ReadLine();
                Console.Write("Введите фамилию студента: ");
                string surname = Console.ReadLine();
                Console.Write("Введите отчество студента: ");
                string patronymic = Console.ReadLine();
                Console.Write("Введите дату рождения студента: ");
                string dob = Console.ReadLine();
                Console.Write("Введите номер группы студента: ");
                int group = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите успеваемость студента: ");
                string performance = Console.ReadLine();
                Console.Write("Введите принадлежность студента к СНО: ");
                string affiliation = Console.ReadLine();
                Console.WriteLine();

                students[i] = new Student(name, surname, patronymic, dob, group, performance, affiliation);
            }

            return students;
        }
    }
    #endregion

    #region №2 Класс окружность
    public class Circle
    {
        public int radius, diameter;
        double square, perimeter;

        public Circle(int r)
        {
            radius = r; diameter = radius * 2; square = Square(); perimeter = Perimeter();
        }

        public double Square()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double Perimeter()
        {
            return Math.PI * diameter;
        }

        public void Info()
        {
            Console.WriteLine($"Радиус круга: {radius}");
            Console.WriteLine($"Диаметр круга: {diameter}");
            Console.WriteLine($"Периметр круга равен: {perimeter}");
            Console.WriteLine($"Площадь круга равна: {square}");
        }

        public static Circle[] InputInfo(int n)
        {
            Circle[] circles = new Circle[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите радиус круга: ");
                int R = Convert.ToInt32(Console.ReadLine());
                circles [i] = new Circle(R);
            }

            return circles;
        }

    }
    #endregion

    #region Класс длинной арифметики

    public class BigNumber
    {
        char[] number, number_two;
        string plus, minus, multiplication;
        bool Positive = true;

        public BigNumber(string n, string n_2)
        {
            if (Convert.ToInt32(n_2) > Convert.ToInt32(n))
            {
                (n, n_2) = (n_2, n);
                Positive = false;
            }

            if (n.Length > n_2.Length)
            {
                number = n.ToCharArray();
                number_two = new char[n.Length];
                for (int i = 0; i < n.Length; i++)
                {
                    if (n_2.Length - 1 >= i)
                    {
                        number_two[n.Length - 1 - i] = n_2[n.Length - i - 2];
                    }
                    else
                    {
                        number_two[n.Length - 1 - i] = '0';
                    }
                }

            }
            else if (n_2.Length > n.Length)
            {
                number_two = n_2.ToCharArray();
                number = new char[n_2.Length];
                for (int i = 0; i < n_2.Length; i++)
                {
                    if (n.Length - 1 >= i)
                    {
                        number[n_2.Length - 1 - i] = n[n_2.Length - i - 2];
                    }
                    else
                    {
                        number[n_2.Length - 1 - i] = '0';
                    }
                }
            }
            else
            {
                number = n.ToCharArray();
                number_two = n_2.ToCharArray();
            }

            Array.Reverse(number);
            Array.Reverse(number_two);
            plus = Plus();
            minus = Minus();
            multiplication = Multi();
        }

        public void Inf()
        {
            Console.WriteLine($"Результат сложения чисел: {plus}");
            Console.WriteLine($"Результат вычитания чисел: {minus}");
            Console.WriteLine($"Результат умножения чисел: {multiplication}");
        }

        public string Plus()
        {
            int max_lenght = Math.Max(number.Length, number_two.Length);
            int[] result = new int[max_lenght + 1];

            for (int i = 0; i < max_lenght; i++)
            {
                int sum = Convert.ToInt32(number[i].ToString()) + Convert.ToInt32((number_two[i].ToString()));
                result[i] += sum % 10;
                result[i + 1] += sum / 10;
            }

            Array.Reverse(result);
            result = Slice(result);
            if (Positive)
            {

            }
            return String.Join("", result);

        }

        public string Minus()
        {
            int max_lenght = Math.Max(number.Length, number_two.Length);
            int[] result = new int[max_lenght];

            for (int i = 0; i < max_lenght; i++)
            {
                int diff = (result[i] + Convert.ToInt32(number[i].ToString())) - Convert.ToInt32((number_two[i].ToString()));
                if (diff < 0)
                {
                    result[i] += 10 - number_two[i] + number[i];
                    result[i + 1] = -1;
                }
                else if (diff  >= 0 && result[i] < 0)
                {
                    result[i] = diff;
                }
                else
                {
                    result[i] += diff;
                }

            }

            Array.Reverse(result);
            result = Slice(result);
            if (!Positive)
            {
                return "-" + String.Join("", result);
            }
            return String.Join("", result);
        }

        public string Multi()
        {
            int max_lenght = Math.Max(number.Length, number_two.Length) * 2;
            int[] result = new int[max_lenght];

            for (int i = 0; i < number.Length; i++)
            {
                for (int j = 0; j < number_two.Length; j++)
                {
                    int mult = Convert.ToInt32(number[i].ToString()) * Convert.ToInt32((number_two[j].ToString()));
                    result[i + j] += mult;
                }
            }
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] > 9)
                {
                    result[i + 1] += result[i] / 10;
                    result[i] = result[i] % 10;
                }
            }

            Array.Reverse(result);
            result = Slice(result);
            return String.Join("", result);
        }

        private int[] Slice(int[] n)
        {
            if (n[0] == 0)
            {
                int[] a = new int[n.Length - 1];
                for (int i = 1; i < n.Length; i++) { a[i - 1] = n[i]; }
                return a;
            }
            return n;
        }
    }
    #endregion



}
