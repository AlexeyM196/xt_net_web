using System;

namespace _1._1._4_X_mas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество треугольников 'N'");
            int sumTriangle = int.Parse(Console.ReadLine());

            for(int height = 0; height <= sumTriangle + 1; height++)
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = sumTriangle; j >= i + 1; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int a = 0; a <= i * 2; a++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
