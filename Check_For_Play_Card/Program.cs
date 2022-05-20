using System;

namespace Check_For_Play_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var cards = new string[]
            { "2", "3", "4", "5",
              "6", "7", "8", "9", "10",
              "J", "Q", "K", "A"
            };

            bool check = false;

            foreach (var card in cards)
            {
                if(input == card)
                {
                    check = true;
                    break;
                }
            }

            if(check)
            {
                Console.WriteLine("yes {0}", input);
            }
            else
            {
                Console.WriteLine("no {0}", input);
            }
        }
    }
}
