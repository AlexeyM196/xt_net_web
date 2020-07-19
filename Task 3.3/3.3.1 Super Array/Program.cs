using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._1_Super_Array
{
    public static class ExtentionArrayNumbers
    {
        public static int[] Selections(this int[] array, Func<int, int> func)
        {
            if (array == null || func == null)
            {
                throw new ArgumentNullException("Arguments is null");
            }

            return array.Select(item => func(item)).ToArray();
        }

        public static double[] Selections(this double[] array, Func<double, double> func)
        {
            if (array == null || func == null)
            {
                throw new ArgumentNullException("Arguments is null");
            }

            return array.Select(item => func(item)).ToArray();
        }

        public static decimal[] Selections(this decimal[] array, Func<decimal, decimal> func)
        {
            if (array == null || func == null)
            {
                throw new ArgumentNullException("Arguments is null");
            }

            return array.Select(item => func(item)).ToArray();
        }

        public static double Sum<T>(this T[] array) where T : struct
        {
            if (array == null)
            {
                throw new ArgumentNullException("Array is null");
            }

            double sum = 0;

            foreach (string num in array.Select(item => item.ToString()))
            {
                Double.TryParse(num, out double temp);
                sum += temp;
            }

            return sum;
        }

        public static double Average<T>(this T[] array) where T : struct
        {
            if (array == null)
            {
                throw new ArgumentNullException("Array is null");
            }

            return Sum<T>(array) / array.Length;
        }

        public static T OftenUsed<T>(this T[] array) where T : struct
        {
            if (array == null)
            {
                throw new ArgumentNullException("Array is null");
            }

            return array.OrderBy(item => item).GroupBy(item => item).OrderByDescending(item => item.Count()).FirstOrDefault().Key;
        }
        class Program
        {
            static void Main(string[] args)
            {
                int[] arr1 = { 1, 2, 3, 4, 5 };
                double[] arr2 = { 3, 1, 3, 1, 2, 3, 4, 5 };
                decimal[] arr3 = { 1, 2, 3, 4, 5, 100 };

                Console.WriteLine("Сумма: {0}", arr1.Sum());
                Console.WriteLine("Средние значение: {0}" , arr3.Average());
                Console.WriteLine("Самый повторяющийся эелемент: {0}", arr2.OftenUsed());
            }
        }
    }
}