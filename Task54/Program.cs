/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

        // Упорядочивание элементов каждой строки по убыванию
        for (int i = 0; i < rows; i++)
        {
            int[] tempArray = new int[cols];

            for (int j = 0; j < cols; j++)
            {
                tempArray[j] = array[i, j];
            }

            Array.Sort(tempArray);
            Array.Reverse(tempArray);

            for (int j = 0; j < cols; j++)
            {
                array[i, j] = tempArray[j];
            }
        }

        // Вывод исходного массива
        Console.WriteLine("Заданный массив:");
        PrintArray(array);

        // Вывод упорядоченного двумерного массива
        Console.WriteLine("\nВ итоге получается следующий массив:");
        PrintArray(array);
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


