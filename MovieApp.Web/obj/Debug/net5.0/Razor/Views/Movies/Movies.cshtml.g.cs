#pragma checksum "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Movies\Movies.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5537d0f832554db5ce811be06f5460fb8e58a19933991d126d7263ae584a555a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Movies), @"mvc.1.0.view", @"/Views/Movies/Movies.cshtml")]
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
#nullable restore
#line 2 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\_ViewImports.cshtml"
using MovieApp.Web.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"5537d0f832554db5ce811be06f5460fb8e58a19933991d126d7263ae584a555a", @"/Views/Movies/Movies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"eacd6f4e8a324ccb74a1833cd021c2b5f6e4a2a69fd5c8032384fb68a828e891", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movies_Movies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MoviesViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1>Movie List</h1>\r\n\r\n<div id=\"Filmler\">\r\n\r\n");
#nullable restore
#line 8 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Movies\Movies.cshtml"
     if (Model.Movies.Count() > 0)
    {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Movies\Movies.cshtml"
         foreach (var movie in Model.Movies)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Movies\Movies.cshtml"
       Write(await Html.PartialAsync("_movie", movie));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Movies\Movies.cshtml"
                                                     
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Movies\Movies.cshtml"
         

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning\">\r\n            Upss.. There is no Movie data here.\r\n\r\n        </div>\r\n");
#nullable restore
#line 23 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Movies\Movies.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</div>\r\n");
#nullable restore
#line 28 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Movies\Movies.cshtml"
 if (TempData["Message"] != null)
{
    

#line default
#line hidden
#nullable disable
            DefineSection("message", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 32 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Movies\Movies.cshtml"
Write(await Html.PartialAsync("_message", (string)TempData["Message"]));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
            }
            );
#nullable restore
#line 33 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Movies\Movies.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("menu", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("    ");
#nullable restore
#line 41 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Movies\Movies.cshtml"
Write(await Component.InvokeAsync("Genres"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MoviesViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
