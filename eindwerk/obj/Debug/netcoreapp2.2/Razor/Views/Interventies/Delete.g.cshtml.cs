#pragma checksum "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "679f61395ac22e1aa555d9add8ccdb72de3068f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Interventies_Delete), @"mvc.1.0.view", @"/Views/Interventies/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Interventies/Delete.cshtml", typeof(AspNetCore.Views_Interventies_Delete))]
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
#line 1 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\_ViewImports.cshtml"
using eindwerk;

#line default
#line hidden
#line 2 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\_ViewImports.cshtml"
using eindwerk.Models;

#line default
#line hidden
#line 3 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"679f61395ac22e1aa555d9add8ccdb72de3068f3", @"/Views/Interventies/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b0b6622c4097f5c03432eed49ff525bd06bcc39", @"/Views/_ViewImports.cshtml")]
    public class Views_Interventies_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eindwerk.Entities.Interventies>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(130, 184, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Interventies</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(315, 49, false);
#line 17 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Meldingsdatum));

#line default
#line hidden
            EndContext();
            BeginContext(364, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(428, 45, false);
#line 20 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Meldingsdatum));

#line default
#line hidden
            EndContext();
            BeginContext(473, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(536, 48, false);
#line 23 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Omschrijving));

#line default
#line hidden
            EndContext();
            BeginContext(584, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(648, 44, false);
#line 26 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Omschrijving));

#line default
#line hidden
            EndContext();
            BeginContext(692, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(755, 45, false);
#line 29 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Einddatum));

#line default
#line hidden
            EndContext();
            BeginContext(800, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(864, 41, false);
#line 32 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Einddatum));

#line default
#line hidden
            EndContext();
            BeginContext(905, 83, true);
            WriteLiteral("\r\n        </dd>\r\n \r\n       \r\n       \r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(989, 57, false);
#line 38 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OmschrijvingOplossing));

#line default
#line hidden
            EndContext();
            BeginContext(1046, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1110, 53, false);
#line 41 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OmschrijvingOplossing));

#line default
#line hidden
            EndContext();
            BeginContext(1163, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1226, 42, false);
#line 44 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1268, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1332, 38, false);
#line 47 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1370, 78, true);
            WriteLiteral("\r\n        </dd>\r\n      \r\n      \r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1449, 46, false);
#line 52 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Personeels));

#line default
#line hidden
            EndContext();
            BeginContext(1495, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1559, 51, false);
#line 55 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Personeels.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(1610, 68, true);
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1679, 46, false);
#line 58 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Prioriteit));

#line default
#line hidden
            EndContext();
            BeginContext(1725, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1789, 54, false);
#line 61 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Prioriteit._Prioriteit));

#line default
#line hidden
            EndContext();
            BeginContext(1843, 68, true);
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1912, 43, false);
#line 64 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Toestel));

#line default
#line hidden
            EndContext();
            BeginContext(1955, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2019, 44, false);
#line 67 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Toestel.Naam));

#line default
#line hidden
            EndContext();
            BeginContext(2063, 44, true);
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2107, 217, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "679f61395ac22e1aa555d9add8ccdb72de3068f311939", async() => {
                BeginContext(2133, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2143, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "679f61395ac22e1aa555d9add8ccdb72de3068f312332", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 72 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.InterventieId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2190, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2273, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "679f61395ac22e1aa555d9add8ccdb72de3068f314241", async() => {
                    BeginContext(2295, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2311, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2324, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eindwerk.Entities.Interventies> Html { get; private set; }
    }
}
#pragma warning restore 1591
