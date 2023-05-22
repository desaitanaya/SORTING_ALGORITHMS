using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SortingAndSearchingAlgorithms
{

    class BinarySearch<T>
    {

        //Method for sorting the array elements
        public void SortMethod<T>(int size, T[] array) where T : IComparable<T>
        {
            T temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i].CompareTo(array[j]) > 0)
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }

            }

        }

        public int SearchMethod<T>(T[] array, T element) where T : IComparable<T>
        {
            SortMethod(array.Length - 1, array);

            int lowerBound = 0;
            int upperBound = array.Length - 1;
            int middle;

            while (lowerBound <= upperBound)
            {
                middle = (lowerBound + upperBound) / 2;

                if (element.CompareTo(array[middle]) == 0)
                {
                    return middle;
                }
                else if (element.CompareTo(array[middle]) > 0)
                {
                    lowerBound = middle + 1;
                }
                else if (element.CompareTo(array[middle]) < 0)
                {
                    upperBound = middle - 1;


                }
            }
            return -1;
        }

        public void UserInputIntArray<T>()
        {
            int size;
            Console.WriteLine("Enter the size of array :");
            size = int.Parse(Console.ReadLine());

            int[] intArray = new int[size];


            Console.WriteLine("Enter the array elements :");
            for (int index = 0; index < size; index++)
            {
                intArray[index] = int.Parse(Console.ReadLine());
            }

            int intElement = 0;
            Console.WriteLine("Enter the element to be searched :");
            intElement = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------");

            SortMethod(size, intArray);
            int result = SearchMethod(intArray, intElement);
            if (result > 0)
            {
                Console.WriteLine("Element is present in array");
                Console.WriteLine("-----------------------------------");
            }
            else
            {
                Console.WriteLine("Element is not present in array");
                Console.WriteLine("-----------------------------------");
            }
        }

        public void UserInputStringArray<T>() {

            int size;
            Console.WriteLine("Enter the size of array :");
            size = int.Parse(Console.ReadLine());

            string[] strArray = new string[size];


            Console.WriteLine("Enter the array elements :");
            for (int index = 0; index < size; index++)
            {
                strArray[index] = Console.ReadLine();
            }

            string strElement;
            Console.WriteLine("Enter the element to be searched :");
            strElement = Console.ReadLine();
            Console.WriteLine("-----------------------------------");

            SortMethod(size, strArray);
            int result = SearchMethod(strArray, strElement);
            if (result > 0)
            {
                Console.WriteLine("Element is present in array");
                Console.WriteLine("-----------------------------------");
            }
            else
            {
                Console.WriteLine("Element is not present in array");
                Console.WriteLine("-----------------------------------");
            }
        }

    }


    
}
