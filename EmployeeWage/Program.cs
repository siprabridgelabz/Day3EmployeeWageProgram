using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee age Computation Program");
            Console.WriteLine("*******************");
            Console.WriteLine("Enter the company Name : \n1. Dmart\n2.Reliance");
            int company = Convert.ToInt32(Console.ReadLine());
            EmployeeInformation obj = new EmployeeInformation();
            switch (company)
            {
                case 1:
                    obj.EmpWageBuilder1();
                    obj.ComputeEmpWage();
                    break;
                case 2:
                    obj.EmpWageBuilder2();
                    obj.ComputeEmpWage();
                    break;

                default:
                    Console.WriteLine("Enter a valid company!!!");
                    break;
            }
        }
    }
}
