#pragma checksum "C:\Users\umuto\source\repos\Mvc\ViewStructure\ViewStructure\Views\Shared\Partials\_SliderPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf88465c39eb42e2e0519d3af4f0df24a6747a14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partials__SliderPartial), @"mvc.1.0.view", @"/Views/Shared/Partials/_SliderPartial.cshtml")]
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
#line 2 "C:\Users\umuto\source\repos\Mvc\ViewStructure\ViewStructure\Views\_ViewImports.cshtml"
using ViewStructure.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf88465c39eb42e2e0519d3af4f0df24a6747a14", @"/Views/Shared/Partials/_SliderPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12d518869718590a9545243ecaf96ff7e45bf36d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partials__SliderPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">
    <!-- Indicators -->
    <ol class=""carousel-indicators"">
      <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
      <li data-target=""#myCarousel"" data-slide-to=""1""></li>
      <li data-target=""#myCarousel"" data-slide-to=""2""></li>
    </ol>

    <!-- Wrapper for slides -->
    <div class=""carousel-inner"">
      <div class=""item active"">
        <img src=""/images/la.jpg"" alt=""Los Angeles"" style=""width:100%;"">
      </div>

      <div class=""item"">
        <img src=""/images/chicago.jpg"" alt=""Chicago"" style=""width:100%;"">
      </div>
    
      <div class=""item"">
        <img src=""/images/ny.jpg"" alt=""New york"" style=""width:100%;"">
      </div>
    </div>

    <!-- Left and right controls -->
    <a class=""left carousel-control"" href=""#myCarousel"" data-slide=""prev"">
      <span class=""glyphicon glyphicon-chevron-left""></span>
      <span class=""sr-only"">Previous</span>
    </a>
    <a class=""ri");
            WriteLiteral("ght carousel-control\" href=\"#myCarousel\" data-slide=\"next\">\r\n      <span class=\"glyphicon glyphicon-chevron-right\"></span>\r\n      <span class=\"sr-only\">Next</span>\r\n    </a>\r\n  </div>");
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