// Lab_05_1.cs
// Якубовський Владислав
// Лабораторна робота № 5.1
// Функції, що містять арифметичний вираз.
// Варіант 24
using System;
using static System.Math;

namespace AP_Lab_05_1
{
    public class Lab_05_1
    {
        public static double F(double a) => (Pow(a, 2) + 1) / (Pow(Sin(a), 2) + 1);

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Console.Write("Введіть змінні \"x\", \"y\" по черзі через крапку з комою: ");

            string[] varArray = Console.ReadLine().Split(';');

            double x = Double.Parse(varArray[0].Replace('.', ',')),
                y = Double.Parse(varArray[1].Replace('.', ',')),
                solution = (F(3) + F(x + 1) + 1) / (1 - Pow(F(y + 1), 2));

            Console.WriteLine($"Отримане значення виразу:\t{solution}");

            Console.ReadLine();
        }
    }
}