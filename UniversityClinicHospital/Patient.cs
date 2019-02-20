using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Patient  
    { 
        public int BloodLevel { get; set; }
        public int HealthLevel { get; set; }
        public string Name { get; set; }
        
        public Patient()
        {
            BloodLevel = 20;
            HealthLevel = 10;
        }

        public Patient(int bloodLevel, int healthLevel)
        {
            BloodLevel = bloodLevel;
            HealthLevel = healthLevel;
        }

        public void DoctorDrawBlood()
        {
            
         BloodLevel = BloodLevel - 5;
         HealthLevel = HealthLevel - 1;
               
        }

        public void NurseDrawBlood()
        {
                       
         BloodLevel = BloodLevel - 3;
         HealthLevel = HealthLevel - 1;
            
        }

        public void GivePatientMedicine()
        {
            HealthLevel = HealthLevel + 1;
        }

    }
}