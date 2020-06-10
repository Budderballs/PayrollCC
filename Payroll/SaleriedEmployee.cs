using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollCC
{
    public class SaleriedEmployee : Employee
    {
        public decimal monthlyPay { get;}
        public decimal weeklyPay { get;}
        public decimal FICA { get;}
        public decimal FEDTax { get;}

        public SaleriedEmployee(string fname, string lname, int age, int empID, decimal monthlyPay) : base(fname, lname, age, empID)
        {
            this.monthlyPay = monthlyPay;

            weeklyPay = (monthlyPay * 12) / 52;
            FICA = Math.Round(weeklyPay * .0765m, 2);
            FEDTax = Math.Round(weeklyPay * .265m, 2);
        }
        public override string calcPay()
        {
            decimal totalPay = weeklyPay - FICA - FEDTax;
            return totalPay.ToString("C2");
        }
    }
}
