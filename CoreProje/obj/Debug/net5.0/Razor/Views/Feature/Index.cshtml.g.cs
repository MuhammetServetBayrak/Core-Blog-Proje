#pragma checksum "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\Feature\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2594e03c705e91ce4607e9ef518d987d67901ca4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feature_Index), @"mvc.1.0.view", @"/Views/Feature/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2594e03c705e91ce4607e9ef518d987d67901ca4", @"/Views/Feature/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"420a9968a2b79939a38765cc478adf3d5ef0f418", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Feature_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Feature>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\Feature\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\Feature\Index.cshtml"
 using (Html.BeginForm("Index","Feature",FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\Feature\Index.cshtml"
Write(Html.HiddenFor(x=>x.FeatureID));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 11 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\Feature\Index.cshtml"
Write(Html.Label("Başlık"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\Feature\Index.cshtml"
Write(Html.TextBoxFor(x=>x.Header, new{@class="form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 14 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\Feature\Index.cshtml"
Write(Html.Label("Ad Soyad"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\Feature\Index.cshtml"
Write(Html.TextBoxFor(x=>x.Name, new{@class="form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 17 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\Feature\Index.cshtml"
Write(Html.Label("Görev"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\Feature\Index.cshtml"
Write(Html.TextBoxFor(x=>x.Title, new{@class="form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n <button class=\"btn btn-success\">Kaydet</button>\r\n");
#nullable restore
#line 21 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\Feature\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Feature> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591