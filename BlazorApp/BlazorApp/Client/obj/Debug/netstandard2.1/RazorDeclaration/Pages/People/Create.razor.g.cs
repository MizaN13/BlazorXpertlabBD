#pragma checksum "I:\XpertLab\XpertlabBlazor\BlazorApp\BlazorApp\Client\Pages\People\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4123d72617ac0dec4d4a42908fcfd6a5d67e4d4f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Client.Pages.People
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "I:\XpertLab\XpertlabBlazor\BlazorApp\BlazorApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "I:\XpertLab\XpertlabBlazor\BlazorApp\BlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "I:\XpertLab\XpertlabBlazor\BlazorApp\BlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "I:\XpertLab\XpertlabBlazor\BlazorApp\BlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "I:\XpertLab\XpertlabBlazor\BlazorApp\BlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "I:\XpertLab\XpertlabBlazor\BlazorApp\BlazorApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "I:\XpertLab\XpertlabBlazor\BlazorApp\BlazorApp\Client\_Imports.razor"
using BlazorApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "I:\XpertLab\XpertlabBlazor\BlazorApp\BlazorApp\Client\_Imports.razor"
using BlazorApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "I:\XpertLab\XpertlabBlazor\BlazorApp\BlazorApp\Client\_Imports.razor"
using BlazorApp.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "I:\XpertLab\XpertlabBlazor\BlazorApp\BlazorApp\Client\_Imports.razor"
using BlazorApp.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "I:\XpertLab\XpertlabBlazor\BlazorApp\BlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "I:\XpertLab\XpertlabBlazor\BlazorApp\BlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "I:\XpertLab\XpertlabBlazor\BlazorApp\BlazorApp\Client\Pages\People\Create.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/people/create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "I:\XpertLab\XpertlabBlazor\BlazorApp\BlazorApp\Client\Pages\People\Create.razor"
       
    Person person = new Person();

    async Task CreatePerson()
    {
        var httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri(navigationManager.BaseUri);

        var tokenResult = await AuthenticationService.RequestAccessToken();

        if (tokenResult.TryGetToken(out var token))
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token.Value}");
            await httpClient.PostJsonAsync("api/people", person);
            navigationManager.NavigateTo("people");

        }
        //await http.PostJsonAsync("api/people", person);
        //navigationManager.NavigateTo("people");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccessTokenProvider AuthenticationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
