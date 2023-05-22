namespace AnagramDetection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Anagram anagramDetection = new Anagram();

            string firstString, secondString;

            Console.WriteLine("Enter the First String:");
            firstString = Console.ReadLine();

            Console.WriteLine("Enter the Second String:");
            secondString = Console.ReadLine();

            anagramDetection.AnagramDetectionMethod(firstString, secondString);

        }
    }
}