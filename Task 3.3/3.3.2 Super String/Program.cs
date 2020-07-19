using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._2_Super_String
{
    public enum TypeLanguages
    {
        English,
        Russian,
        Numbers,
        Mixed
    }
    public static class ExtentionString
    {
        public static TypeLanguages Checklanguage(this string str)
        {
            str = string.Join("", str.Where(i => Char.IsLetterOrDigit(i)));

            if (str == string.Empty)
            {
                throw new ArgumentException("String is empty");
            }

            if (str.All(i => Char.IsNumber(i)))
            {
                return TypeLanguages.Numbers;
            }

            else if (str.All(i => Char.IsLetter(i) && i < 1000))
            {
                return TypeLanguages.English;
            }

            else if (str.All(i => Char.IsLetter(i) && i > 1000))
            {
                return TypeLanguages.Russian;
            }

            return TypeLanguages.Mixed;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string str = Console.ReadLine();
            Console.WriteLine("Тип языка: {0}", str.Checklanguage());
        }
    }
}
