using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(',').Select(n => int.Parse(n)).ToArray();

            var missingNums = new List<int>();
             
            for (int i = 1; i <= nums.Length; i++)
            {
                bool check = false;

                for (int j = 0; j < nums.Length; j++)
                {
                    if(i == nums[j])
                    {
                        check = true;
                        break;
                    }
                }

                if(!check)
                {
                    missingNums.Add(i);
                }
            }

            Console.WriteLine(string.Join(",", missingNums));
        }
    }
}
