
/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int number = 645;

        if (number >= 100 && number <= 999)
        {
            // Получаем третью цифру числа
            int thirdDigit = (number / 100) % 10;
            Console.WriteLine(number + " -> " + thirdDigit);
        }
        else
        {
            Console.WriteLine(number + " -> третьей цифры нет");
        }
        
        number = 78;

        if (number >= 100 && number <= 999)
        {
            int thirdDigit = (number / 100) % 10;
            Console.WriteLine(number + " -> " + thirdDigit);
        }
        else
        {
            Console.WriteLine(number + " -> третьей цифры нет");
        }

        number = 32679;

        if (number >= 100 && number <= 999)
        {
            int thirdDigit = (number / 100) % 10;
            Console.WriteLine(number + " -> " + thirdDigit);
        }
        else
        {
            Console.WriteLine(number + " -> третьей цифры нет");
        }

        Console.ReadKey();
    }
}

