using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1._2_Text_analysis
{
    public class StrManager
    {
        public static void CountWords(string str)
        {
            string[] words = str.ToLower().Replace(".", "").Replace(",", "").Replace(";", "").Replace(":", "").Replace("!", "")
                .Replace("?", "").Replace("(", "").Replace(")", "").Replace("[", "").Replace("]", "").Replace("~", "")
                .Replace("`", "").Replace("@", "").Replace("#", "").Replace("$", "").Replace("№", "").Replace("%", "")
                .Replace("^", "").Replace("&", "").Replace("*", "").Replace("-", "").Replace("_", "").Replace("+", "")
                .Replace("=", "").Replace("{", "").Replace("}", "").Replace("'", "").Replace(@"""", "").Replace("|", "")
                .Replace(@"\", "").Replace("<", "").Replace(">", "").Replace("/", "").Split(' ');

            List<string> words1 = new List<string>();
            foreach(string item in words)
            {
                words1.Add(item);
            }

            for(int i = 0; i < words1.Count; i++)
            {
                for(int j = i + 1; j < words1.Count; j++)
                {
                    if(words1[i] == words1[j])
                    {
                        words1.RemoveAt(j);
                    }
                }
            }

            foreach (string word1 in words1)
            {
                int count = 0;
                foreach (string item in words)
                {
                    if (item == word1)
                    {
                        count++;
                    }
                }
                Console.WriteLine("{0} : {1}", word1, count);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            int value = 0;
            while(value != 3)
            {
                Console.WriteLine("1. Enter text:");
                Console.WriteLine("2. Print the number of words:");
                Console.WriteLine("3. Exit.");
                int.TryParse(Console.ReadLine(), out value);
                switch (value)
                {
                    case 1:
                        str = Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        if(str == null)
                        {
                            Console.WriteLine("Need enter text.");
                        }
                        else 
                        {
                            Console.Clear();
                            StrManager.CountWords(str);
                            Console.WriteLine();
                        }
                        break;
                }
            }
        }
    }
}
