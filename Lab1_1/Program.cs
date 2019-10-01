using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            number = decimal.Parse(Console.ReadLine());
            int result = (int)((number - (int)(number))*10);
            Console.WriteLine("The first digit of the fractional part: " + result);
        }
    }
}
