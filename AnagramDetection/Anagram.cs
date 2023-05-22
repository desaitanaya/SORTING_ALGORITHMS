using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramDetection
{
    internal class Anagram
    {
        public void AnagramDetectionMethod(string firstString, string secondString)
        {
            if (firstString.Length != secondString.Length)
            {
                Console.WriteLine("String Length is not same");
            }

            char[] firstCharArray = firstString.ToLower().ToCharArray();
            char[] secondCharArray = secondString.ToLower().ToCharArray();
            char temp;

            for (int i = 0; i < firstCharArray.Length; i++)
            {
                for (int j = i + 1; j < firstCharArray.Length; j++)
                {
                    if (firstCharArray[i] > firstCharArray[j])
                    {
                        temp = firstCharArray[i];
                        firstCharArray[i] = firstCharArray[j];
                        firstCharArray[j] = temp;
                    }
                }

            }

            for (int i = 0; i < secondCharArray.Length; i++)
            {
                for (int j = i + 1; j < secondCharArray.Length; j++)
                {
                    if (secondCharArray[i] > secondCharArray[j])
                    {
                        temp = secondCharArray[i];
                        secondCharArray[i] = secondCharArray[j];
                        secondCharArray[j] = temp;
                    }
                }

            }

            int flag = 0;
            for (int i = 0; i < firstCharArray.Length; i++)
            {

                if (firstCharArray[i].ToString() == secondCharArray[i].ToString())
                {

                    Console.WriteLine("Both the strings are Anagram strings");
                    break;
                }
                else
                {
                    Console.WriteLine("Not an Anagram string");
                    break;
                }
            }
        }
    }
}
