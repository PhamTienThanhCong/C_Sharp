using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int stt = 33;
            int n = 15+stt;
            double[] a = new double[100];
            Console.WriteLine("Dinh viet huy: 20010902. STT:33");
            Console.Write("Nhap 15 phan tu cua mang : ");

            for (int i = stt; i < n; i++)
            {
                Console.Write("\nNhap phan Tu Thu {0}: ", i);
                a[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("\nCac phan tu co phan nguyen chia het cho chia het cho 6 la : ");
            for (int i = stt; i < n; i++)
            {
                if (((int)a[i]) % 6 == 0)
                {
                    Console.Write(a[i] + " ");
                }
            }

            Console.Write("\nNhap phan tu a: ");
            double c = Convert.ToDouble(Console.ReadLine());
            bool check = true;
            for (int i = stt; i < n; i++)
            {
                if (a[i] == c)
                {
                    check = false;
                    break;
                }
            }
            if (check)
            {
                Console.WriteLine("Phan tu {0} khong co trong mang.", c);
            }
            else
            {
                Console.WriteLine("Phan tu {0} ton tai trong mang.", c);
            }

            Console.Write("\nNhap phan tu b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            int count = 0;
            for (int i = stt; i < n; i++)
            {
                if (a[i] == b)
                {
                    count++;
                }
            }
            Console.WriteLine("So lan xuat hien cua b la: " + count);
        }
    }
}
