#pragma checksum "/Users/gunnarauger/Desktop/SP19/3610/AMIS3610/fisher-bookstore-mvc/Fisher.Bookstore/Views/Authors/Featured.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c74f896cb58e5d2b96cba7f2c71efeb164f5c269"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authors_Featured), @"mvc.1.0.view", @"/Views/Authors/Featured.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Authors/Featured.cshtml", typeof(AspNetCore.Views_Authors_Featured))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c74f896cb58e5d2b96cba7f2c71efeb164f5c269", @"/Views/Authors/Featured.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe85d33f817b92d8d7bea3effdbb5f304afb1296", @"/Views/_ViewImports.cshtml")]
    public class Views_Authors_Featured : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 37, true);
            WriteLiteral("\n<p>This month\'s featured author is​ ");
            EndContext();
            BeginContext(38, 11, false);
#line 2 "/Users/gunnarauger/Desktop/SP19/3610/AMIS3610/fisher-bookstore-mvc/Fisher.Bookstore/Views/Authors/Featured.cshtml"
                               Write(Model.Name​);

#line default
#line hidden
            EndContext();
            BeginContext(49, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591