#pragma checksum "E:\Eindwerk\Eindwerk\Eindwerk\eindwerk\Views\Shared\sideBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71734f475ea1f52938d71cf64cd881889487fa8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_sideBar), @"mvc.1.0.view", @"/Views/Shared/sideBar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/sideBar.cshtml", typeof(AspNetCore.Views_Shared_sideBar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71734f475ea1f52938d71cf64cd881889487fa8a", @"/Views/Shared/sideBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b0b6622c4097f5c03432eed49ff525bd06bcc39", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_sideBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(15, 3443, true);
            WriteLiteral(@"<aside>
    <div id=""sidebar"" class=""nav-collapse"">
        <!-- sidebar menu start-->
        <ul class=""sidebar-menu"">
            <li class=""active"">
                <a class="""" href=""/index"">
                    <i class=""icon_house_alt""></i>
                    <span>Dashboard</span>
                </a>
            </li>
            <li class=""sub-menu"">
                <a href=""javascript:;"" class="""">
                    <i class=""icon_document_alt""></i>
                    <span>Toestellen</span>
                    <span class=""menu-arrow arrow_carrot-right""></span>
                </a>
                <ul class=""sub"">
                    <!--HREF = LINK NAAR CONTROLLER(toestel)-->
                    <li><a class="""" href=""/Toestel"">Toestel</a></li>
                    <li><a class="""" href=""form_validation.html"">Form Validation</a></li>
                    <li><a class="""" href=""form_component.html"">Form Elements</a></li>

                </ul>
            </li>
            <li");
            WriteLiteral(@" class=""sub-menu"">
                <a href=""javascript:;"" class="""">
                    <i class=""icon_profile""></i>
                    <span>Personeelsleden</span>
                    <span class=""menu-arrow arrow_carrot-right""></span>
                </a>
                <ul class=""sub"">
                    <li><a class="""" href=""/personeelsleden"">Alle Personeelsleden</a></li>
                    <li><a class="""" href=""/Kennisgebieden"">Kennisgebieden</a></li>
                    <li><a class="""" href=""buttons.html"">Alle techniekers</a></li>

                </ul>
            </li>
            <li class=""sub-menu"">
                <a href=""javascript:;"" class="""">
                    <i class=""icon_desktop""></i>
                    <span>Meldingen</span>
                    <span class=""menu-arrow arrow_carrot-right""></span>
                </a>
                <ul class=""sub"">

                    <li><a class="""" href=""/interventies/create"">Nieuwe meldingen</a></li>
                    <l");
            WriteLiteral(@"i><a class="""" href=""/interventies"">Alle meldingen</a></li>


                </ul>
            </li>
           
                


            <li class=""sub-menu"">
                <a href=""javascript:;"" class="""">
                    <i class=""icon_table""></i>
                    <span>Tables</span>
                    <span class=""menu-arrow arrow_carrot-right""></span>
                </a>
                <ul class=""sub"">
                    <li><a class="""" href=""/basic_table.html"">Basic Table</a></li>
                </ul>
            </li>

            <li class=""sub-menu"">
                <a href=""javascript:;"" class="""">
                    <i class=""icon_documents_alt""></i>
                    <span>Pages</span>
                    <span class=""menu-arrow arrow_carrot-right""></span>
                </a>
                <ul class=""sub"">
                    <li><a class="""" href=""profile.html"">Profile</a></li>
                    <li><a class="""" href=""login.html""><span>Login Pag");
            WriteLiteral(@"e</span></a></li>
                    <li><a class="""" href=""contact.html""><span>Contact Page</span></a></li>
                    <li><a class="""" href=""blank.html"">Blank Page</a></li>
                    <li><a class="""" href=""404.html"">404 Error</a></li>
                </ul>
            </li>

        </ul>
        <!-- sidebar menu end-->
    </div>
</aside>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
