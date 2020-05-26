using System;
using System.Linq;

namespace _1._1._6_Font_adjustment
{
    class Program
    {
        public static string Style(int[] array, int value)
        {
            if (value == 1)
            {
                if (array[0] == 1)
                {
                    array[0] = 0;
                }
                else
                {
                    array[0] = 1;
                }
            }
            if (value == 2)
            {
                if (array[1] == 1)
                {
                    array[1] = 0;
                }
                else
                {
                    array[1] = 1;
                }
            }
            if (value == 3)
            {
                if (array[2] == 1)
                {
                    array[2] = 0;
                }
                else
                {
                    array[2] = 1;
                }
            }
            int[] array1 = { 0, 0, 0 };
            int[] array2 = { 0, 0, 1 };
            int[] array3 = { 0, 1, 0 };
            int[] array4 = { 1, 0, 0 };
            int[] array5 = { 0, 1, 1 };
            int[] array6 = { 1, 0, 1 };
            int[] array7 = { 1, 1, 0 };
            int[] array8 = { 1, 1, 1 };
            string style = "";

            if (array.SequenceEqual(array1)) { style = "None"; }
            if (array.SequenceEqual(array2)) { style = "Underline"; }
            if (array.SequenceEqual(array3)) { style = "Italic"; }
            if (array.SequenceEqual(array4)) { style = "Bold"; }
            if (array.SequenceEqual(array5)) { style = "Italic, Underline"; }
            if (array.SequenceEqual(array6)) { style = "Bold, Underline"; }
            if (array.SequenceEqual(array7)) { style = "Bold, Italic"; }
            if (array.SequenceEqual(array8)) { style = "Bold, Italic, Underline"; }

            return style;
        }
        static void Main(string[] args)
        {
            int[] array = { 0, 0, 0 };
            int value = 0;
            while (value != 4)
            {
                Console.WriteLine("Параметры надписи: " + Style(array, value));
                Console.WriteLine("Введите:");
                Console.WriteLine("1: Bold");
                Console.WriteLine("2: Italic");
                Console.WriteLine("3: Underline");
                value = int.Parse(Console.ReadLine());
            }
        }
    }
}
