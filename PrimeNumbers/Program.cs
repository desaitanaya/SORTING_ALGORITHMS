namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrimeNumber primeNumber = new PrimeNumber();

            int size;

            Console.WriteLine("Enter the size of array :");
            size = int.Parse(Console.ReadLine());

            //Array declaration
            int[] array = new int[size];

            

            Console.WriteLine("PRIME NUMBERS");
            primeNumber.PrimeNumberMethod(size, array);
        }
    }
}