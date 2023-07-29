/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        double x1 = 3, y1 = 6, z1 = 8;
        double x2 = 2, y2 = 1, z2 = -7;

        double distance = CalculateDistance(x1, y1, z1, x2, y2, z2);
        Console.WriteLine("A (" + x1 + "," + y1 + "," + z1 + "); B (" + x2 + "," + y2 + "," + z2 + ") -> " + distance.ToString("F2"));

        x1 = 7; y1 = -5; z1 = 0;
        x2 = 1; y2 = -1; z2 = 9;

        distance = CalculateDistance(x1, y1, z1, x2, y2, z2);
        Console.WriteLine("A (" + x1 + "," + y1 + "," + z1 + "); B (" + x2 + "," + y2 + "," + z2 + ") -> " + distance.ToString("F2"));

        Console.ReadKey();
    }

    public static double CalculateDistance(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        double dx = x2 - x1;
        double dy = y2 - y1;
        double dz = z2 - z1;
        double distance = Math.Sqrt(dx * dx + dy * dy + dz * dz);
        return distance;
    }
}

