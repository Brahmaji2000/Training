using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Box
    {
        int length;
        int breadth;
        public void Box1()
        {
            int L;
            Console.WriteLine("Enter the length");
            L = Convert.ToInt16(Console.ReadLine());
        }
        public void Box2()
        {
            int B;
            Console.WriteLine("Enter the breadth");
            B = Convert.ToInt16(Console.ReadLine());
        }
        public void add2box()
        {
            Box b = new Box();
            b.Box1();
            b.Box2();
            int sum;
        }

        class Test
        {
            static void Main()
            {
                Box b = new Box();
                b.Box1();
                b.Box2();
                b.add2box();
            }
        }
    }
}
