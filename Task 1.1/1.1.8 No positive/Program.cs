using System;

namespace _1._1._8_No_positive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность трехмерного массива: ");
            int n = int.Parse(Console.ReadLine());
            int[,,] numbers = new int[n, n, n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        numbers[i, j, k] = r.Next(-10, 10);
                    }
                }
            }
            Console.WriteLine("Массив чисел:");
            foreach (int i in numbers)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();

            Console.WriteLine("Измененный массив чисел:");
            foreach (int i in numbers)
            {
                if( i > 0)
                {
                    Console.Write(0 + ", ");
                }
                else
                {
                    Console.Write(i + ", ");
                }
            }
        }
    }
}
