using Microsoft.AspNetCore.Components;
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
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class IllnessController : ControllerBase
    {
        private readonly IHttpClientFactory factory;
        private string API_ENDPOINT = @"/illnesses";
        private string API_URL;

        //Dependency injection for HTTP Client Service as well as Configuration
        public IllnessController(IHttpClientFactory factory, IConfiguration config)
        {
            this.factory = factory;
            API_URL = config.GetValue<string>("PaloSettings:APIUrl");
        }
        [HttpGet]
        public async Task<PaginatedIllness> GetByPage([FromQuery] Page page)
        {
            PaginatedIllness paginatedIllness = new PaginatedIllness();
            var request = new HttpRequestMessage(HttpMethod.Get, API_URL + API_ENDPOINT + ExternalAPIHelpers.PaloConvert.ConvertPageToAPIString(page));
            var client = factory.CreateClient();
            try
            {
                HttpResponseMessage response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    var model = await response.Content.ReadFromJsonAsync<CollectionModel>();
                    var illnessesToReturn = model._embedded.Illnesses.Select(x => x.Illness).ToList();
                    var page1 = model.Page;
                    paginatedIllness.Illnesses = illnessesToReturn;
                    paginatedIllness.Page = page1;
                    return paginatedIllness;
                }
                else
                    throw new ApplicationException();
            }
            catch (Exception e1)
            {

                paginatedIllness.ErrorText = $"A network error has occured. Please check your connection and try again later.";
                return paginatedIllness;
            }
        
        }
    }
}
