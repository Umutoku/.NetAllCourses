#pragma checksum "C:\Users\umuto\source\repos\Mvc\DbFirst\DbFirst\Views\Category\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7578360ab18d6b7d0b410adabdeb21f1c377a51c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_List), @"mvc.1.0.view", @"/Views/Category/List.cshtml")]
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
#line 1 "C:\Users\umuto\source\repos\Mvc\DbFirst\DbFirst\Views\_ViewImports.cshtml"
using DbFirst.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7578360ab18d6b7d0b410adabdeb21f1c377a51c", @"/Views/Category/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a698a1b634b03aff7a43d0537261fb9f8e5861f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Category_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <h2 style=\"text-align:center\">Kategori Listesi</h2>\r\n\r\n    <ul>\r\n");
#nullable restore
#line 6 "C:\Users\umuto\source\repos\Mvc\DbFirst\DbFirst\Views\Category\List.cshtml"
         foreach (Category item in Model)
       {

#line default
#line hidden
#nullable disable
            WriteLiteral("           <li>");
#nullable restore
#line 8 "C:\Users\umuto\source\repos\Mvc\DbFirst\DbFirst\Views\Category\List.cshtml"
          Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 9 "C:\Users\umuto\source\repos\Mvc\DbFirst\DbFirst\Views\Category\List.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591