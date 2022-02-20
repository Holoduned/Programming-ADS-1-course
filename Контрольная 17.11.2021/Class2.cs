using System;

namespace Study.NewFolder2
{
    public class Desk
    {
        public int TaskCount { get; set; } 
        int[] marks { get; set; }


        public Desk(int n)
        {
            TaskCount = n;
            marks = new int[n];
            Mark();
        }
        public void WorkAtDesk(Student[] input)
        {
            Random random = new Random();
            for (int i = 0; i < marks.Length; i++)
            {
                Student studentDesk = input[random.Next(input.Length)];
                studentDesk.Mark = marks[i];
                studentDesk.GetInfoStudent();
            }
        }

        public void Mark()
        {
            for (int i = TaskCount - 1; i > 0; i--)
            {
                Random random = new Random();
                marks[i] = random.Next(1, 5);
            }
        }
    }

    public class Student
    {
        public string Name, Surname, Patronymic; 
        public int Mark;

        public Student(string name, string surname, string patronymic)
        {
            Name = name; Surname = surname; Patronymic = patronymic;
        }

        public void GetInfoStudent()
        {
            Console.WriteLine($"ФИО студента: {Name} {Surname} {Patronymic}");
            Console.WriteLine($"Оценка студента за выход к доске: {Mark}");
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
                Console.WriteLine();

                students[i] = new Student(name, surname, patronymic);
            }

            return students;
        }
    }
}
