#pragma checksum "E:\RoleTop1\Views\Cliente\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb63825563f71bcdc00eb49101f0e3b6246a8fcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Login), @"mvc.1.0.view", @"/Views/Cliente/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Login.cshtml", typeof(AspNetCore.Views_Cliente_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb63825563f71bcdc00eb49101f0e3b6246a8fcd", @"/Views/Cliente/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8fc0cfda6b2bb54f88e5d7a55c241985d2df4ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTop.ViewModels.RespostaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/facebook.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("facebook"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100em"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/google.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("google"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("30em"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 34, true);
            WriteLiteral("\r\n<main>\r\n    <h2>Login</h2>\r\n    ");
            EndContext();
            BeginContext(79, 654, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22cf73f3312f45828ab69fcc647eda35", async() => {
                BeginContext(140, 27, true);
                WriteLiteral("\r\n<div class=\"menulogin\">\r\n");
                EndContext();
#line 7 "E:\RoleTop1\Views\Cliente\Login.cshtml"
     if(!string.IsNullOrEmpty(@Model.Mensagem)){

#line default
#line hidden
                BeginContext(217, 11, true);
                WriteLiteral("        <p>");
                EndContext();
                BeginContext(229, 14, false);
#line 8 "E:\RoleTop1\Views\Cliente\Login.cshtml"
      Write(Model.Mensagem);

#line default
#line hidden
                EndContext();
                BeginContext(243, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
#line 9 "E:\RoleTop1\Views\Cliente\Login.cshtml"
    }

#line default
#line hidden
                BeginContext(256, 391, true);
                WriteLiteral(@"    <div>
        <label for=""email"">Email</label>
        <br />
        <input type=""email"" id=""email"" name=""email"" required>
    </div>
    <div>
        <label for=""senha"">Senha</label>
        <br />
        <input type=""password"" id=""senha"" name=""senha"" required>
    </div>
    <input type=""submit"" value=""Entrar"">
</div>

        <div id=""link-cadastro"">
            <a");
                EndContext();
                BeginWriteAttribute("href", "  href=\'", 647, "\'", 687, 1);
#line 24 "E:\RoleTop1\Views\Cliente\Login.cshtml"
WriteAttributeValue("", 655, Url.Action("Index", "Cadastro"), 655, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(688, 38, true);
                WriteLiteral(">Cadastre-se</a>\r\n        </div>\r\n    ");
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
#line 5 "E:\RoleTop1\Views\Cliente\Login.cshtml"
AddHtmlAttributeValue("", 107, Url.Action("Login", "Cliente"), 107, 31, false);

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
            BeginContext(733, 126, true);
            WriteLiteral("\r\n</main>\r\n\r\n<!-- <main>\r\n    <div class=\"menulogin\">\r\n        <h3 id=\"login\">Login</h3>\r\n        <form method=\"POST\" action=\'");
            EndContext();
            BeginContext(860, 30, false);
#line 32 "E:\RoleTop1\Views\Cliente\Login.cshtml"
                               Write(Url.Action("Login", "Cliente"));

#line default
#line hidden
            EndContext();
            BeginContext(890, 6, true);
            WriteLiteral("\'>\r\n\r\n");
            EndContext();
#line 34 "E:\RoleTop1\Views\Cliente\Login.cshtml"
             if(!string.IsNullOrEmpty(@Model.Mensagem))
            {

#line default
#line hidden
            BeginContext(968, 19, true);
            WriteLiteral("                <p>");
            EndContext();
            BeginContext(988, 14, false);
#line 36 "E:\RoleTop1\Views\Cliente\Login.cshtml"
              Write(Model.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(1002, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 37 "E:\RoleTop1\Views\Cliente\Login.cshtml"
            }

#line default
#line hidden
            BeginContext(1023, 675, true);
            WriteLiteral(@"            <div>
                <label for=""email"">Email</label>
                <input id=""email"" name=""email"" type=""email"">
            </div>
            <br>
            <div>
                <label for=""email"">Senha</label>
                <input id=""email"" name=""senha"" maxlength=""50"" type=""password"">
            </div>
        </form>
        <input class=""botao"" type=""submit"" value=""Entrar"">
        <br>
        <a asp-controller=""Cadastro"" asp-action=""Index"">Ainda não tem cadastro?</a>
    </div> -->
        <br>
        <div class=""redeslogin"">
            <div id=""face"">
                <p>Entre</p>
                <br>
                ");
            EndContext();
            BeginContext(1698, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3c397de0ae3645839fbaa22c74387d34", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1761, 164, true);
            WriteLiteral("\r\n            </div>\r\n            <div id=\"google\">\r\n                <p>Entre</p>\r\n                <br>\r\n                <div id=\"logogoogle\">\r\n                    ");
            EndContext();
            BeginContext(1925, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "01e62dff7dcb483d823a722a115aa1b7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1984, 47, true);
            WriteLiteral("\r\n                </div>\r\n    </div>\r\n</main>\r\n");
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
