using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struck_learn
{
    internal class Program
    {
        struct Sinhvien
        {
            public int MSSV;
            public string hoTen;
            public double diemToan;
            public double diemTriet;
            public double diemCnet;

        }

        static String ChuanHoaChuoi(String name)
        {
            name = name.Trim();

            name = string.Join(" ", name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

            name = name.ToLower();

            char[] NameArray = name.ToCharArray();

            NameArray[0] = char.ToUpper(NameArray[0]);
            for (int i = 1; i < name.Length-1; i++)
            {
                if (NameArray[i] == ' ')
                {
                    NameArray[i + 1] = char.ToUpper(NameArray[i + 1]);
                }
            }

            return new string(NameArray);
        }
        
        static void nhapdl()
        {
            Console.Write("nhap MSSV: ");
            infoStuden.MSSV = int.Parse(Console.ReadLine());
            Console.Write("Ho Ten: ");
            infoStuden.hoTen = Console.ReadLine();
            infoStuden.hoTen = ChuanHoaChuoi(infoStuden.hoTen);
            Console.Write("diem toan: ");
            do
            {
                infoStuden.diemToan = double.Parse(Console.ReadLine());
                if ((infoStuden.diemToan < 0) || (infoStuden.diemToan > 10)){
                    Console.Write("Nhap lai diem toan: ");
                }
            } while (infoStuden.diemToan < 0 || infoStuden.diemToan > 10);

            Console.Write("diemTriet: ");
            do
            {
                infoStuden.diemTriet = double.Parse(Console.ReadLine());
                if ((infoStuden.diemTriet < 0) || (infoStuden.diemTriet > 10))
                {
                    Console.Write("Nhap lai diem triet: ");
                }
            } while (infoStuden.diemTriet < 0 || infoStuden.diemTriet > 10);

            Console.Write("diem C.net: ");
            do
            {
                infoStuden.diemCnet = double.Parse(Console.ReadLine());
                if ((infoStuden.diemCnet < 0) || (infoStuden.diemCnet > 10))
                {
                    Console.Write("Nhap lai diem C.net: ");
                }
            } while (infoStuden.diemCnet < 0 || infoStuden.diemCnet > 10);
        }

        static void inThongTin()
        {
            Console.WriteLine("Thong tin sinh vien: ");
            Console.WriteLine("Ho va Ten: " + infoStuden.hoTen);
            Console.WriteLine("Diem Toan: " + infoStuden.diemToan);
            Console.WriteLine("Diem Triet: " + infoStuden.diemTriet);
            Console.WriteLine("Diem .Net: " + infoStuden.diemCnet);
        }

        static Sinhvien infoStuden;

        static void Main(string[] args)
        {
            nhapdl();
            inThongTin();
        }
    }
}
