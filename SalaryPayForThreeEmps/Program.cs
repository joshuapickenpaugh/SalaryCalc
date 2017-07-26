//Joshua Pickenpaugh
//July 26th, 2017
//Salary Calc.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryPayForThreeEmps
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter Emp #1 data:
            Console.Write("Enter Emp #1 hours:");
            double dblEmp01Hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Emp #1 hourly rate:");
            double dblEmp01Rate = Convert.ToInt32(Console.ReadLine());

            //Enter Emp #2 data:
            Console.Write("Enter Emp #2 hours:");
            double dblEmp02Hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Emp #2 hourly rate:");
            double dblEmp02Rate = Convert.ToInt32(Console.ReadLine());

            //Enter Emp #3 data:
            Console.Write("Enter Emp #3 hours:");
            double dblEmp03Hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Emp #3 hourly rate:");
            double dblEmp03Rate = Convert.ToInt32(Console.ReadLine());

            //Emp #1 calculation:
            if (dblEmp01Hours > 40.0)
            {
                double dblEmp01Total = dblEmp01Rate * 40;
                dblEmp01Hours = dblEmp01Hours - 40.0;
                dblEmp01Total = ((dblEmp01Hours * dblEmp01Rate) * 1.5) + dblEmp01Total;
                Console.WriteLine("Emp #1 week's pay: {0}", dblEmp01Total);
            }
            else
            {
                double dblEmp01Total = dblEmp01Rate * dblEmp01Hours;
                Console.WriteLine("Emp #1 week's pay: {0}", dblEmp01Total);
            }

            //Emp #2 calculation:
            if (dblEmp02Hours > 40.0)
            {
                double dblEmp02Total = dblEmp02Rate * 40;
                dblEmp02Hours = dblEmp02Hours - 40.0;
                dblEmp02Total = ((dblEmp02Hours * dblEmp02Rate) * 1.5) + dblEmp02Total;
                Console.WriteLine("Emp #2 week's pay: {0}", dblEmp02Total);
            }
            else
            {
                double dblEmp02Total = dblEmp02Rate * dblEmp02Hours;
                Console.WriteLine("Emp #2 week's pay: {0}", dblEmp02Total);
            }

            //Emp #3 calculation:
            if (dblEmp03Hours > 40.0)
            {
                double dblEmp03Total = dblEmp03Rate * 40;
                dblEmp03Hours = dblEmp03Hours - 40.0;
                dblEmp03Total = ((dblEmp03Hours * dblEmp03Rate) * 1.5) + dblEmp03Total;
                Console.WriteLine("Emp #3 week's pay: {0}", dblEmp03Total);
            }
            else
            {
                double dblEmp03Total = dblEmp03Rate * dblEmp03Hours;
                Console.WriteLine("Emp #3 week's pay: {0}", dblEmp03Total);
            }
        }
    }
}
