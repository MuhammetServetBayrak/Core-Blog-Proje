#pragma checksum "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\SocialMedia\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc9628f642f27c4ec47c9b86a651c171e8e7218a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SocialMedia_Index), @"mvc.1.0.view", @"/Views/SocialMedia/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\_ViewImports.cshtml"
using CoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\_ViewImports.cshtml"
using CoreProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\SocialMedia\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc9628f642f27c4ec47c9b86a651c171e8e7218a", @"/Views/SocialMedia/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"420a9968a2b79939a38765cc478adf3d5ef0f418", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SocialMedia_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SocialMedia>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\SocialMedia\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Sosyal Medya Hesapları</h4>

            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Başlık</th>
                            <th>Sil</th>
                            <th>Güncelle</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 24 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\SocialMedia\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 27 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\SocialMedia\Index.cshtml"
                               Write(item.SocialMediaID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 28 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\SocialMedia\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1000, "\"", 1057, 2);
            WriteAttributeValue("", 1007, "/SocialMedia/DeleteSocialMedia/", 1007, 31, true);
#nullable restore
#line 29 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\SocialMedia\Index.cshtml"
WriteAttributeValue("", 1038, item.SocialMediaID, 1038, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1142, "\"", 1197, 2);
            WriteAttributeValue("", 1149, "/SocialMedia/EditSocialMedia/", 1149, 29, true);
#nullable restore
#line 30 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\SocialMedia\Index.cshtml"
WriteAttributeValue("", 1178, item.SocialMediaID, 1178, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\SocialMedia\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                <a href=\"/SocialMedia/AddSocialMedia/\" class=\"btn btn-outline-info\">Yeni Hesap Ekle</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SocialMedia>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
