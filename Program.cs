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
                Menu.menuStrings();
                Menu.menuNav(employeeList);
            }
        }
    }
}