#pragma checksum "C:\Users\dashakrashenko\source\repos\FilmsCollectionApp\FilmsCollectionApp\Views\Films\FilmsByGenre.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49ad3275e4907aaaefb06420019fba8f909bffac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Films_FilmsByGenre), @"mvc.1.0.view", @"/Views/Films/FilmsByGenre.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Films/FilmsByGenre.cshtml", typeof(AspNetCore.Views_Films_FilmsByGenre))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49ad3275e4907aaaefb06420019fba8f909bffac", @"/Views/Films/FilmsByGenre.cshtml")]
    public class Views_Films_FilmsByGenre : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\dashakrashenko\source\repos\FilmsCollectionApp\FilmsCollectionApp\Views\Films\FilmsByGenre.cshtml"
  
    ViewData["Title"] = "GetFilmsByGenre";

#line default
#line hidden
            BeginContext(53, 44, true);
            WriteLiteral("\r\n<h2>FilmsByGenre</h2>\r\n\r\n<div>\r\n    <ol>\r\n");
            EndContext();
#line 10 "C:\Users\dashakrashenko\source\repos\FilmsCollectionApp\FilmsCollectionApp\Views\Films\FilmsByGenre.cshtml"
         foreach (var el in ViewBag.FilmsbyGenre)
        {

#line default
#line hidden
            BeginContext(159, 16, true);
            WriteLiteral("            <li>");
            EndContext();
            BeginContext(176, 11, false);
#line 12 "C:\Users\dashakrashenko\source\repos\FilmsCollectionApp\FilmsCollectionApp\Views\Films\FilmsByGenre.cshtml"
           Write(el.Filmname);

#line default
#line hidden
            EndContext();
            BeginContext(187, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
            BeginContext(196, 50, true);
            WriteLiteral("            <div>\r\n                <p>Imdb Score: ");
            EndContext();
            BeginContext(247, 12, false);
#line 15 "C:\Users\dashakrashenko\source\repos\FilmsCollectionApp\FilmsCollectionApp\Views\Films\FilmsByGenre.cshtml"
                          Write(el.ImdbScore);

#line default
#line hidden
            EndContext();
            BeginContext(259, 39, true);
            WriteLiteral("</p>\r\n                <p>Release date: ");
            EndContext();
            BeginContext(299, 14, false);
#line 16 "C:\Users\dashakrashenko\source\repos\FilmsCollectionApp\FilmsCollectionApp\Views\Films\FilmsByGenre.cshtml"
                            Write(el.Releasedate);

#line default
#line hidden
            EndContext();
            BeginContext(313, 26, true);
            WriteLiteral("</p>\r\n            </div>\r\n");
            EndContext();
#line 18 "C:\Users\dashakrashenko\source\repos\FilmsCollectionApp\FilmsCollectionApp\Views\Films\FilmsByGenre.cshtml"
        }

#line default
#line hidden
            BeginContext(350, 17, true);
            WriteLiteral("    </ol>\r\n</div>");
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
