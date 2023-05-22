namespace SortingAndSearchingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            while (choice != 2)
            {
                Console.WriteLine("**********MENU**********");
                Console.WriteLine("1.Binary Search \n2.Exit");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Enter choice :");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------------");

                switch (choice) {
                    case 1:
                        Console.WriteLine("BINARY SEARCH");
                        Console.WriteLine();
                        Console.WriteLine("1.Binary Search on Integer values \n2.Binary Search on String values");
                        int binarySearch = int.Parse(Console.ReadLine());
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
                }
            }
        }
    }
}