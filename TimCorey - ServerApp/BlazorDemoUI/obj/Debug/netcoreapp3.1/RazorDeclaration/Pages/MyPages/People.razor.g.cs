// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorDemoUI.Pages.MyPages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rafael_so\OneDrive - TSEA\Documents\02 - teste codes\03 - Blazor\TimCorey - ServerApp\BlazorDemoUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rafael_so\OneDrive - TSEA\Documents\02 - teste codes\03 - Blazor\TimCorey - ServerApp\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rafael_so\OneDrive - TSEA\Documents\02 - teste codes\03 - Blazor\TimCorey - ServerApp\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rafael_so\OneDrive - TSEA\Documents\02 - teste codes\03 - Blazor\TimCorey - ServerApp\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rafael_so\OneDrive - TSEA\Documents\02 - teste codes\03 - Blazor\TimCorey - ServerApp\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rafael_so\OneDrive - TSEA\Documents\02 - teste codes\03 - Blazor\TimCorey - ServerApp\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rafael_so\OneDrive - TSEA\Documents\02 - teste codes\03 - Blazor\TimCorey - ServerApp\BlazorDemoUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rafael_so\OneDrive - TSEA\Documents\02 - teste codes\03 - Blazor\TimCorey - ServerApp\BlazorDemoUI\_Imports.razor"
using BlazorDemoUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rafael_so\OneDrive - TSEA\Documents\02 - teste codes\03 - Blazor\TimCorey - ServerApp\BlazorDemoUI\_Imports.razor"
using BlazorDemoUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rafael_so\OneDrive - TSEA\Documents\02 - teste codes\03 - Blazor\TimCorey - ServerApp\BlazorDemoUI\Pages\MyPages\People.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rafael_so\OneDrive - TSEA\Documents\02 - teste codes\03 - Blazor\TimCorey - ServerApp\BlazorDemoUI\Pages\MyPages\People.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rafael_so\OneDrive - TSEA\Documents\02 - teste codes\03 - Blazor\TimCorey - ServerApp\BlazorDemoUI\Pages\MyPages\People.razor"
using BlazorDemoUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/Data/People")]
    public partial class People : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\rafael_so\OneDrive - TSEA\Documents\02 - teste codes\03 - Blazor\TimCorey - ServerApp\BlazorDemoUI\Pages\MyPages\People.razor"
       
    private List<PersonModel> people;
    private DisplayPersonModel newPerson = new DisplayPersonModel();

    protected override async Task OnInitializedAsync()
    {
        people = await _db.GetPeople();
    }

    private async Task InsertPerson()
    {
        PersonModel p = new PersonModel
        {
            FirstName = newPerson.FirstName,
            LastName = newPerson.LastName,
            EmailAddress = newPerson.EmailAddress
        };

        await _db.InsertPerson(p);

        people.Add(p);

        newPerson = new DisplayPersonModel();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPeopleData _db { get; set; }
    }
}
#pragma warning restore 1591
