#pragma checksum "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\GiaiDau\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79f5be66284e7c0717c98800493af1a0a730910e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GiaiDau_Index), @"mvc.1.0.view", @"/Views/GiaiDau/Index.cshtml")]
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
#line 4 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\GiaiDau\Index.cshtml"
using PTIT.B17DCCN490.PTTK_DBCLPM.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79f5be66284e7c0717c98800493af1a0a730910e", @"/Views/GiaiDau/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_GiaiDau_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GiaiDau>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\GiaiDau\Index.cshtml"
  
    ViewData["Title"] = "Giải đấu | Thiết lập | Premier Language";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""page"">
    <section>
        <div class=""title-site d-flex align-items-center"">
            <div class=""footballIcon""></div>
            <h1 class=""title"">Danh sách giải đấu</h1>
            <div class=""ml-auto""></div>
            <button class=""btn"" onclick=""openForm('Ten')"">Thêm mới</button>
        </div>
    </section>
    <table class=""dataTable"">
        <thead>
            <tr>
                <th class=""txt-center"">STT</th>
                <th class=""txt-left"">Giải đấu</th>
                <th class=""txt-center"">Mùa giải</th>
                <th class=""txt-center"">Thời gian bắt đầu</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 25 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\GiaiDau\Index.cshtml"
              
                for (int i = 0; i < Model.Count(); i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr title=\"Chọn để đăng ký đội bóng tham gia giải\"");
            BeginWriteAttribute("ondblclick", " ondblclick=\"", 997, "\"", 1034, 3);
            WriteAttributeValue("", 1010, "loadPage(\'", 1010, 10, true);
#nullable restore
#line 28 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\GiaiDau\Index.cshtml"
WriteAttributeValue("", 1020, Model[i].Id, 1020, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1032, "\')", 1032, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <td class=\"txt-center\">");
#nullable restore
#line 29 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\GiaiDau\Index.cshtml"
                                           Write(i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"txt-left\">");
#nullable restore
#line 30 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\GiaiDau\Index.cshtml"
                                        Write(Model[i].Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"txt-center\">");
#nullable restore
#line 31 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\GiaiDau\Index.cshtml"
                                          Write(Model[i].MuaGiai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"txt-center\">");
#nullable restore
#line 32 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\GiaiDau\Index.cshtml"
                                          Write(Model[i].ThoiGianBD.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 34 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\GiaiDau\Index.cshtml"
                }
                if (Model.Count() == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td colspan=\"4\">Dữ liệu không có sẵn</td>\r\n                    </tr>\r\n");
#nullable restore
#line 40 "E:\MYPROJECT\ASP.NETCoreApp\PTIT.B17DCCN490.PTTK_DBCLPM\PTIT.B17DCCN490.PTTK_DBCLPM\Views\GiaiDau\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>

    <div class=""bgForm"" id=""screen"" style=""display: none"">
        <div class=""form"">
            <div style=""position: relative; height: 100%; width: 100%"">
                <div class=""title-form"">Thêm giải đấu <span class=""ml-auto"" style=""cursor: pointer"" onclick=""closeForm()"">x</span></div>
                <div class=""body-form"">
                    <div class=""row"">
                        <label class=""w-100 mb-5"">Tên <span class=""c-red"">(*)</span></label>
                        <input id=""Ten""
                               required
                               type=""text""
                               onblur=""checkEmpty('Ten')""
                               onfocus=""removeError('Ten', 'p-input default w-100')""
                               class=""p-input default w-100""
                               tabindex=""1"" />
                    </div>
                    <div class=""row"">
                        <label class=""w-100 mb-5"">Mùa giải <span clas");
            WriteLiteral(@"s=""c-red"">(*)</span></label>
                        <input id=""MuaGiai""
                               required
                               type=""text""
                               onblur=""checkEmpty('MuaGiai')""
                               onfocus=""removeError('MuaGiai', 'p-input default w-100')""
                               class=""p-input default w-100""
                               tabindex=""2"" />
                    </div>
                    <div class=""row"">
                        <label class=""w-100 mb-5"">Thời gian bắt đầu <span class=""c-red"">(*)</span></label>
                        <input 
                               id=""ThoiGianBD"" 
                               onblur=""checkEmpty('ThoiGianBD')""
                               onfocus=""removeError('ThoiGianBD', 'p-input default w-100')"" 
                               required 
                               type=""date"" 
                               class=""p-input default w-100"" 
                               tab");
            WriteLiteral(@"index=""3"" />
                    </div>
                </div>
                <div class=""footer-form"">
                    <button class=""btn"" onclick=""save()"" tabindex=""4"">Cất</button>
                </div>
            </div>

        </div>
    </div>
</div>
<script type=""text/javascript"">

    
    let name = document.getElementById(""Ten"");
    let season = document.getElementById(""MuaGiai"");
    let startDate = document.getElementById(""ThoiGianBD"");
    

    function save() {
        if (name.value != null && season.value != null && startDate.value != null) {
            var data = {
                Ten: name.value,
                MuaGiai: season.value,
                ThoiGianBD: startDate.value
            };
            fetch(""https://localhost:44352/GiaiDau"",
                {
                    body: JSON.stringify(data),
                    method: ""POST"",
                    headers: {
                        'Accept': 'application/json',
                      ");
            WriteLiteral(@"  'Content-Type': 'application/json'
                    }
                })
                .then(response => {
                    window.location.href = ""/GiaiDau"";
                })
                .catch(error => { console.log(error); })
        }
    }

    function loadPage(giaiDauId) {
        window.location.href = `/DoiBongGiaiDau/${giaiDauId}`;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GiaiDau>> Html { get; private set; }
    }
}
#pragma warning restore 1591
