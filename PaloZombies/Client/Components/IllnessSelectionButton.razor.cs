using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaloZombies.Shared.Models;

namespace PaloZombies.Client.Components
{
    public partial class IllnessSelectionButton
    {
        [Parameter]
        public Illness Illness { get; set; }
        [Parameter]
        public EventCallback<Illness> SetPatientIllness { get; set; }
        [Parameter]
        public bool IsSelected { get; set; }
        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }

    }
}
