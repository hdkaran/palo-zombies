#pragma checksum "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\Components\HospitalSelector.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbbc66488360b3e1f354d7db28889a2f16deba38"
// <auto-generated/>
#pragma warning disable 1591
namespace PaloZombies.Client.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\_Imports.razor"
using PaloZombies.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\_Imports.razor"
using PaloZombies.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\_Imports.razor"
using Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\_Imports.razor"
using PaloZombies.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\_Imports.razor"
using PaloZombies.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
    public partial class HospitalSelector : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\Components\HospitalSelector.razor"
 if (paginatedHospital == null) //while it is loading
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<PaloZombies.Client.Shared.ZombieSpinner>(0);
            __builder.CloseComponent();
#nullable restore
#line 6 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\Components\HospitalSelector.razor"
}
else if (paginatedHospital?.HospitalDTOs != null) //after success load
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<PaloZombies.Client.Components.BackButton>(1);
            __builder.AddAttribute(2, "ButtonText", "Back to Level of Pain");
            __builder.AddAttribute(3, "GoBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 9 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\Components\HospitalSelector.razor"
                                                           GoBack

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card m-3 shadow");
            __builder.AddMarkupContent(7, "<h4 class=\"card-header\">Our suggested hospitals...</h4>\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "container p-3");
#nullable restore
#line 13 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\Components\HospitalSelector.razor"
             foreach (var hosp in paginatedHospital.HospitalDTOs)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<PaloZombies.Client.Components.HospitalSelectionButton>(10);
            __builder.AddAttribute(11, "HospitalDTO", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<PaloZombies.Shared.DTOs.HospitalDTO>(
#nullable restore
#line 15 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\Components\HospitalSelector.razor"
                                                      hosp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "SetSelectedHospital", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<PaloZombies.Shared.DTOs.HospitalDTO>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<PaloZombies.Shared.DTOs.HospitalDTO>(this, 
#nullable restore
#line 15 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\Components\HospitalSelector.razor"
                                                                                 SetSelectedHospital

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "IsSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\Components\HospitalSelector.razor"
                                                                                                                  (SelectedHospitalId==hosp.HospitalId)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 16 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\Components\HospitalSelector.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<PaloZombies.Client.Shared.Pagination>(14);
            __builder.AddAttribute(15, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 17 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\Components\HospitalSelector.razor"
                                     paginatedHospital.Page.Number

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "TotalPages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 17 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\Components\HospitalSelector.razor"
                                                                                paginatedHospital.Page.TotalPages+1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "SelectedPages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 17 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\Components\HospitalSelector.razor"
                                                                                                                                    SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\Components\HospitalSelector.razor"
}
else if (paginatedHospital.ErrorText != null) //if load was unsuccessful
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "container p-3");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "h3 m-3");
            __builder.AddContent(22, 
#nullable restore
#line 25 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\Components\HospitalSelector.razor"
                             paginatedHospital.ErrorText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\Components\HospitalSelector.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHospitalService _hospitalService { get; set; }
    }
}
#pragma warning restore 1591
