#pragma checksum "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75f7a59d1d3353602390b6dde309351e20948dc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Interventies_Index), @"mvc.1.0.view", @"/Views/Interventies/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Interventies/Index.cshtml", typeof(AspNetCore.Views_Interventies_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75f7a59d1d3353602390b6dde309351e20948dc9", @"/Views/Interventies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"749a674558c5d6fa0d01cae030ace8abd8de71a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Interventies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<eindwerk.Entities.Interventies>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(51, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(136, 25, true);
            WriteLiteral("\n<h1>Index</h1>\n\n<p>\n    ");
            EndContext();
            BeginContext(161, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75f7a59d1d3353602390b6dde309351e20948dc94885", async() => {
                BeginContext(184, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(198, 99, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            \n            <th>\n                ");
            EndContext();
            BeginContext(298, 49, false);
#line 18 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Meldingsdatum));

#line default
#line hidden
            EndContext();
            BeginContext(347, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(400, 48, false);
#line 21 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Omschrijving));

#line default
#line hidden
            EndContext();
            BeginContext(448, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(501, 45, false);
#line 24 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Einddatum));

#line default
#line hidden
            EndContext();
            BeginContext(546, 64, true);
            WriteLiteral("\n            </th>\n\n          \n            <th>\n                ");
            EndContext();
            BeginContext(611, 57, false);
#line 29 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OmschrijvingOplossing));

#line default
#line hidden
            EndContext();
            BeginContext(668, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(721, 42, false);
#line 32 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(763, 56, true);
            WriteLiteral("\n            </th>\n   \n            <th>\n                ");
            EndContext();
            BeginContext(820, 46, false);
#line 36 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Personeels));

#line default
#line hidden
            EndContext();
            BeginContext(866, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(919, 46, false);
#line 39 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Prioriteit));

#line default
#line hidden
            EndContext();
            BeginContext(965, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1018, 43, false);
#line 42 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Toestel));

#line default
#line hidden
            EndContext();
            BeginContext(1061, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1114, 51, false);
#line 45 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Toestel.Locatie));

#line default
#line hidden
            EndContext();
            BeginContext(1165, 80, true);
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 51 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1276, 59, true);
            WriteLiteral("        <tr>\n            \n            <td>\n                ");
            EndContext();
            BeginContext(1336, 48, false);
#line 55 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Meldingsdatum));

#line default
#line hidden
            EndContext();
            BeginContext(1384, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1437, 47, false);
#line 58 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Omschrijving));

#line default
#line hidden
            EndContext();
            BeginContext(1484, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1537, 44, false);
#line 61 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Einddatum));

#line default
#line hidden
            EndContext();
            BeginContext(1581, 53, true);
            WriteLiteral("\n            </td>\n\n            <td>\n                ");
            EndContext();
            BeginContext(1635, 56, false);
#line 65 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OmschrijvingOplossing));

#line default
#line hidden
            EndContext();
            BeginContext(1691, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1744, 41, false);
#line 68 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1785, 58, true);
            WriteLiteral("\n            </td>\n     \n            <td>\n                ");
            EndContext();
            BeginContext(1844, 54, false);
#line 72 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Personeels.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(1898, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1951, 57, false);
#line 75 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Prioriteit._Prioriteit));

#line default
#line hidden
            EndContext();
            BeginContext(2008, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2061, 47, false);
#line 78 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Toestel.Naam));

#line default
#line hidden
            EndContext();
            BeginContext(2108, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2161, 55, false);
#line 81 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Toestel.Locatie.Naam));

#line default
#line hidden
            EndContext();
            BeginContext(2216, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2268, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75f7a59d1d3353602390b6dde309351e20948dc914110", async() => {
                BeginContext(2324, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 84 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
                                       WriteLiteral(item.InterventieId);

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
            BeginContext(2332, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(2351, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75f7a59d1d3353602390b6dde309351e20948dc916456", async() => {
                BeginContext(2410, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 85 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
                                          WriteLiteral(item.InterventieId);

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
            BeginContext(2421, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(2440, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75f7a59d1d3353602390b6dde309351e20948dc918808", async() => {
                BeginContext(2498, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 86 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
                                         WriteLiteral(item.InterventieId);

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
            BeginContext(2508, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 89 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2543, 22, true);
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<eindwerk.Entities.Interventies>> Html { get; private set; }
    }
}
#pragma warning restore 1591
