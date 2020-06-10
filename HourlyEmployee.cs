using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollCC
{
    public class HourlyEmployee : Employee
    {
        public decimal weeklyPay { get; set; }
        public decimal hourlyPay { get; set; }
        public decimal FICA { get; set; }
        public decimal FEDTax { get; set; }
        public int hoursWorked { get; set; }

        public HourlyEmployee(string fname, string lname, int age, int empID, decimal hourlyPay, int hoursWorked) : base(fname, lname, age, empID)
        {
            this.hourlyPay = hourlyPay;
            this.hoursWorked = hoursWorked;
            weeklyPay = hourlyPay * hoursWorked;
            FICA = Math.Round(weeklyPay * .0765m, 2);
            FEDTax = Math.Round(weeklyPay * .0765m, 2);
        }
        public override string calcPay()
        {
            decimal totalPay = weeklyPay - FICA - FEDTax;
            return totalPay.ToString("C2");
        }
    }
}
