#pragma checksum "/Users/Guest/Desktop/Parcel/Parcel/Views/Parcels/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbcd7be00bbc412c9a5ca33b79fb981cdf2e16b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parcels_Index), @"mvc.1.0.view", @"/Views/Parcels/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Parcels/Index.cshtml", typeof(AspNetCore.Views_Parcels_Index))]
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
#line 1 "/Users/Guest/Desktop/Parcel/Parcel/Views/Parcels/Index.cshtml"
using Delivery.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbcd7be00bbc412c9a5ca33b79fb981cdf2e16b6", @"/Views/Parcels/Index.cshtml")]
    public class Views_Parcels_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 29, true);
            WriteLiteral("\n<h1>Package List</h1>\n<ul>\n\n");
            EndContext();
#line 6 "/Users/Guest/Desktop/Parcel/Parcel/Views/Parcels/Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(78, 29, true);
            WriteLiteral(" <p>You have no packages</p>\n");
            EndContext();
#line 9 "/Users/Guest/Desktop/Parcel/Parcel/Views/Parcels/Index.cshtml"
}

#line default
#line hidden
#line 10 "/Users/Guest/Desktop/Parcel/Parcel/Views/Parcels/Index.cshtml"
 if(Model.Count != 0)
{
 

#line default
#line hidden
#line 12 "/Users/Guest/Desktop/Parcel/Parcel/Views/Parcels/Index.cshtml"
  foreach (Parcel parcel in Model)
 {

#line default
#line hidden
            BeginContext(171, 7, true);
            WriteLiteral("   <li>");
            EndContext();
            BeginContext(179, 23, false);
#line 14 "/Users/Guest/Desktop/Parcel/Parcel/Views/Parcels/Index.cshtml"
  Write(parcel.GetDescription());

#line default
#line hidden
            EndContext();
            BeginContext(202, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(205, 18, false);
#line 14 "/Users/Guest/Desktop/Parcel/Parcel/Views/Parcels/Index.cshtml"
                            Write(parcel.GetVolume());

#line default
#line hidden
            EndContext();
            BeginContext(223, 12, true);
            WriteLiteral(" cubic cm, $");
            EndContext();
            BeginContext(236, 19, false);
#line 14 "/Users/Guest/Desktop/Parcel/Parcel/Views/Parcels/Index.cshtml"
                                                           Write(parcel.CostToShip());

#line default
#line hidden
            EndContext();
            BeginContext(255, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 15 "/Users/Guest/Desktop/Parcel/Parcel/Views/Parcels/Index.cshtml"
 }

#line default
#line hidden
#line 15 "/Users/Guest/Desktop/Parcel/Parcel/Views/Parcels/Index.cshtml"
  
}

#line default
#line hidden
            BeginContext(266, 55, true);
            WriteLiteral("\n</ul>\n<a href=\"/parcels/new\">Add another package.</a>\n");
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