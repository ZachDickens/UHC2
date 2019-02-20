using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Receptionist : Employee
    {
        // use bool for on phone or not
        bool onthephone = false;
        
        

        public Receptionist()
        {
            Salary = 45000;
            Name = "Tiffany";
            JobTitle = "Receptionist";
            EmployeeID = 323;
        }

        public void ReceptionistOnThePhone()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 2);
            if (number == 1)
            {
                onthephone = true;
                Console.WriteLine("The Receptionist is busy right now, please be patient");
            }
            else 
            {
                onthephone = false;
                Console.WriteLine("The Receptionist is not on the phone");
            }
        }

        public override string PrintEmployee()
        {
            string phoneString = "";

            if (onthephone)
            {
                phoneString = "On Phone";
            }
            else
            {
                phoneString = "Off Phone";
            }

            return Name + " " + EmployeeID + " " + JobTitle + " " + Salary + " " + phoneString;
        }
    }
}
