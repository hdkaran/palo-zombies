using PaloZombies.Shared.DTOs;
using PaloZombies.Shared.Models;
using PaloZombies.Shared.Models.CollectionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PaloZombies.Client.Services
{
    public class IllnessService : IIllnessService
    {
        private readonly HttpClient httpClient;
        private string url = "api/illness";
        public IllnessService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<PaginatedIllness> GetPaginatedIllness()
        {
            return await GetPaginatedIllness(null);
        }
        public async Task<PaginatedIllness> GetPaginatedIllness(Page page)
        {
            HttpResponseMessage response;
            if (page == null)
            {
                response = await httpClient.GetAsync(url);
                return await response.Content.ReadFromJsonAsync<PaginatedIllness>();
            }
            response = await httpClient.GetAsync(url + "?" + Helpers.Extensions.GetUrlParametersFromPage(page));
            return await response.Content.ReadFromJsonAsync<PaginatedIllness>();
        }
    }
}
