using System;

namespace Forest_Road
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', i));
                Console.Write('*');
                Console.Write(new string('.', n - i - 1));
                Console.WriteLine();
            }

            for (int i = n-2; i >= 0; i--)
            {
                Console.Write(new string('.', i));
                Console.Write('*');
                Console.Write(new string('.', n - i - 1));
                Console.WriteLine();
            }
        }
    }
}
