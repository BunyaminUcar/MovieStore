#pragma checksum "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Home\About.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f7f389becbd08db8ebc18566312971e92305d3ebaa5cadacdc84372ad2cab3f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\_ViewImports.cshtml"
using MovieApp.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f7f389becbd08db8ebc18566312971e92305d3ebaa5cadacdc84372ad2cab3f1", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"122694bc5f38fcdc3216ffd75f1689e1a9b34b2542e47ddcf319cca7739b5ece", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Genre>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("        Home/About\r\n\r\n\r\n");
            DefineSection("menu", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("    ");
#nullable restore
#line 8 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Home\About.cshtml"
Write(await Component.InvokeAsync("Genres"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Genre>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
