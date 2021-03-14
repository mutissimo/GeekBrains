using System;

namespace Task_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как тебя зовут? ");
            string name = Console.ReadLine();
            Console.WriteLine($" Здравствуйте, {name}! Сегодня {DateTime.Now}");
        }
    }
}
