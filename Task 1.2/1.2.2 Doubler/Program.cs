using System;

namespace _1._2._2_Doubler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст №1: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введите текст №2: ");
            string str2 = Console.ReadLine();

            for(int i = 0; i < str1.Length; i++)
            {
                for(int j = 0; j < str2.Length; j++)
                {
                    if(str1[i] == str2[j])
                    {
                        Console.Write(str1[i]);
                        break;
                    }
                }
                Console.Write(str1[i]);
            }
        }
    }
}
