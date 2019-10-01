using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            if (((int)(number / 1000) < 10) && ((int)(number / 1000) > 0))
            {
                    int first = (int)(number / 1000);
                    int second = (int)(number % 1000 / 100);
                    int third = (int)(number % 100 / 10);
                    int fourth = number % 10;
                    int product = first * second * third * fourth;
                    Console.WriteLine("The product is " + product);
                    Console.ReadKey();
            }
            else
                Console.WriteLine("Error");
            Console.ReadKey();
        }
    }
}
