#pragma checksum "/Users/Guest/Desktop/PlacesYouveBeen.Solution/PlacesYouveBeen/Views/Places/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc76ef268762cc6b548304ddc90d00eeb937050c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Places_Index), @"mvc.1.0.view", @"/Views/Places/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Places/Index.cshtml", typeof(AspNetCore.Views_Places_Index))]
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
#line 1 "/Users/Guest/Desktop/PlacesYouveBeen.Solution/PlacesYouveBeen/Views/Places/Index.cshtml"
using PlacesYouveBeen.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc76ef268762cc6b548304ddc90d00eeb937050c", @"/Views/Places/Index.cshtml")]
    public class Views_Places_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 21, true);
            WriteLiteral("\n<h1>To Do List</h1>\n");
            EndContext();
#line 4 "/Users/Guest/Desktop/PlacesYouveBeen.Solution/PlacesYouveBeen/Views/Places/Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(77, 42, true);
            WriteLiteral("  <p>There are no places in the list.</p>\n");
            EndContext();
#line 7 "/Users/Guest/Desktop/PlacesYouveBeen.Solution/PlacesYouveBeen/Views/Places/Index.cshtml"
}

#line default
#line hidden
            BeginContext(121, 5, true);
            WriteLiteral("<ul>\n");
            EndContext();
#line 9 "/Users/Guest/Desktop/PlacesYouveBeen.Solution/PlacesYouveBeen/Views/Places/Index.cshtml"
   foreach (Place place in Model)
  {

#line default
#line hidden
            BeginContext(164, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(173, 14, false);
#line 11 "/Users/Guest/Desktop/PlacesYouveBeen.Solution/PlacesYouveBeen/Views/Places/Index.cshtml"
   Write(place.CityName);

#line default
#line hidden
            EndContext();
            BeginContext(187, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 12 "/Users/Guest/Desktop/PlacesYouveBeen.Solution/PlacesYouveBeen/Views/Places/Index.cshtml"
  }

#line default
#line hidden
            BeginContext(197, 167, true);
            WriteLiteral("</ul>\n\n<a href=\"/places/new\">Add a new place.</a>\n\n<form action=\"/places/delete\" method=\"post\">\n  <button type=\"submit\" name=\"button\">Clear All Places</button>\n</form>");
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