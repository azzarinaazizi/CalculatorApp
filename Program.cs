using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Welcome to Simple Calculator!");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Choose an operation: add, subtract, multiply, divide");
            string operation = Console.ReadLine()?.ToLower();

            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = 0;

            switch (operation)
            {
                case "add":
                    result = Add(num1, num2);
                    break;
                case "subtract":
                    result = Subtract(num1, num2);
                    break;
                case "multiply":
                    result = Multiply(num1, num2);
                    break;
                case "divide":
                    result = Divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }

            Console.WriteLine($"Result: {result}");
        }

        static int Add(int a, int b) => a + b;
        static int Subtract(int a, int b) => a - b;
        static int Multiply(int a, int b) => a * b;
        static int Divide(int a, int b) => b == 0 ? 0 : a / b;
    }
}
