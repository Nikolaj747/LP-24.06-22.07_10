/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/

using System;

public class Program
{
    public static void Main()
    {
        double[] numbers = { 3.22, 4.2, 1.15, 77.15, 65.2 };

        Console.Write("[");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i]);
            if (i != numbers.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");

        double min = numbers[0];
        double max = numbers[0];
        foreach (double number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
            if (number > max)
            {
                max = number;
            }
        }

        double difference = max - min;

        Console.WriteLine(min + " - " + max + " = " + difference);

        Console.ReadLine();
    }
}

