/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/


using System;

public class Program
{
    public static void Main()
    {
        // Заданный прямоугольный двумерный массив
        int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 },
            { 5, 2, 6, 7 }
        };

        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        // Поиск строки с наименьшей суммой элементов
        int minSum = int.MaxValue;
        int minSumIndex = -1;

        for (int i = 0; i < rows; i++)
        {
            int sum = 0;

            for (int j = 0; j < cols; j++)
            {
                sum += array[i, j];
            }

            if (sum < minSum)
            {
                minSum = sum;
                minSumIndex = i + 1;
            }
        }

        // Вывод заданного массива
        Console.WriteLine("Задан массив:");
        PrintArray(array);

        // Вывод результата
        Console.WriteLine("\nСтрока с наименьшей суммой элементов: " + minSumIndex + " строка");
    }

    // Метод для вывода двумерного массива
    private static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

