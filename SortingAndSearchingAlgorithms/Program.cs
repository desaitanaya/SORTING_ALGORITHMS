namespace SortingAndSearchingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            while (choice != 3)
            {
                Console.WriteLine("**********MENU**********");
                Console.WriteLine("1.Binary Search \n2.Insertion Sort \n3.Bubble Sort \n4.Exit");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Enter choice :");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------------");

                switch (choice) {
                    case 1:
                        Console.WriteLine("BINARY SEARCH");
                        Console.WriteLine();
                        Console.WriteLine("1.Binary Search on Integer values \n2.Binary Search on String values");
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Enter choice :");
                        int binarySearch = int.Parse(Console.ReadLine());
                        Console.WriteLine("-----------------------------------");
                        if (binarySearch == 1)
                        {
                            BinarySearch<int> intArray = new BinarySearch<int>();
                            intArray.UserInputIntArray<int>();
                        }
                        else
                        {
                            BinarySearch<string> strArray = new BinarySearch<string>();
                            strArray.UserInputStringArray<string>();
                        }
                        
                        break;

                    case 2:
                        Console.WriteLine("INSERTION SORT");
                        Console.WriteLine();
                        Console.WriteLine("1.Insertion Sort on Integer values \n2.Insertion Sort on String values");
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Enter choice :");
                        int insertionSort = int.Parse(Console.ReadLine());
                        Console.WriteLine("-----------------------------------");

                        if (insertionSort == 1)
                        {
                            InsertionSort<int> intArray = new InsertionSort<int>();
                            intArray.UserInputIntArray<int>();
                        }
                        else
                        {
                            InsertionSort<string> strArray = new InsertionSort<string>();
                            strArray.UserInputStringArray<string>();
                        }

                        break;

                    case 3:
                        Console.WriteLine("BUBBLE SORT");
                        Console.WriteLine();
                        Console.WriteLine("1.Bubble Sort on Integer values \n2.Bubble Sort on String values");
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Enter choice :");
                        int bubbleSort = int.Parse(Console.ReadLine());
                        Console.WriteLine("-----------------------------------");

                        if (bubbleSort == 1)
                        {
                            BubbleSort<int> intArray = new BubbleSort<int>();
                            intArray.UserInputIntArray<int>();
                        }
                        else
                        {
                            BubbleSort<string> strArray = new BubbleSort<string>();
                            strArray.UserInputStringArray<string>();
                        }

                        break;

                }
            }
        }
    }
}