/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243
2, 4 -> 16
*/

using System;

public class Program
{
    public static void Main()
    {
        int A = 3;
        int B = 5;

        int result = 1;

        for (int i = 1; i <= B; i++)
        {
            result *= A;
        }

        Console.WriteLine(A + ", " + B + " -> " + result);

        A = 2;
        B = 4;

        result = 1;

        for (int i = 1; i <= B; i++)
        {
            result *= A;
        }

        Console.WriteLine(A + ", " + B + " -> " + result);

        Console.ReadKey();
    }
}


