using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Homework.Homework_01__12_2021
{
    public static class Method
    {
        public static int Check(int input)
        {
            if (input < 0)
            {
                return 0;
            }
            return input;
        }
    }
    public abstract class Decoration_object
    {
        private int Square, Num_Out;
        public int square
        {
            get
            { 
                return Square;
            }

            set
            {
                Square = Method.Check(value);
            }
        }
        

        public int number_outlets
        {
            get
            {
                return Num_Out;
            }

            set
            {
                Num_Out = Method.Check(value);
            }
        }
        public Decoration_object(int sq, int outl)
        {
            square = sq; number_outlets = outl;
        }
    }

    public class ChristmasTree : Decoration_object
    {
        private int Height;

        public int height
        {
            get
            {
                return Height;
            }

            set
            {
                Height = Method.Check(value);
            }
        }

        public ChristmasTree(int square, int outlet, int heig)
            : base(square, outlet)
        {
            height = heig;
        }

        public void PrintTree()
        {
            Console.WriteLine($"Площадь ёлки: {square} ");
            Console.WriteLine($"Количество розеток: {number_outlets} ");
            Console.WriteLine($"Высота ёлки: {height} ");
        }
    }

    public class Showcase : Decoration_object
    {
        public Showcase(int square, int outlet)
            :base(square, outlet)
        {

        }

        public void PrintShowcase()
        {
            Console.WriteLine($"Площадь витрины: {square} ");
            Console.WriteLine($"Количество розеток: {number_outlets} ");
        }
    }
    public abstract class Decoration
    {
        private int Square, Outlet;
        public int square
        {
            get
            {
                return Square;
            }

            set
            {
                Square = Method.Check(value);
            }
        }


        public int outlet_need
        {
            get
            {
                return Outlet;
            }

            set
            {
                Outlet = Method.Check(value);
            }
        }

        public Decoration(int sq, int outl)
        {
            Square = sq; Outlet = outl;
        }
    }

    public class Garland : Decoration
    {
        private int num_colors, num_mode;
        public bool stock = true;
        public int number_colors
        {
            get
            {
                return num_colors;
            }

            set
            {
                num_colors = Method.Check(value);
            }
        }

        public int number_mode
        {
            get
            {
                return num_mode;
            }

            set
            {
                num_mode = Method.Check(value);
            }
        }

        public Garland(int square, int outlet, int num_col, int num_mod)
            :base(square, outlet)
        {
            number_colors = num_col;
            num_mode = num_mod;
        }

        public static Garland[] InputGarland(int n)
        {
            Garland[] mas = new Garland[n];
            for (int i = 0; i < n; i++)
            {
                mas[i] = new Garland(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            }
            return mas;
        }

        public static void PrintGarland(Garland n)
        {
            Console.WriteLine($"Место, занимаемое гирляндой - {n.square}, использовано - {!n.stock}");
        }
    }

    public class Toy : Decoration
    {
        private int Weight, Fragility;
        public bool stock = true;
        public int weight
        {
            get
            {
                return Weight;
            }

            set
            {
                Weight = Method.Check(value);
            }
        }


        public int fragility
        {
            get
            {
                return Fragility;
            }

            set
            {
                Fragility = Method.Check(value);
            }
        }

        public Toy(int square, int outlet, int weig, int fri)
            : base(square, outlet)
        {
            weight = weig;
            fragility = fri;
        }

        public static Toy[] InputToy(int n)
        {
            Toy[] mas = new Toy[n];
            for (int i = 0; i < n; i++)
            {
                mas[i] = new Toy(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            }
            return mas;
        }

        public static void PrintToy(Toy n)
        {
            Console.WriteLine($"Место, занимаемое игрушкой - {n.square}, использовано - {!n.stock}");
        }
    }

    public class DecorationProcess
    {
        public void DecorationTree(ChristmasTree input, Garland[] mas, Toy[] mass)
        {
            mass = Sort(mass);
            mas = Sort(mas);
            int outlet_num = input.number_outlets; int garland_num = mas.Length; int toy_num = mass.Length;
            while (input.square > 0 && (toy_num > 0 || garland_num > 0))
            {
                if (outlet_num > 0 && garland_num > 0)
                {
                    if (input.square - mas[garland_num - 1].square >= 0)
                    {
                        input.square -= mas[garland_num - 1].square;
                        mas[garland_num - 1].stock = false;
                        Garland.PrintGarland(mas[garland_num - 1]);
                        outlet_num -= 1;
                        garland_num -= 1;
                    }
                    else if (input.square - mass[toy_num - 1].square >= 0)
                    {
                        input.square -= mass[toy_num - 1].square;
                        mass[toy_num - 1].stock = false;
                        Toy.PrintToy(mass[toy_num - 1]);
                        toy_num -= 1;
                        outlet_num -= 1;
                        garland_num -= 1;  
                    }
                }
                else
                {
                    if (toy_num - 1 >= 0)
                    {
                        if (input.square - mass[toy_num - 1].square >= 0)
                        {
                            input.square -= mass[toy_num - 1].square;
                            mass[toy_num - 1].stock = false;
                            Toy.PrintToy(mass[toy_num - 1]);
                            toy_num -= 1;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }

        public void DecorationShowCase(Showcase input, Garland[] mas, Toy[] mass)
        {
            mass = Sort(mass);
            mas = Sort(mas);
            int outlet_num = input.number_outlets; int garland_num = mas.Length; int toy_num = mass.Length;
            while (input.square > 0 && (toy_num > 0 || garland_num > 0))
            {
                if (outlet_num > 0 && garland_num > 0)
                {
                    if (input.square - mas[garland_num - 1].square >= 0)
                    {
                        if (mas[garland_num - 1].stock)
                        {
                            input.square -= mas[garland_num - 1].square;
                            mas[garland_num - 1].stock = false;
                            Garland.PrintGarland(mas[garland_num - 1]);
                            outlet_num -= 1;
                            garland_num -= 1;
                        }
                        else
                        {
                            garland_num -= 1;
                        }

                    }
                    else if (input.square - mass[toy_num - 1].square >= 0)
                    {
                        if (mas[toy_num - 1].stock)
                        {
                            input.square -= mass[toy_num - 1].square;
                            mas[toy_num - 1].stock = false;
                            Toy.PrintToy(mass[toy_num - 1]);
                            toy_num -= 1;
                            outlet_num -= 1;
                            garland_num -= 1;
                        }
                        else
                        {
                            garland_num -= 1;
                        }
                    }
                }
                else
                {
                    if (toy_num - 1 >= 0)
                    {
                        if (input.square - mass[toy_num - 1].square >= 0)
                        {
                            if (mass[toy_num - 1].stock)
                            {
                                input.square -= mass[toy_num - 1].square;
                                mass[toy_num - 1].stock = false;
                                Toy.PrintToy(mass[toy_num - 1]);
                                toy_num -= 1;
                            }
                            else
                            {
                                toy_num -= 1;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }

        public Toy[] Sort(Toy[] mas)
        {
            Toy temp;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i].square < mas[j].square)
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }
        public Garland[] Sort(Garland[] mas)
        {
            Garland temp;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i].square < mas[j].square)
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


}
