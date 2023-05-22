using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAndSearchingAlgorithms
{
    class InsertionSort<T>
    {
        public void InsertionSortMethod<T>(int size, T[] array) where T : IComparable<T>
        {
            for (int i = 0; i < size-1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    int k = j - 1;
                    if (array[k].CompareTo(array[j]) > 0)
                    {
                        T temp = array[k];
                        array[k] = array[j];
                        array[j] = temp;
                    }
                }
            }

            for (int i = 0; i < size; i++)
            {
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
            InsertionSortMethod(size, array);
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
            InsertionSortMethod(size, array);
            Console.WriteLine("-----------------------------------");

        }

    }
}
    

