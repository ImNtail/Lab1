using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter all of the variables for a system of expressions");
            Console.WriteLine("a1*x + b1*y + с1*z = d1");
            Console.WriteLine("a2*x + b2*y + с2*z = d2");
            Console.WriteLine("a3*x + b3*y + с3*z = d3");

            Console.WriteLine("a1: ");
            string sa1 = Console.ReadLine();
            Console.WriteLine("b1: ");
            string sb1 = Console.ReadLine();
            Console.WriteLine("c1: ");
            string sc1 = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("d1: ");
            string sd1 = Console.ReadLine();

            Console.WriteLine("a2: ");
            string sa2 = Console.ReadLine();
            Console.WriteLine("b2: ");
            string sb2 = Console.ReadLine();
            Console.WriteLine("c2: ");
            string sc2 = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("d2: ");
            string sd2 = Console.ReadLine();

            Console.WriteLine("a3: ");
            string sa3 = Console.ReadLine();
            Console.WriteLine("b3: ");
            string sb3 = Console.ReadLine();
            Console.WriteLine("c3: ");
            string sc3 = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("d3: ");
            string sd3 = Console.ReadLine();

            int a1 = int.Parse(sa1);
            int b1 = int.Parse(sb1);
            int c1 = int.Parse(sc1);

            int d1 = int.Parse(sd1);
            Console.WriteLine("");

            int a2 = int.Parse(sa2);
            int b2 = int.Parse(sb2);
            int c2 = int.Parse(sc2);

            int d2 = int.Parse(sd2);
            Console.WriteLine("");

            int a3 = int.Parse(sa3);
            int b3 = int.Parse(sb3);
            int c3 = int.Parse(sc3);

            int d3 = int.Parse(sd3);
            Console.WriteLine("");

            int Δ = a1 * b2 * c3 + a3 * b1 * c2 + a2 * b3 * c1 - a3 * b2 * c1 - a1 * b3 * c2 - a2 * b1 * c3;
            if (Δ != 0)
            {
                int Δx = d1 * b2 * c3 + d3 * b1 * c2 + d2 * b3 * c1 - d3 * b2 * c1 - d1 * b3 * c2 - d2 * b1 * c3;
                int Δy = a1 * d2 * c3 + a3 * d1 * c2 + a2 * d3 * c1 - a3 * d2 * c1 - a1 * d3 * c2 - a2 * d1 * c3;
                int Δz = a1 * b2 * d3 + a3 * b1 * d2 + a2 * b3 * d1 - a3 * b2 * d1 - a1 * b3 * d2 - a2 * b1 * d3;

                int x = Δx / Δ;
                int y = Δy / Δ;
                int z = Δz / Δ;

                Console.WriteLine("x = " + x);
                Console.WriteLine("y = " + y);
                Console.WriteLine("z = " + z);
                Console.ReadKey();
            }
            else
                Console.WriteLine("Error");
                
            Console.ReadKey();
        }
    }
}
