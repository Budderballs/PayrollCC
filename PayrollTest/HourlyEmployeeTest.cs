using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayrollCC;

namespace PayrollCCTest
{
    [TestClass]
    public class HourlyEmployeeTest
    {
        [TestMethod]
        public void EmployeeConstructor_MakeEmployee_ReturnTrue()
        {
            string fName = "Colton";
            string lName = "Chilelli";
            int age = 21;
            int empID = 6969;
            decimal hourlyPay = 10m;
            int hoursWorked = 40;

            var employee = new HourlyEmployee(fName, lName, age, empID, hourlyPay, hoursWorked);
            bool result;

            if (employee is Employee) { result = true; }
            else { result = false; }
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CaclPayMath_CalcPay_ReturnTrue()
        {
            string fName = "Colton";
            string lName = "Chilelli";
            int age = 21;
            int empID = 6969;
            decimal hourlyPay = 10m;
            int hoursWorked = 40;

            var employee = new HourlyEmployee(fName, lName, age, empID, hourlyPay, hoursWorked);
            var result2 = employee.calcPay();
            Assert.AreEqual("$263.40", result2);
        }
        [TestMethod]
        public void getHours_HoursWorked_ReturnNotNull()
        {
            string fName = "Colton";
            string lName = "Chilelli";
            int age = 21;
            int empID = 6969;
            decimal hourlyPay = 10m;
            int hoursWorked = 40;

            var employee = new HourlyEmployee(fName, lName, age, empID, hourlyPay, hoursWorked);
            var result3 = employee.hoursWorked;
            Assert.IsNotNull(result3);
        }
        [TestMethod]
        public void getHours_HoursPay_ReturnNotNull()
        {
            string fName = "Colton";
            string lName = "Chilelli";
            int age = 21;
            int empID = 6969;
            decimal hourlyPay = 10m;
            int hoursWorked = 40;

            var employee = new HourlyEmployee(fName, lName, age, empID, hourlyPay, hoursWorked);
            var result4 = employee.hourlyPay;
            Assert.IsNotNull(result4);
        }
    }
}