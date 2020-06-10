using System;
using System.Collections.Generic;

namespace PayrollCC
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();

            while (true)
            {
                Console.WriteLine("1: Add saleried employee");
                Console.WriteLine("2: Add hourly employee");
                Console.WriteLine("3: Run reports");
                Console.WriteLine("4: Close Payroll tool");
                Menu.menuNav(employeeList);
            }
        }
    }
}