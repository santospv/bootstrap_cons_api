#pragma checksum "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Megasena.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96c0913475f8e7ee50d1d83e49ebf006372f508d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Megasena), @"mvc.1.0.view", @"/Views/Home/Megasena.cshtml")]
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
#line 1 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\_ViewImports.cshtml"
using bootstrap_cons_api;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\_ViewImports.cshtml"
using bootstrap_cons_api.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Megasena.cshtml"
using bootstrap_cons_api.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96c0913475f8e7ee50d1d83e49ebf006372f508d", @"/Views/Home/Megasena.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b5c887d8bda136c21a87284939f3a976b280e8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Megasena : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Megasena.cshtml"
  
    var obj = new ServicesDataResponse().GetDataResponse("https://lotericas.io/api/v1/jogos/megasena/lasted");
    var obj2 = obj.Data[0];
    ViewData["Title"] = obj2.TipoJogo.Replace("_", " ");

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 8 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Megasena.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div class=\"row row-cols-1 row-cols-md-3 mb-3 text-center\">\r\n      <div class=\"col-lg-2 col-sm-4\">\r\n        <div class=\"card mb-4 rounded-3 shadow-sm\">\r\n          <div class=\"card-body\">\r\n            <h1 class=\"card-title pricing-card-title\">");
#nullable restore
#line 14 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Megasena.cshtml"
                                                 Write(obj2.ListaDezenas[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n        </div>\r\n      </div>\r\n\r\n      <div class=\"col-lg-2 col-sm-4\">\r\n        <div class=\"card mb-4 rounded-3 shadow-sm\">\r\n          <div class=\"card-body\">\r\n            <h1 class=\"card-title pricing-card-title\">");
#nullable restore
#line 22 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Megasena.cshtml"
                                                 Write(obj2.ListaDezenas[1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n        </div>\r\n      </div>\r\n\r\n      <div class=\"col-lg-2 col-sm-4\">\r\n        <div class=\"card mb-4 rounded-3 shadow-sm border-primary\">\r\n          <div class=\"card-body\">\r\n            <h1 class=\"card-title pricing-card-title\">");
#nullable restore
#line 30 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Megasena.cshtml"
                                                 Write(obj2.ListaDezenas[2]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        </div>\r\n        </div>\r\n      </div>\r\n\r\n      <div class=\"col-lg-2 col-sm-4\">\r\n        <div class=\"card mb-4 rounded-3 shadow-sm\">\r\n          <div class=\"card-body\">\r\n            <h1 class=\"card-title pricing-card-title\">");
#nullable restore
#line 38 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Megasena.cshtml"
                                                 Write(obj2.ListaDezenas[3]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n        </div>\r\n      </div>\r\n\r\n      <div class=\"col-lg-2 col-sm-4\">\r\n        <div class=\"card mb-4 rounded-3 shadow-sm\">\r\n          <div class=\"card-body\">\r\n            <h1 class=\"card-title pricing-card-title\">");
#nullable restore
#line 46 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Megasena.cshtml"
                                                 Write(obj2.ListaDezenas[4]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n        </div>\r\n      </div>\r\n\r\n      <div class=\"col-lg-2 col-sm-4\">\r\n        <div class=\"card mb-4 rounded-3 shadow-sm border-primary\">\r\n          <div class=\"card-body\">\r\n            <h1 class=\"card-title pricing-card-title\">");
#nullable restore
#line 54 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Megasena.cshtml"
                                                 Write(obj2.ListaDezenas[5]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        </div>\r\n        </div>\r\n      </div>\r\n    </div>");
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
