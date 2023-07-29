/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 ->max = 7
a = 2 b = 10 ->max = 10
a = -9 b = -3 ->max = -3*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 5, b = 7;
        int max;

        if (a > b)
        {
            max = a;
        }
        else
        {
            max = b;
        }

        Console.WriteLine("a = " + a + "; b = " + b + " -> max = " + max);

        a = 2;
        b = 10;

        if (a > b)
        {
            max = a;
        }
        else
        {
            max = b;
        }

        Console.WriteLine("a = " + a + "; b = " + b + " -> max = " + max);

        a = -9;
        b = -3;

        if (a > b)
        {
            max = a;
        }
        else
        {
            max = b;
        }

        Console.WriteLine("a = " + a + "; b = " + b + " -> max = " + max);

        Console.ReadKey();
    }
}
