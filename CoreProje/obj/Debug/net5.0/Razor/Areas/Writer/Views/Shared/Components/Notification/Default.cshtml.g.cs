#pragma checksum "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0854fe8b101fbad2c2fbfd1c950d79aeeb7a769"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Shared_Components_Notification_Default), @"mvc.1.0.view", @"/Areas/Writer/Views/Shared/Components/Notification/Default.cshtml")]
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
#line 1 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0854fe8b101fbad2c2fbfd1c950d79aeeb7a769", @"/Areas/Writer/Views/Shared/Components/Notification/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0016b6767730c936e45b5440b0aea7bd14cb65d3", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Shared_Components_Notification_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Announcement>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
  
    string color = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"dropdown-menu dropdown-menu-right navbar-dropdown preview-list\" aria-labelledby=\"notificationDropdown\">\r\n    <p class=\"mb-0 font-weight-normal float-left dropdown-header\">Bildirimler</p>\r\n");
#nullable restore
#line 11 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
     foreach (var item in Model)
    {
        if (item.Status == "Yeni Proje")
        {
            color = "preview-icon bg-success";
        }
        if (item.Status == "Yeni Video")
        {
            color = "preview-icon bg-warning";
        }
        if (item.Status == "Yeni Yazı")
        {
            color = "preview-icon bg-info";
        }
        if (item.Status == "Konferans")
        {
            color = "preview-icon bg-danger";
        }
        if (item.Status == "Bootcamp")
        {
            color = "preview-icon bg-success";
        }
        if (item.Status == "Workshop")
        {
            color = "preview-icon bg-primary";
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a class=\"dropdown-item preview-item\" href=\"/Writer/Default/AnnouncementDetails/\">\r\n            <div class=\"preview-thumbnail\">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 1153, "\"", 1167, 1);
#nullable restore
#line 39 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
WriteAttributeValue("", 1161, color, 1161, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i class=\"ti-info-alt mx-0\"></i>\r\n                </div>\r\n            </div>\r\n            <div class=\"preview-item-content\">\r\n                <h6 class=\"preview-subject font-weight-normal\">");
#nullable restore
#line 44 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
                                                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <p class=\"font-weight-light small-text mb-0 text-muted\">\r\n                    ");
#nullable restore
#line 46 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
               Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </a>\r\n");
#nullable restore
#line 50 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Announcement>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
