#pragma checksum "C:\Users\Abdul\Desktop\Werk\Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "600712a27bdb08558bddd8d957b539d343bd48f9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
