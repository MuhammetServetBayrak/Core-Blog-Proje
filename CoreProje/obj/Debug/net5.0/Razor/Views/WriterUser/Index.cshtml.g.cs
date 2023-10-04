#pragma checksum "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\WriterUser\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "784f4d26186415cd0acf44008a3df7c1ed2d44d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WriterUser_Index), @"mvc.1.0.view", @"/Views/WriterUser/Index.cshtml")]
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
#line 1 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\WriterUser\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"784f4d26186415cd0acf44008a3df7c1ed2d44d8", @"/Views/WriterUser/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"420a9968a2b79939a38765cc478adf3d5ef0f418", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_WriterUser_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WriterUser>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\WriterUser\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-md-6"">
    <div class=""p-2"">
        <button type=""button"" id=""btnGetlistAll"" class=""btn btn-outline-primary"">Verileri Getir</button>
        <button type=""button"" id=""btnAddUser"" class=""btn btn-outline-primary"">Kaydet</button>
    </div>
</div>

<h4 class=""text-center"">Yazar Listesi</h4>
<div class=""p-2"" id=""listuser"">
    Buraya Veriler Gelecek listuser İd'ye bağlı olarak
</div>


<br />

<div class=""col-md-12"">
    <input type=""text"" class=""form-control"" id=""inpName"" placeholder=""Ad"">
    <br />
    <input type=""text"" class=""form-control"" id=""inpSurname"" placeholder=""Soyad"">
    <br />
    <input type=""text"" class=""form-control"" id=""inpUsername"" placeholder=""Kullanıcı Adınız"">
    <br />
    <input type=""text"" class=""form-control"" id=""inpMail"" placeholder=""Mail"">
    

    
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
         $(""#getlistall"").click(function() {         //Bu satır, #getlistall id'sine sahip bir HTML öğesine tıklanıldığında çalışacak bir işlevin başlangıcını işaret eder. Yani, bu kod, belirli bir HTML öğesine tıklama olayına yanıt verir.
             $.ajax({                              //AJAX isteğini başlatmak için kullanılan $.ajax fonksiyonunun başlangıcı.
                 contentType: ""application/json"",  //Bu satır, isteğin içeriğinin JSON türünde olduğunu belirtir. Yani, sunucuya gönderilecek veri JSON formatında olmalıdır.
                 dataType: ""json"",                 //Bu satır, sunucudan alınacak yanıtın JSON formatında olduğunu belirtir. Yani, sunucudan gelen veriyi JSON olarak bekliyoruz.
                 type: ""Get"",                      //Bu satır, AJAX isteğinin HTTP GET yöntemiyle gönderileceğini belirtir. Yani, sunucudan veri almak için GET isteği kullanılacak.
                 url: ""/WriterUser/ListUser/"",     //Bu satır, isteğin gönderileceği URL'yi belirtir. Bu");
                WriteLiteral(@" URL, sunucuda ListUser adlı bir işlemi çağırmak için kullanılacak.

                 success: function(funk) {         //AJAX isteği başarılı olduğunda çalışacak işlevin başlangıcı. funk adında bir parametre alır, bu parametre sunucudan gelen yanıtı temsil eder.
                     let users = jQuery.parseJSON(funk);  //Bu satır, sunucudan gelen JSON yanıtını işlemek için kullanılır. funk değişkenini JSON formatından JavaScript nesnesine dönüştürür ve sonucu users değişkenine atar.
                     console.log(users);           //Bu satır, users değişkenini tarayıcı konsoluna yazdırır. Bu sayede sunucudan gelen kullanıcı verilerini konsolda görebiliriz.
                 }
             });
         });
    </script>
");
            }
            );
            WriteLiteral(" ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "784f4d26186415cd0acf44008a3df7c1ed2d44d86855", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" <!-- jQuery kütüphanesini bir HTML sayfasına eklemek için kullanılan bir HTML-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WriterUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
