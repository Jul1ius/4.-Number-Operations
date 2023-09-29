using System;

namespace _4._Number_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string op = Console.ReadLine();
            
            switch (op)
            {
                    case "+":
                    total = num1 + num2;
                    break;
                    case "-":
                    total = num1 - num2;
                    break ;
                    case "*":
                    total = num1 * num2;
                    break;
                    case "/":
                    total = num1 / num2;
                    break;
            }
            Console.WriteLine(total);
        }
    }
}
