/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

using System;

public class Program
{
    public static void Main()
    {
        int number = 452;
        int sum = CalculateSum(number);
        Console.WriteLine(number + " -> " + sum);

        number = 82;
        sum = CalculateSum(number);
        Console.WriteLine(number + " -> " + sum);

        number = 9012;
        sum = CalculateSum(number);
        Console.WriteLine(number + " -> " + sum);

        Console.ReadKey();
    }

    public static int CalculateSum(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            int digit = number % 10;
            sum += digit;
            number /= 10;
        }
        return sum;
    }
}

