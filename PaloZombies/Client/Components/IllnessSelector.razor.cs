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
    public partial class IllnessSelector
    {
        [Parameter]
        public int SelectedIllnessId { get; set; }
        [Parameter]
        public EventCallback<Illness> SetPatientIllness { get; set; }


        private PaginatedIllness paginatedIllnesses;

        protected override async Task OnInitializedAsync()
        {
            paginatedIllnesses = await _illnessService.GetPaginatedIllness();
            await base.OnInitializedAsync();
        }

        protected async Task<PaginatedIllness> GetPaginatedIllnessAsync(Page page)
        {    
            return paginatedIllnesses = await _illnessService.GetPaginatedIllness(page);
        }

        private async Task SelectedPage(int page)
        {
            paginatedIllnesses.Page.Number = page;
            await GetPaginatedIllnessAsync(paginatedIllnesses.Page);
        }
    }
}
