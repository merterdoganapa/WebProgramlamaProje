#pragma checksum "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Food.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5217b9408367ce35f23a20cd7681f8d0e8b41788"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Food), @"mvc.1.0.view", @"/Views/Category/Food.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Food.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5217b9408367ce35f23a20cd7681f8d0e8b41788", @"/Views/Category/Food.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"270c224c2a2a74b75ea3eec73be48546b24539ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Food : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#nullable restore
#line 2 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Food.cshtml"
  
    ViewData["Title"] = "Food";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"" style=""margin-top: 175px;"">
    <h2 class=""page-section-heading text-center text-uppercase text-secondary mb-0"">FOOD</h2>
    <!-- Icon Divider-->
    <div class=""divider-custom"">
        <div class=""divider-custom-line""></div>
        <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
        <div class=""divider-custom-line""></div>
    </div>
");
#nullable restore
#line 14 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Food.cshtml"
     if (Context.Session.GetString("Username") != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"divider-custom\">\r\n            <div class=\"divider-custom-icon\"><a href=\"/Word/AddWord/2\" class=\"btn btn-primary btn-xl\">Kelime Ekle</a></div>\r\n        </div>\r\n");
#nullable restore
#line 19 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Food.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Food.cshtml"
     if (@ViewBag.WordList.Count != 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table text-center"" style=""margin-bottom:100px;"">
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
#line 34 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Food.cshtml"
                 foreach (var item in @ViewBag.WordList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\"><a>");
#nullable restore
#line 37 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Food.cshtml"
                                      Write(item.word_en);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></th>\r\n                        <td>");
#nullable restore
#line 38 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Food.cshtml"
                       Write(item.word_tr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 39 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Food.cshtml"
                         foreach (var user in ViewBag.UserList)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Food.cshtml"
                             if (user.Id == item.UserId)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>");
#nullable restore
#line 43 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Food.cshtml"
                               Write(user.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 44 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Food.cshtml"
                                break;
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Food.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Food.cshtml"
                         if (ViewBag.Role == "True")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1877, "\"", 1909, 2);
            WriteAttributeValue("", 1884, "/Word/DeleteWord/", 1884, 17, true);
#nullable restore
#line 50 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Food.cshtml"
WriteAttributeValue("", 1901, item.Id, 1901, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5217b9408367ce35f23a20cd7681f8d0e8b417889218", async() => {
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
            WriteLiteral("</a>\r\n                                <a href=\"/word/update/\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5217b9408367ce35f23a20cd7681f8d0e8b4178810394", async() => {
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
            WriteLiteral("</a>\r\n                            </td>\r\n");
#nullable restore
#line 53 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Food.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 55 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Food.cshtml"


                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 61 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Food.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-danger text-center\" style=\"margin-top:100px;\">Bu kategoriye henüz kelime eklenmedi.</div>\r\n");
#nullable restore
#line 65 "C:\Users\Mert_\source\repos\EnglishWords\EnglishWords\Views\Category\Food.cshtml"
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
