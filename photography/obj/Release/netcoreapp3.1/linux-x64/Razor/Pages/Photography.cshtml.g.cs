#pragma checksum "/Users/jeffreyadams/Projects/photography/photography/Pages/Photography.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff14f1d43c041916c7db2859be66d12feadf9e4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(photography.Pages.Pages_Photography), @"mvc.1.0.razor-page", @"/Pages/Photography.cshtml")]
namespace photography.Pages
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
#line 1 "/Users/jeffreyadams/Projects/photography/photography/Pages/_ViewImports.cshtml"
using photography;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff14f1d43c041916c7db2859be66d12feadf9e4e", @"/Pages/Photography.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e2f7fd9eb631504b17ad4f802561f3385d4b295", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Photography : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/jeffreyadams/Projects/photography/photography/Pages/Photography.cshtml"
  
    ViewData["Title"] = "Photography";
    Layout = "_PhotoLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""overlay-p w-100 mh-100"" style=""color: #fff;"">
    <div class=""container text-center"">
        <h3>Jeffrey Adams</h3>
        <h1>Photography</h1>
        <div class=""container text-center mt-5"">
            <font class=""sm-h4"">Coding is my passion. Photography is my expression.</font>
        </div>
        <a href=""/portfolio"" class=""btn btn-outline-light rounded-0 mt-2"">Portfolio</a>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Photography> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Photography> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Photography>)PageContext?.ViewData;
        public Pages_Photography Model => ViewData.Model;
    }
}
#pragma warning restore 1591
