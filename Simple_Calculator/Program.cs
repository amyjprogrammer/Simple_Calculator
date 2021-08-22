using System;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first number: ");
            double firstNum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your operator: ");
            string oper = Console.ReadLine();

            Console.Write("Please enter your second number: ");
            double secondNum = Convert.ToDouble(Console.ReadLine());

            if (oper == "+")
            {
                Console.WriteLine(firstNum + secondNum);
            } else if (oper == "-")
            {
                Console.WriteLine(firstNum - secondNum);
            } else if (oper == "/")
            {
                Console.WriteLine(firstNum / secondNum);
            } else if (oper == "*")
            {
                Console.WriteLine(firstNum * secondNum);
            } else
            {
                Console.WriteLine("Please use *, +, - or / for the operator");
            }
            
        }
    }
}
