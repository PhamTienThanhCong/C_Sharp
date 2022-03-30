using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lich
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] Can = { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };
            string [] Chi = { "Than", "Dau", "Tuat", "Hoi", "Ty", "Suu", "Dan", "Meo", "Thin", "Ty", "Ngo", "Mui" };

            Console.Write("Nhap Nam: ");
            int Nam = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Can[Nam % 10] + " "+ Chi[Nam % 12]);
        }
    }
}
