using System;

namespace Task_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальную температуру за сутки:");
            double max = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите минимальную температуру за сутки:");
            double min = Convert.ToDouble(Console.ReadLine());
            double avg = (min + max) / 2;
            Console.WriteLine($"Среднесуточная температура за {DateTime.Now}: {avg}");
        }
    }
}
