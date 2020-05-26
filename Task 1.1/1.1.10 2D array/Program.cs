using System;

namespace _1._1._10_2D_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность двухмерного  массива: ");
            int n = int.Parse(Console.ReadLine());
            int[,] numbers = new int[n, n];
            Random r = new Random();
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                        numbers[i, j] = r.Next(-10, 10);
                    if((i + j) % 2 == 0 && (i + j) > 0 )
                    {
                        sum += numbers[i, j];
                    }
                }
            }
            Console.WriteLine("Двухмерный массив: ");
            int rows = numbers.GetUpperBound(0) + 1;
            int columns = numbers.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{numbers[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Сумма элементов стоящих на четных позициях: " + sum);
        }
    }
}
