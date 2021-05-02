using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PaloZombies.Shared.DTOs;
using PaloZombies.Shared.Models;
using PaloZombies.Shared.Models.CollectionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PaloZombies.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        private readonly IHttpClientFactory factory;
        private string API_ENDPOINT = @"/hospitals"; //actual api endpoint
        private string API_URL;

        public HospitalController(IHttpClientFactory factory, IConfiguration config)
        {
            this.factory = factory;
            API_URL = config.GetValue<string>("PaloSettings:APIUrl"); //getting url from appsettings.json
        }


        [HttpGet]
        public async Task<PaginatedHospital> GetByPage([FromQuery] Page page, [FromQuery] int LevelOfPain)
        {
            PaginatedHospital paginatedHospital = new PaginatedHospital();
            try
            {
                HttpResponseMessage response = await DoGetRequestWithPageAndReturnResponse(page);
                if (response.IsSuccessStatusCode)
                {
                    var model = await response.Content.ReadFromJsonAsync<CollectionModel>();
                    var pageSize = page.Size == 0 ? 10 : page.Size;
                    //get all hospitals that are available in the api and convert them to HospitalDTO objects, also, calculate the wait time
                    paginatedHospital.HospitalDTOs = (await GetAllHospitals(model)).Select(x => new HospitalDTO() { HospitalId = x.Id, QuotedWaitingTime = GetWaitingTime(x.WaitingList, LevelOfPain), HospitalName = x.Name }).ToList();
                    //sort the HospitalDTOs by wait time ascending and then send data back based on page info
                    paginatedHospital.HospitalDTOs = paginatedHospital.HospitalDTOs.OrderBy(x => x.QuotedWaitingTime).Skip(page.Number * pageSize).Take(pageSize).ToList();
                    paginatedHospital.Page = model.Page;
                    return paginatedHospital;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception e) //using the text provided on the front end
            {
                return new PaginatedHospital() { ErrorText = "A network error has occured. Please check your connection and try again later." };
            }

        }

        private double GetWaitingTime(Waitinglist[] waitingList, int levelOfPain)
        {
            //checking if multiple entries exist
            var patientCount = waitingList.Where(x => x.LevelOfPain == levelOfPain).Select(x => x.PatientCount).ToList();
            var averageProcessingTime = waitingList.Where(x => x.LevelOfPain == levelOfPain).Select(x => x.AverageProcessTime).ToList();

            return patientCount.Sum() * averageProcessingTime.Sum();

        }

        private async Task<List<Hospital>> GetAllHospitals(CollectionModel collectionModel)
        {
            List<Hospital> hospitalsToReturn = new List<Hospital>();
            if (collectionModel.Page != null && collectionModel.Page.TotalElements <= 10)
                hospitalsToReturn = collectionModel._embedded.Hospitals.ToList();

            //since max number of items that can be returned from API at one time is 20
            //we need to do multiple requests to the API to get all hospitals

            int totalRequestsToBeMade = (collectionModel.Page.TotalElements / 20) + 1;

            for (int i = 0; i < totalRequestsToBeMade; i++)
            {
                Page page = new Page() { Size = 20, Number = i };
                HttpResponseMessage response = await DoGetRequestWithPageAndReturnResponse(page);
                if (response.IsSuccessStatusCode)
                {
                    var model = await response.Content.ReadFromJsonAsync<CollectionModel>();
                    hospitalsToReturn.AddRange(model._embedded.Hospitals.ToList());
                }
            }
            return hospitalsToReturn;
        }

        private async Task<HttpResponseMessage> DoGetRequestWithPageAndReturnResponse(Page page)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, API_URL + API_ENDPOINT + ExternalAPIHelpers.PaloConvert.ConvertPageToAPIString(page));
            var client = factory.CreateClient();
            try
            {
                HttpResponseMessage response = await client.SendAsync(request);
                return response;
            }
            catch (Exception e)
            {
                throw new ApplicationException();
            }
        }
    }
}
