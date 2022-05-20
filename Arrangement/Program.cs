using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrangement
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var numsList = input.Split(' ').Select(i => int.Parse(i)).ToArray();
            bool ascending = false;
            bool descending = false;

            for (int i = 0; i < numsList.Length-1; i++)
            {
                if(!(numsList[i] < numsList[i+1]))
                {
                    break;
                }

                if(i == numsList.Length - 2)
                {
                    ascending = true;
                }
            }

            if(!ascending)
            {
                for (int i = 0; i < numsList.Length - 1; i++)
                {
                    if (!(numsList[i] > numsList[i + 1]))
                    {
                        break;
                    }

                    if (i == numsList.Length - 2)
                    {
                        descending = true;
                    }
                }
            }

            if(ascending)
            {
                Console.WriteLine("Ascending");
            }
            else if(descending)
            {
                Console.WriteLine("Descending");
            }
            else
            {
                Console.WriteLine("Mixed");
            }
        }
    }
}
