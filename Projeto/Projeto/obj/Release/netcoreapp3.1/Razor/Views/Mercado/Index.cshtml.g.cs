#pragma checksum "C:\Users\fcpf1\OneDrive\Ambiente de Trabalho\Universidade\LI4_Project\Projeto\Projeto\Views\Mercado\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f93ec1fe5a373e81976b545e98d21d8edb56688"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mercado_Index), @"mvc.1.0.view", @"/Views/Mercado/Index.cshtml")]
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
#line 1 "C:\Users\fcpf1\OneDrive\Ambiente de Trabalho\Universidade\LI4_Project\Projeto\Projeto\Views\_ViewImports.cshtml"
using Projeto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fcpf1\OneDrive\Ambiente de Trabalho\Universidade\LI4_Project\Projeto\Projeto\Views\_ViewImports.cshtml"
using Projeto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f93ec1fe5a373e81976b545e98d21d8edb56688", @"/Views/Mercado/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d4dfd97469170fe8b85a6370378ea67b5320a14", @"/Views/_ViewImports.cshtml")]
    public class Views_Mercado_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Mercado>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table style=\"width:100%\">\r\n    <tr>\r\n        <th>Codigo</th>\r\n        <th>Pais</th>\r\n        <th>Nome</th>\r\n    </tr>\r\n");
#nullable restore
#line 9 "C:\Users\fcpf1\OneDrive\Ambiente de Trabalho\Universidade\LI4_Project\Projeto\Projeto\Views\Mercado\Index.cshtml"
     foreach (Mercado m in @Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 12 "C:\Users\fcpf1\OneDrive\Ambiente de Trabalho\Universidade\LI4_Project\Projeto\Projeto\Views\Mercado\Index.cshtml"
           Write(m.mercadoID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 13 "C:\Users\fcpf1\OneDrive\Ambiente de Trabalho\Universidade\LI4_Project\Projeto\Projeto\Views\Mercado\Index.cshtml"
           Write(m.pais);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 14 "C:\Users\fcpf1\OneDrive\Ambiente de Trabalho\Universidade\LI4_Project\Projeto\Projeto\Views\Mercado\Index.cshtml"
           Write(m.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 16 "C:\Users\fcpf1\OneDrive\Ambiente de Trabalho\Universidade\LI4_Project\Projeto\Projeto\Views\Mercado\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Mercado>> Html { get; private set; }
    }
}
#pragma warning restore 1591
