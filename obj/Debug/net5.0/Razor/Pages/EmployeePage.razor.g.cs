#pragma checksum "D:\tugas\semester 5\Pemrograman Frontend\UTS\FrontEndUts\Pages\EmployeePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16ad3e846e09a37f63909bb13d3631bd43d0f90d"
// <auto-generated/>
#pragma warning disable 1591
namespace FrontEndUts.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\tugas\semester 5\Pemrograman Frontend\UTS\FrontEndUts\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\tugas\semester 5\Pemrograman Frontend\UTS\FrontEndUts\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\tugas\semester 5\Pemrograman Frontend\UTS\FrontEndUts\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\tugas\semester 5\Pemrograman Frontend\UTS\FrontEndUts\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\tugas\semester 5\Pemrograman Frontend\UTS\FrontEndUts\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\tugas\semester 5\Pemrograman Frontend\UTS\FrontEndUts\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\tugas\semester 5\Pemrograman Frontend\UTS\FrontEndUts\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\tugas\semester 5\Pemrograman Frontend\UTS\FrontEndUts\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\tugas\semester 5\Pemrograman Frontend\UTS\FrontEndUts\_Imports.razor"
using FrontEndUts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\tugas\semester 5\Pemrograman Frontend\UTS\FrontEndUts\_Imports.razor"
using FrontEndUts.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeepage")]
    public partial class EmployeePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Daftar Employee</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-striped");
            __builder.AddMarkupContent(3, "<thead><tr><th>Employee Id</th>\r\n            <th>Employee Fistname</th>\r\n            <th>Employee LastName</th>\r\n            <th></th></tr></thead>\r\n    ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 14 "D:\tugas\semester 5\Pemrograman Frontend\UTS\FrontEndUts\Pages\EmployeePage.razor"
         foreach (var empl in Employees)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 17 "D:\tugas\semester 5\Pemrograman Frontend\UTS\FrontEndUts\Pages\EmployeePage.razor"
                     empl.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n                ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 18 "D:\tugas\semester 5\Pemrograman Frontend\UTS\FrontEndUts\Pages\EmployeePage.razor"
                     empl.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 19 "D:\tugas\semester 5\Pemrograman Frontend\UTS\FrontEndUts\Pages\EmployeePage.razor"
                     empl.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "td");
            __builder.OpenElement(16, "a");
            __builder.AddAttribute(17, "href", 
#nullable restore
#line 20 "D:\tugas\semester 5\Pemrograman Frontend\UTS\FrontEndUts\Pages\EmployeePage.razor"
                               $" employeedetail/{empl.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "class", "btn btn-primary");
            __builder.AddContent(19, "detail");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "D:\tugas\semester 5\Pemrograman Frontend\UTS\FrontEndUts\Pages\EmployeePage.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591