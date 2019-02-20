using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Nurse : Employee
    {
        public int NumberOfPatients { get; set; }
        
        public Nurse()
        {          
            Salary = 50000;
            JobTitle = "Nurse";
            EmployeeID = 542;
            NumberOfPatients = 8;
            Name = "Megan";
        }

        public override string PrintEmployee()
        {
            return Name + " " + EmployeeID + " " + JobTitle + " " + Salary + " " + NumberOfPatients;
        }

    }
}
