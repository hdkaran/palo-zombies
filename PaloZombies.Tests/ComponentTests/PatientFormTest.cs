using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using PaloZombies.Client.Components;
using PaloZombies.Client.Services;
using PaloZombies.Shared.DTOs;
using PaloZombies.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PaloZombies.Tests.ComponentTests
{
    public class PatientFormTest : TestContext
    {
        TestContext tc = new TestContext();
        Mock<IPatientService> patientService = new Mock<IPatientService>();
        Mock<IIllnessService> illnessService = new Mock<IIllnessService>();
        Mock<IHospitalService> hospitalService = new Mock<IHospitalService>();
        Illness illness = new Illness() { Id = 10, Name = "Test Illness" };

        [Fact]
        public void Check_PatientPage_LoadsIllnessSelector()
        {
            //Arrange
            illnessService.Setup(s => s.GetPaginatedIllness()).Returns(Task.FromResult(new PaginatedIllness() { Illnesses = new List<Illness>() { illness }, Page = new Shared.Models.CollectionModels.Page() }));
            tc.Services.AddSingleton<IPatientService>(patientService.Object);
            tc.Services.AddSingleton<IIllnessService>(illnessService.Object);

            //Act
            var page = tc.RenderComponent<PatientForm>();

            //assert
            page.Markup.Contains($"<h4 class=\"card-title\" id=\"illness-{illness.Id}\">{illness.Name}</h4>");
        }
        [Fact]
        public void Check_LevelofPainPage_LoadsCorrectly()
        {
            //Arrange
            illnessService.Setup(s => s.GetPaginatedIllness()).Returns(Task.FromResult(new PaginatedIllness() { Illnesses = new List<Illness>() { illness }, Page = new Shared.Models.CollectionModels.Page() }));
            tc.Services.AddSingleton<IPatientService>(patientService.Object);
            tc.Services.AddSingleton<IIllnessService>(illnessService.Object);

            //Act
            var page = tc.RenderComponent<PatientForm>();
            page.Find("button").Click();

            //assert
            //check if number of list items is 5
            var li = page.FindAll("li");
            Assert.Equal(5, li.Count);

        }
        [Fact]
        public void Check_HospitalsPage_LoadsCorrectly()
        {
            //Arrange
            HospitalDTO hospDTO = new HospitalDTO() { HospitalId = 1, HospitalName = "Sydney Hospital", QuotedWaitingTime = 10 };
            illnessService.Setup(s => s.GetPaginatedIllness()).Returns(Task.FromResult(new PaginatedIllness() { Illnesses = new List<Illness>() { illness }, Page = new Shared.Models.CollectionModels.Page() }));
            hospitalService.Setup(s => s.GetPaginatedHospital(null, 0)).Returns(Task.FromResult(new PaginatedHospital() { HospitalDTOs = new List<HospitalDTO>() { hospDTO }, Page = new Shared.Models.CollectionModels.Page() }));
            tc.Services.AddSingleton<IPatientService>(patientService.Object);
            tc.Services.AddSingleton<IIllnessService>(illnessService.Object);
            tc.Services.AddSingleton<IHospitalService>(hospitalService.Object);

            //Act
            var page = tc.RenderComponent<PatientForm>();
            page.Find("button").Click();
            page.Find("li").Click();
            var markUpToCompare = page.FindAll("h4").Last();

            //assert
            markUpToCompare.MarkupMatches(@"<h4 class=""card-title"">" + hospDTO.HospitalName + "</h4>");
        }
        [Fact]
        public void Check_HospitalsErrorMessage_IsShown()
        {
            //Arrange
            string errorMessage = "A network error has occured.";
            illnessService.Setup(s => s.GetPaginatedIllness()).Returns(Task.FromResult(new PaginatedIllness() { Illnesses = new List<Illness>() { illness }, Page = new Shared.Models.CollectionModels.Page() }));
            hospitalService.Setup(s => s.GetPaginatedHospital(null, 0)).Returns(Task.FromResult(new PaginatedHospital() { HospitalDTOs = null, ErrorText = errorMessage }));
            tc.Services.AddSingleton<IPatientService>(patientService.Object);
            tc.Services.AddSingleton<IIllnessService>(illnessService.Object);
            tc.Services.AddSingleton<IHospitalService>(hospitalService.Object);

            //Act
            var page = tc.RenderComponent<PatientForm>();
            page.Find("button").Click();
            page.Find("li").Click();
            var markUpToCompare = page.Find(".h3");

            //assert
            markUpToCompare.MarkupMatches(@"<div class=""h3 m-3"">" + errorMessage + "</div>");
        }


    }
}
