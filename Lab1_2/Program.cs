using System;

namespace Lab1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many seconds are gone?");
            int seconds = int.Parse(Console.ReadLine());
            int hours = (int)(seconds / 3600);
            int minutes = (int)(seconds / 60);
            while (minutes > 60)
            {
                minutes = minutes - 60;
            }
            Console.WriteLine("Time are gone: " + hours + " hours " + minutes + " minutes");
        }
    }
}
