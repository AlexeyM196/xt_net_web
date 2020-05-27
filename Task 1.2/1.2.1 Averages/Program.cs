using System;

namespace Task_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string str = Console.ReadLine();
            string[] words = str.ToLower().Replace(".", "").Replace(",", "").Replace(";", "").Replace(":", "").Replace("!", "").Replace("?", "").Split(' ');
            double sumChar = 0;

            foreach (string word in words)
            {
                sumChar += word.Length;
            }

            double avgChar = sumChar / words.Length;
            Console.WriteLine("Средние количество букв в слове: " + Math.Round(avgChar, 1));
        }
    }
}
