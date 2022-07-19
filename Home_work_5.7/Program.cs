namespace Home_work_5._7
{
    using System;

    internal class Program
    {
        // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // 1,7 -> такой позиции в массиве нет

        private static void Main(string[] args)
        {
            // задаем произвольный формат двухмерной матрицы (до 10 строк и столбцов)
            int m = new Random().Next(11), n = new Random().Next(11);
            double[,] array = new double[m, n];
            int[] positionElement = new int[2] { 0, 0 };
            Console.Write("Введите искомую строку элемента в массиве: ");
            positionElement[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите искомый столбец элемента в массиве: ");
            positionElement[1] = Convert.ToInt32(Console.ReadLine());
            FillandOutputArray(array);
            SearchElementInArray(positionElement, array);

            // функция заполнения и вывода массива произольными числами
            void FillandOutputArray(double[,] ArrayInFunction1)
            {
                Console.WriteLine("Вывод массива, с произвольно генерируемыми вещественными числами:");
                for (int i = 0; i < ArrayInFunction1.GetLength(0); i++)
                {
                    for (int j = 0; j < ArrayInFunction1.GetLength(1); j++)
                    {
                        Random autoRand = new Random();
                        ArrayInFunction1[i, j] = Math.Round(autoRand.NextDouble() * 10, 2);
                        Console.Write(ArrayInFunction1[i, j] + "\t");
                    }
                    Console.Write("\n");
                }
            }

            void SearchElementInArray(int[] ArrayInFunction2, double[,] ArrayInFunction1)
            {
                if ((ArrayInFunction2[0] >= ArrayInFunction1.GetLength(0)) && (ArrayInFunction2[1] >= ArrayInFunction1.GetLength(1)))
                    Console.WriteLine($"Искомого элемента ({ArrayInFunction2[0]}, {ArrayInFunction2[1]}) не найдено!");
                else
                {
                    Console.WriteLine($"Искомый элемент ({ArrayInFunction2[0]}, {ArrayInFunction2[1]}) найден! Его значение в массиве: {ArrayInFunction1[ArrayInFunction2[0], ArrayInFunction2[1]]}");
                }
            }
        }
    }
}