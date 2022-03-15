using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThi2
{
    internal class Program
    {
        class DongVat
        {
            public double CanNang;
            public String TenLoai;
            public DongVat() { }
            public void NhapThongTinDongVat(String TenLoai, double CanNang) { 
                this.CanNang = CanNang;
                this.TenLoai = TenLoai;
            }
            public void InThongTin()
            {
                Console.WriteLine("Ten loai: " + TenLoai);
                Console.WriteLine("Can Nang: "  + CanNang);
            }

        }
        class GiaCam : DongVat
        {
            public int SoTien;
            public GiaCam() { }
            public void setSoTien(int SoTien) { 
                this.SoTien = SoTien;
            }
            public void inThongTinGiaCam()
            {
                Console.WriteLine("Gia Tien: " + SoTien);
            }

        }

        class TrangTrai : DongVat
        {
            public String ViTri;
            public TrangTrai() { }

            public void setViTri(String ViTri) { 
                this.ViTri = ViTri;
            }

            public void inThongTinTrangTrai()
            {
                Console.WriteLine("Trang Trai: " + ViTri);
            }

        }

        static void Main(string[] args)
        {
            DongVat dongVat = new DongVat();
            dongVat.NhapThongTinDongVat("Ga Cong Nghiep", 5.4);
            dongVat.InThongTin();

            Console.WriteLine("-----------------------------------");

            GiaCam giaCam = new GiaCam();
            giaCam.NhapThongTinDongVat("Con Vit Bau", 4.5);
            giaCam.setSoTien(50000);
            giaCam.InThongTin();
            giaCam.inThongTinGiaCam();

            Console.WriteLine("-----------------------------------");

            TrangTrai trangTrai = new TrangTrai();
            trangTrai.NhapThongTinDongVat("Con Bo Non", 100.3);
            trangTrai.setViTri("Lau Dai Tinh Ai");
            trangTrai.InThongTin();
            trangTrai.inThongTinTrangTrai();
        }
    }
}
