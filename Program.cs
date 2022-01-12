using System;
using System.Text;

namespace fibonacci_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            const int steps = 7;
            Program program = new Program();
            program.PrintFibonacci(steps);

        }

        public bool IsEven(int number) => number % 2 == 0;
        public string CurrentMessage(int currentNumber) => IsEven(currentNumber) ? "Fizz" : "Buzz";
        string RepeatMessage(string message, int times) => new StringBuilder(message.Length * times).Insert(0, message, times).ToString();

        public void PrintFibonacci(int steps)
        {
            int currentNumber = 0;
            int latsNumber = 0;
            int aux = 0;
            string message = "";

            for(int i = 0; i < steps; i++)
            {
                if(i == 1)
                {
                    currentNumber = 1;
                    latsNumber = 0;
                }
                if(i > 1)
                {
                    aux = latsNumber;
                    latsNumber = currentNumber;
                    currentNumber = aux + latsNumber;
                }
                message = CurrentMessage(i + 1);
                if(currentNumber > 0) Console.WriteLine(RepeatMessage(message, currentNumber));
            }
        }
    }
}
