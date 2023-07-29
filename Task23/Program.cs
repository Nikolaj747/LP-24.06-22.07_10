/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
5 ->
1 | 1
2 | 8
3 | 27
4 | 64
5 | 125
*/

using System;

public class Program
{
    public static void Main()
    {
        int N = 5;
        Console.WriteLine("Таблица кубов чисел от 1 до " + N + ":");

        for (int i = 1; i <= N; i++)
        {
            int cube = i * i * i;
            Console.WriteLine(i + " | " + cube);
        }

        Console.ReadKey();
    }
}

