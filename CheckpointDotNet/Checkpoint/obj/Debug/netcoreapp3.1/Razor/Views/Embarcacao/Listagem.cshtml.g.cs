#pragma checksum "C:\Users\CLIENTE\Documents\GitHub\CheckpointDotNet\CheckpointDotNet\Checkpoint\Views\Embarcacao\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c64410cb4b2a2eaa2b804ed81c572c5444461e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Embarcacao_Listagem), @"mvc.1.0.view", @"/Views/Embarcacao/Listagem.cshtml")]
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
#line 1 "C:\Users\CLIENTE\Documents\GitHub\CheckpointDotNet\CheckpointDotNet\Checkpoint\Views\_ViewImports.cshtml"
using Checkpoint;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CLIENTE\Documents\GitHub\CheckpointDotNet\CheckpointDotNet\Checkpoint\Views\_ViewImports.cshtml"
using Checkpoint.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c64410cb4b2a2eaa2b804ed81c572c5444461e3", @"/Views/Embarcacao/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8be7b779f816e0076ee8d85cf9147dc577565134", @"/Views/_ViewImports.cshtml")]
    public class Views_Embarcacao_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Embarcacao>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Alterar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<h1 style=""text-align: center"">Listagem das embarcações</h1>


<table class=""table table-dark table-hover w-100 mt-5"">
    <thead>
        <tr>
            <th scope=""col"">Nome</th>
            <th scope=""col"">Milhas navegadas</th>
            <th scope=""col"">Condição</th>
            <th scope=""col"">Porte</th>
            <th scope=""col"">Turístico</th>
        </tr>
    </thead>
");
#nullable restore
#line 17 "C:\Users\CLIENTE\Documents\GitHub\CheckpointDotNet\CheckpointDotNet\Checkpoint\Views\Embarcacao\Listagem.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tbody>\r\n            <tr class=\"table table-primary table-striped text-black-50\">\r\n                <th scope=\"row\">");
#nullable restore
#line 21 "C:\Users\CLIENTE\Documents\GitHub\CheckpointDotNet\CheckpointDotNet\Checkpoint\Views\Embarcacao\Listagem.cshtml"
                           Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\CLIENTE\Documents\GitHub\CheckpointDotNet\CheckpointDotNet\Checkpoint\Views\Embarcacao\Listagem.cshtml"
               Write(item.MilhasNavegadas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\CLIENTE\Documents\GitHub\CheckpointDotNet\CheckpointDotNet\Checkpoint\Views\Embarcacao\Listagem.cshtml"
               Write(item.Condicao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\CLIENTE\Documents\GitHub\CheckpointDotNet\CheckpointDotNet\Checkpoint\Views\Embarcacao\Listagem.cshtml"
               Write(item.Porte);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\CLIENTE\Documents\GitHub\CheckpointDotNet\CheckpointDotNet\Checkpoint\Views\Embarcacao\Listagem.cshtml"
               Write(item.Turistico);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c64410cb4b2a2eaa2b804ed81c572c5444461e36119", async() => {
                WriteLiteral("Alterar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </tr>\r\n        </tbody>\r\n");
#nullable restore
#line 29 "C:\Users\CLIENTE\Documents\GitHub\CheckpointDotNet\CheckpointDotNet\Checkpoint\Views\Embarcacao\Listagem.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Embarcacao>> Html { get; private set; }
    }
}
#pragma warning restore 1591
