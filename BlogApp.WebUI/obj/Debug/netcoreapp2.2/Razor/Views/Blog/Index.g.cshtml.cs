#pragma checksum "C:\Users\Salih\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6eca8480db9ae9553120ae8afc1751e13dd6f831"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Index.cshtml", typeof(AspNetCore.Views_Blog_Index))]
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
#line 1 "C:\Users\Salih\source\repos\BlogApp\BlogApp.WebUI\Views\_ViewImports.cshtml"
using BlogApp.WebUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6eca8480db9ae9553120ae8afc1751e13dd6f831", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84ec72186d8cccc0b883e2af25d647e1e0b1f73c", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BlogApp.Entity.Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Salih\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(82, 97, true);
            WriteLiteral("<div class=\"container mt-3\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            ");
            EndContext();
            BeginContext(180, 43, false);
#line 8 "C:\Users\Salih\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\Index.cshtml"
       Write(await Component.InvokeAsync("CategoryMenu"));

#line default
#line hidden
            EndContext();
            BeginContext(223, 62, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-9\">\r\n            ");
            EndContext();
            BeginContext(286, 32, false);
#line 11 "C:\Users\Salih\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\Index.cshtml"
       Write(Html.Partial("_BlogList", Model));

#line default
#line hidden
            EndContext();
            BeginContext(318, 39, true);
            WriteLiteral(";\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BlogApp.Entity.Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591