#pragma checksum "C:\Users\Abdul\Desktop\Werk\Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8846f39c65fb0231d4f8e872524168994764c2b8"
// <auto-generated/>
#pragma warning disable 1591
namespace _01_Ej2.blazor_syncfusion.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Abdul\Desktop\Werk\Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\Abdul\Desktop\Werk\Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "C:\Users\Abdul\Desktop\Werk\Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "C:\Users\Abdul\Desktop\Werk\Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "C:\Users\Abdul\Desktop\Werk\Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "C:\Users\Abdul\Desktop\Werk\Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "C:\Users\Abdul\Desktop\Werk\Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "C:\Users\Abdul\Desktop\Werk\Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using _01_Ej2.blazor_syncfusion;

#line default
#line hidden
#line 9 "C:\Users\Abdul\Desktop\Werk\Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using _01_Ej2.blazor_syncfusion.Shared;

#line default
#line hidden
#line 10 "C:\Users\Abdul\Desktop\Werk\Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Syncfusion.EJ2.Blazor;

#line default
#line hidden
#line 11 "C:\Users\Abdul\Desktop\Werk\Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Syncfusion.EJ2.Blazor.Calendars;

#line default
#line hidden
#line 12 "C:\Users\Abdul\Desktop\Werk\Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Syncfusion.EJ2.Blazor.Inputs;

#line default
#line hidden
#line 13 "C:\Users\Abdul\Desktop\Werk\Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Syncfusion.EJ2.Blazor.Buttons;

#line default
#line hidden
#line 14 "C:\Users\Abdul\Desktop\Werk\Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Syncfusion.EJ2.Blazor.Notifications;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#line 5 "C:\Users\Abdul\Desktop\Werk\Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 6 "C:\Users\Abdul\Desktop\Werk\Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n<br>\r\n<hr>\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-xs-6 col-sm-6 col-lg-6 col-md-6");
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenComponent<Syncfusion.EJ2.Blazor.Inputs.EjsTextBox>(13);
            __builder.AddAttribute(14, "CssClass", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 11 "C:\Users\Abdul\Desktop\Werk\Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\Pages\Counter.razor"
                                               CssClass

#line default
#line hidden
            ));
            __builder.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 11 "C:\Users\Abdul\Desktop\Werk\Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\Pages\Counter.razor"
                              Text

#line default
#line hidden
            ));
            __builder.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Text = __value, Text))));
            __builder.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Text));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenComponent<Syncfusion.EJ2.Blazor.Buttons.EjsButton>(20);
            __builder.AddAttribute(21, "IsPrimary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 13 "C:\Users\Abdul\Desktop\Werk\Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\Pages\Counter.razor"
                          true

#line default
#line hidden
            ));
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 13 "C:\Users\Abdul\Desktop\Werk\Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\Pages\Counter.razor"
                                          Opslaan

#line default
#line hidden
            ));
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(24, "Opslaan Je Naam");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n\r\n    ");
            __builder.OpenComponent<Syncfusion.EJ2.Blazor.Notifications.EjsToast>(26);
            __builder.AddAttribute(27, "ID", "toast_type");
            __builder.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.EJ2.Blazor.Notifications.ToastPosition>(30);
                __builder2.AddAttribute(31, "X", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 16 "C:\Users\Abdul\Desktop\Werk\Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\Pages\Counter.razor"
                           ToastPosition

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n    ");
            }
            ));
            __builder.AddComponentReferenceCapture(33, (__value) => {
#line 15 "C:\Users\Abdul\Desktop\Werk\Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\Pages\Counter.razor"
                    ToastObj = (Syncfusion.EJ2.Blazor.Notifications.EjsToast)__value;

#line default
#line hidden
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 19 "C:\Users\Abdul\Desktop\Werk\Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\Pages\Counter.razor"
           
        int currentCount = 0;
        string Text { get; set; }
        string CssClass = "e-outline e-small";
        private string ToastPosition = "Right";
        EjsToast ToastObj;
        List<ToastModel> Toast = new List<ToastModel>
{
        new ToastModel{ Title = "Success!", Content="Your name has been save successfully.", CssClass="e-toast-success", Icon="e-success toast-icons" },
    };

        void IncrementCount()
        {
            currentCount++;
        }

        private void SuccessBtnOnClick()
        {
            this.ToastObj.Show(Toast[0]);
        }


        void Opslaan()
        {
            if (Text != "Arno")
            {
                CssClass = "e-error e-small";
                Text = "Ongeldig Naam";
            }
            else
            {
                CssClass = "e-success e-small";
                SuccessBtnOnClick();
            }
        }
    

#line default
#line hidden
    }
}
#pragma warning restore 1591
