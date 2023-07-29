/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

using System;

public class Program
{
    public static void Main()
    {
        int[] array = new int[] { 345, 897, 568, 234 };

        Console.WriteLine("[" + string.Join(", ", array) + "] -> " + CountEvenNumbers(array));

        Console.ReadKey();
    }

    public static int CountEvenNumbers(int[] array)
    {
        int count = 0;

        foreach (int num in array)
        {
            if (num % 2 == 0)
            {
                count++;
            }
        }

        return count;
    }
}


