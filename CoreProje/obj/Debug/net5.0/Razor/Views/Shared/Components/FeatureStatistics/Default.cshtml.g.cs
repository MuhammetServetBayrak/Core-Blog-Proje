#pragma checksum "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\Shared\Components\FeatureStatistics\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "237a292349fb4e2d208e89b0bdf86d5b8e6aeac8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FeatureStatistics_Default), @"mvc.1.0.view", @"/Views/Shared/Components/FeatureStatistics/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"237a292349fb4e2d208e89b0bdf86d5b8e6aeac8", @"/Views/Shared/Components/FeatureStatistics/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"420a9968a2b79939a38765cc478adf3d5ef0f418", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_FeatureStatistics_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
              <div class=""col-xl-3 col-sm-6 grid-margin stretch-card"">
                <div class=""card"">
                  <div class=""card-body"">
                    <div class=""row"">
                      <div class=""col-9"">
                        <div class=""d-flex align-items-center align-self-start"">
                          <h3 class=""mb-0"">");
#nullable restore
#line 8 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\Shared\Components\FeatureStatistics\Default.cshtml"
                                      Write(ViewBag.v1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        </div>
                      </div>
                      <div class=""col-3"">
                        <div class=""icon icon-box-success "">
                          <span class=""mdi mdi-arrow-top-right icon-item""></span>
                        </div>
                      </div>
                    </div>
                    <h6 class=""text-muted font-weight-normal"">Yetenek Sayısı</h6>
                  </div>
                </div>
              </div>
              <div class=""col-xl-3 col-sm-6 grid-margin stretch-card"">
                <div class=""card"">
                  <div class=""card-body"">
                    <div class=""row"">
                      <div class=""col-9"">
                        <div class=""d-flex align-items-center align-self-start"">
                          <h3 class=""mb-0"">");
#nullable restore
#line 27 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\Shared\Components\FeatureStatistics\Default.cshtml"
                                      Write(ViewBag.v2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        </div>
                      </div>
                      <div class=""col-3"">
                        <div class=""icon icon-box-success"">
                          <span class=""mdi mdi-arrow-top-right icon-item""></span>
                        </div>
                      </div>
                    </div>
                    <h6 class=""text-muted font-weight-normal"">Okunmamış Mesaj Sayısı</h6>
                  </div>
                </div>
              </div>
              <div class=""col-xl-3 col-sm-6 grid-margin stretch-card"">
                <div class=""card"">
                  <div class=""card-body"">
                    <div class=""row"">
                      <div class=""col-9"">
                        <div class=""d-flex align-items-center align-self-start"">
                          <h3 class=""mb-0"">");
#nullable restore
#line 46 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\Shared\Components\FeatureStatistics\Default.cshtml"
                                      Write(ViewBag.v3);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        </div>
                      </div>
                      <div class=""col-3"">
                        <div class=""icon icon-box-danger"">
                          <span class=""mdi mdi-arrow-bottom-left icon-item""></span>
                        </div>
                      </div>
                    </div>
                    <h6 class=""text-muted font-weight-normal"">Okunmuş Mesaj Sayısı</h6>
                  </div>
                </div>
              </div>
              <div class=""col-xl-3 col-sm-6 grid-margin stretch-card"">
                <div class=""card"">
                  <div class=""card-body"">
                    <div class=""row"">
                      <div class=""col-9"">
                        <div class=""d-flex align-items-center align-self-start"">
                          <h3 class=""mb-0"">");
#nullable restore
#line 65 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\Shared\Components\FeatureStatistics\Default.cshtml"
                                      Write(ViewBag.v4);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        </div>
                      </div>
                      <div class=""col-3"">
                        <div class=""icon icon-box-success "">
                          <span class=""mdi mdi-arrow-top-right icon-item""></span>
                        </div>
                      </div>
                    </div>
                    <h6 class=""text-muted font-weight-normal"">Deneyim Sayısı</h6>
                  </div>
                </div>
              </div>
            </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
