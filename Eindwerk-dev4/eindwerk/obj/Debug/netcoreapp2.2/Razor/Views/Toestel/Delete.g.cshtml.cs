#pragma checksum "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "faaa0167992bd9315152185eac60dfdd55a00c6c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faaa0167992bd9315152185eac60dfdd55a00c6c", @"/Views/Toestel/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b0b6622c4097f5c03432eed49ff525bd06bcc39", @"/Views/_ViewImports.cshtml")]
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
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(125, 177, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Toestel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(303, 40, false);
#line 16 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Naam));

#line default
#line hidden
            EndContext();
            BeginContext(343, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(407, 36, false);
#line 19 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Naam));

#line default
#line hidden
            EndContext();
            BeginContext(443, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(506, 40, false);
#line 22 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Merk));

#line default
#line hidden
            EndContext();
            BeginContext(546, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(610, 36, false);
#line 25 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Merk));

#line default
#line hidden
            EndContext();
            BeginContext(646, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(709, 43, false);
#line 28 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Keuring));

#line default
#line hidden
            EndContext();
            BeginContext(752, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(816, 39, false);
#line 31 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Keuring));

#line default
#line hidden
            EndContext();
            BeginContext(855, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(918, 44, false);
#line 34 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Ouderdom));

#line default
#line hidden
            EndContext();
            BeginContext(962, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1026, 40, false);
#line 37 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ouderdom));

#line default
#line hidden
            EndContext();
            BeginContext(1066, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1129, 48, false);
#line 40 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Omschrijving));

#line default
#line hidden
            EndContext();
            BeginContext(1177, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1241, 44, false);
#line 43 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Omschrijving));

#line default
#line hidden
            EndContext();
            BeginContext(1285, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1348, 43, false);
#line 46 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Formaat));

#line default
#line hidden
            EndContext();
            BeginContext(1391, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1455, 39, false);
#line 49 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Formaat));

#line default
#line hidden
            EndContext();
            BeginContext(1494, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1557, 50, false);
#line 52 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaximumGewicht));

#line default
#line hidden
            EndContext();
            BeginContext(1607, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1671, 46, false);
#line 55 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaximumGewicht));

#line default
#line hidden
            EndContext();
            BeginContext(1717, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1780, 46, false);
#line 58 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TypeMatras));

#line default
#line hidden
            EndContext();
            BeginContext(1826, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1890, 42, false);
#line 61 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TypeMatras));

#line default
#line hidden
            EndContext();
            BeginContext(1932, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1995, 51, false);
#line 64 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TypeAandrijving));

#line default
#line hidden
            EndContext();
            BeginContext(2046, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2110, 47, false);
#line 67 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TypeAandrijving));

#line default
#line hidden
            EndContext();
            BeginContext(2157, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2220, 47, false);
#line 70 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Opplooibaar));

#line default
#line hidden
            EndContext();
            BeginContext(2267, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2331, 43, false);
#line 73 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Opplooibaar));

#line default
#line hidden
            EndContext();
            BeginContext(2374, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2437, 47, false);
#line 76 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Verstelbaar));

#line default
#line hidden
            EndContext();
            BeginContext(2484, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2548, 43, false);
#line 79 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Verstelbaar));

#line default
#line hidden
            EndContext();
            BeginContext(2591, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2654, 43, false);
#line 82 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Materie));

#line default
#line hidden
            EndContext();
            BeginContext(2697, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2761, 39, false);
#line 85 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Materie));

#line default
#line hidden
            EndContext();
            BeginContext(2800, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2863, 53, false);
#line 88 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DatumAfschrijving));

#line default
#line hidden
            EndContext();
            BeginContext(2916, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2980, 49, false);
#line 91 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DatumAfschrijving));

#line default
#line hidden
            EndContext();
            BeginContext(3029, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3092, 48, false);
#line 94 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SoortToestel));

#line default
#line hidden
            EndContext();
            BeginContext(3140, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3204, 44, false);
#line 97 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SoortToestel));

#line default
#line hidden
            EndContext();
            BeginContext(3248, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3311, 43, false);
#line 100 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Locatie));

#line default
#line hidden
            EndContext();
            BeginContext(3354, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3418, 44, false);
#line 103 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Toestel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Locatie.Naam));

#line default
#line hidden
            EndContext();
            BeginContext(3462, 44, true);
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(3506, 213, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "faaa0167992bd9315152185eac60dfdd55a00c6c17491", async() => {
                BeginContext(3532, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3542, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "faaa0167992bd9315152185eac60dfdd55a00c6c17884", async() => {
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
                BeginContext(3585, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(3668, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "faaa0167992bd9315152185eac60dfdd55a00c6c19785", async() => {
                    BeginContext(3690, 12, true);
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
                BeginContext(3706, 6, true);
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
            BeginContext(3719, 10, true);
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
