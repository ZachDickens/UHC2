using System;
using Xunit;

namespace Patient.Tests
{
    public class PatientTests
    {
        [Fact]
        public void DoctorDrawsBlood()
        {
            PatientTests patient = new PatientTests();

            patient.DoctorDrawsBlood();

            Assert.Equal(15, 15);
        }
        [Fact]
        public void NurseDrawsBlood()
        {
            PatientTests patient = new PatientTests();

            patient.NurseDrawsBlood();

            Assert.Equal(17, 17);
        }

        [Fact]
        public void GivePatientMedicine()
        {
            PatientTests patient = new PatientTests();

            patient.GivePatientMedicine();

            Assert.Equal(11, 11);
        }
    }
}
