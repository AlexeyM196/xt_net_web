using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3._2._1_Dynamic_array
{
    public class DynamicArray<T> 
    {
        public int arrayLenght = 8;
        public T[] mass;
        public int Count { get; protected set; }
        public int Capacity => mass.Length;
        public DynamicArray()
        {
            mass = new T[arrayLenght];
        }
        public DynamicArray(int capacity)
        {
            arrayLenght = capacity;
            mass = new T[arrayLenght];
        }
        public DynamicArray(IEnumerable<T> collection)
        {
            Count = collection.Count();
            mass = collection.ToArray();
        }
        protected void ChangeSizeArray(Func<int, int> func)
        {
            T[] tempMass = new T[func(mass.Length)];
            Array.Copy(mass, tempMass, Count);
            mass = tempMass;
        }
        public void Add(T item)
        {
            if(Count >=  mass.Length)
            {
                ChangeSizeArray(x => x * 2);
            }
            mass[Count] = item;
            Count++;
        }
        public void AddRange(IEnumerable<T> collection)
        {
            if (mass.Length - Count < collection.Count())
            {
                int arrayCellsAdded = collection.Count() - (mass.Length - Count);
                ChangeSizeArray(x => x + arrayCellsAdded);
            }
            collection.ToArray().CopyTo(mass, Count);
            Count += collection.Count();
        }
        public int IndexOf(T item)
        {
            for(int i = 0; i < Count; i++)
            {
                if(mass[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
        public void RemoveAt(int index)
        {
            if(index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException("There is no index in the array");
            }
            for(int i = index; i < Count; i++)
            {
                if (!(i + 1 == Count))
                {
                    mass[i] = mass[i + 1];
                }
            }
            Count--;
        }
        public bool Remove(T item)
        {
            int temp = IndexOf(item);
            if(temp == -1)
            {
                return false;
            }
            RemoveAt(temp);
            return true;
        }
        public bool Insert(T item, int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException("There is no index in the array");
            }

            mass[index] = item;
            return true;
        }
        public T this[int index]
        {
            get
            {
                if (Count != 0 && index < Count)
                {

                    return mass[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Argument is out of range");
                }
            }
            set
            {
                if (Count != 0 && index < Count)
                {
                    

                    mass[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Argument is out of range");
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> arr1 = new DynamicArray<int>();
            Console.WriteLine("Конструктор без параметров, вместимость: {0}", arr1.Capacity);
            Console.WriteLine();

            DynamicArray<int> arr2 = new DynamicArray<int>(6);
            Console.WriteLine("Конструктор c параметром 6, вместимость: {0}", arr2.Capacity);
            Console.WriteLine();

            List<int> lst1 = new List<int> { 1, 2, 3, 4 };
            DynamicArray<int> arr3 = new DynamicArray<int>(lst1);
            Console.Write("Конструктор принимающий колекцию, вместимость: {0}.", arr2.Capacity);
            Console.Write("Содержимое массива принимаеющий колекцию: ");
            for(int i = 0; i < arr3.Count; i++)
            {
                Console.Write(" " + arr3[i]);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Метод Add добавляет элементы и удваивает емкость в случае ее не хватки:");
            int count = 1;
            while (count < 9)
            {
                arr2.Add(count);
                Console.WriteLine("Колличество элементов: {0}, вместимость: {1}", arr2.Count, arr2.Capacity);
                count++;
            }
            Console.WriteLine();

            Console.WriteLine("Метод AddRange добавляющий в конец массива содержимое коллекции IEnumerable.");
            arr2.AddRange(lst1);
            Console.WriteLine("Колличество элементов: {0}, вместимость: {1}", arr2.Count, arr2.Capacity);
            Console.WriteLine();

            Console.WriteLine("Метод Remove удаляющий из коллекции пепрвое вхождение заданного элемента.");
            Console.WriteLine(arr2.Remove(3));
            Console.WriteLine("Колличество элементов: {0}, вместимость: {1}", arr2.Count, arr2.Capacity);
            Console.WriteLine();

            Console.WriteLine("Метод Insert, позволяющую вставить объект по нужному индексу");
            Console.WriteLine(arr2.Insert(3, 0));
            Console.WriteLine("Измененный элемент: {0}", arr2[0]);
            Console.WriteLine();

            Console.WriteLine("Свйойство Lenght: - получение колличества элементов (В данном случае Count): {0}, вместимость: {1}", arr2.Count, arr2.Capacity);

            Console.WriteLine("Доступ по индексу:");
            for (int i = 0; i < arr3.Count; i++)
            {
                Console.WriteLine("Индекс: {0} , элемент: {1}", i, arr3[i]);
            }
        }
    }
}
