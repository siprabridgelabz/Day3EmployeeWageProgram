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
            EmployeeInformation employeeInformation = new EmployeeInformation();
            employeeInformation.EmployeeWageSwitchCaseStatement();
            Console.ReadLine();
        }
    }
}
