#pragma checksum "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\Shared\Components\SkillList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "875715eac49b451efef84f364241b9febb13b5da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SkillList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SkillList/Default.cshtml")]
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
#line 1 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\Shared\Components\SkillList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"875715eac49b451efef84f364241b9febb13b5da", @"/Views/Shared/Components/SkillList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"420a9968a2b79939a38765cc478adf3d5ef0f418", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_SkillList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Skill>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""section px-3 px-lg-4 pt-5"" id=""skills"">
  <div class=""container-narrow"">
    <div class=""text-center mb-5"">
      <h2 class=""marker marker-center"">Yeteneklerim</h2>
    </div>
    <div class=""text-center"">
      <p class=""mx-auto mb-3"" style=""max-width:600px"">Aşağıda bildiğim programlama dilleri ve teknolojiler üzerine bir bar listesi bulunmaktadır.Temel algoritma ve Nesne Tabanlı Programlama konularını iyi kavradığım için yeni bir programlama dilini öğrenmek benim için oldukça hızlı gerçekleşen bir durumdur.</p>
    </div>
    <div class=""bg-light p-3"">
      <div class=""row"">
        <div class=""col-md-12"">
");
#nullable restore
#line 16 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\Shared\Components\SkillList\Default.cshtml"
             foreach (var item in Model)
                    {
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("          <div class=\"py-1\">\r\n            <div class=\"d-flex text-small fw-bolder\"><span class=\"me-auto\">");
#nullable restore
#line 20 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\Shared\Components\SkillList\Default.cshtml"
                                                                      Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span>");
#nullable restore
#line 20 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\Shared\Components\SkillList\Default.cshtml"
                                                                                              Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span></div>\r\n            <div class=\"progress my-1\">\r\n              <div class=\"progress-bar bg-primary\" role=\"progressbar\" data-aos=\"zoom-in-right\" data-aos-delay=\"100\" data-aos-anchor=\".skills-section\"");
            BeginWriteAttribute("style", " style=\"", 1127, "\"", 1154, 3);
            WriteAttributeValue("", 1135, "width:", 1135, 6, true);
#nullable restore
#line 22 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\Shared\Components\SkillList\Default.cshtml"
WriteAttributeValue(" ", 1141, item.Value, 1142, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1153, "%", 1153, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 1155, "\"", 1182, 1);
#nullable restore
#line 22 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\Shared\Components\SkillList\Default.cshtml"
WriteAttributeValue("", 1171, item.Value, 1171, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n            </div>\r\n          </div>        \r\n");
#nullable restore
#line 25 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\Shared\Components\SkillList\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("          </div>\r\n\r\n      </div>\r\n    </div>\r\n  </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Skill>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
