using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Basic
{
    class Program
    {
        private static readonly string[] operators = { "+", "-", "*", "/", "%" };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter first number");
                double num1;
                while (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Invalid number");
                }

                Console.WriteLine("Enter second number");
                double num2;
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Invalid number");
                }

                Console.WriteLine("Enter operator (" + string.Join(", ", operators) + ")");

                string op = Console.ReadLine();
                while (Array.IndexOf(operators, op) == -1)
                {
                    Console.WriteLine("Invalid operator, try again: ");
                    op = Console.ReadLine();
                }

                Console.Write("Answer: ");
                switch (op)
                {
                    case "+":
                        Console.Write(num1 + num2);
                        break;
                    case "-":
                        Console.Write(num1 - num2);
                        break;
                    case "*":
                        Console.Write(num1 * num2);
                        break;
                    case "/":
                        Console.Write(num1 / num2);
                        break;
                    //case "%":
                    //    Console.Write(num1 % num2);
                    //    break;
                    default:
                        Console.Write("Operator not implemented yet.");
                        break;
                }
                Console.WriteLine("\n------------------------");
            }
        }
    }
}
