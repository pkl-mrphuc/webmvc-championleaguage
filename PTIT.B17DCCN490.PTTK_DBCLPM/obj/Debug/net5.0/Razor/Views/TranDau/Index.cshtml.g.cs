#pragma checksum "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\TranDau\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2afdc26ca8d78ac4502140d008f25678e6141204"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TranDau_Index), @"mvc.1.0.view", @"/Views/TranDau/Index.cshtml")]
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
#line 4 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\TranDau\Index.cshtml"
using PTIT.B17DCCN490.PTTK_DBCLPM.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2afdc26ca8d78ac4502140d008f25678e6141204", @"/Views/TranDau/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_TranDau_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TranDau>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\TranDau\Index.cshtml"
  
    ViewData["Title"] = "Danh sách trận đấu | Premier Leaguae";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .tg {
        padding: 0 10px;
        margin-right: 5px;
        background: #1b2a50;
        border-radius: 5px;
    }
</style>
<div class=""page"">
    <section>
        <div class=""d-flex align-items-center"">
            <div class=""footballIcon""></div>
            <h1 class=""title"">Danh sách trận đấu - ");
#nullable restore
#line 18 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\TranDau\Index.cshtml"
                                              Write(ViewData["TenCauThu"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  ghi bàn </h1>
        </div>
    </section>
    <section>
        <table class=""dataTable"">
            <thead>
                <tr>
                    <th class=""w-t-num"">STT</th>
                    <th class=""txt-left"">Đội nhà</th>
                    <th class=""txt-left"">Đội khách</th>
                    <th class=""w-t-num"" title=""Số bàn thắng"">SBT</th>
                    <th class=""txt-left"">Mốc thời gian</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 33 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\TranDau\Index.cshtml"
                 if (Model.Count() == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td colspan=\"5\">Dữ liệu không có sắn</td>\r\n                    </tr>\r\n");
#nullable restore
#line 38 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\TranDau\Index.cshtml"
                }
                else
                {
                    Dictionary<TranDau, List<SuKien>> mappingTDSKs = (Dictionary<TranDau, List<SuKien>>)ViewData["TDSKS"];
                    for (int i = 0; i < Model.Count(); i++)
                    {
                        List<SuKien> sks = mappingTDSKs[Model[i]].OrderBy(item => item.ThoiDiem).ToList();


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("onclick", " onclick=\"", 1589, "\"", 1623, 3);
            WriteAttributeValue("", 1599, "loadPage(\'", 1599, 10, true);
#nullable restore
#line 46 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\TranDau\Index.cshtml"
WriteAttributeValue("", 1609, Model[i].Id, 1609, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1621, "\')", 1621, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <td class=\"w-t-num\">");
#nullable restore
#line 47 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\TranDau\Index.cshtml"
                                            Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"txt-left\">");
#nullable restore
#line 48 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\TranDau\Index.cshtml"
                                            Write(Model[i].DoiNha.DoiBong.DoiBong.Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"txt-left\">");
#nullable restore
#line 49 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\TranDau\Index.cshtml"
                                            Write(Model[i].DoiKhach.DoiBong.DoiBong.Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"w-t-num\">");
#nullable restore
#line 50 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\TranDau\Index.cshtml"
                                           Write(sks.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"txt-left\">\r\n");
#nullable restore
#line 52 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\TranDau\Index.cshtml"
                                 for (int j = 0; j < sks.Count(); j++)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"tg\">");
#nullable restore
#line 54 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\TranDau\Index.cshtml"
                                                Write(sks[j].ThoiDiem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 55 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\TranDau\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 58 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\TranDau\Index.cshtml"

                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </section>\r\n\r\n</div>\r\n<script type=\"text/javascript\">\r\n    function loadPage(id) {\r\n        window.location.href = `/TranDau/Edit/${id}`;\r\n    }\r\n</script>\r\n");
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
