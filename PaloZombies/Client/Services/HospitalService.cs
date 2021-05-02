using PaloZombies.Shared.DTOs;
using PaloZombies.Shared.Models.CollectionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PaloZombies.Client.Services
{
    public class HospitalService: IHospitalService
    {
        private readonly HttpClient httpClient;
        private string url = "api/hospital";
        public HospitalService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<PaginatedHospital> GetPaginatedHospital(Page page, int LevelOfPain)
        {
            var response = await httpClient.GetAsync(url + "?" + (page == null ? "" : Helpers.Extensions.GetUrlParametersFromPage(page)) + "&" + Helpers.Extensions.GetUrlParameterFromLevelOfPain(LevelOfPain));
            return await response.Content.ReadFromJsonAsync<PaginatedHospital>();
        }
    }
}
