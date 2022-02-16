using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("value 1: ");
            Double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("value 2: ");
            Double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("value 3: ");
            Double c = Convert.ToDouble(Console.ReadLine());

            Double m = a;

            if (m < a) { m = a; }
            if (m < b) { m = b; }

            Console.WriteLine(m);

        }
    }
}
