/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

using System;

public class Program
{
    public static void Main()
    {
        int[] array = new int[] { 1, 2, 5, 7, 19 };
        Console.WriteLine(string.Join(", ", array) + " -> [" + string.Join(", ", array) + "]");

        array = new int[] { 6, 1, 33 };
        Console.WriteLine(string.Join(", ", array) + " -> [" + string.Join(", ", array) + "]");

        Console.ReadKey();
    }
}


