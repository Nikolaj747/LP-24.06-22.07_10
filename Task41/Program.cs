/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

using System;

public class Program
{
    public static void Main()
    {
        int[] numbers = { 0, 7, 8, -2, -2 };

        int positiveCount = 0; // Счетчик положительных чисел

        foreach (int number in numbers)
        {
            if (number > 0)
            {
                positiveCount++; // Увеличиваем счетчик положительных чисел
            }
        }

        Console.WriteLine(string.Join(", ", numbers) + " -> " + positiveCount);

        int[] numbers2 = { -1, -7, 567, 89, 223 };

        positiveCount = 0; // Счетчик положительных чисел

        foreach (int number in numbers2)
        {
            if (number > 0)
            {
                positiveCount++; // Увеличиваем счетчик положительных чисел
            }
        }

        Console.WriteLine(string.Join(", ", numbers2) + " -> " + positiveCount);

        Console.ReadLine();
    }
}

