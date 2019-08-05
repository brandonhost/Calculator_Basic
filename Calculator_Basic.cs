using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter first number");
                double num1;
                while (!double.TryParse(Console.ReadLine(), out num1)) {
                    Console.WriteLine("Invalid number");
                }

                Console.WriteLine("Enter second number");
                double num2;
                while (!double.TryParse(Console.ReadLine(), out num2)) {
                    Console.WriteLine("Invalid number");
                }

                Console.WriteLine("Enter operator (+, -, *, /)");
                string op = Console.ReadLine();

                Console.Write("Answer: ");
                switch (op)
                {
                    case "+":
                        Console.WriteLine(num1 + num2);
                        break;
                    case "-":
                        Console.WriteLine(num1 - num2);
                        break;
                    case "*":
                        Console.WriteLine(num1 * num2);
                        break;
                    case "/":
                        Console.WriteLine(num1 / num2);
                        break;
                    default:
                        Console.WriteLine("Incorrect operator");
                        break;
                }
            }
        }
    }
}