using System;

namespace _1._1._2_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк 'N'");
            int height = int.Parse(Console.ReadLine());
            string sumChar = "";

            for(int i = 0; i < height; i++)
            {
                sumChar += "*";
                Console.WriteLine(sumChar);
            }
        }
    }
}
