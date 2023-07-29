/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int num = 4;

        if (num % 2 == 0)
        {
            Console.WriteLine(num + " -> да");
        }
        else
        {
            Console.WriteLine(num + " -> нет");
        }

        num = -3;

        if (num % 2 == 0)
        {
            Console.WriteLine(num + " -> да");
        }
        else
        {
            Console.WriteLine(num + " -> нет");
        }

        num = 7;

        if (num % 2 == 0)
        {
            Console.WriteLine(num + " -> да");
        }
        else
        {
            Console.WriteLine(num + " -> нет");
        }

        Console.ReadKey();
    }
}

