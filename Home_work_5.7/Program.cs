namespace Home_work_5._7
{
    using System;

    internal class Program
    {
        // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

        private static void Main(string[] args)
        {
            int m = 4, n = 4;
            int[,] array = new int[m,n];
            double[] outputResault = new double[n];
            FillArrayAndOutput(array);
            CalculateAverageColumn(array);

            void FillArrayAndOutput(int[,] ArrayInFunction)
            {
                for (int i = 0; i < ArrayInFunction.GetLength(0); i++)
                {
                    for (int j = 0; j < ArrayInFunction.GetLength(1); j++)
                    {
                        ArrayInFunction[i, j] = new Random().Next(11);
                        Console.Write(ArrayInFunction[i, j] + "\t");
                    }
                    Console.Write("\n");
                }
            }

            double [] CalculateAverageColumn(int[,] ArrayInFunction)
            {
                int lengthColumn = ArrayInFunction.GetLength(1);
                double[] arrayResault = new double[lengthColumn];
                for (int j = 0; j < lengthColumn; j++)
                {
                    double sum = 0.0;
                    for (int i = 0; i < ArrayInFunction.GetLength(0); i++)
                    {
                        sum += Convert.ToDecimal(ArrayInFunction(i, j));
                    }
                    Console.Write("\n");
                }
                return (arrayResault);
            }
        }
    }
}