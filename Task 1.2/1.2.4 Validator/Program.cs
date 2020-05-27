using System;
using System.Collections.Generic;

namespace _1._2._4_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            //ЗАДАНИЕ НЕ ГОТОВО
            //Console.WriteLine("Введите текст: ");
            //string str = Console.ReadLine();
            var base_string = "я плохо учил русский язык. забываю начинать предложения с заглавной. хорошо, что можно написать программу!";
            var words = base_string.Replace(".", ".@").Replace("?", "?@").Replace("!", "!@").Split('@');
            List<string> words1 = new List<string>();
            
            foreach (var word in words)
            {
                if (!string.IsNullOrEmpty(word) && char.IsLower(word[0]) && char.IsLetter(word[0]))
                {
                    words1.Add(word.Replace(word[0], char.ToUpper(word[0]))) ;
                }
            }
            foreach(string word in words1)
            {
                Console.Write(word);
            }
        }
    }
}
