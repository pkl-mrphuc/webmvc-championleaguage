#pragma checksum "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DangKyCauThu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26df3d8a1325cd81c49620525a02ac3ded57fed3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DangKyCauThu_Index), @"mvc.1.0.view", @"/Views/DangKyCauThu/Index.cshtml")]
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
#line 4 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DangKyCauThu\Index.cshtml"
using PTIT.B17DCCN490.PTTK_DBCLPM.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26df3d8a1325cd81c49620525a02ac3ded57fed3", @"/Views/DangKyCauThu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_DangKyCauThu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CauThu>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DangKyCauThu\Index.cshtml"
  
    ViewData["Title"] = "Bảng xếp hạng | Premier Language";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DangKyCauThu\Index.cshtml"
  
    List<CauThu_DoiBong_TranDau> daDK = (List<CauThu_DoiBong_TranDau>)ViewData["CauThu"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""page"">
    <section>
        <div class=""title-site d-flex align-items-center"">
            <div class=""footballIcon""></div>
            <h1 class=""title"">Đăng ký cầu thủ - (<span id=""counter""></span>)</h1>
            <div class=""ml-auto""></div>
            <button class=""btn btn-default-w"" onclick=""back()"">Quay lại</button>
            <button class=""btn"" onclick=""sendRegister()"">Gửi danh sách</button>
        </div>
        <table class=""dataTable"">
            <thead>
                <tr>
                    <th class=""w-t-num"">#</th>
                    <th class=""txt-center"">STT</th>
                    <th class=""txt-left"">Cầu thủ</th>
                    <th class=""txt-center"">Số áo</th>
                    <th class=""txt-center"">Đá chính</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 29 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DangKyCauThu\Index.cshtml"
                 for (int i = 0; i < Model.Count(); i++)
                {
                    var isValid = daDK.Where(item => item.CauThu.Id == Model[i].Id).FirstOrDefault();

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            <input");
            BeginWriteAttribute("tabindex", " tabindex=\"", 1367, "\"", 1384, 1);
#nullable restore
#line 34 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DangKyCauThu\Index.cshtml"
WriteAttributeValue("", 1378, i+1, 1378, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("cauthuid", "\r\n                                   cauthuid=\"", 1385, "\"", 1444, 1);
#nullable restore
#line 35 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DangKyCauThu\Index.cshtml"
WriteAttributeValue("", 1432, Model[i].Id, 1432, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                   name=\"choose\"\r\n                                   type=\"checkbox\"");
            BeginWriteAttribute("checked", "\r\n                                   checked=\"", 1547, "\"", 1626, 1);
#nullable restore
#line 38 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DangKyCauThu\Index.cshtml"
WriteAttributeValue("", 1593, isValid != null ? true : false, 1593, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 40 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DangKyCauThu\Index.cshtml"
                        Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"txt-left\">");
#nullable restore
#line 41 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DangKyCauThu\Index.cshtml"
                                        Write(Model[i].Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"txt-center\">");
#nullable restore
#line 42 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DangKyCauThu\Index.cshtml"
                                          Write(Model[i].SoAo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"txt-center\">\r\n                            <input name=\"isdachinh\"\r\n                                   type=\"checkbox\"");
            BeginWriteAttribute("checked", "\r\n                                   checked=\"", 1987, "\"", 2079, 1);
#nullable restore
#line 46 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DangKyCauThu\Index.cshtml"
WriteAttributeValue("", 2033, isValid != null ? isValid.IsDaChinh : false, 2033, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 49 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DangKyCauThu\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DangKyCauThu\Index.cshtml"
                 if (Model.Count() == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td colspan=\"5\">Dữ liệu không có sẵn</td>\r\n                    </tr>\r\n");
#nullable restore
#line 55 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DangKyCauThu\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </section>\r\n</div>\r\n\r\n<script type=\"text/javascript\">\r\n    let counter = ");
#nullable restore
#line 62 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DangKyCauThu\Index.cshtml"
             Write(daDK.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
    const elementCounter = document.getElementById(""counter"");
    elementCounter.innerHTML = counter;
    let choose = document.getElementsByName(""choose"");
    let dachinh = document.getElementsByName(""isdachinh"");
    for (var i = 0; i < choose.length; i++) {
        choose[i].addEventListener('change', counting);
    }

    function counting(e) {
        if (e.target.checked) {
            counter++;
        } else {
            counter--;
        }
        elementCounter.innerHTML = counter;
    }

    function sendRegister() {
        var data = new Array();
        for (var i = 0; i < choose.length; i++) {
            if (choose[i].checked) {
                data.push({
                    CauThu: { Id: choose[i].getAttribute(""cauthuid"") },
                    IsDaChinh: dachinh[i].checked
                });
            }

        }
        fetch(""https://localhost:44352/DangKyCauThu/"" + '");
#nullable restore
#line 91 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\DangKyCauThu\Index.cshtml"
                                                    Write(ViewBag.DoiBongTranDauId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"', {
            body: JSON.stringify(data),
            method: ""POST"",
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            }
        }).then(function (response) {
            window.location.reload();
            window.history.back();
        })

    }

    function back() {
        window.history.back();
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CauThu>> Html { get; private set; }
    }
}
#pragma warning restore 1591
