/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int N = 5;

        Console.Write(N + " -> ");

        for (int i = 2; i <= N; i += 2)
        {
            Console.Write(i + ", ");
        }
        Console.WriteLine();

        N = 8;

        Console.Write(N + " -> ");

        for (int i = 2; i <= N; i += 2)
        {
            Console.Write(i + ", ");
        }
        Console.WriteLine();

        Console.ReadKey();
    }
}


