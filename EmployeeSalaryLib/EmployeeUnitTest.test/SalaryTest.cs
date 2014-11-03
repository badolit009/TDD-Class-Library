using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeSalaryLib;
using NUnit.Framework;

namespace EmployeeUnitTest.test
{
    [TestFixture]
    class SalaryTest
    {
        private Salary aSalary;

        [SetUp]
        public void Start()
        {
            
        }
        [Test]
        public void CreateSalaryAndCheckInitialyTotalZero()
        {
            aSalary = new Salary();
            Assert.AreEqual(0,aSalary.Total);
        }

        [Test]
        public void CreateSalaryWithBasic5000MedicaAndConveyanceTotalShouldBe6700()
        {
            aSalary = new Salary();
            aSalary.Basic = 5000;
            aSalary.MedicalPercent = 20;
            aSalary.ConveyancePercent = 15;

            Assert.AreEqual(6750,aSalary.GetTotal());
        }

        [Test]
        public void CreateSalaryWithBasic5000AndMedicalPercent20()
        {
            aSalary = new Salary();
            aSalary.Basic = 5000;
            aSalary.MedicalPercent = 20;
            Assert.AreEqual(1000,aSalary.GetMedicalPercent());
        }

        [Test]
        public void CreateSalaryWithBasic5000AndConveyance15()
        {
            aSalary = new Salary();
            aSalary.Basic = 5000;
            aSalary.ConveyancePercent = 15;
            Assert.AreEqual(750,aSalary.GetConveyancePercent());
        }

        [Test]
        public void CreateSalaryWithBasic5000AndIncrementPercent20()
        {
            aSalary = new Salary();
            aSalary.Basic = 5000;
            aSalary.IncrementPercent = 20;
            Assert.AreEqual(1000,aSalary.GetIncrimentPercent());
        }
        [Test]
        public void CheckTotal()
        {
            aSalary = new Salary(5000, 20, 15, 20);
            Assert.AreEqual(7750,aSalary.GetTotal());

        }

        [TearDown]
        public void End()
        {
            aSalary = null;
        }
    }
}
