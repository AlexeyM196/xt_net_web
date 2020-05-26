using System;

namespace _1._1._1_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение стороны 'а'");
            int sideA = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение стороны 'b'");
            int sideB = int.Parse(Console.ReadLine());

            if(sideA <= 0 || sideB <= 0)
            {
                Console.WriteLine("Значения должны быть больше 0");
            }

            else
            {
                Console.WriteLine("Площадь прямоугольника: " + sideA * sideB);
            }
        }
    }
}
