using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2_individual_var_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter variable x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter variable a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter variable b: ");
            double b = double.Parse(Console.ReadLine());
            double e = 2.718;
            Console.WriteLine("e = 2.718 - const");
            double z = Math.Sqrt(a * x * Math.Sin(2 * x) + Math.Pow(e, -2 * x) * (x + b));
            double w = Math.Pow(Math.Cos(x), 2) * Math.Pow(x, 3) - x / Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("z = sqrt(a * x * sin(2x) + e^(-2x) * (x+b)) = " + z);
            Console.WriteLine("w = (cos(x^3))^2 - x / sqrt(a^2 + b^2) = " + w);
            Console.ReadKey();
        }
    }
}