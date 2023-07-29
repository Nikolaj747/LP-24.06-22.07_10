/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3

Результирующая матрица будет:
18 20
15 18
*/

using System;

public class Program
{
    public static void Main()
    {
        // Заданные матрицы
        int[,] matrix1 = {
            { 2, 4 },
            { 3, 2 }
        };

        int[,] matrix2 = {
            { 3, 4 },
            { 3, 3 }
        };

        // Умножение матриц
        int[,] result = MultiplyMatrices(matrix1, matrix2);

        // Вывод заданных матриц
        Console.WriteLine("Даны 2 матрицы:");
        PrintMatrix(matrix1);
        Console.WriteLine();
        PrintMatrix(matrix2);

        // Вывод результирующей матрицы
        Console.WriteLine("\nРезультирующая матрица будет:");
        PrintMatrix(result);
    }

    // Функция для умножения матриц
    public static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int columns1 = matrix1.GetLength(1);
        int columns2 = matrix2.GetLength(1);

        int[,] result = new int[rows1, columns2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < columns2; j++)
            {
                for (int k = 0; k < columns1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return result;
    }

    // Метод для вывода матрицы
    public static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}


