using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Input the operand (first number) in the operation:");
            string operandString = Console.ReadLine();

            if (!double.TryParse(operandString, out double operand))
            {
                Console.WriteLine("You did not input a valid operand!");
                continue;
            }

            Console.WriteLine("Input the operation (add, subtract, multiply, or divide):");
            string operation = Console.ReadLine();

            if (operation != "add" && operation != "subtract" && operation != "multiply" && operation != "divide")
            {
                Console.WriteLine("You did not input a valid operation!");
                continue;
            }

            Console.WriteLine("Input the operator (second number) in the operation:");
            string operatorString = Console.ReadLine();

            if (!double.TryParse(operatorString, out double operatorNumber))
            {
                Console.WriteLine("You did not input a valid operator!");
                continue;
            }

            double result = 0;

            switch (operation)
            {
                case "add":
                    result = operand + operatorNumber;
                    break;
                case "subtract":
                    result = operand - operatorNumber;
                    break;
                case "multiply":
                    result = operand * operatorNumber;
                    break;
                case "divide":
                    if (operatorNumber == 0)
                    {
                        Console.WriteLine("You cannot divide by zero!");
                        continue;
                    }
                    result = operand / operatorNumber;
                    break;
                default:
                    Console.WriteLine("You did not input a valid operation!");
                    continue;
            }

            Console.WriteLine($"The result of {operand} {operation} {operatorNumber} is {result}.");
            Console.WriteLine("Would you like to do another calculation? (n, any other input will continue)");

            string response = Console.ReadLine();

            if (response == "n")
            {
                break;
            }
        }
    }
}