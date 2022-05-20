using System;
using System.Collections.Generic;

namespace Biggest_Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sieveCheck = new bool[n - 1];

            for (int i = 0; i < sieveCheck.Length; i++)
            {
                var numToCheck = 0;
                
                if(!sieveCheck[i])
                {
                    numToCheck = i + 2;
                }
                else
                {
                    continue;
                }

                for (int j = i;;)
                {
                    j += numToCheck;
                    if(j >= sieveCheck.Length)
                    {
                        break;
                    }
                    sieveCheck[j] = true;
                }
            }

            for (int i = sieveCheck.Length-1; i >= 0; i--)
            {
                if(!sieveCheck[i])
                {
                    Console.WriteLine(i+2);
                    break;
                }
            }
        }
    }
}
