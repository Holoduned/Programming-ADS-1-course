using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Homework.Homework_08_12_2021
{
    public interface IComparable
    {
        int CompareTo(object o);
    }

    class ComplexNumber : ICloneable
    {
        public double real; double imaginary; double module; double arg;

        public ComplexNumber(double real_num, double imag_num)
        {
            real = real_num; imaginary = imag_num;
        }

        public object Clone()
        {
            return new ComplexNumber(real = this.real, imaginary = this.imaginary);
        }

        public ComplexNumber Addition(ComplexNumber input)
        {
            return new ComplexNumber(real + input.real, imaginary + input.imaginary);
        }

        public ComplexNumber Substraction(ComplexNumber input)
        {
            return new ComplexNumber(real - input.real, imaginary - input.imaginary);
        }

        public ComplexNumber ComplexMultiplication(ComplexNumber input)
        {
            return new ComplexNumber(real * input.real - imaginary * input.imaginary, real * input.imaginary + imaginary * input.real);
        }

        public ComplexNumber Multiplication(double n)
        {
            return new ComplexNumber(real * n, imaginary * n);
        }

        public ComplexNumber Division(ComplexNumber input)
        {
            return new ComplexNumber((real * input.real + imaginary * input.imaginary) / (Math.Pow(input.real, 2) + Math.Pow(input.imaginary, 2)),
                (imaginary * input.real - real * input.imaginary) / (Math.Pow(input.real, 2) + Math.Pow(input.imaginary, 2)));
        }

        public double Length()
        {
            module = Math.Sqrt(real * real + imaginary * imaginary);
            return module;
        }

        public double Arg()
        {
            arg = Math.Atan(imaginary / real);
            return arg;
        }


        public void ToString()
        {
            if (real == 0 && imaginary != 0)
            {
                Console.WriteLine($"{imaginary}i");
            }
            else if (real != 0 && imaginary == 0)
            {
                Console.WriteLine(real);
            }
            else if (real == 0 && imaginary == 0)
            {
                Console.WriteLine(0);
            }
            else if (imaginary > 0)
            {
                Console.WriteLine($"{real} + {imaginary}i");
            }
            else
            {
                Console.WriteLine($"{real}{imaginary}i");
            }
        }

        public bool Comparison(ComplexNumber input)
        {
            if (real == input.real && imaginary == input.imaginary) return true;
            return false;
        }

        public ComplexNumber Pow(double n)
        {
            if (n == 0)
            {
                return new ComplexNumber(0, 0);
            }
            else
            {
                return new ComplexNumber(Math.Pow(module, n) * Math.Cos(n * arg), Math.Pow(module, n) * Math.Sin(n * arg));
            }
        }
    }

    class RationalFraction : IComparable
    {
        public int numenator, denumenator;
        public int CompareTo(object o)
        {
            RationalFraction fraction = o as RationalFraction;
            if (fraction != null)
                return this.numenator.CompareTo(fraction.numenator);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    

        public RationalFraction(int num, int denum)
        {
            numenator = num; denumenator = denum;
            if (denumenator == 0)
            {
                throw new DivideByZeroException();
            }
        }



        public void Reduce()
        {
            int count = 0;
            int a = Math.Abs(numenator); int b = Math.Abs(denumenator); int nod = 0;
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
                count++;
            }
            nod = a + b; numenator /= nod; denumenator /= nod;
        }

        public RationalFraction Addition(RationalFraction input)
        {
            if (denumenator == input.denumenator)
            {
                return new RationalFraction(numenator + input.numenator, denumenator);
            }
            else
            {
                return new RationalFraction(numenator * input.denumenator + input.numenator * denumenator, denumenator * input.denumenator);
            }
        }

        public RationalFraction Subtraction(RationalFraction input)
        {
            if (denumenator == input.denumenator)
            {
                return new RationalFraction(numenator - input.numenator, denumenator);
            }
            else
            {
                return new RationalFraction(numenator * input.denumenator - input.numenator * denumenator, denumenator * input.denumenator);
            }
        }

        public RationalFraction Multiplication(RationalFraction input)
        {
            return new RationalFraction(numenator * input.numenator, denumenator * input.denumenator);
        }

        public RationalFraction Division(RationalFraction input)
        {
            return new RationalFraction(numenator * input.denumenator, denumenator * input.numenator);
        }


        public void ToString()
        {
            if (numenator == 0)
            {
                Console.WriteLine("0");
            }
            else if (denumenator == 1)
            {
                Console.WriteLine(numenator);
            }
            else
            {
                Console.WriteLine($"{numenator} / {denumenator}");
            }
        }

        public double DoubleValue()
        {
            return Convert.ToDouble(numenator) / denumenator;
        }

        public bool Comparison(RationalFraction input)
        {
            if (numenator == input.numenator && denumenator == input.denumenator) return true;
            return false;
        }

        public int IntPart()
        {
            return numenator / denumenator;
        }
    }
}
