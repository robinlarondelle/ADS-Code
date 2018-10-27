using System;

namespace ADS.Class2.Homework
{
    class Opdracht2
    {
        public void Run()
        {
            string input = "soossoos";
            Console.WriteLine("{0} is a palindrome: {1}", input, IsPalinDrome(input));
        }

        private bool IsPalinDrome(string input)
        {
            if (input.Length <= 1)
            {
                return true;
            }

            if (input[0]==input[input.Length-1])
            {
                return IsPalinDrome(input.Substring(1, input.Length - 2));
            }
            return false;
        }
    }
}
