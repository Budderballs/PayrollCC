using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollCC
{
    public abstract class Employee
    {
        //Data
        string fName { get; }
        string lName { get; }
        int age { get; }
        int empID { get; }

        //Props
        public string fullName { get { return lName + ", " + fName; } }
        public int Age { get { return age; } }
        public int eID { get { return empID; } }

        protected Employee(string fname, string lname, int age, int empID)
        {
            this.fName = fname;
            this.lName = lname;
            this.age = age;
            this.empID = empID;
        }
        public abstract string calcPay();
    }
}
