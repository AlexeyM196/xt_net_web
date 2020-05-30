using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _1._1._6_Font_adjustment
{
    class Program
    {
        [Flags] 
        public enum Style
        {
            None = 0,
            Bold = 1,
            Italic = 10,
            Underline = 100
        }
        static void Main(string[] args)
        {
            int value = 0;
            Style style = Style.None;
            Console.WriteLine("Параметры надписи: " + style);
            Console.WriteLine("Введите:\n 1: Bold\n 2: Italic\n 3: Underline");
            while (true)
            {
                int.TryParse(Console.ReadLine(), out value);
                switch(value)
                {
                    case 0:
                        style = style ^ Style.None;
                        break;
                    case 1:
                        style = style ^ Style.Bold;
                        break;
                    case 2:
                        style = style ^ Style.Italic;
                        break;
                    case 3:
                        style = style ^ Style.Underline;
                        break;
                }
                Console.WriteLine("Параметры надписи: " + style);
                Console.WriteLine("Введите:\n 1: Bold\n 2: Italic\n 3: Underline");
            }
        }
    }
}
