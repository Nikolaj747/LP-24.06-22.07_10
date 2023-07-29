/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

using System;

public class Program
{
    public static void Main()
    {
        // Заданный двумерный массив
        int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        // Вычисление среднего арифметического для каждого столбца
        double[] columnAverages = new double[cols];

        for (int j = 0; j < cols; j++)
        {
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                sum += array[i, j];
            }

            columnAverages[j] = (double)sum / rows;
        }

        // Вывод массива
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Вывод среднего арифметического каждого столбца
        Console.Write("Среднее арифметическое каждого столбца: ");
        for (int j = 0; j < cols; j++)
        {
            Console.Write(columnAverages[j].ToString("0.0") + "; ");
        }
    }
}

