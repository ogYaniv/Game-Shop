#pragma checksum "C:\Users\Owner\Source\Repos\ogYaniv\Game-Shop\GameShop\GameShop\Views\Products\GamePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "283d867ff82a9964f9a0989ca2dadbd5fa7069b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_GamePage), @"mvc.1.0.view", @"/Views/Products/GamePage.cshtml")]
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
#line 1 "C:\Users\Owner\Source\Repos\ogYaniv\Game-Shop\GameShop\GameShop\Views\_ViewImports.cshtml"
using GameShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Owner\Source\Repos\ogYaniv\Game-Shop\GameShop\GameShop\Views\_ViewImports.cshtml"
using GameShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"283d867ff82a9964f9a0989ca2dadbd5fa7069b6", @"/Views/Products/GamePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83e4f2d1382b70432e23cf03130c3870902af444", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_GamePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GameShop.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Owner\Source\Repos\ogYaniv\Game-Shop\GameShop\GameShop\Views\Products\GamePage.cshtml"
  
    ViewData["Title"] = "GamePage";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"white\">\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 11 "C:\Users\Owner\Source\Repos\ogYaniv\Game-Shop\GameShop\GameShop\Views\Products\GamePage.cshtml"
       Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 285, "\"", 329, 1);
#nullable restore
#line 14 "C:\Users\Owner\Source\Repos\ogYaniv\Game-Shop\GameShop\GameShop\Views\Products\GamePage.cshtml"
WriteAttributeValue("", 291, Html.DisplayFor(model => model.Image), 291, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"display\" width=\"300\" height=\"400\" />\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Owner\Source\Repos\ogYaniv\Game-Shop\GameShop\GameShop\Views\Products\GamePage.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Owner\Source\Repos\ogYaniv\Game-Shop\GameShop\GameShop\Views\Products\GamePage.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Owner\Source\Repos\ogYaniv\Game-Shop\GameShop\GameShop\Views\Products\GamePage.cshtml"
       Write(Html.DisplayNameFor(model => model.DateOfRelease));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Owner\Source\Repos\ogYaniv\Game-Shop\GameShop\GameShop\Views\Products\GamePage.cshtml"
       Write(Html.DisplayFor(model => model.DateOfRelease));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Owner\Source\Repos\ogYaniv\Game-Shop\GameShop\GameShop\Views\Products\GamePage.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Owner\Source\Repos\ogYaniv\Game-Shop\GameShop\GameShop\Views\Products\GamePage.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Owner\Source\Repos\ogYaniv\Game-Shop\GameShop\GameShop\Views\Products\GamePage.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Owner\Source\Repos\ogYaniv\Game-Shop\GameShop\GameShop\Views\Products\GamePage.cshtml"
       Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Owner\Source\Repos\ogYaniv\Game-Shop\GameShop\GameShop\Views\Products\GamePage.cshtml"
       Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Owner\Source\Repos\ogYaniv\Game-Shop\GameShop\GameShop\Views\Products\GamePage.cshtml"
       Write(Html.DisplayFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Owner\Source\Repos\ogYaniv\Game-Shop\GameShop\GameShop\Views\Products\GamePage.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Owner\Source\Repos\ogYaniv\Game-Shop\GameShop\GameShop\Views\Products\GamePage.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Owner\Source\Repos\ogYaniv\Game-Shop\GameShop\GameShop\Views\Products\GamePage.cshtml"
       Write(Html.DisplayNameFor(model => model.Trailer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <iframe");
            BeginWriteAttribute("src", " src=\"", 1782, "\"", 1828, 1);
#nullable restore
#line 56 "C:\Users\Owner\Source\Repos\ogYaniv\Game-Shop\GameShop\GameShop\Views\Products\GamePage.cshtml"
WriteAttributeValue("", 1788, Html.DisplayFor(model => model.Trailer), 1788, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"420\" height=\"345\"></iframe>\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 59 "C:\Users\Owner\Source\Repos\ogYaniv\Game-Shop\GameShop\GameShop\Views\Products\GamePage.cshtml"
       Write(Html.DisplayNameFor(model => model.Consoles));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 62 "C:\Users\Owner\Source\Repos\ogYaniv\Game-Shop\GameShop\GameShop\Views\Products\GamePage.cshtml"
       Write(Html.DisplayFor(model => model.Consoles));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GameShop.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
