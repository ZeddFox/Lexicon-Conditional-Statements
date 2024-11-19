using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Conditional_Statements
{
    internal class Calculator
    {
        public void Run()
        {
            Console.WriteLine("Welcome to the calculator. Please enter your first number:");
            double numOne = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Please enter your second number. Your first number was " + numOne);

            double numTwo = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Please enter your operation. Your first number was " + numOne + " and your second number was " + numTwo);
            Console.WriteLine("Your operation alternatives are: add, subtract, multiply, divide");

            string inputString = Convert.ToString(Console.ReadLine().ToLower());

            Console.Clear();
            Console.WriteLine("You selected " + inputString + " and your numbers were, " + numOne + " and " + numTwo + ".");
            Console.WriteLine("Result: " + Calculate(inputString, numOne, numTwo));

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
        double Calculate(string operation, double valueOne, double valueTwo)
        {
            switch (operation)
            {
                case "add":
                    return Add(valueOne, valueTwo);

                case "subtract":
                    return Subtract(valueOne, valueTwo);

                case "multiply":
                    return Multiply(valueOne, valueTwo);

                case "divide":
                    return Divide(valueOne, valueTwo);

                default:
                    return 0d;
            }
        }

        double Add(double valueOne, double valueTwo)
        {
            return valueOne + valueTwo;
        }

        double Subtract(double valueOne, double valueTwo)
        {
            return valueOne - valueTwo;
        }
        double Multiply(double valueOne, double valueTwo)
        {
            return valueOne * valueTwo;
        }

        double Divide(double valueOne, double valueTwo)
        {
            return valueOne / valueTwo;
        }
    }
}
