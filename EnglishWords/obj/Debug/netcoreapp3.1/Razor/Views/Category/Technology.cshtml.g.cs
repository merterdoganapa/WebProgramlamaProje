#pragma checksum "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Technology.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "322faac2ee8cdbf32e3572a93be7a6ff8301935a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Technology), @"mvc.1.0.view", @"/Views/Category/Technology.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"322faac2ee8cdbf32e3572a93be7a6ff8301935a", @"/Views/Category/Technology.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"270c224c2a2a74b75ea3eec73be48546b24539ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Technology : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/trash.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/arrow.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Technology.cshtml"
  
    ViewData["Title"] = "Technology";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"" style=""margin-top: 175px;"">
    <h2 class=""page-section-heading text-center text-uppercase text-secondary mb-0"">HOME</h2>
    <!-- Icon Divider-->
    <div class=""divider-custom"">
        <div class=""divider-custom-line""></div>
        <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
        <div class=""divider-custom-line""></div>
    </div>
    <div class=""divider-custom"">
        <div class=""divider-custom-icon""><a href=""/word/addWord/home"" class=""btn btn-primary btn-xl"">Kelime Ekle</a></div>
    </div>
    <table class=""table text-center"" style=""margin-bottom:100px;"">
        <thead style=""background:#1abc9c;"">
            <tr>
                <th scope=""col"">Kelime</th>
                <th scope=""col"">Karşılığı</th>
                <th scope=""col"">Ekleyen</th>
                <th scope=""col""></th>

            </tr>
        </thead>
        <tbody>

");
#nullable restore
#line 29 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Technology.cshtml"
             foreach (var item in @ViewBag.WordList)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\"><a>");
#nullable restore
#line 32 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Technology.cshtml"
                                  Write(item.word_en);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></th>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Technology.cshtml"
                   Write(item.word_tr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 34 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Technology.cshtml"
                     foreach (var user in ViewBag.UserList)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Technology.cshtml"
                         if (user.Id == item.UserId)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 38 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Technology.cshtml"
                           Write(user.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 39 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Technology.cshtml"
                            break;
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Technology.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Technology.cshtml"
                     if (ViewBag.Role == "True")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1615, "\"", 1622, 0);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "322faac2ee8cdbf32e3572a93be7a6ff8301935a8044", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1697, "\"", 1704, 0);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "322faac2ee8cdbf32e3572a93be7a6ff8301935a9333", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                        </td>\r\n");
#nullable restore
#line 48 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Technology.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 50 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Technology.cshtml"


            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 56 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Technology.cshtml"
     if (ViewBag.WordList == null)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger text-center\" style=\"margin-top:100px;\">Henüz Kelime Eklemediniz</div>\r\n");
#nullable restore
#line 60 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Technology.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>");
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
