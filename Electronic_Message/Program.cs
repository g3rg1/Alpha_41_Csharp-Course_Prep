using System;

namespace Electronic_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var index = 0;
            var maxLength = int.MinValue;
            var currentLength = 0;
            while (input[index] != '.')
            {
                var element = input[index];
                if (char.IsDigit(element) || char.IsLetter(element) || char.IsWhiteSpace(element))
                {
                    currentLength = 0;
                }
                else
                {
                    currentLength++;
                }

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }

                index++;
            }

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
            }
            Console.WriteLine(maxLength);
        }
    }
}
