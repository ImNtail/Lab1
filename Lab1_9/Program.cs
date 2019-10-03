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
            Console.WriteLine("");

            Console.Write("a1: ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("b1: ");
            int b1 = int.Parse(Console.ReadLine());
            Console.Write("c1: ");
            int c1 = int.Parse(Console.ReadLine());
            Console.Write("d1: ");
            int d1 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("a2: ");
            int a2 = int.Parse(Console.ReadLine());
            Console.Write("b2: ");
            int b2 = int.Parse(Console.ReadLine());
            Console.Write("c2: ");
            int c2 = int.Parse(Console.ReadLine());
            Console.Write("d2: ");
            int d2 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("a3: ");
            int a3 = int.Parse(Console.ReadLine());
            Console.Write("b3: ");
            int b3 = int.Parse(Console.ReadLine());
            Console.Write("c3: ");
            int c3 = int.Parse(Console.ReadLine());
            Console.Write("d3: ");
            int d3 = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine(a1 + "*x + " + b1 +"*y + " + c1 +"*z = " + d1);
            Console.WriteLine(a2 + "*x + " + b2 + "*y + " + c2 + "*z = " + d2);
            Console.WriteLine(a3 + "*x + " + b3 + "*y + " + c3 + "*z = " + d3);

            Console.WriteLine("");

            //Находим определитель по правилу треугольника
            int Δ = a1 * b2 * c3 + a3 * b1 * c2 + a2 * b3 * c1 - a3 * b2 * c1 - a1 * b3 * c2 - a2 * b1 * c3;
            if (Δ != 0)
            {
                //Присваем коэффициентам а1, а2, а3 значения d1, d2, d3 и находим определитель
                int Δx = d1 * b2 * c3 + d3 * b1 * c2 + d2 * b3 * c1 - d3 * b2 * c1 - d1 * b3 * c2 - d2 * b1 * c3;
                //Присваем коэффициентам b1, b2, b3 значения d1, d2, d3 и находим определитель
                int Δy = a1 * d2 * c3 + a3 * d1 * c2 + a2 * d3 * c1 - a3 * d2 * c1 - a1 * d3 * c2 - a2 * d1 * c3;
                //Присваем коэффициентам c1, c2, c3 значения d1, d2, d3 и находим определитель
                int Δz = a1 * b2 * d3 + a3 * b1 * d2 + a2 * b3 * d1 - a3 * b2 * d1 - a1 * b3 * d2 - a2 * b1 * d3;

                //Находим х, y и z методом Крамера
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
