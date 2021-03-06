#pragma checksum "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d4339cbbfd07566069f8461197e52c531cdc542"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Loteca), @"mvc.1.0.view", @"/Views/Home/Loteca.cshtml")]
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
#line 1 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
using bootstrap_cons_api.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d4339cbbfd07566069f8461197e52c531cdc542", @"/Views/Home/Loteca.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b5c887d8bda136c21a87284939f3a976b280e8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Loteca : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
  
    var obj = new ServicesDataResponse().GetDataResponse("https://lotericas.io/api/v1/jogos/loteca/lasted");
    var obj2 = obj.Data[0];
    ViewData["Title"] = "Loteca";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 7 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<div class=""row row-cols-1 row-cols-md-3 mb-3 text-center"">
    <div class=""col-lg-10  col-sm-10"">
        <div class=""card mb-4 rounded-3 shadow-sm"">
            <div class=""card-body"">
                <h1 class=""card-title pricing-card-title"">Equipe 1: ");
#nullable restore
#line 13 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                                                               Write(obj2.ListaResultadoEquipeEsportiva[0].NomeEquipeUm);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    Equipe 2: ");
#nullable restore
#line 14 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                         Write(obj2.ListaResultadoEquipeEsportiva[0].NomeEquipeDois);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h1>
            </div>
        </div>
    </div>

    <div class=""col-lg-10  col-sm-10"">
        <div class=""card mb-4 rounded-3 shadow-sm"">
            <div class=""card-body"">
                <h1 class=""card-title pricing-card-title"">Equipe 1: ");
#nullable restore
#line 22 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                                                               Write(obj2.ListaResultadoEquipeEsportiva[1].NomeEquipeUm);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    Equipe 2: ");
#nullable restore
#line 23 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                         Write(obj2.ListaResultadoEquipeEsportiva[1].NomeEquipeDois);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h1>
            </div>
        </div>
    </div>

    <div class=""col-lg-10  col-sm-10"">
        <div class=""card mb-4 rounded-3 shadow-sm"">
            <div class=""card-body"">
                <h1 class=""card-title pricing-card-title"">Equipe 1: ");
#nullable restore
#line 31 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                                                               Write(obj2.ListaResultadoEquipeEsportiva[2].NomeEquipeUm);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    Equipe 2: ");
#nullable restore
#line 32 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                         Write(obj2.ListaResultadoEquipeEsportiva[2].NomeEquipeDois);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h1>
            </div>
        </div>
    </div>

    <div class=""col-lg-10  col-sm-10"">
        <div class=""card mb-4 rounded-3 shadow-sm"">
            <div class=""card-body"">
                <h1 class=""card-title pricing-card-title"">Equipe 1: ");
#nullable restore
#line 40 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                                                               Write(obj2.ListaResultadoEquipeEsportiva[3].NomeEquipeUm);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    Equipe 2: ");
#nullable restore
#line 41 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                         Write(obj2.ListaResultadoEquipeEsportiva[3].NomeEquipeDois);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h1>
            </div>
        </div>
    </div>

    <div class=""col-lg-10  col-sm-10"">
        <div class=""card mb-4 rounded-3 shadow-sm"">
            <div class=""card-body"">
                <h1 class=""card-title pricing-card-title"">Equipe 1: ");
#nullable restore
#line 49 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                                                               Write(obj2.ListaResultadoEquipeEsportiva[4].NomeEquipeUm);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    Equipe 2: ");
#nullable restore
#line 50 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                         Write(obj2.ListaResultadoEquipeEsportiva[4].NomeEquipeDois);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h1>
            </div>
        </div>
    </div>

    <div class=""col-lg-10  col-sm-10"">
        <div class=""card mb-4 rounded-3 shadow-sm"">
            <div class=""card-body"">
                <h1 class=""card-title pricing-card-title"">Equipe 1: ");
#nullable restore
#line 58 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                                                               Write(obj2.ListaResultadoEquipeEsportiva[5].NomeEquipeUm);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    Equipe 2: ");
#nullable restore
#line 59 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                         Write(obj2.ListaResultadoEquipeEsportiva[5].NomeEquipeDois);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h1>
            </div>
        </div>
    </div>

    <div class=""col-lg-10  col-sm-10"">
        <div class=""card mb-4 rounded-3 shadow-sm"">
            <div class=""card-body"">
                <h1 class=""card-title pricing-card-title"">Equipe 1: ");
#nullable restore
#line 67 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                                                               Write(obj2.ListaResultadoEquipeEsportiva[6].NomeEquipeUm);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    Equipe 2: ");
#nullable restore
#line 68 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                         Write(obj2.ListaResultadoEquipeEsportiva[6].NomeEquipeDois);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h1>
            </div>
        </div>
    </div>

    <div class=""col-lg-10  col-sm-10"">
        <div class=""card mb-4 rounded-3 shadow-sm"">
            <div class=""card-body"">
                <h1 class=""card-title pricing-card-title"">Equipe 1: ");
#nullable restore
#line 76 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                                                               Write(obj2.ListaResultadoEquipeEsportiva[7].NomeEquipeUm);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    Equipe 2: ");
#nullable restore
#line 77 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                         Write(obj2.ListaResultadoEquipeEsportiva[7].NomeEquipeDois);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h1>
            </div>
        </div>
    </div>

    <div class=""col-lg-10  col-sm-10"">
        <div class=""card mb-4 rounded-3 shadow-sm"">
            <div class=""card-body"">
                <h1 class=""card-title pricing-card-title"">Equipe 1: ");
#nullable restore
#line 85 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                                                               Write(obj2.ListaResultadoEquipeEsportiva[8].NomeEquipeUm);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    Equipe 2: ");
#nullable restore
#line 86 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                         Write(obj2.ListaResultadoEquipeEsportiva[8].NomeEquipeDois);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h1>
            </div>
        </div>
    </div>

    <div class=""col-lg-10  col-sm-10"">
        <div class=""card mb-4 rounded-3 shadow-sm"">
            <div class=""card-body"">
                <h1 class=""card-title pricing-card-title"">Equipe 1: ");
#nullable restore
#line 94 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                                                               Write(obj2.ListaResultadoEquipeEsportiva[9].NomeEquipeUm);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    Equipe 2: ");
#nullable restore
#line 95 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                         Write(obj2.ListaResultadoEquipeEsportiva[9].NomeEquipeDois);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h1>
            </div>
        </div>
    </div>

    <div class=""col-lg-10  col-sm-10"">
        <div class=""card mb-4 rounded-3 shadow-sm"">
            <div class=""card-body"">
                <h1 class=""card-title pricing-card-title"">Equipe 1: ");
#nullable restore
#line 103 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                                                               Write(obj2.ListaResultadoEquipeEsportiva[10].NomeEquipeUm);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    Equipe 2: ");
#nullable restore
#line 104 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                         Write(obj2.ListaResultadoEquipeEsportiva[10].NomeEquipeDois);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h1>
            </div>
        </div>
    </div>

    <div class=""col-lg-10  col-sm-10"">
        <div class=""card mb-4 rounded-3 shadow-sm"">
            <div class=""card-body"">
                <h1 class=""card-title pricing-card-title"">Equipe 1: ");
#nullable restore
#line 112 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                                                               Write(obj2.ListaResultadoEquipeEsportiva[11].NomeEquipeUm);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    Equipe 2: ");
#nullable restore
#line 113 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                         Write(obj2.ListaResultadoEquipeEsportiva[11].NomeEquipeDois);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h1>
            </div>
        </div>
    </div>

    <div class=""col-lg-10  col-sm-10"">
        <div class=""card mb-4 rounded-3 shadow-sm"">
            <div class=""card-body"">
                <h1 class=""card-title pricing-card-title"">Equipe 1: ");
#nullable restore
#line 121 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                                                               Write(obj2.ListaResultadoEquipeEsportiva[12].NomeEquipeUm);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    Equipe 2: ");
#nullable restore
#line 122 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                         Write(obj2.ListaResultadoEquipeEsportiva[12].NomeEquipeDois);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h1>
            </div>
        </div>
    </div>

    <div class=""col-lg-10  col-sm-10"">
        <div class=""card mb-4 rounded-3 shadow-sm"">
            <div class=""card-body"">
                <h1 class=""card-title pricing-card-title"">Equipe 1: ");
#nullable restore
#line 130 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                                                               Write(obj2.ListaResultadoEquipeEsportiva[13].NomeEquipeUm);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    Equipe 2: ");
#nullable restore
#line 131 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                         Write(obj2.ListaResultadoEquipeEsportiva[13].NomeEquipeDois);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h1>
            </div>
        </div>
    </div>

    <div class=""col-lg-10  col-sm-10"">
        <div class=""card mb-4 rounded-3 shadow-sm"">
            <div class=""card-body"">
                <h1 class=""card-title pricing-card-title"">Equipe 1: ");
#nullable restore
#line 139 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                                                               Write(obj2.ListaResultadoEquipeEsportiva[13].NomeEquipeUm);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    Equipe 2: ");
#nullable restore
#line 140 "C:\Users\paulo\Documents\bootstrap_cons_api\Views\Home\Loteca.cshtml"
                         Write(obj2.ListaResultadoEquipeEsportiva[13].NomeEquipeDois);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n</div>");
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
