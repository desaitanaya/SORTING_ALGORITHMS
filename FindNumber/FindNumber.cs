using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace FindNumber
{
    internal class FindNumber
    {
        public void FindNumberMethod(int left, int right)
        {
            while (left <= right)
            {
                int mid = (left + right) / 2;

                Console.WriteLine("Is the number equal to, greater than, or less than " + mid);
                Console.WriteLine("Enter 'equal', 'greater' or 'less'");
                string userInput = Console.ReadLine();

                if (userInput == "equal")
                {
                    Console.WriteLine("The number is: " +mid);
                    break;
                }
                else if (userInput == "greater")
                {
                    left = mid + 1;
                }
                else if (userInput == "less")
                {
                    right = mid - 1;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'equal', 'greater', or 'less'.");
                }
            }

        }
    }
}