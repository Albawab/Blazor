#pragma checksum "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\Pages\In-place Editer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6e1518dc4cd85dc43ce4a567c883d36ba40764d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HenE_Ej2.blazor_syncfusion.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\_Imports.razor"
using HenE_Ej2.blazor_syncfusion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\_Imports.razor"
using HenE_Ej2.blazor_syncfusion.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\_Imports.razor"
using Syncfusion.EJ2.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\_Imports.razor"
using Syncfusion.EJ2.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\Pages\In-place Editer.razor"
using Syncfusion.EJ2.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\Pages\In-place Editer.razor"
using Syncfusion.EJ2.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\Pages\In-place Editer.razor"
using Syncfusion.EJ2.Blazor.InPlaceEditor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/update")]
    public partial class In_place_Editer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\Pages\In-place Editer.razor"
      
    private RenderMode Mode = RenderMode.Inline;
    private string TitleValue = "Succinctly E-Book about TypeScript";
       private object TitleData = new { placeholder = "Enter your question title" };
    private object TipModel = new { width = "50%" };
    private object TipModel2 = new { width = "auto" };
    private object TipModel3 = new { width = "30%" };
      private string[] TagValue = new string[] { "TypeScript", "JavaScript" };
        private static string[] Validation1 = new string[] { "true", "Enter valid title" };
    private static string[] Validation2 = new string[] { "true", "Enter valid comments" };
    private static string[] Validation3 = new string[] { "true", "Enter valid tags" };
        private static string[] Data = new string[] { "Android", "JavaScript", "jQuery", "TypeScript", "Angular", "React", "Vue", "Ionic" };
     private string CommentValue = "The extensive adoption of JavaScript for application development, and the ability to use HTML and JavaScript to create Windows Store apps, has made JavaScript a vital part of the Windows development ecosystem. Microsoft has done extensive work to make JavaScript easier to use.";
      private static string[] RteItems = new string[] { "Bold", "Italic", "Underline", "FontColor", "BackgroundColor", "LowerCase", "UpperCase", "|", "OrderedList", "UnorderedList" };

        private object CommentData = new
    {
        toolbarSettings = new
        {
            enableFloating = false,
            items = RteItems
        }
    };

        private object CommentValidation = new { RTE = new { required = Validation2 } };

      private object TitleValidation = new { Title = new { required = Validation1 } };
        private object TagValidation = new { Tag = new { required = Validation3 } };

        private object TagData = new
    {
        mode = "Box",
        placeholder = "Enter your tags",
        dataSource = Data
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
