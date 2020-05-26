using System;

namespace _1._1._5_Sum_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for(int i = 1; i < 1000; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Сумма чисел кратные 3 и 5 меньше 1000: " + sum);
        }
    }
}
