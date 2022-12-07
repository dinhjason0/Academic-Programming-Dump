using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int sum = 0;
            int[] x = new int[n];
            for (int i = 0; i<x.Length;i++)
            {
                x[i] = (x.Length-i) * 2;
                Console.WriteLine("Int: {0}", x[i]);
                sum += x[i];
                Console.WriteLine("Sum: {0}", sum);
            }
        }
    }

    class GuessingGameHelper
    {
        public void PrintGreeting()
        {
            Console.WriteLine("Guess the secret number ( between 0 and 31) in 5 guesses.");
        }
        public void PrintFeedback(int x, int y)
        {
            if (x > y)
                Console.WriteLine("Your guess is too low");
            if (y > x)
                Console.WriteLine("Your guess is too high");
        }
        public void PrintPreviousGuesses(int[] x)
        {
            Console.Write("Your guesses so far are: ");
            for (int i = 0; i < x.Length; i++)
                Console.Write("{0} ",x[i]);
            Console.WriteLine();
        }
        public double GetSuggestion(int x, int y)
        {
            if (x > y)
                return ((y - 31.0) / 2.0);
            if (y > x)
                return (y / 2.0);
            return -.0;
        }
    }
}
