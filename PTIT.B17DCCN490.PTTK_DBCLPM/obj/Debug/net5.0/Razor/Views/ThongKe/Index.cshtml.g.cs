#pragma checksum "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f64e8c3b29ea7103a29c9a16635f8c5a9eb219e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ThongKe_Index), @"mvc.1.0.view", @"/Views/ThongKe/Index.cshtml")]
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
#line 1 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
using PTIT.B17DCCN490.PTTK_DBCLPM.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f64e8c3b29ea7103a29c9a16635f8c5a9eb219e", @"/Views/ThongKe/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_ThongKe_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
  
    ViewData["Title"] = "Thống kê | Premier Language";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .club {
        max-width: 50px;
        text-overflow: ellipsis;
        white-space: nowrap;
        overflow: hidden;
    }
</style>

<div class=""page"">
    <section>
        <div class=""d-flex align-items-center"">
            <div class=""footballIcon""></div>
            <h1 class=""title"">Thống kê giải đấu</h1>
        </div>
    </section>

    <section class=""tabControl"">
        <div class=""d-flex align-items-center"">
            <ul class=""tabControlTitle w-70"">
                <li class=""sumary"" id=""result_tab""><a onclick=""loadPage('result')"" tabindex=""1"">BXH</a></li>
                <li class=""sumary"" id=""goal_tab""><a onclick=""loadPage('goal')"" tabindex=""2"">Bàn thắng</a></li>
                <li class=""sumary"" id=""card_tab""><a onclick=""loadPage('card')"" tabindex=""3"">Thẻ phạt</a></li>
                <li class=""sumary"" id=""stadium_tab""><a onclick=""loadPage('stadium')"" tabindex=""4"">Sân đấu</a></li>
            </ul>
            <div class=""ml-auto""></div>
         ");
            WriteLiteral("   <div style=\"width: 250px\">\r\n                ");
#nullable restore
#line 33 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
           Write(Html.DropDownList("GiaiDauId",
                    new SelectList(ViewBag.GiaiDaus, "Value", "Text", ViewData["CurrentSeason"]),
                    new { @class = "w-100 p-drop", @onchange = "loadPage()", @tabindex="5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>

        <div class=""tabControlBody"" id=""goal"">
            <table class=""dataTable mt-10"">
                <thead>
                    <tr>
                        <th class=""w-t-num"">#</th>
                        <th class=""txt-left club"">Đội bóng</th>
                        <th class=""txt-left"">Cầu thủ</th>
                        <th class=""w-t-num"">Bàn thắng</th>
                        <th class=""w-t-num"">Kiến tạo</th>
                        <th class=""w-t-num"">Thứ hạng</th>
                        <th class=""w-t-num"">Số phút</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 53 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
                     if (ViewData["TKGoal"] != null)
                    {
                        List<BXHCauThuBanThang> bxh = (List<BXHCauThuBanThang>)ViewData["TKGoal"];
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
                         for (int i = 0; i < bxh.Count(); i++)
                        {
                            string[] ten = bxh[i].Ten.Split("|");

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr");
            BeginWriteAttribute("ondblclick", " ondblclick=\"", 2477, "\"", 2510, 3);
            WriteAttributeValue("", 2490, "toPage(\'", 2490, 8, true);
#nullable restore
#line 59 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
WriteAttributeValue("", 2498, bxh[i].Id, 2498, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2508, "\')", 2508, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <td>");
#nullable restore
#line 60 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
                                Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"txt-left club\"");
            BeginWriteAttribute("title", " title=\"", 2620, "\"", 2635, 1);
#nullable restore
#line 61 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
WriteAttributeValue("", 2628, ten[1], 2628, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 61 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
                                                                     Write(ten[1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"txt-left\">\r\n                                    <span class=\"player\">\r\n                                        ");
#nullable restore
#line 64 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
                                   Write(ten[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </span>\r\n                                </td>\r\n                                <td>");
#nullable restore
#line 67 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
                               Write(bxh[i].BanThang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 68 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
                               Write(bxh[i].KienTao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 69 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
                               Write(bxh[i].ThuHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 70 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
                               Write(bxh[i].ThoiGian);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 72 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
                         
                        if (bxh.Count() == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td colspan=\"6\">Dữ liệu không có sắn</td>\r\n                            </tr>\r\n");
#nullable restore
#line 78 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
                        }
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td colspan=\"6\">Dữ liệu không có sắn</td>\r\n                        </tr>\r\n");
#nullable restore
#line 85 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
        <div id=""result"" class=""tabControlBody"" style=""display: none;"">
            <table class=""dataTable mt-10"">
                <thead>
                    <tr>
                        <th class=""w-t-num"">TH</th>
                        <th class=""txt-left"">Đội bóng</th>
                        <th class=""w-t-num"">Điểm</th>
                        <th class=""w-t-num"">Bàn thắng</th>
                        <th class=""w-t-num"">Bàn thua</th>
                        <th class=""w-t-num"">Hiệu số</th>
                        <th class=""w-t-num"">Số trận</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 103 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
                     if (ViewData["TKResult"] != null)
                    {
                        List<BXH> bxh = (List<BXH>)ViewData["TKResult"];
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
                         for (int i = 0; i < bxh.Count(); i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr");
            BeginWriteAttribute("tabindex", " tabindex=\"", 4655, "\"", 4672, 1);
#nullable restore
#line 108 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
WriteAttributeValue("", 4666, 6+i, 4666, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <td class=\"w-t-num\">");
#nullable restore
#line 109 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
                                               Write(bxh[i].ThuHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"txt-left\">");
#nullable restore
#line 110 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
                                                Write(bxh[i].Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 111 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
                               Write(bxh[i].Diem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 112 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
                               Write(bxh[i].BanThang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 113 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
                               Write(bxh[i].BanThua);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 114 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
                                Write(bxh[i].BanThang-bxh[i].BanThua);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 115 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
                               Write(bxh[i].SoTran);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 117 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 117 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
                         
                        if (bxh.Count() == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td colspan=\"7\">Dữ liệu không có sắn</td>\r\n                            </tr>\r\n");
#nullable restore
#line 123 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
                        }
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td colspan=\"7\">Dữ liệu không có sắn</td>\r\n                        </tr>\r\n");
#nullable restore
#line 130 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </tbody>
            </table>
        </div>
        <div id=""card"" class=""tabControlBody"" style=""display: none;"">
            <span class=""notiMes mt-10"">Tính năng này đang được phát triển</span>
        </div>
        <div id=""stadium"" class=""tabControlBody"" style=""display: none;"">
            <span class=""notiMes mt-10"">Tính năng này đang được phát triển</span>
        </div>

    </section>
");
#nullable restore
#line 143 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
     if (ViewData["TypeTK"] != null)
    {
        var tabName = ViewData["TypeTK"] as string;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script type=\"text/javascript\">\r\n            window.onload = function () {\r\n                this.openTab(\'");
#nullable restore
#line 148 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
                         Write(tabName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n            }\r\n\r\n            function loadPage(tabName) {\r\n                if (this.isNullOrUndefined(tabName)) {\r\n                    tabName = \'");
#nullable restore
#line 153 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
                          Write(tabName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
                }
                let giaiDauId = document.getElementById(""GiaiDauId"").value;
                if (getCookie(""GiaiDauId"") != null) {
                    eraseCookie(""GiaiDauId"");
                }
                setCookie(""GiaiDauId"", giaiDauId);
                window.location.href = `/ThongKe?loai=${tabName}&muaGiai=${giaiDauId}`;
            }

            function toPage(cauThuId) {
                let giaiDauId = document.getElementById(""GiaiDauId"").value;
                window.location.href = `/TranDau?cauThu=${cauThuId}&muaGiai=${giaiDauId}`;
            }
        </script>
");
#nullable restore
#line 168 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\ThongKe\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
