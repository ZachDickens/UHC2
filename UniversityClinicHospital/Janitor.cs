using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Janitor : Employee
    {
        bool sweeping = false;
        public Janitor()
        {
            Salary = 40000;
            Name = "Brent";
            EmployeeID = 212;
            JobTitle = "Janitor";
        }

        public void JanitorIsSweeping()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 2);
            if (number == 1)
            {
                sweeping = true;
                Console.WriteLine("The Janitor is busy sweeping right now");
            }
            else
            {
                sweeping = false;
                Console.WriteLine("The Janitor is not sweeping right now");
            }
        }

        public override string PrintEmployee()
        {
            string sweepingString = "";

            if(sweeping)
            {
                sweepingString = "Is Sweeping";
            }
            else
            {
                sweepingString = "Is Not Sweeping";
            }

            return Name + " " + EmployeeID + " " + JobTitle + " " + Salary + " " + sweepingString;
        }
    }
}
