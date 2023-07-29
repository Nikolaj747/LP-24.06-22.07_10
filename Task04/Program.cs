/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int num1 = 2, num2 = 3, num3 = 7;
        int max;

        max = num1;

        if (num2 > max)
        {
            max = num2;
        }

        if (num3 > max)
        {
            max = num3;
        }

        Console.WriteLine(num1 + ", " + num2 + ", " + num3 + " -> " + max);

        num1 = 44;
        num2 = 5;
        num3 = 78;

        max = num1;

        if (num2 > max)
        {
            max = num2;
        }

        if (num3 > max)
        {
            max = num3;
        }

        Console.WriteLine(num1 + " " + num2 + " " + num3 + " -> " + max);

        num1 = 22;
        num2 = 3;
        num3 = 9;

        max = num1;

        if (num2 > max)
        {
            max = num2;
        }

        if (num3 > max)
        {
            max = num3;
        }

        Console.WriteLine(num1 + " " + num2 + " " + num3 + " -> " + max);

        Console.ReadKey();
    }
}

