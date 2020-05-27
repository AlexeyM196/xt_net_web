using System;

namespace _1._2._3_Lowercase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string str = Console.ReadLine();
            string[] words = str.Replace(".", "").Replace(",", "").Replace(";", "").Replace(":", "").Replace("!", "").Replace("?", "").Split(' ');
            int sum = 0;
            foreach(string word in words)
            { 
                if (char.IsLower(word[0]) && char.IsLetter(word[0]))
                {
                    sum += 1;
                }
            }
            Console.WriteLine("Сумма слов начинающихся с маленькой буквы: " + sum);
        }
    }
}
