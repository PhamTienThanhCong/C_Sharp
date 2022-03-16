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
            const int stt = 23;
            int n = 20;
            int[] a = new int[100];
            Console.Write("Nhap 20 phan tu cua mang : ");

            a[0] = stt;
            Console.Write("\n-Phan Tu Thu {0}: {1}", 1, stt);
            for (int i = 1; i < n; i++)
            {
                Console.Write("\n-Phan Tu Thu {0}: ", i+1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nCac phan tu chia het cho 5 la : ");
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 5 == 0)
                {
                    Console.Write(a[i] + " ");
                }
            }

            Console.Write("\nNhap phan tu x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            bool check = true;
            for (int i = 0; i < n; i++)
            {
                if (a[i] == x)
                {
                    Console.WriteLine("Vi Tri Xuat Hien dau tien cua {0} la vi tri: {1}",x,i);
                    check = false;
                    break;
                }
            }
            if (check)
            {
                Console.WriteLine("Phan tu {0} khong co trong mang.", x);
            }

            Console.Write("\nNhap phan tu y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] == y)
                {
                    count+=a[i];
                }
            }
            Console.WriteLine("Tong cua y la: " + count);
        }
    }
}
