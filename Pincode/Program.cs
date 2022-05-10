using System;
using System.Linq;

namespace Pincode
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var reverse = "";
            for (int i = input.Length-1; i >= 0; i--)
            {
                reverse += input[i];
            }

            var nums = reverse.Split(' ').Select(i => int.Parse(i)).ToArray();
            if(nums[0] > nums[1])
            {
                Console.WriteLine(nums[0]);
            }
            else
            {
                Console.WriteLine(nums[1]);
            }
        }
    }
}
