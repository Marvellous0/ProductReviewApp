#pragma checksum "C:\Users\Favour .O\source\repos\ProductReviewApp\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0304c7c68577961c1b30b495333f47a655cf4e84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
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
#line 1 "C:\Users\Favour .O\source\repos\ProductReviewApp\Views\_ViewImports.cshtml"
using ProductReviewApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Favour .O\source\repos\ProductReviewApp\Views\_ViewImports.cshtml"
using ProductReviewApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0304c7c68577961c1b30b495333f47a655cf4e84", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8660e5de8c9d072a62480c3d954c2949ba75f92b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductReviewApp.Models.ViewModel.ProductIndexViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Favour .O\source\repos\ProductReviewApp\Views\Home\Detail.cshtml"
   ViewBag.Title = "Details"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""text-center text-secondary"">Product Reviews</h1>

<div class=""card"">
    <div class=""card-body"">
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th>UserName</th>
                    <th>Product</th>
                    <th>Comment</th>
                    <th>Ratings</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 18 "C:\Users\Favour .O\source\repos\ProductReviewApp\Views\Home\Detail.cshtml"
                 foreach (var review in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"text-primary\">\r\n                        <td> ");
#nullable restore
#line 21 "C:\Users\Favour .O\source\repos\ProductReviewApp\Views\Home\Detail.cshtml"
                        Write(review.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td> ");
#nullable restore
#line 22 "C:\Users\Favour .O\source\repos\ProductReviewApp\Views\Home\Detail.cshtml"
                        Write(review.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td>");
#nullable restore
#line 23 "C:\Users\Favour .O\source\repos\ProductReviewApp\Views\Home\Detail.cshtml"
                       Write(review.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 24 "C:\Users\Favour .O\source\repos\ProductReviewApp\Views\Home\Detail.cshtml"
                       Write(review.Ratings);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    </tr>\r\n");
#nullable restore
#line 26 "C:\Users\Favour .O\source\repos\ProductReviewApp\Views\Home\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<br />\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductReviewApp.Models.ViewModel.ProductIndexViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
