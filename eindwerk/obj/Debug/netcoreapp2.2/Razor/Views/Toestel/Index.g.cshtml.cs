#pragma checksum "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81914fe55ca12580157d5c415e3307ccdb116c11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Toestel_Index), @"mvc.1.0.view", @"/Views/Toestel/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Toestel/Index.cshtml", typeof(AspNetCore.Views_Toestel_Index))]
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
#line 1 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\_ViewImports.cshtml"
using eindwerk;

#line default
#line hidden
#line 2 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\_ViewImports.cshtml"
using eindwerk.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81914fe55ca12580157d5c415e3307ccdb116c11", @"/Views/Toestel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3871df00a48f214334ed5c7506f687e1dea1fc11", @"/Views/_ViewImports.cshtml")]
    public class Views_Toestel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<eindwerk.Entities.Toestel>>
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
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(137, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(166, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81914fe55ca12580157d5c415e3307ccdb116c114739", async() => {
                BeginContext(189, 10, true);
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
            BeginContext(203, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(296, 40, false);
#line 17 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Naam));

#line default
#line hidden
            EndContext();
            BeginContext(336, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(392, 40, false);
#line 20 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Merk));

#line default
#line hidden
            EndContext();
            BeginContext(432, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(488, 43, false);
#line 23 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Keuring));

#line default
#line hidden
            EndContext();
            BeginContext(531, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(587, 44, false);
#line 26 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ouderdom));

#line default
#line hidden
            EndContext();
            BeginContext(631, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(687, 48, false);
#line 29 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Omschrijving));

#line default
#line hidden
            EndContext();
            BeginContext(735, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(791, 43, false);
#line 32 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Formaat));

#line default
#line hidden
            EndContext();
            BeginContext(834, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(890, 50, false);
#line 35 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MaximumGewicht));

#line default
#line hidden
            EndContext();
            BeginContext(940, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(996, 46, false);
#line 38 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TypeMatras));

#line default
#line hidden
            EndContext();
            BeginContext(1042, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1098, 51, false);
#line 41 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TypeAandrijving));

#line default
#line hidden
            EndContext();
            BeginContext(1149, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1205, 47, false);
#line 44 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Opplooibaar));

#line default
#line hidden
            EndContext();
            BeginContext(1252, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1308, 47, false);
#line 47 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Verstelbaar));

#line default
#line hidden
            EndContext();
            BeginContext(1355, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1411, 43, false);
#line 50 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Materie));

#line default
#line hidden
            EndContext();
            BeginContext(1454, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1510, 53, false);
#line 53 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DatumAfschrijving));

#line default
#line hidden
            EndContext();
            BeginContext(1563, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1619, 48, false);
#line 56 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SoortToestel));

#line default
#line hidden
            EndContext();
            BeginContext(1667, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1723, 43, false);
#line 59 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Locatie));

#line default
#line hidden
            EndContext();
            BeginContext(1766, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 65 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1884, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1933, 39, false);
#line 68 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Naam));

#line default
#line hidden
            EndContext();
            BeginContext(1972, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2028, 39, false);
#line 71 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Merk));

#line default
#line hidden
            EndContext();
            BeginContext(2067, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2123, 42, false);
#line 74 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Keuring));

#line default
#line hidden
            EndContext();
            BeginContext(2165, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2221, 43, false);
#line 77 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ouderdom));

#line default
#line hidden
            EndContext();
            BeginContext(2264, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2320, 47, false);
#line 80 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Omschrijving));

#line default
#line hidden
            EndContext();
            BeginContext(2367, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2423, 42, false);
#line 83 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Formaat));

#line default
#line hidden
            EndContext();
            BeginContext(2465, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2521, 49, false);
#line 86 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaximumGewicht));

#line default
#line hidden
            EndContext();
            BeginContext(2570, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2626, 45, false);
#line 89 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TypeMatras));

#line default
#line hidden
            EndContext();
            BeginContext(2671, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2727, 50, false);
#line 92 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TypeAandrijving));

#line default
#line hidden
            EndContext();
            BeginContext(2777, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2833, 46, false);
#line 95 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Opplooibaar));

#line default
#line hidden
            EndContext();
            BeginContext(2879, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2935, 46, false);
#line 98 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Verstelbaar));

#line default
#line hidden
            EndContext();
            BeginContext(2981, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3037, 42, false);
#line 101 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Materie));

#line default
#line hidden
            EndContext();
            BeginContext(3079, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3135, 52, false);
#line 104 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DatumAfschrijving));

#line default
#line hidden
            EndContext();
            BeginContext(3187, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3243, 47, false);
#line 107 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SoortToestel));

#line default
#line hidden
            EndContext();
            BeginContext(3290, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3346, 52, false);
#line 110 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Locatie.LocatieId));

#line default
#line hidden
            EndContext();
            BeginContext(3398, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3453, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81914fe55ca12580157d5c415e3307ccdb116c1119073", async() => {
                BeginContext(3505, 4, true);
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
#line 113 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
                                       WriteLiteral(item.ToestelId);

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
            BeginContext(3513, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3533, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81914fe55ca12580157d5c415e3307ccdb116c1121422", async() => {
                BeginContext(3588, 7, true);
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
#line 114 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
                                          WriteLiteral(item.ToestelId);

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
            BeginContext(3599, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3619, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81914fe55ca12580157d5c415e3307ccdb116c1123777", async() => {
                BeginContext(3673, 6, true);
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
#line 115 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
                                         WriteLiteral(item.ToestelId);

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
            BeginContext(3683, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 118 "C:\Users\Richard\source\repos\Eindwerk\eindwerk\Views\Toestel\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3722, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<eindwerk.Entities.Toestel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
