#pragma checksum "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e20288b1cf7f9a2a88f8b0e13769b5c38cd497f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Toestel_Details), @"mvc.1.0.view", @"/Views/Toestel/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Toestel/Details.cshtml", typeof(AspNetCore.Views_Toestel_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e20288b1cf7f9a2a88f8b0e13769b5c38cd497f", @"/Views/Toestel/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b0b6622c4097f5c03432eed49ff525bd06bcc39", @"/Views/_ViewImports.cshtml")]
    public class Views_Toestel_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eindwerk.Entities.Toestel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(126, 130, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Toestel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(257, 40, false);
#line 15 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Naam));

#line default
#line hidden
            EndContext();
            BeginContext(297, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(361, 36, false);
#line 18 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayFor(model => model.Naam));

#line default
#line hidden
            EndContext();
            BeginContext(397, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(460, 40, false);
#line 21 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Merk));

#line default
#line hidden
            EndContext();
            BeginContext(500, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(564, 36, false);
#line 24 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayFor(model => model.Merk));

#line default
#line hidden
            EndContext();
            BeginContext(600, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(663, 43, false);
#line 27 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Keuring));

#line default
#line hidden
            EndContext();
            BeginContext(706, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(770, 39, false);
#line 30 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayFor(model => model.Keuring));

#line default
#line hidden
            EndContext();
            BeginContext(809, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(872, 44, false);
#line 33 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ouderdom));

#line default
#line hidden
            EndContext();
            BeginContext(916, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(980, 40, false);
#line 36 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ouderdom));

#line default
#line hidden
            EndContext();
            BeginContext(1020, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1083, 48, false);
#line 39 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Omschrijving));

#line default
#line hidden
            EndContext();
            BeginContext(1131, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1195, 44, false);
#line 42 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayFor(model => model.Omschrijving));

#line default
#line hidden
            EndContext();
            BeginContext(1239, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1302, 43, false);
#line 45 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Formaat));

#line default
#line hidden
            EndContext();
            BeginContext(1345, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1409, 39, false);
#line 48 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayFor(model => model.Formaat));

#line default
#line hidden
            EndContext();
            BeginContext(1448, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1511, 50, false);
#line 51 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaximumGewicht));

#line default
#line hidden
            EndContext();
            BeginContext(1561, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1625, 46, false);
#line 54 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaximumGewicht));

#line default
#line hidden
            EndContext();
            BeginContext(1671, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1734, 46, false);
#line 57 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TypeMatras));

#line default
#line hidden
            EndContext();
            BeginContext(1780, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1844, 42, false);
#line 60 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayFor(model => model.TypeMatras));

#line default
#line hidden
            EndContext();
            BeginContext(1886, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1949, 51, false);
#line 63 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TypeAandrijving));

#line default
#line hidden
            EndContext();
            BeginContext(2000, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2064, 47, false);
#line 66 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayFor(model => model.TypeAandrijving));

#line default
#line hidden
            EndContext();
            BeginContext(2111, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2174, 47, false);
#line 69 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Opplooibaar));

#line default
#line hidden
            EndContext();
            BeginContext(2221, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2285, 43, false);
#line 72 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayFor(model => model.Opplooibaar));

#line default
#line hidden
            EndContext();
            BeginContext(2328, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2391, 47, false);
#line 75 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Verstelbaar));

#line default
#line hidden
            EndContext();
            BeginContext(2438, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2502, 43, false);
#line 78 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayFor(model => model.Verstelbaar));

#line default
#line hidden
            EndContext();
            BeginContext(2545, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2608, 43, false);
#line 81 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Materie));

#line default
#line hidden
            EndContext();
            BeginContext(2651, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2715, 39, false);
#line 84 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayFor(model => model.Materie));

#line default
#line hidden
            EndContext();
            BeginContext(2754, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2817, 53, false);
#line 87 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DatumAfschrijving));

#line default
#line hidden
            EndContext();
            BeginContext(2870, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2934, 49, false);
#line 90 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayFor(model => model.DatumAfschrijving));

#line default
#line hidden
            EndContext();
            BeginContext(2983, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3046, 48, false);
#line 93 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SoortToestel));

#line default
#line hidden
            EndContext();
            BeginContext(3094, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3158, 44, false);
#line 96 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayFor(model => model.SoortToestel));

#line default
#line hidden
            EndContext();
            BeginContext(3202, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3265, 43, false);
#line 99 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Locatie));

#line default
#line hidden
            EndContext();
            BeginContext(3308, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3372, 44, false);
#line 102 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
       Write(Html.DisplayFor(model => model.Locatie.Naam));

#line default
#line hidden
            EndContext();
            BeginContext(3416, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3463, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e20288b1cf7f9a2a88f8b0e13769b5c38cd497f16774", async() => {
                BeginContext(3516, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 107 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Details.cshtml"
                           WriteLiteral(Model.ToestelId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3524, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3532, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e20288b1cf7f9a2a88f8b0e13769b5c38cd497f19092", async() => {
                BeginContext(3554, 12, true);
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
            BeginContext(3570, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eindwerk.Entities.Toestel> Html { get; private set; }
    }
}
#pragma warning restore 1591
