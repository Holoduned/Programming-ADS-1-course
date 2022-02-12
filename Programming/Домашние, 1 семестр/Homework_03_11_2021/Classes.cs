using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Homework.Homework_03_11_2021
{
    #region Класс рациональной дроби
    class RationalFraction
    {
        public int numenator, denumenator;

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
    #endregion

    #region Класс комплексное число
    class ComplexNumber
    {
        public double real; double imaginary; double module; double arg;

        public ComplexNumber(double real_num, double imag_num)
        {
            real = real_num; imaginary = imag_num;
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
    #endregion

    class Matrix
    {
        public double[,] doubleMatrix = new double[2, 2]; public double[,] MatrixPlus = new double[2, 2];
        public double[,] MatrixMinus = new double[2, 2]; public double[,] MatrixMultNum = new double[2, 2];
        public double[,] MatrixMult = new double[2, 2]; double det = 0;

        public Matrix(double num_1 = 0, double num_2 = 0, double num_3 = 0, double num_4 = 0)
        {
            doubleMatrix[0, 0] = num_1; doubleMatrix[0, 1] = num_2;
            doubleMatrix[1, 0] = num_3; doubleMatrix[1, 1] = num_4;
        }

        public Matrix(double[,] Arr)
        {
            FillMatrix(Arr);
        }

        public void MatrixAddition(Matrix input)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    MatrixPlus[i, j] = doubleMatrix[i, j] + input.doubleMatrix[i, j];
                }
            }
        }

        public void MatrixSubstraction(Matrix input)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    MatrixMinus[i, j] = doubleMatrix[i, j] - input.doubleMatrix[i, j];
                }
            }
        }

        public void MultNumber(double n)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    MatrixMultNum[i, j] = doubleMatrix[i, j] * n;
                }
            }
        }

        public void MatrixMultiplication(Matrix input)
        {
            MatrixMult[0, 0] = doubleMatrix[0, 0] * input.doubleMatrix[0, 0] + doubleMatrix[0, 1] * input.doubleMatrix[1, 0];
            MatrixMult[0, 1] = doubleMatrix[0, 0] * input.doubleMatrix[0, 1] + doubleMatrix[0, 1] * input.doubleMatrix[1, 1];
            MatrixMult[1, 0] = doubleMatrix[1, 0] * input.doubleMatrix[0, 0] + doubleMatrix[1, 1] * input.doubleMatrix[1, 0];
            MatrixMult[1, 1] = doubleMatrix[1, 0] * input.doubleMatrix[0, 1] + doubleMatrix[1, 1] * input.doubleMatrix[1, 1];
        }

        public double MatrixDet()
        {
            det = doubleMatrix[0, 0] * doubleMatrix[1, 1] - doubleMatrix[0, 1] * doubleMatrix[1, 0];
            return det;
        }

        public void Transposition()
        {
            Console.WriteLine($"{doubleMatrix[0, 0]} {doubleMatrix[1, 0]} ");
            Console.WriteLine($"{doubleMatrix[0, 1]} {doubleMatrix[1, 1]} ");
        }

        public double[,] Reverse()
        {
            double[,] reverseMas = new double[2, 2];
            if (det == 0)
            {
                Console.WriteLine("Обратной матрицы не сущетсвует");
                return reverseMas;
            }
            else
            {
                reverseMas[0, 0] = doubleMatrix[1, 1] / det;
                reverseMas[0, 1] = (-1) * doubleMatrix[0, 1] / det;
                reverseMas[1, 0] = (-1) * doubleMatrix[1, 0] / det;
                reverseMas[1, 1] = doubleMatrix[0, 0] / det;
                return reverseMas;
            }
        }

        public Vector2D multVector(Vector2D input)
        {
            return new Vector2D(doubleMatrix[0, 0] * input.X + doubleMatrix[0, 1] * input.Y, doubleMatrix[1, 0] * input.X + doubleMatrix[1, 1] * input.Y);

        }

        public void FillMatrix(double[,] Array)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    doubleMatrix[i, j] = Array[i, j];
                }
            }
            Console.WriteLine("Матрица имеет ввид: ");
            PrintMatrix(doubleMatrix);
            Console.WriteLine();
        }

        public static void PrintMatrix(double[,] Array)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(Array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void InputMatrix(double[,] Array)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Array[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
        }
    }

    class Vector2D
    {
        public double X; public double Y;
        public Vector2D(double x, double y)
        {
            X = x; Y = y;
        }

        public void Print()
        {
            Console.Write($"{X} {Y}\n");
        }
    }
}