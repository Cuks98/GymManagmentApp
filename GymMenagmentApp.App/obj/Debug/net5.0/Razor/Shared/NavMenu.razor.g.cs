#pragma checksum "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "687aeac276ad424fbad0c47aa3bff5e2a23cd94c"
// <auto-generated/>
#pragma warning disable 1591
namespace GymMenagmentApp.App.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\_Imports.razor"
using GymMenagmentApp.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\_Imports.razor"
using GymMenagmentApp.App.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\_Imports.razor"
using GymMenagmentApp.App.Shared.ResourceFiles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\_Imports.razor"
using Syncfusion.Blazor.TreeGrid;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-umz4a6vdmz");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-umz4a6vdmz>GymMenagmentApp.App</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-umz4a6vdmz");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-umz4a6vdmz></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 10 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-umz4a6vdmz");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-umz4a6vdmz");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-umz4a6vdmz");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "home");
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(24, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-umz4a6vdmz></span> ");
#nullable restore
#line 14 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Shared\NavMenu.razor"
__builder2.AddContent(25, localizer["home"]);

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "li");
            __builder.AddAttribute(28, "class", "nav-item px-3");
            __builder.AddAttribute(29, "b-umz4a6vdmz");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(30);
            __builder.AddAttribute(31, "class", "nav-link");
            __builder.AddAttribute(32, "href", "userOverview");
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(34, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-umz4a6vdmz></span> ");
#nullable restore
#line 24 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Shared\NavMenu.razor"
__builder2.AddContent(35, localizer["users"]);

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "li");
            __builder.AddAttribute(38, "class", "nav-item px-3");
            __builder.AddAttribute(39, "b-umz4a6vdmz");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(40);
            __builder.AddAttribute(41, "class", "nav-link");
            __builder.AddAttribute(42, "href", "trainerOverview");
            __builder.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(44, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-umz4a6vdmz></span> ");
#nullable restore
#line 29 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Shared\NavMenu.razor"
__builder2.AddContent(45, localizer["trainers"]);

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n\r\n        ");
            __builder.OpenElement(47, "li");
            __builder.AddAttribute(48, "class", "nav-item px-3");
            __builder.AddAttribute(49, "b-umz4a6vdmz");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(50);
            __builder.AddAttribute(51, "class", "nav-link");
            __builder.AddAttribute(52, "href", "employeeOverview");
            __builder.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(54, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-umz4a6vdmz></span> ");
#nullable restore
#line 35 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Shared\NavMenu.razor"
__builder2.AddContent(55, localizer["employees"]);

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\r\n        ");
            __builder.OpenElement(57, "li");
            __builder.AddAttribute(58, "class", "nav-item px-3");
            __builder.AddAttribute(59, "b-umz4a6vdmz");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(60);
            __builder.AddAttribute(61, "class", "nav-link");
            __builder.AddAttribute(62, "href", "newsletter");
            __builder.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(64, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-umz4a6vdmz></span> ");
#nullable restore
#line 41 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Shared\NavMenu.razor"
__builder2.AddContent(65, localizer["newsletter"]);

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Shared\NavMenu.razor"
         if (isAdmin)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(66, "li");
            __builder.AddAttribute(67, "class", "nav-item px-3");
            __builder.AddAttribute(68, "b-umz4a6vdmz");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(69);
            __builder.AddAttribute(70, "class", "nav-link");
            __builder.AddAttribute(71, "href", "loginDataOverview");
            __builder.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(73, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-umz4a6vdmz></span> ");
#nullable restore
#line 48 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Shared\NavMenu.razor"
__builder2.AddContent(74, localizer["loginData"]);

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n            ");
            __builder.OpenElement(76, "li");
            __builder.AddAttribute(77, "class", "nav-item px-3");
            __builder.AddAttribute(78, "b-umz4a6vdmz");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(79);
            __builder.AddAttribute(80, "class", "nav-link");
            __builder.AddAttribute(81, "href", "transactionsOverview");
            __builder.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(83, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-umz4a6vdmz></span> ");
#nullable restore
#line 53 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Shared\NavMenu.razor"
__builder2.AddContent(84, localizer["transactions"]);

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n            ");
            __builder.OpenElement(86, "li");
            __builder.AddAttribute(87, "class", "nav-item px-3");
            __builder.AddAttribute(88, "b-umz4a6vdmz");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(89);
            __builder.AddAttribute(90, "class", "nav-link");
            __builder.AddAttribute(91, "href", "reports");
            __builder.AddAttribute(92, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(93, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-umz4a6vdmz></span> ");
#nullable restore
#line 58 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Shared\NavMenu.razor"
__builder2.AddContent(94, localizer["reports"]);

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private bool isAdmin = false;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    protected async override Task OnInitializedAsync()
    {
        var security = await localstorage.GetItemAsync<string>("security");
        if (security == "2")
        {
            isAdmin = true;
        }
        else
        {
            isAdmin = false;
        }
    }

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<Resource> localizer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localstorage { get; set; }
    }
}
#pragma warning restore 1591
