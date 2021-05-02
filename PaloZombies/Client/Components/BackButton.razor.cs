using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaloZombies.Client.Components
{
    public partial class BackButton
    {
        [Parameter]
        public string ButtonText { get; set; }
        [Parameter]
        public EventCallback GoBack { get; set; }
    }
}
