#pragma checksum "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\LichThiDau\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0468ff3707a48c2ff95cc8acbc0aab474856169"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LichThiDau_Index), @"mvc.1.0.view", @"/Views/LichThiDau/Index.cshtml")]
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
#line 4 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\LichThiDau\Index.cshtml"
using PTIT.B17DCCN490.PTTK_DBCLPM.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0468ff3707a48c2ff95cc8acbc0aab474856169", @"/Views/LichThiDau/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_LichThiDau_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TranDau>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\LichThiDau\Index.cshtml"
  
    ViewData["Title"] = "Lịch thi đấu | Premier Language";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>

    .tt-td {
        display: flex;
        align-items: center;
        width: 100%;
        font-weight: bold;
    }

    .dn > .tg {
        position: absolute;
        left: 15px;
    }

    .ty-so {
        padding: 0 10px;
        background: #0f4cd9;
        border-radius: 3px;
        display: block;
        width: 6%;
    }

        .ty-so > a {
            text-decoration: none;
            color: #fff;
        }

    .dn {
        width: 47%;
        position: relative;
        display: flex;
        align-items: center;
        justify-content: end;
    }

    .dk {
        width: 47%;
        display: flex;
        align-items: center;
        justify-content: start;
    }
</style>

<div class=""page"">
    <section>
        <div class=""title-site d-flex align-items-center"">
            <div class=""footballIcon""></div>
            <h1 class=""title"">Lịch thi đấu</h1>
        </div>
        <div class=""d-flex"">
            ");
#nullable restore
#line 56 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\LichThiDau\Index.cshtml"
       Write(Html.DropDownList("LoaiVongDauId",
                    new SelectList(ViewBag.VongDaus, "Value", "Text", ViewData["CurrentGroundStage"]),
                    new { @class = "p-drop", @onchange = "loadPage()" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div style=\"margin-right: 10px\"></div>\r\n            ");
#nullable restore
#line 60 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\LichThiDau\Index.cshtml"
       Write(Html.DropDownList("GiaiDauId",
                    new SelectList(ViewBag.GiaiDaus, "Value", "Text", ViewData["CurrentSeason"]),
                    new { @class = "p-drop", @onchange = "loadPage()" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            <div class=""ml-auto"">
                <button class=""btn"" onclick=""createMatch()"">Lên lịch</button>
            </div>
        </div>

        <table class=""dataTable mt-10"">
            <thead>
                <tr>
                    <td colspan=""3"" class=""txt-center"" style=""font-weight: bold"">DANH SÁCH TRẬN ĐẤU</td>
                </tr>
            </thead>
            <tbody>

");
#nullable restore
#line 77 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\LichThiDau\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"tt-td\">\r\n                        <td class=\"dn\">\r\n                            <div class=\"tg\">");
#nullable restore
#line 81 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\LichThiDau\Index.cshtml"
                                       Write(item.ThoiGianBD.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div style=\"padding-right: 20px;\">");
#nullable restore
#line 82 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\LichThiDau\Index.cshtml"
                                                         Write(item.DoiNha.DoiBong.DoiBong.Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </td>\r\n                        <td class=\"ty-so\">\r\n");
#nullable restore
#line 85 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\LichThiDau\Index.cshtml"
                             if (item.DaKetThuc || item.DangDienRa)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 2592, "\"", 2621, 2);
            WriteAttributeValue("", 2599, "/TranDau/Edit/", 2599, 14, true);
#nullable restore
#line 87 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\LichThiDau\Index.cshtml"
WriteAttributeValue("", 2613, item.Id, 2613, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Xem chi tiết\">");
#nullable restore
#line 87 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\LichThiDau\Index.cshtml"
                                                                                 Write(item.DoiNha.SoBanThang);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 87 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\LichThiDau\Index.cshtml"
                                                                                                           Write(item.DoiKhach.SoBanThang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 88 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\LichThiDau\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 2831, "\"", 2860, 2);
            WriteAttributeValue("", 2838, "/TranDau/Edit/", 2838, 14, true);
#nullable restore
#line 91 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\LichThiDau\Index.cshtml"
WriteAttributeValue("", 2852, item.Id, 2852, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Xem chi tiết\">vs</a>\r\n");
#nullable restore
#line 92 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\LichThiDau\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td class=\"dk\">\r\n                            <div style=\"padding-left: 20px;\">");
#nullable restore
#line 95 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\LichThiDau\Index.cshtml"
                                                        Write(item.DoiKhach.DoiBong.DoiBong.Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 98 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\LichThiDau\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\LichThiDau\Index.cshtml"
                 if (Model.Count() == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr><td class=\"txt-center\">Dữ liệu không có sẵn</td></tr>\r\n");
#nullable restore
#line 102 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\LichThiDau\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </section>
</div>

<script type=""text/javascript"">
    function loadPage() {
        let giaiDauId = document.getElementById(""GiaiDauId"").value;
        let loaiVongDauId = document.getElementById(""LoaiVongDauId"").value;
        if (getCookie(""GiaiDauId"") != null) {
            eraseCookie(""GiaiDauId"");
        }
        setCookie(""GiaiDauId"", giaiDauId);
        window.location.href = `/LichThiDau?vongDau=${loaiVongDauId}&muaGiai=${giaiDauId}`;
    }

    function createMatch() {
        let giaiDauId = document.getElementById(""GiaiDauId"").value;
        let loaiVongDauId = document.getElementById(""LoaiVongDauId"").value;
        if (getCookie(""GiaiDauId"") != null) {
            eraseCookie(""GiaiDauId"");
        }
        if (getCookie(""LoaiVongDauId"") != null) {
            eraseCookie(""LoaiVongDauId"");
        }
        setCookie(""GiaiDauId"", giaiDauId);
        setCookie(""LoaiVongDauId"", loaiVongDauId);
        window.location.href = '/Tr");
            WriteLiteral("anDau/Add\';\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TranDau>> Html { get; private set; }
    }
}
#pragma warning restore 1591
