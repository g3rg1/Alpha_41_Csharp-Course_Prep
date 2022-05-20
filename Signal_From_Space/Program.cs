using System;
using System.Text;

namespace Signal_From_Space
{
    class Program
    {
        static void Main(string[] args)
        {
            var signal = new StringBuilder(Console.ReadLine());

            for (int i = 1; i < signal.Length; i++)
            {
                while (i < signal.Length && signal[i - 1] == signal[i])
                {
                    signal.Remove(i, 1);
                }
            }
            Console.WriteLine(signal.ToString());
        }
    }
}
