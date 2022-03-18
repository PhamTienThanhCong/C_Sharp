using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThi2
{
    internal class Program
    {
        class DiemSo
        {
            protected int DiemKieuSo;
            protected Char DiemKieuChu;
            public DiemSo(int DiemKieuSo, char DiemKieuChu) { 
                this.DiemKieuSo = DiemKieuSo;
                this.DiemKieuChu = DiemKieuChu;
            }
            public void InThongTin()
            {
                Console.WriteLine("Diem thi: " + DiemKieuSo);
                Console.WriteLine("Diem chuyen doi: "  + DiemKieuChu);
            }

        }
        class KietQua : DiemSo
        {
            private String HocLuc;
            public KietQua(int DiemKieuSo, char DiemKieuChu) :base(DiemKieuSo, DiemKieuChu) {}
            public void setHocLuc(String HocLuc) { 
                this.HocLuc = HocLuc;
            }
            public void inThongTinKetQua()
            {
                base.InThongTin();
                Console.WriteLine("Hoc Luc: " + HocLuc);
            }

        }

        class DiemThiLai : DiemSo
        {
            public double DiemThi;
            public DiemThiLai(int DiemKieuSo, char DiemKieuChu) : base(DiemKieuSo, DiemKieuChu) { }

            public void SetDiemThi(double DiemThi) { 
                this.DiemThi = DiemThi;
            }

            public static void KetQuaThi(double DiemThi)
            {
                if(DiemThi <= 4)
                {
                    Console.WriteLine("Ket qua: Truot mon");
                }
                else
                {
                    Console.WriteLine("Ket qua: Qua mon");
                }
            }

            public void inKetQua()
            {
                InThongTin();
                Console.WriteLine("Diem thi lai: " + DiemThi);
                KetQuaThi(DiemThi);
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nCau 1:");
            DiemSo Diem_1 = new DiemSo(8,'B');
            Diem_1.InThongTin();

            Console.WriteLine("\nCau 2:");
            KietQua Diem_2 = new KietQua(7, 'B');
            Diem_2.setHocLuc("Kha");
            Diem_2.inThongTinKetQua();

            Console.WriteLine("\nCau 3:");
            DiemThiLai Diem_3 = new DiemThiLai(3, 'F');
            Diem_3.SetDiemThi(5.5);
            Diem_3.inKetQua();
            
        }
    }
}
