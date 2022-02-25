using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mien_bai_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[5];
            friends[0] = "lan";
            friends[1] = "huong";
            friends[2] = "mien";
            friends[3] = "huy";
            friends[4] = "lan";

            Console.Write("Nhap Ten Dua Ban: ");
            string value = Console.ReadLine();
            int pos = Array.IndexOf(friends, value);
            if (pos > -1)
            {
                Console.WriteLine("ton tai:" + value);
                int count = 0;
                for (int i = 0; i < friends.Length; i++)
                {
                    if (friends[i] == value) { count++; }
                }

                Console.WriteLine("so lan xuat hien " + value + " trong mang la:" + count);
            }
            else
            {
                Console.WriteLine("khong ton tai:" + value);
            }







        }
    }
}
