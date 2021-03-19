using System;

namespace Task_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] adressbook = new string[,] { { "Иванов", "Петров", "Сидоров", "Путин", "Медведев" }, { "123", "456", "789", "147", "258" } };
            for (int i = 0; i < adressbook.GetLength(1); i++)
            {
                Console.WriteLine("{0,-12}{1}",adressbook[0, i],adressbook[1, i]);
            }
        }
    }
}
