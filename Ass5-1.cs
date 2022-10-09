using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ass5
{
    abstract class Student
    {
        string Name;
        int StudentId;
        int Grade;

        public abstract void Ispassed();
        public void grade()
        {
            int Grade;
            Console.WriteLine("Enter the Grade");
            Grade = int.Parse(Console.ReadLine());
        }
    }

    class Undergraduate : Student
    {
        public Undergraduate()
        {
            string Name;
            int id;
            Console.WriteLine("Enter Name : ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter id : ");
            id = Convert.Toint32(Console.ReadLine());
        }
        public override void Ispassed()
        {
            int number;
            Console.WriteLine("Enter Name : ");
            number = Convert.Toint32(Console.ReadLine());
            string value = (number > 70) ? "TRUE" : "False";
            Console.WriteLine($"{number} is {value}");
            return number;
        }

    }

    class Graduate : Student
    {
        public Graduate()
        {
            string Name;
            int id;
            Console.Write("Enter Name : ");
            Name = Console.ReadLine();
            Console.Write("Enter id : ");
            id = Convert.ToInt16(Console.ReadLine());
        }
        public override void Ispassed()
        {
            int number;
            Console.WriteLine("Enter a number");
            number = Convert.ToInt16(Console.ReadLine());
            string value = (number > 80) ? "TRUE" : "FALSE";
            Console.WriteLine($"{number} is {value}");
            return number;
        }

        class program
        {
            public static void Main(string[] args)
            {
                Undergraduate myUg = new Undergraduate();
                Graduate myG = new Graduate();
                myUg.Ispassed();
                myG.Ispassed();
                myUg.grade();
                myG.grade();
            }
        }

    }
}


