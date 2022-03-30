using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    internal class Program
    {
        class Program_6_1
        {
            private int n = 5;
            private int[] a;
            public Program_6_1(){
                a = new int[n];
            }
            
            public void getValue()
            {
                Console.WriteLine("Nhap 5 so: ");
                for (int i = 0; i < n; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
            }
            public int SumArr()
            {
                return a.Sum();
            }
            public float TbCong()
            {
                return (float)SumArr()/(float)n;
            }
            public int MaxArr()
            {
                return (a.Max());
            }
            public int MinArr()
            {
                return (a.Min());
            }
            
        }
        
        public interface IVehicle
        {
            void driver();
            bool Refuel(int a);   
        }
        class Car : IVehicle
        {
            private int fuel;
            public Car()
            {
                fuel = 0;
            }

            public bool Refuel(int a)
            {
                fuel += a;
                return true;
            }

            public void driver()
            {
                if (fuel == 0)
                {
                    Console.WriteLine("Xe het Xang: ");
                    DoXang();
                }
                else
                {
                    fuel -= 3;
                    Console.WriteLine("Xe dang chay");
                }
                if (fuel <= 0)
                {
                    Console.WriteLine("Xe het Xang do them nhien lieu: ");
                    DoXang();
                }else if (fuel <= 3)
                {
                    Console.WriteLine("Xe chuan bi het Xang do them nhien lieu: ");
                    DoXang();
                }
            }
            public void DoXang()
            {
                Console.WriteLine("Yeu cau do xang: ");
                Console.Write("Nhap Xang: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(Refuel(a));
            }

        }
        static void Main(string[] args)
        {
            Car a = new Car();
            a.DoXang();
            a.driver();
            a.driver();
            a.driver();
        }
    }
}
