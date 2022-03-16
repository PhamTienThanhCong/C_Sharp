using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThi2
{
    internal class Program
    {
        class LoaiSanBay
        {
            protected int NamHoatDong;
            protected Char KiHieu;
            public LoaiSanBay() { }
            public void NhapThongTinLoaiSanBay(Char KiHieu, int NamHoatDong) { 
                this.KiHieu = KiHieu;
                this.NamHoatDong = NamHoatDong;
            }
            public void InThongTin()
            {
                Console.WriteLine("Nam hoat Dong: " + NamHoatDong);
                Console.WriteLine("Ki Hieu Loai: "  + KiHieu);
            }

        }
        class SanBay : LoaiSanBay
        {
            private String TenSanBay;
            public SanBay() { }
            public void setTenSanBay(String TenSanBay) { 
                this.TenSanBay = TenSanBay;
            }
            public void inThongTinSanBay()
            {
                InThongTin();
                Console.WriteLine("Ten San Bay: " + TenSanBay);
            }

        }

        class DienTichSanBay : LoaiSanBay
        {
            private double DienTich;
            public DienTichSanBay() { }

            public void SetDienTich(double DienTich) { 
                this.DienTich = DienTich;
            }

            public static void set(double DienTich)
            {
                SetDienTich(DienTich)
            }

            public void inThongTinSanBay()
            {
                InThongTin();
                Console.WriteLine("Dien Tich San Bay: " + DienTich);
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("-Cau 1----------------------------------");
            LoaiSanBay san_bay_1 = new LoaiSanBay();
            san_bay_1.NhapThongTinLoaiSanBay('C', 2007);
            san_bay_1.InThongTin();

            Console.WriteLine("-Cau 2----------------------------------");

            SanBay san_bay_2 = new SanBay();
            san_bay_2.NhapThongTinLoaiSanBay('A', 1990);
            san_bay_2.setTenSanBay("Tan Son Nhat");
            san_bay_2.InThongTin();
            san_bay_2.inThongTinSanBay();

            Console.WriteLine("-Cau 3----------------------------------");

            DienTichSanBay san_bay_3 = new DienTichSanBay();
            san_bay_3.NhapThongTinLoaiSanBay('C', 2007);
            san_bay_3.SetDienTich(13.8);
            san_bay_3.InThongTin();
            san_bay_3.inThongTinSanBay();
        }
    }
}
