#pragma checksum "C:\Users\jocm\My Private Documents\codes\Desafio MVC\WaMVC\Views\wa\listaFuncionarioAlocar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "baaef45111d8b820ef3764e12e05565e66dd8cf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_wa_listaFuncionarioAlocar), @"mvc.1.0.view", @"/Views/wa/listaFuncionarioAlocar.cshtml")]
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
#line 1 "C:\Users\jocm\My Private Documents\codes\Desafio MVC\WaMVC\Views\_ViewImports.cshtml"
using WaMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jocm\My Private Documents\codes\Desafio MVC\WaMVC\Views\_ViewImports.cshtml"
using WaMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baaef45111d8b820ef3764e12e05565e66dd8cf1", @"/Views/wa/listaFuncionarioAlocar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d94a3a1083251febf56ad5248af768046b65396e", @"/Views/_ViewImports.cshtml")]
    public class Views_wa_listaFuncionarioAlocar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FuncionarioTecnologia>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "wa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "alocarFuncionario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\jocm\My Private Documents\codes\Desafio MVC\WaMVC\Views\wa\listaFuncionarioAlocar.cshtml"
  
    ViewData["Title"] = "Alocar";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Alocar Funcionário</h2><br>
<h4 style=""font-size: 20px;"">Escolha: </h4>

<div id=""list"" class=""row"">
    <div class=""table-responsive col-md-12"">
        <table class=""table table-striped table-bordered table-hover"">
            <thead style=""background-color: #00008B; color: white;"">
                <tr>
                    <th>Nome</th>
                    <th>Cargo</th>
                    <th>Tecnologia</th>
                    <th>Inicio WA</th>
                    <th class=""actions"">Escolher</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 23 "C:\Users\jocm\My Private Documents\codes\Desafio MVC\WaMVC\Views\wa\listaFuncionarioAlocar.cshtml"
                 foreach (var funcionario in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 26 "C:\Users\jocm\My Private Documents\codes\Desafio MVC\WaMVC\Views\wa\listaFuncionarioAlocar.cshtml"
                       Write(funcionario.Funcionario.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 27 "C:\Users\jocm\My Private Documents\codes\Desafio MVC\WaMVC\Views\wa\listaFuncionarioAlocar.cshtml"
                       Write(funcionario.Funcionario.Cargo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\jocm\My Private Documents\codes\Desafio MVC\WaMVC\Views\wa\listaFuncionarioAlocar.cshtml"
                       Write(funcionario.Tecnologia.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\jocm\My Private Documents\codes\Desafio MVC\WaMVC\Views\wa\listaFuncionarioAlocar.cshtml"
                       Write(funcionario.Funcionario.InicioWa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"actions\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baaef45111d8b820ef3764e12e05565e66dd8cf16767", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"id\" id=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1266, "\"", 1289, 1);
#nullable restore
#line 32 "C:\Users\jocm\My Private Documents\codes\Desafio MVC\WaMVC\Views\wa\listaFuncionarioAlocar.cshtml"
WriteAttributeValue("", 1274, funcionario.Id, 1274, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                                <button class=\"btn btn-primary\">Alocar</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 37 "C:\Users\jocm\My Private Documents\codes\Desafio MVC\WaMVC\Views\wa\listaFuncionarioAlocar.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<nav aria-label=\"Page navigation example\">\r\n  <ul class=\"pagination justify-content-center\">\r\n    ");
#nullable restore
#line 44 "C:\Users\jocm\My Private Documents\codes\Desafio MVC\WaMVC\Views\wa\listaFuncionarioAlocar.cshtml"
Write(Html.ActionLink("Voltar", "vagas", "wa", null, new {@class = "page-item btn btn-outline-primary my-2 my-sm-0"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    &nbsp;&nbsp;\r\n    ");
#nullable restore
#line 46 "C:\Users\jocm\My Private Documents\codes\Desafio MVC\WaMVC\Views\wa\listaFuncionarioAlocar.cshtml"
Write(Html.ActionLink("Próxima", "historico", "wa", null, new {@class = "page-item btn btn-outline-primary my-2 my-sm-0"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </ul>\r\n</nav>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FuncionarioTecnologia>> Html { get; private set; }
    }
}
#pragma warning restore 1591
