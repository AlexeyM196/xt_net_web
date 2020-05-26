using System;

namespace _1._1._9_Non_negative_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов в массиве: ");
            int[] numbers = new int[int.Parse(Console.ReadLine())];
            Random r = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(-10, 10);
            }

            int sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] > 0)
                {
                    sum += numbers[i];
                }
            }

            Console.WriteLine("Массив чисел:");
            foreach(int i in numbers)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Сумма положительных элементов массива: " + sum);
        }
    }
}
