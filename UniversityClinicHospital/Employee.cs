using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public abstract class Employee
    {
        public string Name;
        public int Salary;
        public string JobTitle;
        public int EmployeeID;
        bool paid = false;
        
        
        

        public Employee(string name, int employeeid, string jobtitle, int salary)
        {
            Name = name; 
            Salary = salary;
            JobTitle = jobtitle;
            EmployeeID = employeeid;

          
        }
        public Employee()
        {

        }
        
        public void PaySalary()
        {
            if (paid == true)
            {
                Console.WriteLine("You have already paid all your employees");

            }
            else 
            {               
                Console.WriteLine(Name + " got paid!");
                paid = true;
            }        
            
        }


        // janitor clean up floor in patients room
        // receptionist call doctor for emergency
        // nurse draw blood 
        // doctor draw blood if blood level increases, health decreases

        public abstract string PrintEmployee();


    }
}