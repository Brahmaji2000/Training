using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Cricket
    {
        public static void Main(string[] args)
        {
            Cricket e = new Cricket();
        }
        public void Pointscalculation()
        {
            int Total, Sum = 0, Value;
            float Average;

            Console.WriteLine("Enter number of matches");
            Total = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Total; i++)
            {
                Console.WriteLine("Enter the scores of matches: ");
                Value = Convert.ToInt32(Console.ReadLine());
                Sum += Value;
            }

            
            Average = (float)Sum / Total;

            Console.WriteLine("Sum: " + Sum + ", Average: " + Average);
        }
    }
}
