namespace FindNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the limit: ");
            int n = int.Parse(Console.ReadLine());

            int left= 0;
            int right = (int)Math.Pow(2, (n-1));

            Console.WriteLine("Think of a number between 0 and " + right);

            FindNumber findNumber = new FindNumber();
            Console.WriteLine("The number is: ");
            findNumber.FindNumberMethod(left, right);

           
        }
    }
}