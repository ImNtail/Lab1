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
            Console.WriteLine("Enter the length of the first cathet: ");
            string sa = Console.ReadLine();
            double a = double.Parse(sa);
            Console.WriteLine("Enter the length of the second cathet: ");
            string sb = Console.ReadLine();
            double b = double.Parse(sb);
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            double @area = (a * b) / 2;
            double @perimeter = a + b + c;
            Console.WriteLine("The area is " + @area);
            Console.WriteLine("The perimeter is " + @perimeter);
            Console.ReadKey();
        }
    }
}
