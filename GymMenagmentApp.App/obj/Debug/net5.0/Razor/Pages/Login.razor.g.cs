#pragma checksum "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "732646a274ad1bcd8ee388ba8819083e8b907aee"
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
#nullable restore
#line 4 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\Login.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "culture-wrapper");
            __builder.OpenComponent<GymMenagmentApp.App.Pages.CultureSelector>(2);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "center");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "loginDiv");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "loginHeader");
            __builder.OpenElement(9, "h4");
#nullable restore
#line 14 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\Login.razor"
__builder.AddContent(10, localizer["login"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "loginBody");
            __builder.OpenElement(14, "div");
            __builder.OpenElement(15, "label");
            __builder.AddAttribute(16, "class", "loginLabel");
            __builder.AddAttribute(17, "for", "email");
#nullable restore
#line 18 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\Login.razor"
__builder.AddContent(18, localizer["email"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "class", "form-control");
            __builder.AddAttribute(22, "type", "email");
            __builder.AddAttribute(23, "name", "email");
            __builder.AddAttribute(24, "style", "max-width:300px");
            __builder.AddAttribute(25, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\Login.razor"
                                                                                                                         (e)=>{ email = (string)e.Value;}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\Login.razor"
                                                                                                      email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenElement(29, "div");
            __builder.OpenElement(30, "label");
            __builder.AddAttribute(31, "class", "loginLabel");
            __builder.AddAttribute(32, "for", "password");
#nullable restore
#line 22 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\Login.razor"
__builder.AddContent(33, localizer["password"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "class", "form-control");
            __builder.AddAttribute(37, "type", "password");
            __builder.AddAttribute(38, "name", "password");
            __builder.AddAttribute(39, "style", "max-width:300px");
            __builder.AddAttribute(40, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\Login.razor"
                                                                                                                                  (e)=>{ password = (string)e.Value;}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\Login.razor"
                                                                                                            password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "loginFooter");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "class", "btn btn-primary btn");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\Login.razor"
                                                           LogIn

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 27 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\Login.razor"
__builder.AddContent(49, localizer["login"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<Resource> localizer { get; set; }
    }
}
#pragma warning restore 1591