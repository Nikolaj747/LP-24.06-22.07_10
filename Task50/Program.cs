/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого элемента в массиве нет
*/

using System;

public class Program
{
    public static void Main()
    {
        // Заданный двумерный массив
        int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

        // Позиция элемента
        int rowPos = 1;
        int colPos = 7;

        // Вывод массива
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Проверка наличия элемента и его вывод
        if (rowPos >= 0 && rowPos < array.GetLength(0) && colPos >= 0 && colPos < array.GetLength(1))
        {
            Console.WriteLine("{0}, {1} -> Значение элемента: {2}", rowPos, colPos, array[rowPos, colPos]);
        }
        else
        {
            Console.WriteLine("{0}, {1} -> Такого элемента в массиве нет.", rowPos, colPos);
        }
    }
}

