using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    class Program 
    {
        
        public static void Main(string[] args) 
        {
            Doctor doctor = new Doctor();
            Nurse nurse = new Nurse();
            Receptionist receptionist = new Receptionist();
            Janitor janitor = new Janitor();
            Patient patient = new Patient();
            List<Employee> Employees = new List<Employee>()
            {
                doctor,
                nurse,
                receptionist,
                janitor
            };

            PerformActivitiesMenu(Employees, patient);
                        
        }
        
        public static void PerformActivitiesMenu(List<Employee> Employees, Patient patient)
        {            
            
            string userInput;
            bool running = true;

            while (running)
            {
                Console.WriteLine("Welcome to the University Clinic Hospital Staff Directory \n");

                PrintList(Employees);

                Console.WriteLine("\nPress 1 to select an employee to interact with \n");
                Console.WriteLine("Press 2 to pay all the employees \n");
                Console.WriteLine("Press 0 to close the program \n");
                
                userInput = Console.ReadLine();
                Console.Clear();
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Press 1 for Doctor \n" +
                                          "Press 2 for Nurse \n" +
                                          "Press 3 for Receptionist \n" +
                                          "Press 4 for Janitor ");

                        userInput = Console.ReadLine();
                        Console.Clear();
                        if (userInput == "1")
                        {
                            Console.WriteLine("You have chosen Doctor \n");
                            Console.WriteLine("Press 1 to draw blood \n" +
                                              "Press 2 to give medicine \n" +
                                              "Press 3 to call a doctor to report to the emergency room");
                            userInput = Console.ReadLine();
                            Console.Clear();
                            if (userInput == "1")
                            {
                                Console.WriteLine("The Doctor has drawn the patient's blood");
                                patient.DoctorDrawBlood();
                                Console.WriteLine("Patients BloodLevel: " + patient.BloodLevel);
                                Console.WriteLine("Patients HealthLevel: " + patient.HealthLevel);
                                Console.WriteLine("Press any key to continue");
                                Console.ReadLine();
                                Console.Clear();


                            }
                            if (userInput == "2")
                            {
                                Console.WriteLine("The Doctor has given the patient medicine");
                                patient.GivePatientMedicine();
                                Console.WriteLine("Patients HealthLevel: " + patient.HealthLevel);
                                Console.WriteLine("Press any key to continue");
                                Console.ReadLine();
                                Console.Clear();

                            }
                            if (Console.ReadLine() == "3")
                            {
                                Console.WriteLine("The Doctor calls a doctor to the emergency room");
                            }

                        }
                        if (userInput == "2")
                        {
                            Console.WriteLine("You have chosen Nurse");
                            Console.WriteLine("Press 1 to draw blood" +
                                              "Press 2 to give medicine" +
                                              "Press 3 to call a doctor to report to the emergency room");
                            
                            if (userInput == "1")
                            {
                                Console.WriteLine("The Nurse has drawn the patient's blood");
                                patient.NurseDrawBlood();
                                Console.WriteLine("Patients BloodLevel: " + patient.BloodLevel);
                                Console.WriteLine("Patients HealthLevel: " + patient.HealthLevel);
                                Console.WriteLine("Press any key to continue");
                                Console.ReadLine();
                            }
                            if (userInput == "2")
                            {
                                Console.WriteLine("The Nurse has given the patient medicine");
                                patient.GivePatientMedicine();
                                Console.WriteLine("Patients HealthLevel: " + patient.HealthLevel);
                                Console.WriteLine("Press any key to continue");
                                Console.ReadLine();

                            }
                            if (userInput == "3")
                            {
                                Console.WriteLine("The Nurse calls a doctor to the emergency room");

                            }


                        }
                        if (userInput == "3")
                        {
                            Console.WriteLine("You have chosen Receptionist");
                            Console.WriteLine("Press 1 to call a doctor to report to the emergency room");
                            userInput = Console.ReadLine();
                            if (userInput == "1")
                            {
                                Console.WriteLine("The Receptionist calls a doctor to the emergency room");
                            }
                        }
                        if (userInput == "4")
                        {
                            Console.WriteLine("You have chosen Janitor");
                            Console.WriteLine("Press 1 to sweep the emergency room floor");
                            
                            if (userInput == "1")
                            {
                                Console.WriteLine("The Janitor has swept the emergency room floor");
                            }
                        }
                        break;

                    case "2":

                        foreach(var employee in Employees)
                        {
                            employee.PaySalary();
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadLine();
                            Console.Clear();
                        }

                        break;

                    case "0":
                        Environment.Exit(1);
                        break;

                    default:
                        Console.WriteLine("Invalid response please choose option one");
                        break;
                }

            }
                         
        }

        public static void PrintList(List<Employee> employees)
        {
            Console.WriteLine("Name | Employee ID | Job Title | Salary | Job Specific Info");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.PrintEmployee());
            }

        }
        
        
        
    }

}
