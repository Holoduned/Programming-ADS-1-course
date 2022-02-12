//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Study.Homework.Homework_03_11_2021
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            #region Задача 1
//            Console.WriteLine("Вводите значения знаменателя и числителя дроби");
//            var fraction = new RationalFraction(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())); fraction.Reduce();
//            Console.Write("Первая дробь равна: "); fraction.ToString();
//            var fraction_2 = new RationalFraction(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())); fraction_2.Reduce();
//            Console.Write("Вторая дробь равна: "); fraction_2.ToString();

//            var fractionAdd = fraction.Addition(fraction_2); fractionAdd.Reduce();
//            Console.Write("Результат сложения дробей: "); fractionAdd.ToString();

//            var fractionSub = fraction.Subtraction(fraction_2); fractionSub.Reduce();
//            Console.Write("Результат вычитания дробей: "); fractionSub.ToString();

//            var fractionMult = fraction.Multiplication(fraction_2); fractionMult.Reduce();
//            Console.Write("Результат умножения дробей: "); fractionMult.ToString();

//            Console.WriteLine($"Десятичное значение дроби: {fraction.DoubleValue()}");

//            Console.WriteLine($"Равны ли дроби? {fraction.Comparison(fraction_2)}");

//            Console.WriteLine($"Целая часть дроби: {fraction.IntPart()}");

//            Console.WriteLine();
//            #endregion

//            #region Задача 2

//            Console.WriteLine("Вводите значения мнимой и действительной частей дроби");
//            var complexNumber = new ComplexNumber(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
//            Console.Write("Первое комплексное число: "); complexNumber.ToString();

//            var complexNumber_2 = new ComplexNumber(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
//            Console.Write("Второе комплексное число: "); complexNumber_2.ToString();

//            var complexAdd = complexNumber.Addition(complexNumber_2);
//            Console.Write("Результат сложения комплексных чисел: "); complexAdd.ToString();

//            var complexSub = complexNumber.Substraction(complexNumber_2);
//            Console.Write("Результат вычетания комплексных чисел: "); complexSub.ToString();

//            var complexMult = complexNumber.ComplexMultiplication(complexNumber_2);
//            Console.Write("Результат умножения комплексных чисел: "); complexMult.ToString();

//            Console.Write("Введите вещественное число: ");
//            double n = Convert.ToDouble(Console.ReadLine());
//            var complexDMult = complexNumber.Multiplication(n);
//            Console.Write("Результат умножения комплексного числа на вещественное число: "); complexDMult.ToString();

//            var complexDiv = complexNumber.Division(complexNumber_2);
//            Console.Write("Результат деления комплексных чисел: "); complexDiv.ToString();

//            Console.WriteLine($"Модуль комплексного числа: {complexNumber.Length()}");
//            Console.WriteLine($"Аргумент комплексного числа: {complexNumber.Arg()}");
//            Console.WriteLine($"Равны ли комплексные числа? {complexNumber.Comparison(complexNumber_2)}");

//            Console.Write("Введите вещественное число - степень: ");
//            double num = Convert.ToDouble(Console.ReadLine());
//            var complexPow = complexNumber.Pow(num);
//            Console.Write("Результат возведения комплексного числа в степень n: "); complexPow.ToString();

//            Console.WriteLine();
//            #endregion

//            #region Задача 3

//            double[,] mas = new double[2, 2];
//            Console.WriteLine("Вводите числа - элементы массива: ");
//            Matrix.InputMatrix(mas);
//            var doubleMas = new Matrix(mas);
//            double[,] mas_2 = new double[2, 2];
//            Matrix.InputMatrix(mas_2);
//            var doubleMas_2 = new Matrix(mas_2);


//            Console.WriteLine("Результат сложения матриц: ");
//            doubleMas.MatrixAddition(doubleMas_2);
//            Matrix.PrintMatrix(doubleMas.MatrixPlus);

//            Console.WriteLine("Результат вычитания матриц: ");
//            doubleMas.MatrixSubstraction(doubleMas_2);
//            Matrix.PrintMatrix(doubleMas.MatrixMinus);

//            Console.WriteLine("Введите число, на которое будет умножаться матрица: ");
//            double nu = Convert.ToDouble(Console.ReadLine());
//            doubleMas.MultNumber(nu);
//            Matrix.PrintMatrix(doubleMas.MatrixMultNum);

//            Console.WriteLine("Результат умножения матриц: ");
//            doubleMas.MatrixMultiplication(doubleMas_2);
//            Matrix.PrintMatrix(doubleMas.MatrixMult);

//            Console.WriteLine($"Определитель матрицы равен: {doubleMas.MatrixDet()} ");

//            Console.WriteLine("Транспонирование матрицы: ");
//            doubleMas.Transposition();

//            Console.WriteLine("Обратная матрица: ");
//            double[,] reverseMas = doubleMas.Reverse();
//            Matrix.PrintMatrix(reverseMas);

//            Console.WriteLine("Введите значения Х, У для вектора: ");
//            var vector = new Vector2D(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
//            vector = doubleMas.multVector(vector);
//            vector.Print();

//            Console.ReadKey();

//            #endregion

//        }

//    }
//}
