using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayrollCC;

namespace PayrollCCTest
{
    [TestClass]
    public class SaleriedEmployeeTest
    {
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
        public void CaclPayMath_CalcPay_ReturnTrue()
        {
            string fName = "Colton";
            string lName = "Chilelli";
            int age = 21;
            int empID = 6969;
            decimal monthlyPay = 1000;

            var employee = new SaleriedEmployee(fName, lName, age, empID, monthlyPay);
            var result = employee.calcPay();
            Assert.AreEqual("$151.97", result);
        }
        [TestMethod]
        public void getPay_MonthlyPay_ReturnNotNull()
        {
            string fName = "Colton";
            string lName = "Chilelli";
            int age = 21;
            int empID = 6969;
            decimal monthlyPay = 1000;

            var employee = new SaleriedEmployee(fName, lName, age, empID, monthlyPay);
            var resultMaybeImFinallyDoneWithThis = employee.monthlyPay;
            Assert.IsNotNull(resultMaybeImFinallyDoneWithThis);
        }
    }
}