using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAndSearchingAlgorithms
{
    internal class MergeSort<T>
    {
        public void SortArray<T>(T[] array) where T : IComparable<T>
        {
            
            if (array.Length <= 1)
                return;

            int mid = array.Length / 2;

            T[] left = new T[mid];
            T[] right = new T[array.Length - mid];

            for (int i = 0; i < mid; i++)
            {
                left[i] = array[i];
            }

            for (int i = mid; i < array.Length; i++)
            {
                right[i - mid] = array[i];
            }


            SortArray<T>(left);
            SortArray<T>(right);

            // Merge the sorted subarrays
            Merge<T>(left, right, array);
        }

        public void Merge<T>(T[] left, T[] right, T[] result) where T : IComparable<T>
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int resultIndex = 0;

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex].CompareTo(right[rightIndex]) < 0)
                {
                    result[resultIndex] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    result[resultIndex] = right[rightIndex];
                    rightIndex++;
                }
                resultIndex++;
            }

            // Copy any remaining elements from the left subarray
            while (leftIndex < left.Length)
            {
                result[resultIndex] = left[leftIndex];
                leftIndex++;
                resultIndex++;
            }

            // Copy any remaining elements from the right subarray
            while (rightIndex < right.Length)
            {
                result[resultIndex] = right[rightIndex];
                rightIndex++;
                resultIndex++;
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
            SortArray(array);
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(array[i]);
            }
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
            SortArray(array);
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("-----------------------------------");

        }

    }
}


