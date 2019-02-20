using System;
using Xunit;
using UniversityClinicHospital;
namespace EmployeeClass.Tests
{
    public class EmployeeTests
    {
        public string Name;
        public int Salary;
        public string JobTitle;
        public int EmployeeID;
        [Fact]
        public void CanPayEmployee()
        {
            //Arrange
            Employee employee = new Employee();

            //Act
            employee.PaySalary (Name, EmployeeID, JobTitle, Salary);

            //Assert
            Assert.Equal(90000, 90000);

        }

        

        [Fact]
        public void NurseDrawBlood()
        {
            //Arrange 
            Employee employee = new Employee();
            //Act
            //employee
            //Assert
        }
    }
}
