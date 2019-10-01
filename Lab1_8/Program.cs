using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the X for an expression 3x^4-5x^3+2x^2-x+7: ");
            Console.Write("X = ");
            double x = double.Parse(Console.ReadLine());
            double @expression = x * (x * (x * (3 * x - 5) + 2) - 1) + 7;
            Console.WriteLine("The expression is equal: " + @expression);
            Console.ReadKey();
        }
    }
}
