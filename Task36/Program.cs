/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

using System;

public class Program
{
    public static void Main()
    {
        int[] numbers = new int[] { 3, 7, 23, 12 }; // Задаем массив с указанными числами

        // Выводим на экран исходный массив
        Console.Write("[");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i]);
            if (i != numbers.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.Write("] -> ");

        // Вычисляем сумму элементов, стоящих на нечетных позициях
        int sum = 0;
        for (int i = 1; i < numbers.Length; i += 2)
        {
            sum += numbers[i];
        }

        // Выводим результат на экран
        Console.WriteLine(sum);

        int[] numbers2 = new int[] { -4, -6, 89, 6 }; 

        // Выводим на экран исходный массив
        Console.Write("[");
        for (int i = 0; i < numbers2.Length; i++)
        {
            Console.Write(numbers2[i]);
            if (i != numbers2.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.Write("] -> ");

        // Вычисляем сумму элементов, стоящих на нечетных позициях
        int sum2 = 0;
        for (int i = 1; i < numbers2.Length; i += 2)
        {
            sum2 += numbers2[i];
        }

        // Выводим результат на экран
        Console.WriteLine(sum2);

        // Ждем нажатия клавиши Enter, чтобы программа не закрылась сразу
        Console.ReadLine();
    }
}


