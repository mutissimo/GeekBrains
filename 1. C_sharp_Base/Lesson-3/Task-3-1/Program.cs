using System;

namespace Task_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[,] matrix = new int [n,n];
            var rand = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(10);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }            
            Console.WriteLine();            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write($"{matrix[i, i]} ");
            }            
            Console.WriteLine(" - главная диагональ");
        }
    }
}
