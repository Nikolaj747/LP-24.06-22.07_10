//Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int m = InputNumbers("Введите M: ");
int n = InputNumbers("Введите N: ");
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}

PrintSumm(m, n, temp = 0);

void PrintSumm(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов = {summ} ");
        return;
    }
    PrintSumm(m, n - 1, summ);
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

public class Program
{
    public static void Main()
    {
        // Задание размеров массива
        int size = 4;

        // Создание двумерного массива
        int[,] array = new int[size, size];

        // Определение переменных для индексов
        int top = 0;
        int bottom = size - 1;
        int left = 0;
        int right = size - 1;

        // Определение текущего значения
        int value = 1;

        while (value <= size * size)
        {
            // Вверх
            for (int i = left; i <= right; i++)
            {
                array[top, i] = value++;
            }
            top++;

            // Вправо
            for (int i = top; i <= bottom; i++)
            {
                array[i, right] = value++;
            }
            right--;

            // Вниз
            for (int i = right; i >= left; i--)
            {
                array[bottom, i] = value++;
            }
            bottom--;

            // Влево
            for (int i = bottom; i >= top; i--)
            {
                array[i, left] = value++;
            }
            left++;
        }

        // Вывод массива на экран
        Console.WriteLine("Полученный массив:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"{array[i, j]:00} ");
            }
            Console.WriteLine();
        }
    }
}

