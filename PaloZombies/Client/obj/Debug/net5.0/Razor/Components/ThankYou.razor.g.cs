#pragma checksum "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\Components\ThankYou.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd1bff975daa82245cce0d3a02e012ee4ce8675c"
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
    public partial class ThankYou : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron text-center");
            __builder.AddMarkupContent(2, "<h1 class=\"display-4\">Information Received!</h1>\r\n    ");
            __builder.AddMarkupContent(3, "<p class=\"lead\"><strong>Help is on the way!</strong> Hang on tight, we are on the way to save you. </p>\r\n    <hr>\r\n    ");
            __builder.OpenElement(4, "p");
            __builder.AddMarkupContent(5, "\r\n        Your Patient Id is ");
            __builder.OpenElement(6, "strong");
            __builder.AddContent(7, 
#nullable restore
#line 7 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\Components\ThankYou.razor"
                                    PatientId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "p");
            __builder.AddAttribute(10, "class", "lead");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "class", "btn btn-primary");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\karan\source\repos\PaloZombies\PaloZombies\Client\Components\ThankYou.razor"
                                                  NavigateToStart

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "type", "button");
            __builder.AddContent(15, "Start Again");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
