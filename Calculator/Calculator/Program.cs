using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculato");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Subtractor");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("divide");
            int ch = Int32.Parse(Console.ReadLine());
            int a, b, c;
            switch (ch)
            {
                case 1:
                    Console.WriteLine("enter a:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter b:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a + b;
                    Console.WriteLine("Sum = {0}", c);
                    break;
                case 2:
                    Console.WriteLine("enter b:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter b:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a - b;
                    Console.WriteLine("Subtract = {0}", c);
                    break;
                case 3:
                    Console.WriteLine("enter b:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter b:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a * b;
                    Console.WriteLine("Multiply = {0}", c);
                    break;
                case 4:
                    Console.WriteLine("enter b:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter b:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a / b;
                    Console.WriteLine("Divide = {0}", c);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;

            }
            Console.ReadKey();
        }
    }
}
