#pragma checksum "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\User\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54273cf3621a1f868b7b53738095035b58c5852a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Dashboard), @"mvc.1.0.view", @"/Views/User/Dashboard.cshtml")]
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
#line 1 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\_ViewImports.cshtml"
using EnglishWords;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\_ViewImports.cshtml"
using EnglishWords.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54273cf3621a1f868b7b53738095035b58c5852a", @"/Views/User/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"270c224c2a2a74b75ea3eec73be48546b24539ef", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\User\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\" style=\"margin-top:100px;\">\r\n    <h1>Welcome , ");
#nullable restore
#line 7 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\User\Dashboard.cshtml"
             Write(ViewBag.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\User\Dashboard.cshtml"
 if(ViewBag.Role == "True")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a>Delete</a>\r\n    <a>Edit</a>\r\n");
#nullable restore
#line 14 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\User\Dashboard.cshtml"
    
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<a>Detail</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
