#pragma checksum "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\UserEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26cd1c432df61c031c561f687c93526acefd48d4"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/useredit/{UserId}")]
    public partial class UserEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\UserEdit.razor"
 if (!Saved)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "section");
            __builder.OpenElement(1, "h1");
            __builder.AddAttribute(2, "class", "page-title marginBot30");
            __builder.AddAttribute(3, "style", "margin-bottom:30px");
#nullable restore
#line 7 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\UserEdit.razor"
__builder.AddContent(4, localizer["extendMembershipFor"]);

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, ": ");
#nullable restore
#line 7 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\UserEdit.razor"
__builder.AddContent(6, User.FirstName);

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, " ");
#nullable restore
#line 7 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\UserEdit.razor"
__builder.AddContent(8, User.LastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\UserEdit.razor"
                          User

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\UserEdit.razor"
                                                HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "OnInvalidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\UserEdit.razor"
                                                                                     HandleInvalidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group row");
                __builder2.OpenElement(17, "label");
                __builder2.AddAttribute(18, "for", "lastName");
                __builder2.AddAttribute(19, "class", "col-sm-3 bold");
                __builder2.AddAttribute(20, "style", "font-weight:bold");
#nullable restore
#line 10 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\UserEdit.razor"
__builder2.AddContent(21, localizer["id"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n                ");
                __builder2.OpenElement(23, "label");
                __builder2.AddAttribute(24, "for", "lastName");
                __builder2.AddAttribute(25, "class", "col-sm-3");
#nullable restore
#line 11 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\UserEdit.razor"
__builder2.AddContent(26, User.Id);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group row");
                __builder2.OpenElement(30, "label");
                __builder2.AddAttribute(31, "for", "firstName");
                __builder2.AddAttribute(32, "class", "col-sm-3 bold");
                __builder2.AddAttribute(33, "style", "font-weight:bold");
#nullable restore
#line 15 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\UserEdit.razor"
__builder2.AddContent(34, localizer["firstName"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                ");
                __builder2.OpenElement(36, "label");
                __builder2.AddAttribute(37, "for", "firstName");
                __builder2.AddAttribute(38, "class", "col-sm-3");
#nullable restore
#line 16 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\UserEdit.razor"
__builder2.AddContent(39, User.FirstName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n            ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group row");
                __builder2.OpenElement(43, "label");
                __builder2.AddAttribute(44, "for", "firstName");
                __builder2.AddAttribute(45, "class", "col-sm-3 bold");
                __builder2.AddAttribute(46, "style", "font-weight:bold");
#nullable restore
#line 20 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\UserEdit.razor"
__builder2.AddContent(47, localizer["LastName"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                ");
                __builder2.OpenElement(49, "label");
                __builder2.AddAttribute(50, "for", "firstName");
                __builder2.AddAttribute(51, "class", "col-sm-3");
#nullable restore
#line 21 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\UserEdit.razor"
__builder2.AddContent(52, User.LastName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n            ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "form-group row");
                __builder2.OpenElement(56, "label");
                __builder2.AddAttribute(57, "for", "selector");
                __builder2.AddAttribute(58, "class", "col-sm-4 bold");
                __builder2.AddAttribute(59, "style", "font-weight:bold");
#nullable restore
#line 25 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\UserEdit.razor"
__builder2.AddContent(60, localizer["numOfMonthsSelectorLabel"]);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(61, ":");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n                ");
                __Blazor.GymMenagmentApp.App.Pages.UserEdit.TypeInference.CreateInputSelect_0(__builder2, 63, 64, "selector", 65, "col-sm-3", 66, 
#nullable restore
#line 26 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\UserEdit.razor"
                                                                          SelectedNumberOfMonths

#line default
#line hidden
#nullable disable
                , 67, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SelectedNumberOfMonths = __value, SelectedNumberOfMonths)), 68, () => SelectedNumberOfMonths, 69, (__builder3) => {
                    __builder3.OpenElement(70, "option");
                    __builder3.AddAttribute(71, "selected");
                    __builder3.AddAttribute(72, "value", "0");
#nullable restore
#line 27 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\UserEdit.razor"
__builder3.AddContent(73, localizer["selectNumMonth"]);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(74, "\r\n                    ");
                    __builder3.AddMarkupContent(75, "<option value=\"1\">1</option>\r\n                    ");
                    __builder3.AddMarkupContent(76, "<option value=\"3\">3</option>\r\n                    ");
                    __builder3.AddMarkupContent(77, "<option value=\"6\">6</option>\r\n                    ");
                    __builder3.AddMarkupContent(78, "<option value=\"12\">12</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n            ");
                __builder2.OpenElement(80, "button");
                __builder2.AddAttribute(81, "typle", "submit");
                __builder2.AddAttribute(82, "class", "btn btn-primary");
#nullable restore
#line 34 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\UserEdit.razor"
__builder2.AddContent(83, localizer["extendMembershipBtn"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n            ");
                __builder2.OpenElement(85, "a");
                __builder2.AddAttribute(86, "class", "btn btn-danger table-btn");
                __builder2.AddAttribute(87, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\UserEdit.razor"
                                                           DeleteUser

#line default
#line hidden
#nullable disable
                ));
#nullable restore
#line 35 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\UserEdit.razor"
__builder2.AddContent(88, localizer["delete"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n            ");
                __builder2.OpenElement(90, "a");
                __builder2.AddAttribute(91, "class", "btn btn-outline-primary table-btn");
                __builder2.AddAttribute(92, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\UserEdit.razor"
                                                                    NavigateToOverview

#line default
#line hidden
#nullable disable
                ));
#nullable restore
#line 36 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\UserEdit.razor"
__builder2.AddContent(93, localizer["back"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\UserEdit.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(94, "div");
            __builder.AddAttribute(95, "class", "alert" + " " + (
#nullable restore
#line 42 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\UserEdit.razor"
                       StatusClass

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 42 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\UserEdit.razor"
__builder.AddContent(96, Msg);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 43 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\UserEdit.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<Resource> localizer { get; set; }
    }
}
namespace __Blazor.GymMenagmentApp.App.Pages.UserEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
