using System;
using System.Collections.Generic;
using System.Linq;

namespace Combine_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = Console.ReadLine().Split(',').Select(n => int.Parse(n)).ToList();
            var secondList = Console.ReadLine().Split(',').Select(n => int.Parse(n)).ToList();

            var combinedList = new List<int>();

            for (int i = 0; i < firstList.Count; i++)
            {
                combinedList.Add(firstList[i]);
                combinedList.Add(secondList[i]);
            }

            Console.WriteLine(string.Join(",", combinedList));
        }
    }
}
