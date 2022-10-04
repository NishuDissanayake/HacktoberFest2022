using System;
using CalLibrary;

namespace Hactoberfest2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number : ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Select a Operation [+, -, *, /]");

            char opt = char.Parse(Console.ReadLine());


            switch (opt)
            {
                case '+':
                    Console.WriteLine(Calculations.Addition(num1, num2));
                    break;

                case '-':
                    Console.WriteLine("Not yet implemented");
                    break;

                case '*':
                    Console.WriteLine("Not yet implemented");
                    break;

                case '/':
                    Console.WriteLine("Not yet implemented");
                    break;

                default:
                    break;
            }
        }
    }
}
