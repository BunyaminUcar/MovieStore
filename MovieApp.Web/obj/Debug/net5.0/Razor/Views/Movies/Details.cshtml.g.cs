#pragma checksum "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Movies\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "91fda3adea74ccaf834bad37724b43df708ca240dbc7dd2ac4e8dc1ac68c0a2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"91fda3adea74ccaf834bad37724b43df708ca240dbc7dd2ac4e8dc1ac68c0a2a", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"eacd6f4e8a324ccb74a1833cd021c2b5f6e4a2a69fd5c8032384fb68a828e891", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 107, "\"", 133, 2);
            WriteAttributeValue("", 113, "/img/", 113, 5, true);
#nullable restore
#line 6 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Movies\Details.cshtml"
WriteAttributeValue("", 118, Model.ImageURL, 118, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img\"/>\r\n        </div>\r\n        <div class=\"col-md-9\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 10 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Movies\Details.cshtml"
                                  Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 11 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Movies\Details.cshtml"
                                Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">");
#nullable restore
#line 12 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Movies\Details.cshtml"
                                Write(Model.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 13 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Movies\Details.cshtml"
                 if(Model.Players!=null)
                {
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>\r\n                        <ul>\r\n");
#nullable restore
#line 18 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Movies\Details.cshtml"
                             foreach (var item in Model.Players)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>");
#nullable restore
#line 20 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Movies\Details.cshtml"
                               Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 21 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Movies\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </p>\r\n");
#nullable restore
#line 24 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Movies\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
