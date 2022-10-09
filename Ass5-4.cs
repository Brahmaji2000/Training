using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass5
{
        interface IStudent
        {
            string Name { get; set; }
            int StudentId { get; set; }
            void ShowDetails();
        }
        class DayScholar : IStudent
        {
            public string Name { get; set; }
            public int StudentId { get; set; }
            public void ShowDetails()
            {
                Console.WriteLine("Student name :" + Name + " " + ", and i'd is: " + StudentId);
            }

        }
        class Resident : IStudent
        {
            public string Name { get; set; }
            public int StudentId { get; set; }
            public void ShowDetails()
            {
                Console.WriteLine("student name : " + Name + " " + " , and i'd is: " + StudentId);
            }

        }
        class Program
        {
            static void Main(string[] args)
            {
                DayScholar ds = new DayScholar();
                ds.Name = " Brahmaji";
                ds.StudentId = 3;
                Resident rs = new Resident();
                rs.Name = " Sai ";
                rs.StudentId = 4;
                ds.ShowDetails();
                rs.ShowDetails();
                Console.ReadLine();
            }
        }
 }
