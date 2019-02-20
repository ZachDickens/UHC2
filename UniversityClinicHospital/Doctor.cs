using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Doctor : Employee
    {
        
        public string SpecialtyArea { get; set; }
        
        public Doctor()
        {
           
            Salary = 90000;
            SpecialtyArea = "Heart";
            Name = "Joe";
            EmployeeID = 967;
            JobTitle = "Doctor";

        }

        public override string PrintEmployee()
        {
            return Name + " " + EmployeeID + " " + JobTitle + " " + Salary + " " + SpecialtyArea;
        }

        

    }
    
}
