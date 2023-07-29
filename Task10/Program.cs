/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int number = 456;
        int secondDigit = (number / 10) % 10;
        Console.WriteLine(number + " -> " + secondDigit);
        
        number = 782;
        secondDigit = (number / 10) % 10;
        Console.WriteLine(number + " -> " + secondDigit);
        
        number = 918;
        secondDigit = (number / 10) % 10;
        Console.WriteLine(number + " -> " + secondDigit);

        Console.ReadKey();
    }
}

