#pragma checksum "D:\Client Project\Web Application\saioncorp\layer\Saioncorp\Saioncorp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88005875a9d01f73219a65881dc1e715796f49a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\Client Project\Web Application\saioncorp\layer\Saioncorp\Saioncorp\Views\_ViewImports.cshtml"
using Saioncorp;

#line default
#line hidden
#line 2 "D:\Client Project\Web Application\saioncorp\layer\Saioncorp\Saioncorp\Views\_ViewImports.cshtml"
using Saioncorp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88005875a9d01f73219a65881dc1e715796f49a6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6e5c3e881f6a94f7fc8d80c14b8017573d64798", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 173, true);
            WriteLiteral("<div class=\"featured-products-row\">\r\n    <div class=\"inner-container\">\r\n        <div class=\"home-page-title\">Featured products</div>\r\n        <ul class=\"homepage-listing\">\r\n");
            EndContext();
#line 5 "D:\Client Project\Web Application\saioncorp\layer\Saioncorp\Saioncorp\Views\Home\Index.cshtml"
             foreach (var product in ViewBag.Products)
            {

#line default
#line hidden
            BeginContext(244, 129, true);
            WriteLiteral("                <li>\r\n                    <div class=\"product-name-pricing-box\">\r\n                        <div class=\"pnpb-name\">");
            EndContext();
            BeginContext(374, 19, false);
#line 9 "D:\Client Project\Web Application\saioncorp\layer\Saioncorp\Saioncorp\Views\Home\Index.cshtml"
                                          Write(product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(393, 60, true);
            WriteLiteral("</div>\r\n                        <div class=\"pnpb-cs\">From $ ");
            EndContext();
            BeginContext(454, 19, false);
#line 10 "D:\Client Project\Web Application\saioncorp\layer\Saioncorp\Saioncorp\Views\Home\Index.cshtml"
                                               Write(product.ProductRate);

#line default
#line hidden
            EndContext();
            BeginContext(473, 111, true);
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"product-dec-box\">\r\n                        ");
            EndContext();
            BeginContext(585, 19, false);
#line 13 "D:\Client Project\Web Application\saioncorp\layer\Saioncorp\Saioncorp\Views\Home\Index.cshtml"
                   Write(product.ProductDesc);

#line default
#line hidden
            EndContext();
            BeginContext(604, 130, true);
            WriteLiteral("\r\n                    </div>\r\n                    <a href=\"#\" class=\"product-addtocart-btn\">View More</a>\r\n                </li>\r\n");
            EndContext();
#line 17 "D:\Client Project\Web Application\saioncorp\layer\Saioncorp\Saioncorp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(749, 216, true);
            WriteLiteral("            </ul>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"current-promotions-row\">\r\n    <div class=\"inner-container\">\r\n        <div class=\"home-page-title\">Current Promotions</div>\r\n        <ul class=\"homepage-listing\">\r\n");
            EndContext();
#line 26 "D:\Client Project\Web Application\saioncorp\layer\Saioncorp\Saioncorp\Views\Home\Index.cshtml"
             foreach (var promotion in ViewBag.Promotions)
            {

#line default
#line hidden
            BeginContext(1040, 129, true);
            WriteLiteral("                <li>\r\n                    <div class=\"product-name-pricing-box\">\r\n                        <div class=\"pnpb-name\">");
            EndContext();
            BeginContext(1170, 23, false);
#line 30 "D:\Client Project\Web Application\saioncorp\layer\Saioncorp\Saioncorp\Views\Home\Index.cshtml"
                                          Write(promotion.PromotionName);

#line default
#line hidden
            EndContext();
            BeginContext(1193, 60, true);
            WriteLiteral("</div>\r\n                        <div class=\"pnpb-cs\">From $ ");
            EndContext();
            BeginContext(1254, 23, false);
#line 31 "D:\Client Project\Web Application\saioncorp\layer\Saioncorp\Saioncorp\Views\Home\Index.cshtml"
                                               Write(promotion.PromotionRate);

#line default
#line hidden
            EndContext();
            BeginContext(1277, 111, true);
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"product-dec-box\">\r\n                        ");
            EndContext();
            BeginContext(1389, 23, false);
#line 34 "D:\Client Project\Web Application\saioncorp\layer\Saioncorp\Saioncorp\Views\Home\Index.cshtml"
                   Write(promotion.PromotionDesc);

#line default
#line hidden
            EndContext();
            BeginContext(1412, 130, true);
            WriteLiteral("\r\n                    </div>\r\n                    <a href=\"#\" class=\"product-addtocart-btn\">View More</a>\r\n                </li>\r\n");
            EndContext();
#line 38 "D:\Client Project\Web Application\saioncorp\layer\Saioncorp\Saioncorp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1557, 33, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n</div>");
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
