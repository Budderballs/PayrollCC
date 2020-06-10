using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayrollCC;

namespace PayrollCCTest
{
    [TestClass]
    public class EmployeeTest
    {
        //Comment
        [TestMethod]
        public void EmployeeConstructor_MakeEmployee_ReturnTrue()
        {
            string fName = "Colton";
            string lName = "Chilelli";
            int age = 21;
            int empID = 6969;
            decimal monthlyPay = 10000m;

            var employee = new SaleriedEmployee(fName, lName, age, empID, monthlyPay);
            bool result;

            if (employee is Employee) { result = true; }
            else { result = false; }
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmployeeName_GetEmployeeName_ReturnTrue()
        {
            string fName = "Colton";
            string lName = "Chilelli";
            int age = 21;
            int empID = 6969;
            decimal payAmount = 80000m;

            var employee = new SaleriedEmployee(fName, lName, age, empID, payAmount);
            bool result;

            if (employee.fullName is string) { result = true; }
            else { result = false; }
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmployeeAge_GetEmployeeAge_ReturnTrue()
        {
            string fName = "Colton";
            string lName = "Chilelli";
            int age = 21;
            int empID = 6969;
            decimal payAmount = 80000m;

            var employee = new SaleriedEmployee(fName, lName, age, empID, payAmount);
            bool result;

            if (employee.Age is int) { result = true; }
            else { result = false; }
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmployeeID_GetEmployeeID_ReturnTrue()
        {
            string fName = "Colton";
            string lName = "Chilelli";
            int age = 21;
            int empID = 6969;
            decimal payAmount = 80000m;

            var employee = new SaleriedEmployee(fName, lName, age, empID, payAmount);
            bool result;

            if (employee.eID is int) { result = true; }
            else { result = false; }
            Assert.IsTrue(result);
        }
    }
}
