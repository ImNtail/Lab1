using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            string sx = Console.ReadLine();
            int x = int.Parse(sx);
            Console.WriteLine("Enter the second number: ");
            string sy = Console.ReadLine();
            int y = int.Parse(sy);
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("The first number is " + x);
            Console.WriteLine("The second number is " + y);
            Console.ReadKey();
        }
    }
}
