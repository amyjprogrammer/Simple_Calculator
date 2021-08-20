using System;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adding two numbers together.");
            Console.Write("Please enter your first number: ");
            double firstNum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter your second number: ");
            double secondNum = Convert.ToDouble(Console.ReadLine());

            double answer = secondNum + firstNum;

            Console.WriteLine("The answer is {0:0.00}", answer);
        }
    }
}
