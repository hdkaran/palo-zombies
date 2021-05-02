using Newtonsoft.Json;
using PaloZombies.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace PaloZombies.Client.Services
{
    public class PatientService: IPatientService
    {
        private readonly HttpClient httpClient;
        private string url = "api/patient";
        public PatientService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<Patient> SavePatient(Patient patient)
        {
            var json = JsonConvert.SerializeObject(patient);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(url, data);
            return await response.Content.ReadFromJsonAsync<Patient>();
        }
    }
}
