#pragma checksum "E:\RoleTop1\Views\Cadastro\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15db895199771310f37434e51b7412c1a52ea148"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cadastro_Index), @"mvc.1.0.view", @"/Views/Cadastro/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cadastro/Index.cshtml", typeof(AspNetCore.Views_Cadastro_Index))]
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
#line 1 "E:\RoleTop1\Views\_ViewImports.cshtml"
using RoleTop;

#line default
#line hidden
#line 2 "E:\RoleTop1\Views\_ViewImports.cshtml"
using RoleTop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15db895199771310f37434e51b7412c1a52ea148", @"/Views/Cadastro/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8fc0cfda6b2bb54f88e5d7a55c241985d2df4ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Cadastro_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTop.ViewModels.RespostaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 48, true);
            WriteLiteral("<main>\r\n    <h2 class=\"cadastro\">Cadastro</h2>\r\n");
            EndContext();
#line 4 "E:\RoleTop1\Views\Cadastro\Index.cshtml"
     if(!string.IsNullOrEmpty(@Model.Mensagem))
    {

#line default
#line hidden
            BeginContext(149, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(161, 14, false);
#line 6 "E:\RoleTop1\Views\Cadastro\Index.cshtml"
      Write(Model.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(175, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 7 "E:\RoleTop1\Views\Cadastro\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(188, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(192, 2183, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "969d8d0c472543129abc585ba0018a70", async() => {
                BeginContext(258, 2110, true);
                WriteLiteral(@"
        <div id=""cadastro1"">
            <div id=""cadcol1"">
                <div>
                    <label for=""nome"">Nome</label>
                    <br>
                    <input type=""text"" name=""nome"" required>
                </div>
                
                <div>
                    <label for=""cpf"">CPF</label>
                    <br>
                    <input type=""number"" name=""cpf"" required>
                </div>
                
                <div>
                    <label for=""email"">Email</label>
                    <br>
                    <input type=""email"" name=""email"" required>
                </div>

                <div>
                    <label for=""cep"">CEP</label>
                    <br>
                    <input type=""text"" name=""cep"" required>
                </div>

                <div>
                    <label for=""logradouro"">Logradouro</label>
                    <br>
                    <input type=""text"" name=""logradouro"" re");
                WriteLiteral(@"quired>
                </div>

                <div>
                    <label for=""complemento"">Complemento</label>
                    <br>
                    <input type=""text"" name=""complemento"">
                </div>

                <div>
                    <label for=""telefone"">Telefone</label>
                    <br>
                    <input type=""number"" name=""telefone"" required>
                </div>
            

            
                <div>
                    <label for=""senha"">Senha</label>
                    <br>
                    <input type=""password"" name=""senha"" minlength=""6"" required>
                </div>

                <div>
                    <label for=""confirmar-senha"">Confirmar Senha</label>
                    <br>
                    <input type=""password"" name=""confirmar-senha"" minlength=""6"" required>
                </div>
                <br>
                
                <input type=""submit"" value=""Cadastrar"">
            ");
                WriteLiteral("</div>\r\n\r\n            <br>\r\n            \r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 8 "E:\RoleTop1\Views\Cadastro\Index.cshtml"
AddHtmlAttributeValue("", 220, Url.Action("Cadastrar", "Cadastro"), 220, 36, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2375, 9, true);
            WriteLiteral("\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTop.ViewModels.RespostaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591