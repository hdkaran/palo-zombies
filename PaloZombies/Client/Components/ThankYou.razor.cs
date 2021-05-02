using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaloZombies.Client.Components
{
    public partial class ThankYou
    {
        [Parameter]
        public string PatientId { get; set; }
        private void NavigateToStart()
        {
            _navigationManager.NavigateTo("/", true);
        }
    }
}
