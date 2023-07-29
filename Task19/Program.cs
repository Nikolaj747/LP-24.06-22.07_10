/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да

*/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int number = 14212;

        int digit1 = number / 10000;
        int digit2 = (number / 1000) % 10;
        int digit4 = (number / 10) % 10;
        int digit5 = number % 10;

        if (digit1 == digit5 && digit2 == digit4)
        {
            Console.WriteLine(number + " -> да");
        }
        else
        {
            Console.WriteLine(number + " -> нет");
        }

        number = 12821;

        digit1 = number / 10000;
        digit2 = (number / 1000) % 10;
        digit4 = (number / 10) % 10;
        digit5 = number % 10;

        if (digit1 == digit5 && digit2 == digit4)
        {
            Console.WriteLine(number + " -> да");
        }
        else
        {
            Console.WriteLine(number + " -> нет");
        }

        number = 23432;

        digit1 = number / 10000;
        digit2 = (number / 1000) % 10;
        digit4 = (number / 10) % 10;
        digit5 = number % 10;

        if (digit1 == digit5 && digit2 == digit4)
        {
            Console.WriteLine(number + " -> да");
        }
        else
        {
            Console.WriteLine(number + " -> нет");
        }

        Console.ReadKey();
    }
}

