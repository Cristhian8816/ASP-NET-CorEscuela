#pragma checksum "c:\Users\PETRO133\dropbox\programacion\Curso ASP-NET Core\Views\Asignatura\MultiAsignatura.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbe35579f843124fcfd31d6d3a5813046c2964fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Asignatura_MultiAsignatura), @"mvc.1.0.view", @"/Views/Asignatura/MultiAsignatura.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Asignatura/MultiAsignatura.cshtml", typeof(AspNetCore.Views_Asignatura_MultiAsignatura))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbe35579f843124fcfd31d6d3a5813046c2964fc", @"/Views/Asignatura/MultiAsignatura.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbcbbff56a102f3675551b06c19ff37cab9a233c", @"/Views/_ViewImports.cshtml")]
    public class Views_Asignatura_MultiAsignatura : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Asignatura>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ListaObjetosEscuela", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "c:\Users\PETRO133\dropbox\programacion\Curso ASP-NET Core\Views\Asignatura\MultiAsignatura.cshtml"
  
    ViewData["Title"] = "Informacion Asignatura";
    Layout = "Simple";

#line default
#line hidden
            BeginContext(111, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(118, 17, false);
#line 9 "c:\Users\PETRO133\dropbox\programacion\Curso ASP-NET Core\Views\Asignatura\MultiAsignatura.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(135, 52, true);
            WriteLiteral("</h1>\r\n\r\n<strong>Desde la vista Parcial</strong>\r\n\r\n");
            EndContext();
            BeginContext(187, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dbe35579f843124fcfd31d6d3a5813046c2964fc4450", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(225, 10, true);
            WriteLiteral(" \r\n\r\n\r\n<p>");
            EndContext();
            BeginContext(236, 20, false);
#line 16 "c:\Users\PETRO133\dropbox\programacion\Curso ASP-NET Core\Views\Asignatura\MultiAsignatura.cshtml"
Write(ViewBag.CosaDinamica);

#line default
#line hidden
            EndContext();
            BeginContext(256, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(266, 13, false);
#line 17 "c:\Users\PETRO133\dropbox\programacion\Curso ASP-NET Core\Views\Asignatura\MultiAsignatura.cshtml"
Write(ViewBag.Fecha);

#line default
#line hidden
            EndContext();
            BeginContext(279, 6, true);
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Asignatura>> Html { get; private set; }
    }
}
#pragma warning restore 1591