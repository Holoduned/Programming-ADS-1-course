using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Homework_24_11_2021
{
    #region Accomodation
    public class Accommodation
    {
        public int cost, min_rentalDuration, max_rentalDuration;
        public string prepaidRequired; public string[] prepaid = { "Требуется", "Не требуется" };
        public bool isoccupied;
        public Accommodation(int c, int min_r, int max_r, string prepaid, bool occupied = false)
        {
            cost = c;
            min_rentalDuration = min_r; max_rentalDuration = max_r;
            prepaidRequired = prepaid; isoccupied = occupied;
        }

        public void Populate()
        {
            isoccupied = true;
        }

        public void Evict()
        {
            isoccupied = false;
        }
    }

    public class Hotel : Accommodation
    {
        string[] type = {"Одноместный", "Двухместный", "Семейный"};
        string[] nutrition_type = { "Завтраки", "Полный день" };

        public int room_Number;
        public string room_type, nutrition;

        public Hotel(int c = 0, int min_r = 0, int max_r = 0, string prepaid = "", int number = 0, string rType = "", string food_type = "")
            : base(c, min_r, max_r, prepaid)
        {
            room_Number = number; room_type = rType; nutrition = food_type; 
        }

        public Hotel CreateHotel()
        {
            Random random = new Random();
            return new Hotel(random.Next(4000, 20000), random.Next(1, 3), random.Next(8, 16), prepaid[random.Next(0, 2)], random.Next(1, 1000), type[random.Next(0, 3)], nutrition_type[random.Next(0, 2)]);
        }

        public void PrintHotel()
        {
            Console.WriteLine("Данные об отеле:");
            Console.WriteLine($"Стоимость проживания: {cost}");
            Console.WriteLine($"Минимальная длительность проживания - {min_rentalDuration}, Максимальная - {max_rentalDuration}");
            Console.WriteLine($"Требуется ли предоплата? {prepaidRequired}");
            Console.WriteLine($"Тип номера: {room_type}");
            Console.WriteLine($"Номер комнаты: {room_Number}");
            Console.WriteLine($"Тип питания: {nutrition}");
            Console.WriteLine($"Заселен?: {isoccupied}");
        }
    }

    public class Rental : Accommodation
    {
        string[] type = { "Включено", "Не включено" };
        string[] rent_type = { "Комната", "Дом" };

        public string rental_type, cleaning, internet, sec_keys;
        public Rental(int c = 0, int min_r = 0, int max_r = 0, string prepaid = "", string r_type = "", string clean = "", string inet = "", string keys = "")
            : base(c, min_r, max_r, prepaid)
        {
            rental_type = r_type; cleaning = clean; internet = inet; sec_keys = keys; 
        }

        public Rental CreateRental()
        {
            Random random = new Random();
            return new Rental(random.Next(4000, 40000), random.Next(1, 5), random.Next(10, 28), prepaid[random.Next(0, 2)], rent_type[random.Next(0, 2)], type[random.Next(0, 2)], type[random.Next(0, 2)], type[random.Next(0, 2)]);
        }

        public void PrintRental()
        {
            Console.WriteLine("Данные о съемном жилье:");
            Console.WriteLine($"Стоимость проживания: {cost}");
            Console.WriteLine($"Минимальная длительность проживания - {min_rentalDuration}, Максимальная - {max_rentalDuration}");
            Console.WriteLine($"Требуется ли предоплата? {prepaidRequired}");
            Console.WriteLine($"Тип жилья: {rental_type}");
            Console.WriteLine($"Услуга уборки: {cleaning}");
            Console.WriteLine($"Услуга интернет: {internet}");
            Console.WriteLine($"Услуга вторые ключи: {sec_keys}");
            Console.WriteLine($"Заселен?: {isoccupied}");
        }
    }
    #endregion

    #region Triangle
    public class Triangle
    {
        private int a, b, c;
        
        public int A
        {
            set { a = NumCheck(value); }
            get { return a; }
        }
        public int B
        {
            set { b = NumCheck(value); }
            get { return b; }
        }
        public int C
        {
            set { c = NumCheck(value); }
            get { return c; }
        }

        public double alpha, beta, gamma, square;
        public Triangle(int a, int b, int c)
        {
            A = a; B = b; C = c;
            Corner(A, B, C);
        }

        public int NumCheck(int n)
        {
            if (n < 0)
            {
                return n * -1;
            }

            return n;
        }

        public void Corner(int a, int b, int c)
        {
            alpha = Math.Acos((b * b + c * c - a * a) / (Convert.ToDouble(2 * b * c))) * 180 / Math.PI; 
            beta = Math.Acos((a * a + c * c - b * b) / (Convert.ToDouble(2 * a * c))) * 180 / Math.PI;
            gamma = Math.Acos((b * b + a * a - c * c) / (Convert.ToDouble(2 * b * a))) * 180 / Math.PI;
        }

        public double Square(int a, int b, double gamma)
        {
            return 0.5 * a * b * Math.Sin(gamma);
        }

        public double Square(int a, int b)
        {
            return 0.5 * a * b;
        }

        public void PrintTriangle()
        {
            Console.WriteLine($"Стороны треугольника равны: {a}, {b}, {c} ");
            Console.WriteLine($"Угол напротив стороны {a} - {alpha}, стороны {b} - {beta}, стороны {c} - {gamma}");
        }
    }

    public class IsoscelesTriangle : Triangle
    {
        public int high;
        public double square_isosceles;
        public IsoscelesTriangle(int a, int b, int c, int h)
            :base(a, b, c)
        {
            high = h;
            square_isosceles = Square(a, h);
        }
    }

    public class RectangularTriangle : Triangle
    {
        public double square_rectangular;
        public RectangularTriangle(int a, int b, int c)
            : base(a, b, c)
        {
            square_rectangular = Square(a, b, gamma);
        }


    }
    #endregion
}
