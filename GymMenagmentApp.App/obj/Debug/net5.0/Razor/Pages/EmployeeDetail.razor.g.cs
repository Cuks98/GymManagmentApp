#pragma checksum "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\EmployeeDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92e274d26a20cef091979ff186b9db5745e6914b"
// <auto-generated/>
#pragma warning disable 1591
namespace GymMenagmentApp.App.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeeDetail/{EmployeeId}")]
    public partial class EmployeeDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddAttribute(1, "class", "page-title");
#nullable restore
#line 4 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\EmployeeDetail.razor"
__builder.AddContent(2, localizer["detailsFor"]);

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, ": ");
#nullable restore
#line 4 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\EmployeeDetail.razor"
__builder.AddContent(4, Employee.FirstName);

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, " ");
#nullable restore
#line 4 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\EmployeeDetail.razor"
__builder.AddContent(6, Employee.LastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-12 row");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-12 row");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-xs-12 col-sm-8");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "form-group row");
            __builder.OpenElement(16, "img");
            __builder.AddAttribute(17, "src", 
#nullable restore
#line 10 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\EmployeeDetail.razor"
                           imagePngDataURL

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "style", "max-width:100%");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form-group row");
            __builder.OpenElement(22, "label");
            __builder.AddAttribute(23, "class", "col-sm-4 col-form-label");
#nullable restore
#line 13 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\EmployeeDetail.razor"
__builder.AddContent(24, localizer["id"]);

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, ":");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col-sm-8");
            __builder.OpenElement(29, "label");
            __builder.AddAttribute(30, "type", "text");
            __builder.AddAttribute(31, "class", "form-control-plaintext");
#nullable restore
#line 15 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\EmployeeDetail.razor"
__builder.AddContent(32, Employee.Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "form-group row");
            __builder.OpenElement(36, "label");
            __builder.AddAttribute(37, "class", "col-sm-4 col-form-label");
#nullable restore
#line 19 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\EmployeeDetail.razor"
__builder.AddContent(38, localizer["firstName"]);

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, ":");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "col-sm-8");
            __builder.OpenElement(43, "label");
            __builder.AddAttribute(44, "type", "text");
            __builder.AddAttribute(45, "class", "form-control-plaintext");
#nullable restore
#line 21 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\EmployeeDetail.razor"
__builder.AddContent(46, Employee.FirstName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "form-group row");
            __builder.OpenElement(50, "label");
            __builder.AddAttribute(51, "class", "col-sm-4 col-form-label");
#nullable restore
#line 25 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\EmployeeDetail.razor"
__builder.AddContent(52, localizer["lastName"]);

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, ":");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "col-sm-8");
            __builder.OpenElement(57, "label");
            __builder.AddAttribute(58, "type", "text");
            __builder.AddAttribute(59, "class", "form-control-plaintext");
#nullable restore
#line 27 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\EmployeeDetail.razor"
__builder.AddContent(60, Employee.LastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n            ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "form-group row");
            __builder.OpenElement(64, "label");
            __builder.AddAttribute(65, "class", "col-sm-4 col-form-label");
#nullable restore
#line 31 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\EmployeeDetail.razor"
__builder.AddContent(66, localizer["Email"]);

#line default
#line hidden
#nullable disable
            __builder.AddContent(67, ":");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "col-sm-8");
            __builder.OpenElement(71, "label");
            __builder.AddAttribute(72, "type", "text");
            __builder.AddAttribute(73, "class", "form-control-plaintext");
#nullable restore
#line 33 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\EmployeeDetail.razor"
__builder.AddContent(74, Employee.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n            ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "form-group row");
            __builder.OpenElement(78, "label");
            __builder.AddAttribute(79, "class", "col-sm-4 col-form-label");
#nullable restore
#line 37 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\EmployeeDetail.razor"
__builder.AddContent(80, localizer["phone"]);

#line default
#line hidden
#nullable disable
            __builder.AddContent(81, ":");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "col-sm-8");
            __builder.OpenElement(85, "label");
            __builder.AddAttribute(86, "type", "text");
            __builder.AddAttribute(87, "class", "form-control-plaintext");
#nullable restore
#line 39 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\EmployeeDetail.razor"
__builder.AddContent(88, Employee.Phone);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n            ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "form-group row");
            __builder.OpenElement(92, "label");
            __builder.AddAttribute(93, "class", "col-sm-4 col-form-label");
#nullable restore
#line 43 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\EmployeeDetail.razor"
__builder.AddContent(94, localizer["levelOfSecurity"]);

#line default
#line hidden
#nullable disable
            __builder.AddContent(95, ":");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                ");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "col-sm-8");
            __builder.OpenElement(99, "label");
            __builder.AddAttribute(100, "type", "text");
            __builder.AddAttribute(101, "class", "form-control-plaintext");
#nullable restore
#line 45 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\EmployeeDetail.razor"
__builder.AddContent(102, Employee.LevelOfSecurity);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<Resource> localizer { get; set; }
    }
}
#pragma warning restore 1591