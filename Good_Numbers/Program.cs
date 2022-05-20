using System;
using System.Linq;

namespace Good_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            var goodNums = 0;

            for (int i = nums[0]; i <= nums[1]; i++)
            {
                bool good = true;
                var numToCheck = i.ToString();

                for (int j = 0; j < numToCheck.Length; j++)
                {
                    if(numToCheck[j] - '0' == 0)
                    {
                        continue;
                    }
                    else if(i %(numToCheck[j] - '0') != 0)
                    {
                        good = false;
                    }
                }

                if(good)
                {
                    goodNums++;
                }
            }
            Console.WriteLine(goodNums);
        }
    }
}
