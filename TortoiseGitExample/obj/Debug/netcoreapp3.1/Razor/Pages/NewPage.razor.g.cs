#pragma checksum "C:\Users\ORISON\source\repos\TortoiseGitExample\TortoiseGitExample\Pages\NewPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99fd906e77ac54bbec13f1f72672c57d86f57601"
// <auto-generated/>
#pragma warning disable 1591
namespace TortoiseGitExample.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ORISON\source\repos\TortoiseGitExample\TortoiseGitExample\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ORISON\source\repos\TortoiseGitExample\TortoiseGitExample\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ORISON\source\repos\TortoiseGitExample\TortoiseGitExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ORISON\source\repos\TortoiseGitExample\TortoiseGitExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ORISON\source\repos\TortoiseGitExample\TortoiseGitExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ORISON\source\repos\TortoiseGitExample\TortoiseGitExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ORISON\source\repos\TortoiseGitExample\TortoiseGitExample\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ORISON\source\repos\TortoiseGitExample\TortoiseGitExample\_Imports.razor"
using TortoiseGitExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ORISON\source\repos\TortoiseGitExample\TortoiseGitExample\_Imports.razor"
using TortoiseGitExample.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Num")]
    public partial class NewPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Number</h1>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "The counter value is ");
            __builder.AddContent(3, 
#nullable restore
#line 3 "C:\Users\ORISON\source\repos\TortoiseGitExample\TortoiseGitExample\Pages\NewPage.razor"
                         Number

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "C:\Users\ORISON\source\repos\TortoiseGitExample\TortoiseGitExample\Pages\NewPage.razor"
       
     private int Number = 42;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
