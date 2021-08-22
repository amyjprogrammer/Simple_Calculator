using System;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDay(0));
            Console.WriteLine(LearnLoop(1));
            Console.WriteLine(DoWhileLoop(11));

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
        //Switch Statement
        static string GetDay(int dayNum)
        {
            string dayName;
            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }
            return dayName;
        }

        //while loop
        static int LearnLoop(int num)
        {
            while (num <= 5)
            {
                Console.WriteLine(num);
                num++;
                                
            }
            return num; //this prints out 1,2,3,4,5,6 6 is included, because that is the last number the while loop checked
        }

        //do while loop
        static int DoWhileLoop (int numb)
        {
            do
            {
                Console.WriteLine(numb); //prints out 11
                numb++;
            } while (numb <= 10);
            return numb; //prints out 12, because the do while loop added 1
        }
    }
}
