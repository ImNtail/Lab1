﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enther the number: ");
            int number = int.Parse(Console.ReadLine());
            if (((int)(number / 100) < 10) && ((int)(number / 100) > 0))
            {
                    int first = number / 100;
                    int second = (int)(number % 100 / 10);
                    int third = number % 10;
                    int reserved = third * 100 + second * 10 + first;
                    Console.WriteLine("Reserved number: " + reserved);
            }
            else
                Console.WriteLine("Error");
                Console.ReadKey();
        }
    }
}
