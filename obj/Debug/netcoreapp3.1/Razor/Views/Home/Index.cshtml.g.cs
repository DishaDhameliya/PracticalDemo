#pragma checksum "D:\DemoProjects\PracticleDemoApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0a1798ad5256cc82bcca73b8cf2ecfce3f75eed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\DemoProjects\PracticleDemoApp\Views\_ViewImports.cshtml"
using PracticleDemoApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DemoProjects\PracticleDemoApp\Views\_ViewImports.cshtml"
using PracticleDemoApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0a1798ad5256cc82bcca73b8cf2ecfce3f75eed", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43f6c552f82ca83a15046f1bf76ed6eb381c9509", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PracticleDemoApp.Models.Bee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\DemoProjects\PracticleDemoApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Index</h1>


<table class=""table"">
    <thead>
        <tr>
            <th>
               Name
            </th>
            <th>
                Health
            </th>
            <th>
                Status
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 26 "D:\DemoProjects\PracticleDemoApp\Views\Home\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 29 "D:\DemoProjects\PracticleDemoApp\Views\Home\Index.cshtml"
           Write(Html.HiddenFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 30 "D:\DemoProjects\PracticleDemoApp\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "D:\DemoProjects\PracticleDemoApp\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.health));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>%</span>\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 36 "D:\DemoProjects\PracticleDemoApp\Views\Home\Index.cshtml"
                 if (@item.isDead)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Dead</p>\r\n");
#nullable restore
#line 39 "D:\DemoProjects\PracticleDemoApp\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Alive</p>\r\n");
#nullable restore
#line 43 "D:\DemoProjects\PracticleDemoApp\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
            WriteLiteral("                ");
#nullable restore
#line 47 "D:\DemoProjects\PracticleDemoApp\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Damage","Index", new { id = item.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 50 "D:\DemoProjects\PracticleDemoApp\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<script>
    //$(document).ready(function(){
    //    $(""[name='btnDamage']"").click(function (e) {
    //        debugger
    //        var id = $(e.target)[0].id
    //        $.ajax({
    //            type: ""get"",
    //            url: ""https://localhost:44331/Home/Index?id=""+id,
    //            success: function () {

    //            },
    //            error: function () {

    //            }
    //        })
    //    })
    //});
</script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PracticleDemoApp.Models.Bee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
