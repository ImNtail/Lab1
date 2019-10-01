using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the time:");
            Console.WriteLine("Hours: ");
            float hours = float.Parse(Console.ReadLine());
            if ((hours > 11) | (hours < 0))
            {
                Console.WriteLine("Error");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Minutes: ");
                float minutes = float.Parse(Console.ReadLine());
                if ((minutes < 0) | (minutes > 59))
                {
                    Console.WriteLine("Error");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Seconds: ");
                float seconds = float.Parse(Console.ReadLine());
                    if ((seconds > 59) | (seconds < 0))
                    {
                        Console.WriteLine("Error");
                        Console.ReadKey();
                    }
                    else
                    {
                        float angle = (hours * 3600 + minutes * 60 + seconds) / 12 / 3600 * 360;
                        Console.WriteLine("The angle is " + angle + " degrees");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
