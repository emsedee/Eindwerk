#pragma checksum "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Areas\Identity\Pages\Account\Lockout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc2ae3ac1ce0688cc1584e99ace3f182955a51e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(eindwerk.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_Lockout), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Lockout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/Lockout.cshtml", typeof(eindwerk.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_Lockout), null)]
namespace eindwerk.Areas.Identity.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Areas\Identity\Pages\_ViewImports.cshtml"
using eindwerk.Areas.Identity;

#line default
#line hidden
#line 3 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 1 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using eindwerk.Areas.Identity.Pages.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc2ae3ac1ce0688cc1584e99ace3f182955a51e9", @"/Areas/Identity/Pages/Account/Lockout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10324a878c3235338ec7d61d9bbe022a15fca13d", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be59db4947508d9f9b2505e0d8003302632d152d", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Lockout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Areas\Identity\Pages\Account\Lockout.cshtml"
  
    ViewData["Title"] = "Locked out";

#line default
#line hidden
            BeginContext(69, 38, true);
            WriteLiteral("\n<header>\n    <h1 class=\"text-danger\">");
            EndContext();
            BeginContext(108, 17, false);
#line 8 "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Areas\Identity\Pages\Account\Lockout.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(125, 105, true);
            WriteLiteral("</h1>\n    <p class=\"text-danger\">This account has been locked out, please try again later.</p>\n</header>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LockoutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LockoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LockoutModel>)PageContext?.ViewData;
        public LockoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
