#pragma checksum "c:\Users\PETRO133\dropbox\programacion\Curso ASP-NET Core\Views\Escuela\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd8f89ff3edac9c072d8413c221641a24b83e777"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escuela_Index), @"mvc.1.0.view", @"/Views/Escuela/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Escuela/Index.cshtml", typeof(AspNetCore.Views_Escuela_Index))]
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
#line 1 "c:\Users\PETRO133\dropbox\programacion\Curso ASP-NET Core\Views\_ViewImports.cshtml"
using Curso_ASP_NET_Core;

#line default
#line hidden
#line 2 "c:\Users\PETRO133\dropbox\programacion\Curso ASP-NET Core\Views\_ViewImports.cshtml"
using Curso_ASP_NET_Core.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd8f89ff3edac9c072d8413c221641a24b83e777", @"/Views/Escuela/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbcbbff56a102f3675551b06c19ff37cab9a233c", @"/Views/_ViewImports.cshtml")]
    public class Views_Escuela_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Escuela>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "c:\Users\PETRO133\dropbox\programacion\Curso ASP-NET Core\Views\Escuela\Index.cshtml"
  
    ViewData["Title"] = "Informacion Escuela";
    Layout = "Simple";

#line default
#line hidden
            BeginContext(97, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(104, 17, false);
#line 8 "c:\Users\PETRO133\dropbox\programacion\Curso ASP-NET Core\Views\Escuela\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(121, 19, true);
            WriteLiteral("</h1>\r\n<h2>Nombre: ");
            EndContext();
            BeginContext(141, 12, false);
#line 9 "c:\Users\PETRO133\dropbox\programacion\Curso ASP-NET Core\Views\Escuela\Index.cshtml"
       Write(Model.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(153, 29, true);
            WriteLiteral(" </h2>\r\n<h3>Tipo de Escuela: ");
            EndContext();
            BeginContext(183, 17, false);
#line 10 "c:\Users\PETRO133\dropbox\programacion\Curso ASP-NET Core\Views\Escuela\Index.cshtml"
                Write(Model.TipoEscuela);

#line default
#line hidden
            EndContext();
            BeginContext(200, 35, true);
            WriteLiteral("</h3>\r\n<address>\r\n   <p>Direccion: ");
            EndContext();
            BeginContext(236, 15, false);
#line 12 "c:\Users\PETRO133\dropbox\programacion\Curso ASP-NET Core\Views\Escuela\Index.cshtml"
            Write(Model.Dirección);

#line default
#line hidden
            EndContext();
            BeginContext(251, 20, true);
            WriteLiteral(" </p> \r\n   <p>Pais: ");
            EndContext();
            BeginContext(272, 10, false);
#line 13 "c:\Users\PETRO133\dropbox\programacion\Curso ASP-NET Core\Views\Escuela\Index.cshtml"
       Write(Model.Pais);

#line default
#line hidden
            EndContext();
            BeginContext(282, 21, true);
            WriteLiteral(" </p>\r\n   <p>Ciudad: ");
            EndContext();
            BeginContext(304, 12, false);
#line 14 "c:\Users\PETRO133\dropbox\programacion\Curso ASP-NET Core\Views\Escuela\Index.cshtml"
         Write(Model.Ciudad);

#line default
#line hidden
            EndContext();
            BeginContext(316, 45, true);
            WriteLiteral(" </p>\r\n</address>\r\n<p><strong>Año fundacion: ");
            EndContext();
            BeginContext(362, 18, false);
#line 16 "c:\Users\PETRO133\dropbox\programacion\Curso ASP-NET Core\Views\Escuela\Index.cshtml"
                     Write(Model.añoFundacion);

#line default
#line hidden
            EndContext();
            BeginContext(380, 20, true);
            WriteLiteral("</strong></p>\r\n\r\n<p>");
            EndContext();
            BeginContext(401, 20, false);
#line 18 "c:\Users\PETRO133\dropbox\programacion\Curso ASP-NET Core\Views\Escuela\Index.cshtml"
Write(ViewBag.CosaDinamica);

#line default
#line hidden
            EndContext();
            BeginContext(421, 5, true);
            WriteLiteral("/p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Escuela> Html { get; private set; }
    }
}
#pragma warning restore 1591
