namespace Home_work_5._7
{
    using System;

    internal class Program
    {
        // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
        // m = 3, n = 4.
        // 0,5 7 -2 -0,2
        // 1 -3,3 8 -9,9
        // 8 7,8 -7,1 9

        private static void Main(string[] args)
        {
            int m = 3, n = 4;
            double[,] array = new double[m, n];
            FillArray(array);
            OutputArray(array);

            // функция заполнения массива произольными вещественными числами
            void FillArray(double[,] ArrayInFunction)
            {
                for (int i = 0; i < ArrayInFunction.GetLength(0); i++)
                {
                    for (int j = 0; j < ArrayInFunction.GetLength(1); j++)
                    {
                        Random autoRand = new Random();
                        ArrayInFunction[i, j] = Math.Round(autoRand.NextDouble() * 10,2);
                    }
                }
            }

            // функция вывода массива
            void OutputArray(double[,] ArrayInFunction)
            {
                Console.WriteLine("Вывод массива, с произвольно генерируемыми вещественными числами:");
                for (int i = 0; i < ArrayInFunction.GetLength(0); i++)
                {
                    for (int j = 0; j < ArrayInFunction.GetLength(1); j++)
                    {
                        Console.Write(ArrayInFunction[i, j] + "\t");
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}