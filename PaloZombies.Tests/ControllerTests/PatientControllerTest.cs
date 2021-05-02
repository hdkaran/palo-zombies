using Microsoft.AspNetCore.Mvc;
using Moq;
using PaloZombies.Server.Controllers;
using PaloZombies.Server.Repository;
using PaloZombies.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PaloZombies.Tests.ControllerTests
{
    public class PatientControllerTest
    {
        private PatientController _patientController;
        Mock<IPatientRepository> _mockPatientRepo = new Mock<IPatientRepository>();
        public PatientControllerTest()
        {
            _patientController = new PatientController(_mockPatientRepo.Object);
        }

        [Fact]
        public void Check_PostFunction_PatientIsReturned()
        {
            //Arrange
            Patient p = new Patient()
            {
                FirstName = "Test",
                LastName = "Test Last",
                Illness = new Illness() { Id = 1, Name = "Test Illness" },
                LevelOfPain = 1,
                SelectedHospital = new Shared.DTOs.HospitalDTO() { HospitalId = 1, HospitalName = "Test Hosp", QuotedWaitingTime = 2 }
            };
            _mockPatientRepo.Setup(s => s.Create(null)).Returns(Task.FromResult(GetUpdatedPatient(p)).Result);

            //act
            var response = _patientController.Create(p);

            //assert
            Assert.IsType<ActionResult<Patient>>(response);
        }
        [Fact]
        public void Check_PostFunctionInvalid_NullIsReturned()
        {
            //Arrange
            Patient p = null;
            _mockPatientRepo.Setup(s => s.Create(p)).Returns(Task.FromResult(GetUpdatedPatient(p)).Result);

            //act
            var response = _patientController.Create(p);

            //pass empty object
            //assert
            Assert.Null(response);
        }

        private Patient GetUpdatedPatient(Patient p)
        {
            if (p == null)
                return p;
            p.Id = new Guid().ToString();
            return p;
        }
    }
}
