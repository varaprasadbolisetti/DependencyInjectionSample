#pragma checksum "C:\Users\Varaprasad Bolisetti\source\repos\Employeemvc1\Employeemvc1\Views\Home\User.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd64c79712197eec7095e454c05c5abf72216750"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_User), @"mvc.1.0.view", @"/Views/Home/User.cshtml")]
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
#line 1 "C:\Users\Varaprasad Bolisetti\source\repos\Employeemvc1\Employeemvc1\Views\_ViewImports.cshtml"
using Employeemvc1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Varaprasad Bolisetti\source\repos\Employeemvc1\Employeemvc1\Views\_ViewImports.cshtml"
using Employeemvc1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd64c79712197eec7095e454c05c5abf72216750", @"/Views/Home/User.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e19420d7d413eb2d9f400e48032787c6a2baa18", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_User : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-3"">
            <table>
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>salary</th>
                    <th>adds</th>
                </tr>
");
#nullable restore
#line 30 "C:\Users\Varaprasad Bolisetti\source\repos\Employeemvc1\Employeemvc1\Views\Home\User.cshtml"
                 foreach (Employee employee in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 33 "C:\Users\Varaprasad Bolisetti\source\repos\Employeemvc1\Employeemvc1\Views\Home\User.cshtml"
                       Write(employee.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\Varaprasad Bolisetti\source\repos\Employeemvc1\Employeemvc1\Views\Home\User.cshtml"
                       Write(employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 35 "C:\Users\Varaprasad Bolisetti\source\repos\Employeemvc1\Employeemvc1\Views\Home\User.cshtml"
                       Write(employee.salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "C:\Users\Varaprasad Bolisetti\source\repos\Employeemvc1\Employeemvc1\Views\Home\User.cshtml"
                       Write(employee.adds);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 38 "C:\Users\Varaprasad Bolisetti\source\repos\Employeemvc1\Employeemvc1\Views\Home\User.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
