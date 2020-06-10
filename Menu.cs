using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollCC
{
    public class Menu
    {
        public static void menuStrings()
        {
            Console.WriteLine("1: Add saleried employee");
            Console.WriteLine("2: Add hourly employee");
            Console.WriteLine("3: Run reports");
            Console.WriteLine("4: Close Payroll tool");
        }

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
                    //Hourly Vars
                    decimal hFICA = 0m;
                    decimal hFEDTax = 0m;
                    decimal hGross = 0m;
                    decimal hNet = 0m;
                    //Saleried Vars
                    decimal sFICA = 0m;
                    decimal sFEDTax = 0m;
                    decimal sGross = 0m;
                    decimal sNet = 0m;

                    foreach (Employee e in employeeList)
                    {


                        Console.WriteLine("Employee Name: " + e.fullName);
                        Console.WriteLine("Employee Age: " + e.Age);
                        Console.WriteLine("Employee ID: " + e.eID);


                        if (e is SaleriedEmployee)
                        {
                            SaleriedEmployee s = e as SaleriedEmployee;
                            Console.WriteLine("Employee Saleried Pay: " + s.monthlyPay.ToString("C2"));
                            Console.WriteLine("Employee FICA paid: " + s.FICA.ToString("C2"));
                            Console.WriteLine("Employee FICA paid: " + s.FEDTax.ToString("C2"));
                            Console.WriteLine("Employee NET Pay: " + s.calcPay());
                            Console.WriteLine();
                            sFICA += s.FICA;
                            sFEDTax += s.FEDTax;
                            sGross = sGross + ((s.monthlyPay * 12) / 52);
                            sNet = sNet + (s.weeklyPay - s.FICA - s.FEDTax);
                        }

                        else if (e is HourlyEmployee)
                        {
                            HourlyEmployee h = e as HourlyEmployee;

                            Console.WriteLine("Employee Hourly Pay: " + h.hourlyPay.ToString("C2"));
                            Console.WriteLine("Employee FICA paid: " + h.hoursWorked);
                            Console.WriteLine("Employee FICA paid: " + h.FICA.ToString("C2"));
                            Console.WriteLine("Employee FID paid: " + h.FEDTax.ToString("C2"));
                            Console.WriteLine("Employee NET Pay: " + h.calcPay());
                            Console.WriteLine();
                            hFICA += h.FICA;
                            hFEDTax += h.FEDTax;
                            hGross += h.weeklyPay;
                            hNet = hNet + (h.weeklyPay - h.FICA - h.FEDTax);
                        }
                    }
                    //Salery
                    Console.WriteLine("Totals for Salery Employees");
                    Console.WriteLine("Salery Gross Pay: " + sGross.ToString("C2"));
                    Console.WriteLine("Salery Net Pay: " + sNet.ToString("C2"));
                    Console.WriteLine("Salery FICA Paid: " + sFICA.ToString("C2"));
                    Console.WriteLine("Salery FID Paid: " + sFEDTax.ToString("C2"));
                    Console.WriteLine();
                    //Hourly
                    Console.WriteLine("Totals for Hourly Employees");
                    Console.WriteLine("Salery Gross Pay: " + hGross.ToString("C2"));
                    Console.WriteLine("Salery Net Pay: " + hNet.ToString("C2"));
                    Console.WriteLine("Salery FICA Paid: " + hFICA.ToString("C2"));
                    Console.WriteLine("Salery FID Paid: " + hFEDTax.ToString("C2"));
                    Console.WriteLine();
                    //Combined
                    Console.WriteLine("Totals for ALL Employees");
                    Console.WriteLine("Combined gross pay: " + (sGross + hGross).ToString("C2"));
                    Console.WriteLine("Combined net pay: " + (sNet + hNet).ToString("C2"));
                    Console.WriteLine("Combined FICA paid: " + (sFICA + hFICA).ToString("C2"));
                    Console.WriteLine("Combined FIT paid: " + (sFEDTax + hFEDTax).ToString("C2"));
                    Console.WriteLine();

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