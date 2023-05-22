using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAndSearchingAlgorithms
{
    internal class BubbleSort<T>
    {
        public void BubbleSortMethod<T>(int size, T[] array) where T : IComparable<T>
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
                Console.WriteLine(array[i]);
            }

        }

        public void UserInputIntArray<T>()
        {
            Console.WriteLine("Enter the size of array :");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            Console.WriteLine("Enter the array elements :");
            for (int index = 0; index < size; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Sorted elements are :");
            BubbleSortMethod(size, array);
            Console.WriteLine("-----------------------------------");

        }

        public void UserInputStringArray<T>()
        {
            Console.WriteLine("Enter the size of array :");
            int size = int.Parse(Console.ReadLine());

            string[] array = new string[size];

            Console.WriteLine("Enter the array elements :");
            for (int index = 0; index < size; index++)
            {
                array[index] = Console.ReadLine();
            }
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Sorted elements are :");
            BubbleSortMethod(size, array);
            Console.WriteLine("-----------------------------------");

        }

    }
}