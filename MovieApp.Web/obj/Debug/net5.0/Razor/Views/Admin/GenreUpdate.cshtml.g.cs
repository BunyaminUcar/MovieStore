#pragma checksum "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Admin\GenreUpdate.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "bcd6cbf50e6b9ad522276cdd655b85ef56df93902438d75dc68f5631f57c5dd6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GenreUpdate), @"mvc.1.0.view", @"/Views/Admin/GenreUpdate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"bcd6cbf50e6b9ad522276cdd655b85ef56df93902438d75dc68f5631f57c5dd6", @"/Views/Admin/GenreUpdate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"eacd6f4e8a324ccb74a1833cd021c2b5f6e4a2a69fd5c8032384fb68a828e891", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_GenreUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminGenreEditViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GenreUpdate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Edit Genres</h1>\r\n\r\n<hr />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcd6cbf50e6b9ad522276cdd655b85ef56df93902438d75dc68f5631f57c5dd66004", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            <input type=\"hidden\" name=\"GenreId\"");
                BeginWriteAttribute("value", " value=\"", 236, "\"", 258, 1);
#nullable restore
#line 8 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
WriteAttributeValue("", 244, Model.GenreId, 244, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n            <div class=\"mb-3\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcd6cbf50e6b9ad522276cdd655b85ef56df93902438d75dc68f5631f57c5dd66836", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 10 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bcd6cbf50e6b9ad522276cdd655b85ef56df93902438d75dc68f5631f57c5dd68369", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 11 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcd6cbf50e6b9ad522276cdd655b85ef56df93902438d75dc68f5631f57c5dd69983", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 12 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n        </div>\r\n        <div class=\"col-md-9\">\r\n");
#nullable restore
#line 17 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
             for (int i = 0; i < @Model.Movies.Count; i++)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 740, "\"", 765, 3);
                WriteAttributeValue("", 747, "Movies[", 747, 7, true);
#nullable restore
#line 19 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
WriteAttributeValue("", 754, i, 754, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 756, "].MovieId", 756, 9, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 766, "\"", 798, 1);
#nullable restore
#line 19 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
WriteAttributeValue("", 774, Model.Movies[i].MovieId, 774, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 840, "\"", 866, 3);
                WriteAttributeValue("", 847, "Movies[", 847, 7, true);
#nullable restore
#line 20 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
WriteAttributeValue("", 854, i, 854, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 856, "].ImageURL", 856, 10, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 867, "\"", 900, 1);
#nullable restore
#line 20 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
WriteAttributeValue("", 875, Model.Movies[i].ImageURL, 875, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 942, "\"", 965, 3);
                WriteAttributeValue("", 949, "Movies[", 949, 7, true);
#nullable restore
#line 21 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
WriteAttributeValue("", 956, i, 956, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 958, "].Title", 958, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 966, "\"", 996, 1);
#nullable restore
#line 21 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
WriteAttributeValue("", 974, Model.Movies[i].Title, 974, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 22 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            <table class=""table table-striped table-hover table-bordered"">

                <thead>
                <tr>
                    <th style=""width:100px"">Remove</th>
                    <th style=""width:30px"">#</th>
                    <th style=""width:100px"">Image</th>
                    <th>Title</th>
                    <th style=""width:160px""></th>
                </tr>
                </thead>
                <tbody>

");
#nullable restore
#line 37 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
                 foreach (var movie in Model.Movies)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n\r\n                        <td>\r\n                            <input class=\"form-check-input\" type=\"checkbox\" name=\"movieIds\"");
                BeginWriteAttribute("value", " value=\"", 1693, "\"", 1715, 1);
#nullable restore
#line 42 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
WriteAttributeValue("", 1701, movie.MovieId, 1701, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                        </td>\r\n\r\n                        <td>");
#nullable restore
#line 45 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
                       Write(movie.MovieId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bcd6cbf50e6b9ad522276cdd655b85ef56df93902438d75dc68f5631f57c5dd616670", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1840, "~/img/", 1840, 6, true);
#nullable restore
#line 46 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
AddHtmlAttributeValue("", 1846, movie.ImageURL, 1846, 15, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 47 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
                       Write(movie.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 1989, "\"", 2029, 2);
                WriteAttributeValue("", 1996, "/admin/movieupdate/", 1996, 19, true);
#nullable restore
#line 49 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
WriteAttributeValue("", 2015, movie.MovieId, 2015, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary btn-sm\">Update</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 52 "C:\Users\UCAR\source\repos\MovieApp.Web\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminGenreEditViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
