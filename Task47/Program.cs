/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

using System;

public class Program
{
    public static void Main()
    {
        int m = 3; // Количество строк
        int n = 4; // Количество столбцов

        double[,] array = new double[,]
        {
            { 0.5, 7, -2, -0.2 },
            { 1, -3.3, 8, -9.9 },
            { 8, 7.8, -7.1, 9 }
        };

        Console.WriteLine($"m = {m}, n = {n}.");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j].ToString("0.0").Replace(",", ".") + " ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}

