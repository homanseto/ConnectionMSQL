// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Project\ConnectionMSQL\BlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\ConnectionMSQL\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Project\ConnectionMSQL\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Project\ConnectionMSQL\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Project\ConnectionMSQL\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Project\ConnectionMSQL\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Project\ConnectionMSQL\BlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Project\ConnectionMSQL\BlazorServer\_Imports.razor"
using BlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Project\ConnectionMSQL\BlazorServer\_Imports.razor"
using BlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Project\ConnectionMSQL\BlazorServer\Pages\People.razor"
using dataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Project\ConnectionMSQL\BlazorServer\Pages\People.razor"
using BlazorServer.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Project\ConnectionMSQL\BlazorServer\Pages\People.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/people")]
    public partial class People : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "D:\Project\ConnectionMSQL\BlazorServer\Pages\People.razor"
       
        /*
        protected override async Task OnInitializedAsync()
            {
            forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }
    */
    List<PersonModel> people;

    private async Task InsertData()
    {
        string sql = "insert into people (fName, lName) values(@fName, @lName);";
        await _data.SaveData(sql, new { fName = "Billy", lName = "Bob" }, _config.GetConnectionString("default"));
    }

    protected override async Task OnInitializedAsync()
    {
        string sql = "select * from people";

        people = await _data.LoadData<PersonModel, dynamic>(sql, new { }, _config.GetConnectionString("default"));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
    }
}
#pragma warning restore 1591
