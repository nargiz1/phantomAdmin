#pragma checksum "C:\Users\user\Desktop\Code\hw\asp.net\phantom\phantom\Views\Projects\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d0bf2a43e571dec01075a986f44dd12cff7b777"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Index), @"mvc.1.0.view", @"/Views/Projects/Index.cshtml")]
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
#line 1 "C:\Users\user\Desktop\Code\hw\asp.net\phantom\phantom\Views\_ViewImports.cshtml"
using phantom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\Code\hw\asp.net\phantom\phantom\Views\_ViewImports.cshtml"
using phantom.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d0bf2a43e571dec01075a986f44dd12cff7b777", @"/Views/Projects/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a91a41d4fcadc11c171fb686c79434d54133a01", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div id=\"main\">\r\n    <div class=\"inner\">\r\n        <h1>");
#nullable restore
#line 4 "C:\Users\user\Desktop\Code\hw\asp.net\phantom\phantom\Views\Projects\Index.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n        <span class=\"image main\"><img");
            BeginWriteAttribute("src", " src=\"", 127, "\"", 145, 1);
#nullable restore
#line 5 "C:\Users\user\Desktop\Code\hw\asp.net\phantom\phantom\Views\Projects\Index.cshtml"
WriteAttributeValue("", 133, Model.Image, 133, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 146, "\"", 152, 0);
            EndWriteAttribute();
            WriteLiteral(" /></span>\r\n        <span class=\"image main\"><img");
            BeginWriteAttribute("src", " src=\"", 202, "\"", 208, 0);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 209, "\"", 215, 0);
            EndWriteAttribute();
            WriteLiteral(" /></span>\r\n        <p>");
#nullable restore
#line 7 "C:\Users\user\Desktop\Code\hw\asp.net\phantom\phantom\Views\Projects\Index.cshtml"
      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project> Html { get; private set; }
    }
}
#pragma warning restore 1591
