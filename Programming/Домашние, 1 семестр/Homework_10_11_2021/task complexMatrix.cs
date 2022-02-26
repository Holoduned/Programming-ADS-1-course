//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Study.Homework.Homework_10_11_2021
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ComplexNumber[,] array = new ComplexNumber[2, 2];
//            var matrix = new ComplexMatrix(array);
//            matrix.InputMatrix();
//            matrix.PrintMatrix();

//            ComplexNumber[,] array_2 = new ComplexNumber[2, 2];
//            var matrix_2 = new ComplexMatrix(array_2);
//            matrix_2.InputMatrix();
//            matrix_2.PrintMatrix();

//            Console.WriteLine("Результат сложения комплексных матриц: ");
//            var matrix_addition = new ComplexMatrix(matrix.ComplexMatrixAddition(matrix_2));
//            matrix_addition.PrintMatrix();

//            Console.WriteLine("Разность комплексных матриц: ");
//            var matrix_substration = new ComplexMatrix(matrix.ComplexMatrixSubstration(matrix_2));
//            matrix_substration.PrintMatrix();

//            Console.WriteLine("Введите число, на которое будет умножаться комплексная матрица: ");
//            var matrix_NumMultiplication = new ComplexMatrix(matrix.ComplexMatrixMultNumber(Convert.ToDouble(Console.ReadLine())));
//            Console.WriteLine("Результат умножение комплексной матрицы на число: ");
//            matrix_NumMultiplication.PrintMatrix();

//            Console.WriteLine("Результат умножения комплексных матриц: ");
//            var matrix_multiplication = new ComplexMatrix(matrix.MatrixMultiplication(matrix_2));
//            matrix_multiplication.PrintMatrix();

//            Console.WriteLine($"Определитель комплексной матрицы: ");
//            var det = matrix.MatrixDet();
//            det.ComplexNumberToString();

//        Console.ReadKey();
//        }
//    }
//}

