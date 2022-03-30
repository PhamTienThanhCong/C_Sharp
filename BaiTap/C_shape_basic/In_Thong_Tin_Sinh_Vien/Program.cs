using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In_Thong_Tin_Sinh_Vien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tenSinhVien, mssv, khoa, gioiTinh;
            int Ngay, Thang, Nam;
            Console.Title = "Thong Tin Sinh Vien";

            Console.Write("Nhap mssv sinh vien: ");
            mssv = Console.ReadLine();

            Console.Write("Nhap Ten Sinh Vien: ");
            tenSinhVien = Console.ReadLine();

            Console.Write("Nhap Gioi Tinh: ");
            gioiTinh = Console.ReadLine();

            Console.Write("Nhap ngay sinh: ");
            Ngay = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap Thang sinh: ");
            Thang = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap Nam sinh: ");
            Nam = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap khoa sinh vien: ");
            khoa = Console.ReadLine();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------------------------------");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ten Sinh Vien: "+tenSinhVien);
            Console.WriteLine("Ma So Sinh Vien: "+ mssv);
            Console.WriteLine("Sinh Nhat: "+Ngay+ "/"+ Thang+ "/"+ Nam);
            Console.WriteLine("Khoa: "+khoa);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------------------------------");

        }
    }
}
