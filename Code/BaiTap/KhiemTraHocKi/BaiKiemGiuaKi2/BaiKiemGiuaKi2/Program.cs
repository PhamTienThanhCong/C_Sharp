using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKiemGiuaKi2
{
    internal class Program
    {
        static bool tam_gia_vuong(int[] x)
        {
            int a = x[0] * x[0];
            int b = x[1] * x[1];
            int c = x[2] * x[2];
            if (x[0] >= x[1] + x[2] || x[1] >= x[0] + x[2] || x[2] >= x[1] + x[0])
            {
                return false;
            }
            if (b == a+c || a == b + c || c == a + b)
            {
                return true;
            }
            return false;

        }
        static void Main(string[] args)
        {
            int[] x = new int[4];
            Console.WriteLine("Nhap 3 canh: ");
            for (int i = 0; i < 3; i++)
            {
                x[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(tam_gia_vuong(x));
        }
    }
}
