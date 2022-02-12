using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Homework.Homework_10_11_2021
{
    class ComplexMatrix
    {
        public ComplexNumber[,] complexMatrix = new ComplexNumber[2, 2];

        public ComplexMatrix(ComplexNumber[,] array)
        {
            complexMatrix = array;
        }

        public ComplexNumber[,] ComplexMatrixAddition(ComplexMatrix input)
        {
            ComplexNumber[,] MatrixPlus = new ComplexNumber[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    MatrixPlus[i, j] = complexMatrix[i, j].Addition(input.complexMatrix[i, j]);
                }
            }

            return MatrixPlus;
        }

        public ComplexNumber[,] ComplexMatrixSubstration(ComplexMatrix input)
        {
            ComplexNumber[,] MatrixMinus = new ComplexNumber[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    MatrixMinus[i, j] = complexMatrix[i, j].Substraction(input.complexMatrix[i, j]);
                }
            }

            return MatrixMinus;
        }

        public ComplexNumber[,] ComplexMatrixMultNumber(double n)
        {
            ComplexNumber[,] MatrixMultNum = new ComplexNumber[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    MatrixMultNum[i, j] = complexMatrix[i, j].Multiplication(n);
                }
            }

            return MatrixMultNum;
        }

        public ComplexNumber MatrixDet()
        {
            ComplexNumber det;
            det = complexMatrix[0, 0].ComplexMultiplication(complexMatrix[1, 1]).Substraction(complexMatrix[0, 1].ComplexMultiplication(complexMatrix[1, 0]));
            return det;
        }

        public ComplexNumber[,] MatrixMultiplication(ComplexMatrix input)
        {
            ComplexNumber[,] ComplexMatrixMult = new ComplexNumber[2, 2];
            ComplexMatrixMult[0, 0] = complexMatrix[0, 0].ComplexMultiplication(input.complexMatrix[0, 0]).Addition(complexMatrix[0, 1].ComplexMultiplication(input.complexMatrix[1, 0]));
            ComplexMatrixMult[0, 1] = complexMatrix[0, 0].ComplexMultiplication(input.complexMatrix[0, 1]).Addition(complexMatrix[0, 1].ComplexMultiplication(input.complexMatrix[1, 1]));
            ComplexMatrixMult[1, 0] = complexMatrix[1, 0].ComplexMultiplication(input.complexMatrix[0, 0]).Addition(complexMatrix[1, 1].ComplexMultiplication(input.complexMatrix[1, 0]));
            ComplexMatrixMult[1, 1] = complexMatrix[1, 0].ComplexMultiplication(input.complexMatrix[0, 1]).Addition(complexMatrix[1, 1].ComplexMultiplication(input.complexMatrix[1, 1]));
            return ComplexMatrixMult;
        }

        public void InputMatrix()
        {
            Console.WriteLine("Вводите комплексные числа - элементы квадратной матрицы");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    complexMatrix[i, j] = new ComplexNumber(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                }
            }
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    complexMatrix[i, j].ComplexNumberToString();
                }
                Console.WriteLine();
            }
        }

    }

    class ComplexNumber
    {
        double real; double imaginary;

        public ComplexNumber(double r, double i)
        {
            real = r; imaginary = i;
        }

        public void ComplexNumberToString()
        {
            if (real == 0 && imaginary != 0)
            {
                Console.Write($"{imaginary}i ");
            }
            else if (real != 0 && imaginary == 0)
            {
                Console.Write($"{real} ");
            }
            else if (real == 0 && imaginary == 0)
            {
                Console.Write("0 ");
            }
            else if (imaginary > 0)
            {
                Console.Write($"{real} + {imaginary}i ");
            }
            else
            {
                Console.Write($"{real}{imaginary}i ");
            }
        }

        public ComplexNumber Addition(ComplexNumber input)
        {
            return new ComplexNumber(real + input.real, imaginary + input.imaginary);
        }

        public ComplexNumber Substraction(ComplexNumber input)
        {
            return new ComplexNumber(real - input.real, imaginary - input.imaginary);
        }

        public ComplexNumber Multiplication(double n)
        {
            return new ComplexNumber(real * n, imaginary * n);
        }

        public ComplexNumber ComplexMultiplication(ComplexNumber input)
        {
            return new ComplexNumber(real * input.real - imaginary * input.imaginary, real * input.imaginary + imaginary * input.real);
        }
    }
}

