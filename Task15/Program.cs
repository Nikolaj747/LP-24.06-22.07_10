/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int day = 6;

        if (day == 6 || day == 7)
        {
            Console.WriteLine(day + " -> да");
        }
        else
        {
            Console.WriteLine(day + " -> нет");
        }

        day = 7;

        if (day == 6 || day == 7)
        {
            Console.WriteLine(day + " -> да");
        }
        else
        {
            Console.WriteLine(day + " -> нет");
        }

        day = 1;

        if (day == 6 || day == 7)
        {
            Console.WriteLine(day + " -> да");
        }
        else
        {
            Console.WriteLine(day + " -> нет");
        }

        Console.ReadKey();
    }
}

