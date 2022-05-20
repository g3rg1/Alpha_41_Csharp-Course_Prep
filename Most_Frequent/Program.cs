using System;
using System.Collections.Generic;

namespace Most_Frequent
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<int, int>();
            var value = 1;
            var mostCommonValue = int.MinValue;
            var mostCommonKey = 0;

            for (int i = 0; i < n; i++)
            {
                var currentNum = int.Parse(Console.ReadLine());

                if (!dict.TryAdd(currentNum, value))
                {
                    dict[currentNum]++;
                }
            }

            foreach (var key in dict)
            {
                if(key.Value > mostCommonValue)
                {
                    mostCommonValue = key.Value;
                    mostCommonKey = key.Key;
                }
            }
            Console.WriteLine($"{mostCommonKey} ({mostCommonValue} times)");
        }
    }
}
