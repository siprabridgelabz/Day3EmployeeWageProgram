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
            // Compute Employee wages for multiple Company

            Console.WriteLine("Enter the name of the company Dmart or Relince:");
            string company = Console.ReadLine();

            EmployeeInformation obj = new EmployeeInformation();
            if (company == "Dmart")
            {
                obj.ComputeEmpWage(company, 20, 10, 90);
            }
            else if (company == "Relince") { obj.ComputeEmpWage(company, 20, 10, 90); }
            else { Console.WriteLine("Please enter correct company!!"); }
        }
    }
}
