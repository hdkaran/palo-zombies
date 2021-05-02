using Microsoft.AspNetCore.Components;
using PaloZombies.Shared.DTOs;
using PaloZombies.Shared.Models;
using PaloZombies.Shared.Models.CollectionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaloZombies.Client.Components
{
    public partial class HospitalSelector
    {
      
        [Parameter]
        public int LevelOfPain { get; set; }
        [Parameter]
        public int SelectedHospitalId { get; set; }
        [Parameter]
        public EventCallback<HospitalDTO> SetSelectedHospital { get; set; }
        [Parameter]
        public EventCallback GoBack { get; set; }

        private PaginatedHospital paginatedHospital;

        protected override async Task OnParametersSetAsync()
        {
            //initial load
            paginatedHospital = await _hospitalService.GetPaginatedHospital(null, LevelOfPain);
            await base.OnParametersSetAsync();
        }
        protected async Task<PaginatedHospital> GetPaginatedHospitalAsync(Page page)
        {
            //on pagination
            return paginatedHospital = await _hospitalService.GetPaginatedHospital(page, LevelOfPain);
        }

        private async Task SelectedPage(int pageNum)
        {
            paginatedHospital.Page.Number = pageNum;
            await GetPaginatedHospitalAsync(paginatedHospital.Page);
        }
    }
}
