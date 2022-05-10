using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            var nums = new int[] { (n[0] - '0'), (n[1] - '0'), (n[2] - '0') };
            var largestSum = int.MinValue;
            var currentSum = 0;

            currentSum = nums[0] + nums[1] + nums[2];
            if (currentSum > largestSum)
            {
                largestSum = currentSum;
            }

            currentSum = nums[0] + nums[1] * nums[2];
            if (currentSum > largestSum)
            {
                largestSum = currentSum;
            }

            currentSum = nums[0] * nums[1] * nums[2];
            if (currentSum > largestSum)
            {
                largestSum = currentSum;
            }
            currentSum = nums[0] * nums[1] + nums[2];
            if (currentSum > largestSum)
            {
                largestSum = currentSum;
            }
            Console.WriteLine(largestSum);
        }
    }
}
