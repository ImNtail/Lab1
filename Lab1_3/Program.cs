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
            string shours = Console.ReadLine();
            float hours = float.Parse(shours);
            if (hours > 11)
            {
                Console.WriteLine("Error");
                Console.ReadKey();
            }
            if (hours < 0)
            {
                Console.WriteLine("Error");
                Console.ReadKey();
            }
                Console.WriteLine("Minutes: ");
                string sminutes = Console.ReadLine();
                float minutes = float.Parse(sminutes);
            if (minutes < 0)
            {
                Console.WriteLine("Error");
                Console.ReadKey();
            }
            if (minutes > 59)
            {
                Console.WriteLine("Error");
                Console.ReadKey();
            }
            Console.WriteLine("Seconds: ");
            string sseconds = Console.ReadLine();
            float seconds = float.Parse(sseconds);
            if (seconds > 59)
            {
                Console.WriteLine("Error");
                Console.ReadKey();
            }
            if (seconds < 0)
            {
                Console.WriteLine("Error");
                Console.ReadKey();
            }
            float angle = (hours*3600+minutes*60+seconds)/12/3600*360;
            Console.WriteLine("The angle is " + angle + " degrees");
            Console.ReadKey();
        }
    }
}
