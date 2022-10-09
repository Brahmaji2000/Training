using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass5
{
    class Passanger
    {
        string Name;
        int Age;

        public void TicketBooking()
        {
            string Name;
            Console.WriteLine("Enter a Name");
            Name = Convert.ToString(Console.ReadLine());
            int age;
            Console.WriteLine("Enter  age");
            age = Convert.ToInt16(Console.ReadLine());
            int tickets;
            Console.WriteLine("NoOfTickets booked : ");
            tickets = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < tickets; i++)
            {
                if (tickets > 2)
                {
                    Console.WriteLine("canot book more than 2 tickets");
                }
                else
                {
                    Console.WriteLine("ticket booked successfully");
                }
                Console.ReadLine();
            }
        }
    }

    class test
    {
        static void Main()
        {
            Passanger p = new Passanger();
            p.TicketBooking();
        }
    }
}  
