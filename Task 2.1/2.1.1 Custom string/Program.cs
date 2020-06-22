using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomString;

namespace _2._1._1_Custom_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string z = "qqqwwwe";
            char[] a = { 'q', 'w', 'e', 'r', 't', 'y', 'y' };
            char[] b = { 'q', 'w', 'e', 'r', 't', 'y' };
            char[] c = { 'y', 't', 'r', 'e', 'w', 'q' };
            char[] d = { 'q', 'w', 'e', 'r', 't', 'y' };

            Console.WriteLine("Возвращаем элемент массива по индексу");
            Console.WriteLine(CharArray.Indexer(a, 3));

            Console.WriteLine();
            Console.WriteLine("Конвертируем строку в массив символов");
            CharArray.ConvertToChar(z);
            foreach(char item in z)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("Возвращаем количество символов в массиве");
            Console.WriteLine(CharArray.SumChar(a));

            Console.WriteLine();
            Console.WriteLine("Конвертируем массив символов в строку");
            Console.WriteLine(CharArray.ConvertToString(b));

            Console.WriteLine();
            Console.WriteLine("Находим символ в массиве и его позицию");
            CharArray.Search(c, 'e');
            CharArray.Search(c, 'b');

            Console.WriteLine();
            Console.WriteLine("Возвращаем новый массив символов состоящий из двух других массивов");
            Console.WriteLine(CharArray.Concatenation(a, c));

            Console.WriteLine();
            Console.WriteLine("Сравниваем массивы на равенство");
            CharArray.Comparison(b, d);
            CharArray.Comparison(c, d);

            Console.WriteLine();
            Console.WriteLine("Находим количество задоного символа в массиве");
            CharArray.SearchSumChar(a, 'y');
        }
    }
}
