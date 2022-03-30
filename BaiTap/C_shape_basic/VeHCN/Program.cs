using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeHCN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w = 50;
            int h = 10;

            // in ra dòng đầu tiên
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < w - 1; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine("=");

            // in phần thân
            for (int i = 0; i < h; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("=");

                Console.ForegroundColor = ConsoleColor.Yellow;
                for (int j = 0; j < w - 2; j++)
                {
                    Console.Write("*");
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("=");
            }

            // in ra dòng cuối cùng
            for (int i = 0; i < w - 1; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine("=");

            Console.ResetColor();
        }
    }
}