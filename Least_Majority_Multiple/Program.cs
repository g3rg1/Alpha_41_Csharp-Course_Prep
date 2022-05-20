using System;

namespace Least_Majority_Multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 5;
            var nums = new int[count];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(nums);

            int checks;

            for (int i = nums[0];; i++)
            {
                checks = 0;

                for (int j = 0; j < nums.Length; j++)
                {
                    if(i%nums[j]==0)
                    {
                        checks++;
                    }
                }

                if(checks >= 3)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
