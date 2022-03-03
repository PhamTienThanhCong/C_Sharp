using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OOP_baiTap
{
    class Person
    {
        protected String name;
        protected int age;
        protected String Gender;
        
        public Person()
        {
            this.name = "";
            this.age = 0;
            this.Gender = "";
        }
        
        public void setValue(String name, int age, String Gender)
        {
            this.name = ChuanHoaChuoi(name);
            this.age = CheckAge(age);
            this.Gender = CheckGender(Gender);
        }

        public void Hello()
        {
            Console.WriteLine("- Name: {0}, \n- Age {1} yearold,\n- Gender: {2}", this.name,this.age,this.Gender);
        }

        public String CheckGender(String Gender)
        {
            Gender = Gender.ToLower();

            while (Gender != "nam" && Gender != "nu")
            {
                Console.Write("Nhap Gender (nam/nu): ");
                Gender = Console.ReadLine();
            }

            return char.ToUpper(Gender[0]) + Gender.Substring(1);
        }

        public int CheckAge(int age)
        {
            while (age < 0 || age > 100)
            {
                Console.Write("Nhap lai tuoi(1-100): ");
                age = Convert.ToInt32(Console.ReadLine());
            }
            return age;
        }

        public String ChuanHoaChuoi(String name)
        {
            name = name.Trim();

            name = string.Join(" ", name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

            name = name.ToLower();

            char[] NameArray = name.ToCharArray();

            NameArray[0] = char.ToUpper(NameArray[0]);
            for (int i = 1; i < name.Length - 1; i++)
            {
                if (NameArray[i] == ' ')
                {
                    NameArray[i + 1] = char.ToUpper(NameArray[i + 1]);
                }
            }
            return new string(NameArray);
        }
    }

    class Teacher : Person
    {
        private String ClassMate;
        public Teacher() { }

        public Teacher(String name, int age, String Gender, String ClassMate)
        {
            setValue(name, age, Gender);
            this.ClassMate = ClassMate;
        }

        public void NotiTeaching()
        {
            Hello();
            Console.WriteLine("- Teach: " + this.ClassMate);
        }
    }

    class Student : Person
    {
        private double Point;

        public Student(String name, int age, String Gender, double Point)
        {
            setValue(name, age, Gender);
            this.Point = CheckPoint(Point);
        }

        public void infoStudent()
        {   
            Hello();
            Console.WriteLine("- Point: " + this.Point);
        }

        public double CheckPoint(double Point)
        {
            while(Point < 0 || Point > 10)
            {
                Console.Write("Nhap lai diem(0-10): ");
                Point = Convert.ToDouble(Console.ReadLine());
            }
            return Point;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Teacher> listTeacher = new List<Teacher>();
            listTeacher.Add(new Teacher("huy", 35, "nam", "dien tu"));

            List<Student> listStudent = new List<Student>();
            listStudent.Add(new Student("hoa", 22, "nam", 9.2));

            Console.WriteLine("\nSinh vien:");
            listStudent[0].infoStudent();

            Console.WriteLine("\nGaio vien:");
            listTeacher[0].NotiTeaching();
        }
    }
}
