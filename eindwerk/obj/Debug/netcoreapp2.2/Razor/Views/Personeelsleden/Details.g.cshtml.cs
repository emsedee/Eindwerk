#pragma checksum "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Personeelsleden\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a13b3068940f84f8e6cae27a11bcf645bbded971"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personeelsleden_Details), @"mvc.1.0.view", @"/Views/Personeelsleden/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Personeelsleden/Details.cshtml", typeof(AspNetCore.Views_Personeelsleden_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a13b3068940f84f8e6cae27a11bcf645bbded971", @"/Views/Personeelsleden/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b0b6622c4097f5c03432eed49ff525bd06bcc39", @"/Views/_ViewImports.cshtml")]
    public class Views_Personeelsleden_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eindwerk.Entities.Personeelsleden>
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Personeelsleden\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(134, 138, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Personeelsleden</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(273, 40, false);
#line 15 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Personeelsleden\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Naam));

#line default
#line hidden
            EndContext();
            BeginContext(313, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(377, 36, false);
#line 18 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Personeelsleden\Details.cshtml"
       Write(Html.DisplayFor(model => model.Naam));

#line default
#line hidden
            EndContext();
            BeginContext(413, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(476, 44, false);
#line 21 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Personeelsleden\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Voornaam));

#line default
#line hidden
            EndContext();
            BeginContext(520, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(584, 40, false);
#line 24 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Personeelsleden\Details.cshtml"
       Write(Html.DisplayFor(model => model.Voornaam));

#line default
#line hidden
            EndContext();
            BeginContext(624, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(687, 45, false);
#line 27 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Personeelsleden\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GsmNummer));

#line default
#line hidden
            EndContext();
            BeginContext(732, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(796, 41, false);
#line 30 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Personeelsleden\Details.cshtml"
       Write(Html.DisplayFor(model => model.GsmNummer));

#line default
#line hidden
            EndContext();
            BeginContext(837, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(900, 46, false);
#line 33 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Personeelsleden\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Emailadres));

#line default
#line hidden
            EndContext();
            BeginContext(946, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1010, 42, false);
#line 36 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Personeelsleden\Details.cshtml"
       Write(Html.DisplayFor(model => model.Emailadres));

#line default
#line hidden
            EndContext();
            BeginContext(1052, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1115, 40, false);
#line 39 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Personeelsleden\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Foto));

#line default
#line hidden
            EndContext();
            BeginContext(1155, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1219, 36, false);
#line 42 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Personeelsleden\Details.cshtml"
       Write(Html.DisplayFor(model => model.Foto));

#line default
#line hidden
            EndContext();
            BeginContext(1255, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1318, 54, false);
#line 45 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Personeelsleden\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SoortPersoneelslid));

#line default
#line hidden
            EndContext();
            BeginContext(1372, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1436, 50, false);
#line 48 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Personeelsleden\Details.cshtml"
       Write(Html.DisplayFor(model => model.SoortPersoneelslid));

#line default
#line hidden
            EndContext();
            BeginContext(1486, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1533, 64, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a13b3068940f84f8e6cae27a11bcf645bbded9719328", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a13b3068940f84f8e6cae27a11bcf645bbded9719478", async() => {
>>>>>>> dev4
                BeginContext(1589, 4, true);
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
#line 53 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Personeelsleden\Details.cshtml"
                           WriteLiteral(Model.PersoneelsId);

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
            BeginContext(1597, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1605, 38, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a13b3068940f84f8e6cae27a11bcf645bbded97111655", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a13b3068940f84f8e6cae27a11bcf645bbded97111805", async() => {
>>>>>>> dev4
                BeginContext(1627, 12, true);
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
            BeginContext(1643, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eindwerk.Entities.Personeelsleden> Html { get; private set; }
    }
}
#pragma warning restore 1591
