using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollCC
{
    public class Menu
    {

        public static void menuNav(List<Employee> employeeList)
        {
            string userInput = Console.ReadLine();

            string fname;
            string lname;
            int age;
            int empID;
            decimal monthlyPay;
            int hoursWorked;
            decimal hourlyPay;

            switch (userInput)
            {

                case "1":

                    Console.WriteLine("Enter employee first name");
                    fname = Console.ReadLine();
                    Console.WriteLine("Enter employee last name");
                    lname = Console.ReadLine();
                    Console.WriteLine("Enter employee age");
                    age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter employee employee ID");
                    empID = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter employee mounthly pay");
                    monthlyPay = decimal.Parse(Console.ReadLine());

                    Employee S = new SaleriedEmployee(fname, lname, age, empID, monthlyPay);

                    employeeList.Add(S);
                    break;

                case "2":

                    Console.WriteLine("Enter employee first name");
                    fname = Console.ReadLine();
                    Console.WriteLine("Enter employee last name");
                    lname = Console.ReadLine();
                    Console.WriteLine("Enter employee age");
                    age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter employee employee ID");
                    empID = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter employee hours worked");
                    hoursWorked = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter employee hourly pay");
                    hourlyPay = decimal.Parse(Console.ReadLine());

                    Employee H = new HourlyEmployee(fname, lname, age, empID, hourlyPay, hoursWorked);

                    employeeList.Add(H);
                    break;

                case "3":
                    Helper.Case3(employeeList);
                    break;

                case "4":

                    Environment.Exit(0);
                    break;


                default:

                    Console.WriteLine("That a wasn't an option noodle head :)");
                    break;
            }
        }
    }
}