using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_baiTap
{
    class car
    {
        private string carName;
        public car(string carName)
        {
            this.carName = carName;
        }
        public void getName()
        {
            Console.WriteLine(this.carName);
        }
        public void setName(string carName)
        {
            this.carName = carName;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            car c = new car("toyta");
            c.setName("vin fats");
            c.getName();
        }
    }
}
