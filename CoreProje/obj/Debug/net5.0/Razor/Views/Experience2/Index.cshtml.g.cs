#pragma checksum "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\Experience2\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8df293e1358923e0516879e1aa5d859dafc9ce75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Experience2_Index), @"mvc.1.0.view", @"/Views/Experience2/Index.cshtml")]
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
#line 1 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\Experience2\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8df293e1358923e0516879e1aa5d859dafc9ce75", @"/Views/Experience2/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"420a9968a2b79939a38765cc478adf3d5ef0f418", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Experience2_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Experience>>
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
#line 3 "C:\Users\muhammet\Desktop\Core1Proje\CoreProje\CoreProje\Views\Experience2\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-md-6"">
    <div class=""p-2"">
        <button type=""button"" id=""btngetlistall"" class=""btn btn-outline-primary"">Verileri Getir</button>
        <button type=""button"" id=""btnadd"" class=""btn btn-outline-info"">Kaydet</button>
        <button type=""button"" id=""btnid"" class=""btn btn-outline-warning"">Id ile Getir</button>
        <button type=""button"" id=""btndelete"" class=""btn btn-outline-danger"">Sil</button>
        <button type=""button"" id=""btnupdate"" class=""btn btn-outline-success"">Güncelle</button>
    </div>
</div>

<h4 class=""text-center"">Deneyim Listesi</h4>


<div class=""p-2"" id=""listexperience"">
 
</div>

<br />

<div class=""p-2"" id=""listbyidexperience"">

</div>

<br />



<div class=""col-md-12"">
    <h4>Ekleme Paneli</h4>
    <input type=""text"" class=""form-control"" id=""inpName"" placeholder=""Başlık"">
    <br />
    <input type=""text"" class=""form-control"" id=""inpDate"" placeholder=""Tarih"">   
</div>
<br />

<div class=""col-md-12"">
    <h5>Id'ye Göre Getirme");
            WriteLiteral(@" Paneli</h5>
    <input type=""text"" class=""form-control"" id=""inpid"" placeholder=""ID Giriniz"" />
</div>

<div class=""col-md-12"">
    <h5>Silme Paneli</h5>
    <input type=""text"" class=""form-control"" id=""inpexpid"" placeholder=""ID Giriniz"" />
</div>

<br />
<div class=""col-md-12"">
    <h5>Güncelleme Paneli</h5>
    <input type=""text"" class=""form-control"" id=""inpid"" placeholder=""ID Giriniz"" />
    <br />
    <input type=""text"" class=""form-control"" id=""inpname"" placeholder=""İsminizi Giriniz"" />
    <br />
    <input type=""text"" class=""form-control"" id=""inpdate"" placeholder=""Tarih Giriniz"" />
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
         $(""#btngetlistall"").click(function() {         //Bu satır, #getlistall id'sine sahip bir HTML öğesine tıklanıldığında çalışacak bir işlevin başlangıcını işaret eder. Yani, bu kod, belirli bir HTML öğesine tıklama olayına yanıt verir.
             $.ajax({                              //AJAX isteğini başlatmak için kullanılan $.ajax fonksiyonunun başlangıcı.
                 contentType: ""application/json"",  //Bu satır, isteğin içeriğinin JSON türünde olduğunu belirtir. Yani, sunucuya gönderilecek veri JSON formatında olmalıdır.
                 dataType: ""json"",                 //Bu satır, sunucudan alınacak yanıtın JSON formatında olduğunu belirtir. Yani, sunucudan gelen veriyi JSON olarak bekliyoruz.
                 type: ""Get"",                      //Bu satır, AJAX isteğinin HTTP GET yöntemiyle gönderileceğini belirtir. Yani, sunucudan veri almak için GET isteği kullanılacak.
                 url: ""/Experience2/ListExperience/"",     //Bu satır, isteğin gönderileceği URL'yi be");
                WriteLiteral(@"lirtir. Bu URL, sunucuda ListUser adlı bir işlemi çağırmak için kullanılacak.

                 success: function(funk) {         //AJAX isteği başarılı olduğunda çalışacak işlevin başlangıcı. funk adında bir parametre alır, bu parametre sunucudan gelen yanıtı temsil eder.
                     let values = jQuery.parseJSON(funk);  //Bu satır, sunucudan gelen JSON yanıtını işlemek için kullanılır. funk değişkenini JSON formatından JavaScript nesnesine dönüştürür ve sonucu users değişkenine atar.
                     console.log(values);           //Bu satır, users değişkenini tarayıcı konsoluna yazdırır. Bu sayede sunucudan gelen kullanıcı verilerini konsolda görebiliriz.
                     let htmlst = ""<table class=table table-bordered> <tr> <th> ID </th> <th> Başlık </th> <th> Tarih </th> </tr>"";
                    $.each(values, (index, value) => {
                        htmlst += `<tr> <td>${value.ExprerienceID}</td> <td>${value.Name}</td> <td>${value.Date}</td> </tr>`
                    });
                WriteLiteral(@"
                    htmlst += ""</table>"";
                    $(""#listexperience"").html(htmlst);
                     
                 }
             });
         });

         $(""#btnadd"").click(function () {
            let values = {
                Name: $(""#inpName"").val(),    //Veri alınacağı zaman val() şeklinde olması gerekiyor.
                Date: $(""#inpDate"").val()
            };

            $.ajax({
                type: ""Post"",
                url: ""/Experience2/AddExperience/"",
                data: values,  //veriler values değişkeninden gleen değerler üstte tanımladığımız.
                success: function (funk1) {         //Aynı script içerisinde fonksiyonların farklı olması gerekiyor
                    let result = jQuery.parseJSON(funk1);
                    alert(""Başarılı bir şekilde eklendi"");
                }
            });
        });

        $(""#btnid"").click(x => {
            let id = $(""#inpid"").val();

            $.ajax({
                cont");
                WriteLiteral(@"entType: ""application/json"",
                dataType: ""json"",
                type: ""Get"",
                url: ""/Experience2/GetById/"",
                data: { ExprerienceID: id },
                success: function (funk2) {
                    let result = jQuery.parseJSON(funk2);
                    console.log(result);
                    let htmlstr = `<table class=table table-hover> <tr> <th>Deneyim ID</th> <td>${result.ExprerienceID}</td></tr> <tr> <th> Deneyim Başlığı </th> <td> ${result.Name}</td> </tr> </table>`;
                    $(""#listbyidexperience"").html(htmlstr);
                }
            });

        });

$(""#btndelete"").click(x => {
            let id = $(""#inpexpid"").val();
            $.ajax({
                url: ""/Experience/DeleteExperience/"" + id,
                type: ""post"",
                contentType: ""application/json"",
                dataType: ""json"",
                success: function (funk3) {
                    loadData();
                }
  ");
                WriteLiteral(@"          });
        });

        $(""#btnupdate"").click(function () {
            let values = {
                ExprerienceID: $(""#inpid"").val(),
                Name: $(""#inpname"").val(),
                Date:$(""inpdate"").val()
            };

            $.ajax({
                type: ""post"",
                url: ""/Experience2/UpdateExperince/"",
                data: values,
                success: function (funk3) {
                    alert(ExprerienceID+""no lu verinin güncelleme işlemi yapıldı"");
                }
            });
        });
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8df293e1358923e0516879e1aa5d859dafc9ce7510845", async() => {
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
            WriteLiteral(" <!-- jQuery kütüphanesini bir HTML sayfasına eklemek için kullanılan bir HTML-->\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Experience>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591