#pragma checksum "D:\tugas\semester 5\Pemrograman Frontend\tugas_7\FrontEndUts\Pages\DetailDepartment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5eb129818d6165c8200c19a11487ad275e38290"
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
#line 1 "D:\tugas\semester 5\Pemrograman Frontend\tugas_7\FrontEndUts\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\tugas\semester 5\Pemrograman Frontend\tugas_7\FrontEndUts\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\tugas\semester 5\Pemrograman Frontend\tugas_7\FrontEndUts\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\tugas\semester 5\Pemrograman Frontend\tugas_7\FrontEndUts\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\tugas\semester 5\Pemrograman Frontend\tugas_7\FrontEndUts\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\tugas\semester 5\Pemrograman Frontend\tugas_7\FrontEndUts\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\tugas\semester 5\Pemrograman Frontend\tugas_7\FrontEndUts\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\tugas\semester 5\Pemrograman Frontend\tugas_7\FrontEndUts\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\tugas\semester 5\Pemrograman Frontend\tugas_7\FrontEndUts\_Imports.razor"
using FrontEndUts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\tugas\semester 5\Pemrograman Frontend\tugas_7\FrontEndUts\_Imports.razor"
using FrontEndUts.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/departmentdetail/{id}")]
    public partial class DetailDepartment : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<a href=\"/departmentpage\" class=\"h4\">Employee</a>\r\n");
            __builder.AddMarkupContent(1, "<a class=\"active h4\">></a>\r\n");
            __builder.AddMarkupContent(2, "<a href=\"/departmentdetail/{id}\" class=\"active h4\">Detail Employee</a><br><br>\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "text-center");
            __builder.AddMarkupContent(5, "<h3>Detail Department</h3>\r\n");
            __builder.OpenElement(6, "p");
            __builder.AddMarkupContent(7, "Id &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp: ");
            __builder.AddContent(8, 
#nullable restore
#line 7 "D:\tugas\semester 5\Pemrograman Frontend\tugas_7\FrontEndUts\Pages\DetailDepartment.razor"
                                       Department.DepartmentId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "p");
            __builder.AddContent(11, "Name : ");
            __builder.AddContent(12, 
#nullable restore
#line 8 "D:\tugas\semester 5\Pemrograman Frontend\tugas_7\FrontEndUts\Pages\DetailDepartment.razor"
           Department.DepartmentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
