#pragma checksum "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Shared\Components\Genres\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "cdb77db8afc46bd5a4d75fddd15a5b31e1e4222e94c8937fad52f3a1d8e95426"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Genres_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Genres/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"cdb77db8afc46bd5a4d75fddd15a5b31e1e4222e94c8937fad52f3a1d8e95426", @"/Views/Shared/Components/Genres/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"89cd596eb89630bacd742f4649ad2d4287829f74d2fa44bb7d7f833b1252007d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Genres_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Genre>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"list-group\">\r\n    \r\n    <a href=\"/movies/list\"");
            BeginWriteAttribute("class", " class=\"", 80, "\"", 169, 3);
            WriteAttributeValue("", 88, "list-group-item", 88, 15, true);
            WriteAttributeValue(" ", 103, "list-group-item-action", 104, 23, true);
#nullable restore
#line 5 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Shared\Components\Genres\Default.cshtml"
WriteAttributeValue(" ", 126, ViewBag.SelectedGenre==null?"active":"", 127, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Tüm Filmler</a>\r\n\r\n\r\n");
#nullable restore
#line 8 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Shared\Components\Genres\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 243, "\"", 276, 2);
            WriteAttributeValue("", 250, "/movies/list/", 250, 13, true);
#nullable restore
#line 10 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Shared\Components\Genres\Default.cshtml"
WriteAttributeValue("", 263, item.GenreId, 263, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", "\r\n           class=\"", 277, "\"", 397, 3);
            WriteAttributeValue("", 297, "list-group-item", 297, 15, true);
            WriteAttributeValue(" ", 312, "list-group-item-action", 313, 23, true);
#nullable restore
#line 11 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Shared\Components\Genres\Default.cshtml"
WriteAttributeValue(" ", 335, ViewBag.SelectedGenre==item.GenreId.ToString()?"active":"", 336, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
#nullable restore
#line 12 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Shared\Components\Genres\Default.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </a>\r\n");
#nullable restore
#line 14 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Shared\Components\Genres\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
