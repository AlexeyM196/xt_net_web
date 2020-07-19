using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1._1_Weakest_link
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> roundPeople = new List<int>();
            Console.WriteLine("Введите количество людей: ");
            int.TryParse(Console.ReadLine(), out int sum);
            Console.WriteLine("Введите, какой по счету человек будет вычеркнут каждый раунд: ");
            int.TryParse(Console.ReadLine(), out int removedPeople);

            if(sum <= 0 || removedPeople <= 0)
            {
                throw new FormatException("Заданы неверные параметры");
            }
            for (int i = 0; i < sum; i++)
            {
                roundPeople.Add(i + 1);
            }
            int count = 1;
            while (roundPeople.Count >= removedPeople)
            {
                foreach (int item in roundPeople)
                {
                    if (item / removedPeople == 0)
                    {
                        roundPeople.RemoveAt(item);
                        Console.WriteLine("Раунд {0}. Вычеркнут человек. Людей осталось: {1}", count, roundPeople.Count);
                        break;
                    }
                }
                count++;
            }
            Console.WriteLine("Игра окончена. Невозможно вычеркнуть больше людей.");
        }
    }
}
