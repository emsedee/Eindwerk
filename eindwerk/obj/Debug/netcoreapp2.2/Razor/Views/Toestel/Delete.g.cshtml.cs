#pragma checksum "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4952c9410a60e5d20b12f6b5e4f3660eea93de55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Toestel_Delete), @"mvc.1.0.view", @"/Views/Toestel/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Toestel/Delete.cshtml", typeof(AspNetCore.Views_Toestel_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4952c9410a60e5d20b12f6b5e4f3660eea93de55", @"/Views/Toestel/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"749a674558c5d6fa0d01cae030ace8abd8de71a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Toestel_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eindwerk.Entities.Toestel>
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
            BeginContext(33, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(119, 168, true);
            WriteLiteral("\n<h1>Delete</h1>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <h4>Toestel</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(288, 40, false);
#line 16 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Naam));

#line default
#line hidden
            EndContext();
            BeginContext(328, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(389, 36, false);
#line 19 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Naam));

#line default
#line hidden
            EndContext();
            BeginContext(425, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(485, 40, false);
#line 22 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Merk));

#line default
#line hidden
            EndContext();
            BeginContext(525, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(586, 36, false);
#line 25 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Merk));

#line default
#line hidden
            EndContext();
            BeginContext(622, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(682, 43, false);
#line 28 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Keuring));

#line default
#line hidden
            EndContext();
            BeginContext(725, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(786, 39, false);
#line 31 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Keuring));

#line default
#line hidden
            EndContext();
            BeginContext(825, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(885, 44, false);
#line 34 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Ouderdom));

#line default
#line hidden
            EndContext();
            BeginContext(929, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(990, 40, false);
#line 37 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ouderdom));

#line default
#line hidden
            EndContext();
            BeginContext(1030, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1090, 48, false);
#line 40 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Omschrijving));

#line default
#line hidden
            EndContext();
            BeginContext(1138, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1199, 44, false);
#line 43 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Omschrijving));

#line default
#line hidden
            EndContext();
            BeginContext(1243, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1303, 43, false);
#line 46 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Formaat));

#line default
#line hidden
            EndContext();
            BeginContext(1346, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1407, 39, false);
#line 49 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Formaat));

#line default
#line hidden
            EndContext();
            BeginContext(1446, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1506, 50, false);
#line 52 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaximumGewicht));

#line default
#line hidden
            EndContext();
            BeginContext(1556, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1617, 46, false);
#line 55 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaximumGewicht));

#line default
#line hidden
            EndContext();
            BeginContext(1663, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1723, 46, false);
#line 58 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TypeMatras));

#line default
#line hidden
            EndContext();
            BeginContext(1769, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1830, 42, false);
#line 61 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TypeMatras));

#line default
#line hidden
            EndContext();
            BeginContext(1872, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1932, 51, false);
#line 64 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TypeAandrijving));

#line default
#line hidden
            EndContext();
            BeginContext(1983, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2044, 47, false);
#line 67 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TypeAandrijving));

#line default
#line hidden
            EndContext();
            BeginContext(2091, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2151, 47, false);
#line 70 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Opplooibaar));

#line default
#line hidden
            EndContext();
            BeginContext(2198, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2259, 43, false);
#line 73 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Opplooibaar));

#line default
#line hidden
            EndContext();
            BeginContext(2302, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2362, 47, false);
#line 76 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Verstelbaar));

#line default
#line hidden
            EndContext();
            BeginContext(2409, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2470, 43, false);
#line 79 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Verstelbaar));

#line default
#line hidden
            EndContext();
            BeginContext(2513, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2573, 43, false);
#line 82 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Materie));

#line default
#line hidden
            EndContext();
            BeginContext(2616, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2677, 39, false);
#line 85 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Materie));

#line default
#line hidden
            EndContext();
            BeginContext(2716, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2776, 53, false);
#line 88 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DatumAfschrijving));

#line default
#line hidden
            EndContext();
            BeginContext(2829, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2890, 49, false);
#line 91 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DatumAfschrijving));

#line default
#line hidden
            EndContext();
            BeginContext(2939, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2999, 48, false);
#line 94 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SoortToestel));

#line default
#line hidden
            EndContext();
            BeginContext(3047, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(3108, 44, false);
#line 97 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SoortToestel));

#line default
#line hidden
            EndContext();
            BeginContext(3152, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(3212, 43, false);
#line 100 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Locatie));

#line default
#line hidden
            EndContext();
            BeginContext(3255, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(3316, 44, false);
#line 103 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Locatie.Naam));

#line default
#line hidden
            EndContext();
            BeginContext(3360, 40, true);
            WriteLiteral("\n        </dd class>\n    </dl>\n    \n    ");
            EndContext();
            BeginContext(3400, 209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4952c9410a60e5d20b12f6b5e4f3660eea93de5517285", async() => {
                BeginContext(3426, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(3435, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4952c9410a60e5d20b12f6b5e4f3660eea93de5517675", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 108 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ToestelId);

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
                BeginContext(3478, 81, true);
                WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\n        ");
                EndContext();
                BeginContext(3559, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4952c9410a60e5d20b12f6b5e4f3660eea93de5519572", async() => {
                    BeginContext(3581, 12, true);
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
                BeginContext(3597, 5, true);
                WriteLiteral("\n    ");
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
            BeginContext(3609, 8, true);
            WriteLiteral("\n</div>\n");
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
