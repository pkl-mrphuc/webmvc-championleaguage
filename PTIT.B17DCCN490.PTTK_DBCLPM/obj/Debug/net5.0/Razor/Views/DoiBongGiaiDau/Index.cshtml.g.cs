#pragma checksum "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DoiBongGiaiDau\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "813ed12ede8878120af8692bd076206a624d3312"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DoiBongGiaiDau_Index), @"mvc.1.0.view", @"/Views/DoiBongGiaiDau/Index.cshtml")]
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
#line 4 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DoiBongGiaiDau\Index.cshtml"
using PTIT.B17DCCN490.PTTK_DBCLPM.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"813ed12ede8878120af8692bd076206a624d3312", @"/Views/DoiBongGiaiDau/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_DoiBongGiaiDau_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DoiBong_GiaiDau>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DoiBongGiaiDau\Index.cshtml"
  
    ViewData["Title"] = "Đội bóng giải đấu | Premier League";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .row {
        width: 100%;
        display: flex;
        flex-direction: column;
        color: #000;
        margin-bottom: 20px;
    }

        .row label {
            padding-bottom: 5px;
        }

        .row input {
            height: 32px;
            border: 1px solid #000;
            outline: none;
            padding-left: 15px;
            box-sizing: border-box;
            border-radius: 5px;
        }
</style>
<div class=""homePage"">
    <section class=""match mx-10"">
        <div class=""title-site d-flex align-items-center"">
            <div class=""footballIcon""></div>
            <h1 class=""title"">Danh sách đội bóng tham gia giải</h1>
            <div class=""ml-auto""></div>
            <button class=""btn"" onclick=""openForm()"">Thêm mới</button>
        </div>
    </section>
    <table class=""dataTable"" id=""ds-db"">
        <thead>
            <tr>
                <th class=""txt-center"">STT</th>
                <th class=""txt-left"">Bảng đấu</th");
            WriteLiteral(">\r\n                <th class=\"txt-left\">Đội bóng</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 47 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DoiBongGiaiDau\Index.cshtml"
              
                for (int i = 0; i < Model.Count(); i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"txt-center\">");
#nullable restore
#line 51 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DoiBongGiaiDau\Index.cshtml"
                                           Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"txt-left\">");
#nullable restore
#line 52 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DoiBongGiaiDau\Index.cshtml"
                                        Write(Model[i].BangDau.Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"txt-left\">");
#nullable restore
#line 53 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DoiBongGiaiDau\Index.cshtml"
                                        Write(Model[i].DoiBong.Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 55 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DoiBongGiaiDau\Index.cshtml"
                }
                if (Model.Count() == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td colspan=\"3\">Dữ liệu không có sẵn</td>\r\n                    </tr>\r\n");
#nullable restore
#line 61 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DoiBongGiaiDau\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>

    <div class=""bgForm"" id=""screen"" style=""display: none"">
        <div class=""form"">
            <div style=""position: relative; height: 100%; width: 100%"">
                <div class=""title-form"">Đăng ký  <span class=""ml-auto"" style=""cursor: pointer"" onclick=""closeForm()"">x</span></div>
                <div class=""body-form"">
                    <input hidden id=""GiaiDauId""");
            BeginWriteAttribute("value", " value=\"", 2287, "\"", 2311, 1);
#nullable restore
#line 71 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DoiBongGiaiDau\Index.cshtml"
WriteAttributeValue("", 2295, ViewBag.GiaiDau, 2295, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <div class=\"row\">\r\n                        <label>Bảng Đấu <span class=\"c-red\">(*)</span></label>\r\n                        ");
#nullable restore
#line 74 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DoiBongGiaiDau\Index.cshtml"
                   Write(Html.DropDownList("BangDauId",
                    new SelectList(ViewBag.BangDaus, "Value", "Text"),
                    new { @class = "dropdown", @tabindex = "1" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <label>Đội bóng <span class=\"c-red\">(*)</span></label>\r\n                        ");
#nullable restore
#line 80 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DoiBongGiaiDau\Index.cshtml"
                   Write(Html.DropDownList("DoiBongId",
                    new SelectList(ViewBag.DoiBongs, "Value", "Text"),
                    new { @class = "dropdown", @tabindex = "2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""footer-form"">
                    <button class=""btn"" onclick=""save()"" tabindex=""3"">Cất</button>
                </div>
            </div>

        </div>
    </div>
</div>
<script type=""text/javascript"">
    let screen = document.getElementById(""screen"");
    let giaiDauId = document.getElementById(""GiaiDauId"");
    let bangDauId = document.getElementById(""BangDauId"");
    let doiBongId = document.getElementById(""DoiBongId"");
    function openForm() {
        screen.style.display = ""block"";
    }

    function closeForm() {
        screen.style.display = ""none"";
    }

    function save() {
        if (giaiDauId.value != null && bangDauId.value != null && doiBongId.value != null) {
            var data = {
                BangDau: { Id: bangDauId.value },
                DoiBong: { Id: doiBongId.value }
            };
            fetch(""https://localhost:44352/DoiBongGiaiDau/");
#nullable restore
#line 112 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DoiBongGiaiDau\Index.cshtml"
                                                     Write(ViewBag.GiaiDau);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                {
                    body: JSON.stringify(data),
                    method: ""POST"",
                    headers: {
                        'Accept': 'application/json',
                        'Content-Type': 'application/json'
                    }
                })
                .then(response => {
                    window.location.href = ""/DoiBongGiaiDau/");
#nullable restore
#line 122 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DoiBongGiaiDau\Index.cshtml"
                                                       Write(ViewBag.GiaiDau);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n                })\r\n                .catch(error => { console.log(error); })\r\n        }\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DoiBong_GiaiDau>> Html { get; private set; }
    }
}
#pragma warning restore 1591
