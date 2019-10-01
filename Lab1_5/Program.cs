using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the first cathet: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the length of the second cathet: ");
            double b = double.Parse(Console.ReadLine());
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            double @area = (a * b) / 2;
            double @perimeter = a + b + c;
            Console.WriteLine("The area is " + @area);
            Console.WriteLine("The perimeter is " + @perimeter);
            Console.ReadKey();
        }
    }
}
