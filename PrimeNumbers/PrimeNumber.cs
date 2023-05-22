using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    internal class PrimeNumber
    {
        public void PrimeNumberMethod(int size, int[] array) { 
        int flag = 0, sum = 0;
            for (int i = 2; i < size; i++)
            {
                for (int j = 2; j <= i / 2; j++)
                {
                    //Condition to check a prime number
                    if (i % j == 0)
                    {
                        flag = 1;
                        break;

                    }
                    else
                    {
                        flag = 0;
                    }

                }


                if (flag == 0)
                {
                    Console.WriteLine(i);
                }

            }
            
            }
            
    }
}
