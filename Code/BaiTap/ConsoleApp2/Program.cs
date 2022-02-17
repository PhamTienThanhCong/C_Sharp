using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static Double MaxTwoValue(Double a, Double b)
        {
            if (a > b) { return a; }
            else { return b; }
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = "Program min max";
            Console.Write("value 1: ");
            Double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("value 2: ");
            Double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("value 3: ");
            Double c = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.ResetColor();

            double m = MaxTwoValue(a, MaxTwoValue(b, c));

            Console.WriteLine(m);


        }

    }
}
