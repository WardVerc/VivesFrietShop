#pragma checksum "D:\Vives\Projecten Rider - WebDev\Vives FrietShop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "303e7a2a8be18d0d65184b92281f6905b7928289"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Vives\Projecten Rider - WebDev\Vives FrietShop\Views\_ViewImports.cshtml"
using Vives_FrietShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Vives\Projecten Rider - WebDev\Vives FrietShop\Views\_ViewImports.cshtml"
using Vives_FrietShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Vives\Projecten Rider - WebDev\Vives FrietShop\Views\Home\Index.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"303e7a2a8be18d0d65184b92281f6905b7928289", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee7ef6e4bbc77e789547b8533d199736d04da1c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Vives_FrietShop.Models.ShopItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "D:\Vives\Projecten Rider - WebDev\Vives FrietShop\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    
    var culture = CultureInfo.CreateSpecificCulture("nl-BE");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welkom bij Vives FrietShop!</h1>\r\n</div>\r\n\r\n<div class=\"row mt-5 align-items-center text-center\">\r\n<div class=\"col\">\r\n    <h4>Maak jouw bestelling:</h4>\r\n    \r\n");
#nullable restore
#line 20 "D:\Vives\Projecten Rider - WebDev\Vives FrietShop\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <button type=\"submit\">");
#nullable restore
#line 22 "D:\Vives\Projecten Rider - WebDev\Vives FrietShop\Views\Home\Index.cshtml"
                         Write(item.Naam);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 22 "D:\Vives\Projecten Rider - WebDev\Vives FrietShop\Views\Home\Index.cshtml"
                                     Write(item.Prijs.ToString("C", culture));

#line default
#line hidden
#nullable disable
            WriteLiteral(") +</button>\r\n");
#nullable restore
#line 23 "D:\Vives\Projecten Rider - WebDev\Vives FrietShop\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n</div>\r\n\r\n<div class=\"col\">\r\n    <h4>Winkelmandje</h4>\r\n</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Vives_FrietShop.Models.ShopItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
