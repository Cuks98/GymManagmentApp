#pragma checksum "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\TrainerEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a510312d7012882ee19ebd576bbcc7aa3d29954b"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/traineredit/{TrainerID}")]
    public partial class TrainerEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\TrainerEdit.razor"
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
#line 7 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\TrainerEdit.razor"
__builder.AddContent(4, localizer["edit"]);

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, ": ");
#nullable restore
#line 7 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\TrainerEdit.razor"
__builder.AddContent(6, Trainer.FirstName);

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, " ");
#nullable restore
#line 7 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\TrainerEdit.razor"
__builder.AddContent(8, Trainer.LastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\TrainerEdit.razor"
                          Trainer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\TrainerEdit.razor"
                                                   HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "OnInvalidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\TrainerEdit.razor"
                                                                                        HandleInvalidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group row");
                __builder2.OpenElement(17, "label");
                __builder2.AddAttribute(18, "for", "id");
                __builder2.AddAttribute(19, "class", "col-sm-4 bold");
                __builder2.AddAttribute(20, "style", "font-weight:bold");
#nullable restore
#line 10 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\TrainerEdit.razor"
__builder2.AddContent(21, localizer["id"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n                ");
                __builder2.OpenElement(23, "label");
                __builder2.AddAttribute(24, "class", "col-sm-3");
#nullable restore
#line 11 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\TrainerEdit.razor"
__builder2.AddContent(25, Trainer.Id);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n            ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group row");
                __builder2.OpenElement(29, "label");
                __builder2.AddAttribute(30, "for", "firstName");
                __builder2.AddAttribute(31, "class", "col-sm-4 bold");
                __builder2.AddAttribute(32, "style", "font-weight:bold");
#nullable restore
#line 16 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\TrainerEdit.razor"
__builder2.AddContent(33, localizer["firstName"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(35);
                __builder2.AddAttribute(36, "id", "firstName");
                __builder2.AddAttribute(37, "name", "firstName");
                __builder2.AddAttribute(38, "class", "form-control col-sm-3");
                __builder2.AddAttribute(39, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\TrainerEdit.razor"
                                                                                                       Trainer.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Trainer.FirstName = __value, Trainer.FirstName))));
                __builder2.AddAttribute(41, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Trainer.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group row");
                __builder2.OpenElement(45, "label");
                __builder2.AddAttribute(46, "for", "lastName");
                __builder2.AddAttribute(47, "class", "col-sm-4 bold");
                __builder2.AddAttribute(48, "style", "font-weight:bold");
#nullable restore
#line 22 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\TrainerEdit.razor"
__builder2.AddContent(49, localizer["lastName"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(51);
                __builder2.AddAttribute(52, "id", "lastName");
                __builder2.AddAttribute(53, "name", "lastName");
                __builder2.AddAttribute(54, "class", "form-control col-sm-3");
                __builder2.AddAttribute(55, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\TrainerEdit.razor"
                                                                                                     Trainer.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Trainer.LastName = __value, Trainer.LastName))));
                __builder2.AddAttribute(57, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Trainer.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n            ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "form-group row");
                __builder2.OpenElement(61, "label");
                __builder2.AddAttribute(62, "for", "selector");
                __builder2.AddAttribute(63, "class", "col-sm-4 bold");
                __builder2.AddAttribute(64, "style", "font-weight:bold");
#nullable restore
#line 28 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\TrainerEdit.razor"
__builder2.AddContent(65, localizer["speciality"]);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(66, ":");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                ");
                __Blazor.GymMenagmentApp.App.Pages.TrainerEdit.TypeInference.CreateInputSelect_0(__builder2, 68, 69, "selector", 70, "col-sm-3", 71, 
#nullable restore
#line 29 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\TrainerEdit.razor"
                                                                          SelectedSpeciality

#line default
#line hidden
#nullable disable
                , 72, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SelectedSpeciality = __value, SelectedSpeciality)), 73, () => SelectedSpeciality, 74, (__builder3) => {
                    __builder3.OpenElement(75, "option");
                    __builder3.AddAttribute(76, "selected");
                    __builder3.AddAttribute(77, "value", "0");
#nullable restore
#line 30 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\TrainerEdit.razor"
__builder3.AddContent(78, localizer[initialSpeciality]);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(79, "\r\n                    ");
                    __builder3.OpenElement(80, "option");
                    __builder3.AddAttribute(81, "value", "1");
#nullable restore
#line 31 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\TrainerEdit.razor"
__builder3.AddContent(82, localizer["condition"]);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(83, "\r\n                    ");
                    __builder3.OpenElement(84, "option");
                    __builder3.AddAttribute(85, "value", "2");
#nullable restore
#line 32 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\TrainerEdit.razor"
__builder3.AddContent(86, localizer["weightLos"]);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(87, "\r\n                    ");
                    __builder3.OpenElement(88, "option");
                    __builder3.AddAttribute(89, "value", "3");
#nullable restore
#line 33 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\TrainerEdit.razor"
__builder3.AddContent(90, localizer["muscleBuilding"]);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n            ");
                __builder2.OpenElement(92, "button");
                __builder2.AddAttribute(93, "typle", "submit");
                __builder2.AddAttribute(94, "class", "btn btn-primary");
#nullable restore
#line 36 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\TrainerEdit.razor"
__builder2.AddContent(95, localizer["extendMembershipBtn"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n            ");
                __builder2.OpenElement(97, "a");
                __builder2.AddAttribute(98, "class", "btn btn-danger table-btn");
                __builder2.AddAttribute(99, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\TrainerEdit.razor"
                                                           DeleteUser

#line default
#line hidden
#nullable disable
                ));
#nullable restore
#line 37 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\TrainerEdit.razor"
__builder2.AddContent(100, localizer["delete"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n            ");
                __builder2.OpenElement(102, "a");
                __builder2.AddAttribute(103, "class", "btn btn-outline-primary table-btn");
                __builder2.AddAttribute(104, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\TrainerEdit.razor"
                                                                    NavigateToOverview

#line default
#line hidden
#nullable disable
                ));
#nullable restore
#line 38 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\TrainerEdit.razor"
__builder2.AddContent(105, localizer["back"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\TrainerEdit.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "alert" + " " + (
#nullable restore
#line 44 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\TrainerEdit.razor"
                       StatusClass

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 44 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\TrainerEdit.razor"
__builder.AddContent(108, Msg);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\filip.curin\source\repos\GymMenagmentApp.App\GymMenagmentApp.App\Pages\TrainerEdit.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<Resource> localizer { get; set; }
    }
}
namespace __Blazor.GymMenagmentApp.App.Pages.TrainerEdit
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