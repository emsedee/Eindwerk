#pragma checksum "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e832da46e14a7ad0b02da9f4a4c41f22b076e6c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e832da46e14a7ad0b02da9f4a4c41f22b076e6c", @"/Views/Interventies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b0b6622c4097f5c03432eed49ff525bd06bcc39", @"/Views/_ViewImports.cshtml")]
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
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(142, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(171, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e832da46e14a7ad0b02da9f4a4c41f22b076e6c4898", async() => {
                BeginContext(194, 10, true);
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
            BeginContext(208, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(301, 48, false);
#line 17 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Complexiteit));

#line default
#line hidden
            EndContext();
            BeginContext(349, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(405, 49, false);
#line 20 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Meldingsdatum));

#line default
#line hidden
            EndContext();
            BeginContext(454, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(510, 48, false);
#line 23 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Omschrijving));

#line default
#line hidden
            EndContext();
            BeginContext(558, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(614, 45, false);
#line 26 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Einddatum));

#line default
#line hidden
            EndContext();
            BeginContext(659, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(715, 40, false);
#line 29 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Duur));

#line default
#line hidden
            EndContext();
            BeginContext(755, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(811, 63, false);
#line 32 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Verwachtteoplossingstermijn));

#line default
#line hidden
            EndContext();
            BeginContext(874, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(930, 57, false);
#line 35 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OmschrijvingOplossing));

#line default
#line hidden
            EndContext();
            BeginContext(987, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1043, 42, false);
#line 38 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1085, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1141, 42, false);
#line 41 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Bestel));

#line default
#line hidden
            EndContext();
            BeginContext(1183, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1239, 46, false);
#line 44 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Personeels));

#line default
#line hidden
            EndContext();
            BeginContext(1285, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1341, 46, false);
#line 47 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Prioriteit));

#line default
#line hidden
            EndContext();
            BeginContext(1387, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1443, 43, false);
#line 50 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Toestel));

#line default
#line hidden
            EndContext();
            BeginContext(1486, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1542, 51, false);
#line 53 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Toestel.Locatie));

#line default
#line hidden
            EndContext();
            BeginContext(1593, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 59 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1711, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1760, 47, false);
#line 62 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Complexiteit));

#line default
#line hidden
            EndContext();
            BeginContext(1807, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1863, 48, false);
#line 65 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Meldingsdatum));

#line default
#line hidden
            EndContext();
            BeginContext(1911, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1967, 47, false);
#line 68 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Omschrijving));

#line default
#line hidden
            EndContext();
            BeginContext(2014, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2070, 44, false);
#line 71 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Einddatum));

#line default
#line hidden
            EndContext();
            BeginContext(2114, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2170, 39, false);
#line 74 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Duur));

#line default
#line hidden
            EndContext();
            BeginContext(2209, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2265, 62, false);
#line 77 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Verwachtteoplossingstermijn));

#line default
#line hidden
            EndContext();
            BeginContext(2327, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2383, 56, false);
#line 80 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OmschrijvingOplossing));

#line default
#line hidden
            EndContext();
            BeginContext(2439, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2495, 41, false);
#line 83 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2536, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2592, 50, false);
#line 86 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bestel.BestelId));

#line default
#line hidden
            EndContext();
            BeginContext(2642, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2698, 54, false);
#line 89 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Personeels.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(2752, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2808, 57, false);
#line 92 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Prioriteit._Prioriteit));

#line default
#line hidden
            EndContext();
            BeginContext(2865, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2921, 47, false);
#line 95 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Toestel.Naam));

#line default
#line hidden
            EndContext();
            BeginContext(2968, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3024, 55, false);
#line 98 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Toestel.Locatie.Naam));

#line default
#line hidden
            EndContext();
            BeginContext(3079, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3134, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e832da46e14a7ad0b02da9f4a4c41f22b076e6c17533", async() => {
                BeginContext(3190, 4, true);
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
#line 101 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
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
            BeginContext(3198, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3218, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e832da46e14a7ad0b02da9f4a4c41f22b076e6c19882", async() => {
                BeginContext(3277, 7, true);
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
#line 102 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
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
            BeginContext(3288, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3308, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e832da46e14a7ad0b02da9f4a4c41f22b076e6c22237", async() => {
                BeginContext(3366, 6, true);
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
#line 103 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
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
            BeginContext(3376, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 106 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Interventies\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3415, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
