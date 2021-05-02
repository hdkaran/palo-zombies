using Microsoft.AspNetCore.Components;
using PaloZombies.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaloZombies.Client.Components
{
    public partial class HospitalSelectionButton
    {
        [Parameter]
        public HospitalDTO HospitalDTO { get; set; }
        [Parameter]
        public bool IsSelected { get; set; }
        [Parameter]
        public EventCallback<HospitalDTO> SetSelectedHospital { get; set; }
        private TimeSpan timeSpan = new TimeSpan();
        protected override Task OnParametersSetAsync()
        {
            //converting to timespan for ease of use
            timeSpan = TimeSpan.FromMinutes(HospitalDTO.QuotedWaitingTime);
            return base.OnParametersSetAsync();
        }
    }
}
