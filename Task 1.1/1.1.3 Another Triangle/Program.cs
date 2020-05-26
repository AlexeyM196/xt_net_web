using System;
using System.Dynamic;

namespace _1._1._3_Another_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк 'N'");
            int height = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < height; i++)
            {
                for(int j = height; j > i + 1; j--)
                {
                    Console.Write(" ");
                }
                for(int a = 0; a <= i * 2; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
