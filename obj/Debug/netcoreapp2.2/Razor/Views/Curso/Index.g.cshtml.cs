#pragma checksum "c:\Users\PETRO133\dropbox\programacion\Curso ASP-NET Core\Views\Curso\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1706709d8d5d3e4560d22ba25a2def63a7f25f43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curso_Index), @"mvc.1.0.view", @"/Views/Curso/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Curso/Index.cshtml", typeof(AspNetCore.Views_Curso_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1706709d8d5d3e4560d22ba25a2def63a7f25f43", @"/Views/Curso/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbcbbff56a102f3675551b06c19ff37cab9a233c", @"/Views/_ViewImports.cshtml")]
    public class Views_Curso_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Curso>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ObjetoEscuelaSimple", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(16, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "c:\Users\PETRO133\dropbox\programacion\Curso ASP-NET Core\Views\Curso\Index.cshtml"
  
    ViewData["Title"] = "Informacion Cursos";
    Layout = "Simple";

#line default
#line hidden
            BeginContext(96, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(103, 17, false);
#line 9 "c:\Users\PETRO133\dropbox\programacion\Curso ASP-NET Core\Views\Curso\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(120, 17, true);
            WriteLiteral("</h1>\r\n\r\n<strong>");
            EndContext();
            BeginContext(138, 20, false);
#line 11 "c:\Users\PETRO133\dropbox\programacion\Curso ASP-NET Core\Views\Curso\Index.cshtml"
   Write(ViewBag.MensajeExtra);

#line default
#line hidden
            EndContext();
            BeginContext(158, 11, true);
            WriteLiteral("</strong>\r\n");
            EndContext();
            BeginContext(169, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1706709d8d5d3e4560d22ba25a2def63a7f25f434602", async() => {
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
            BeginContext(207, 7, true);
            WriteLiteral("\r\n\r\n<p>");
            EndContext();
            BeginContext(215, 20, false);
#line 14 "c:\Users\PETRO133\dropbox\programacion\Curso ASP-NET Core\Views\Curso\Index.cshtml"
Write(ViewBag.CosaDinamica);

#line default
#line hidden
            EndContext();
            BeginContext(235, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(245, 13, false);
#line 15 "c:\Users\PETRO133\dropbox\programacion\Curso ASP-NET Core\Views\Curso\Index.cshtml"
Write(ViewBag.Fecha);

#line default
#line hidden
            EndContext();
            BeginContext(258, 6, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Curso> Html { get; private set; }
    }
}
#pragma warning restore 1591
