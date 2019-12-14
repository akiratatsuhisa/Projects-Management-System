#pragma checksum "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "103b709da26d67ee5942c70d2b662a72e8ea3b9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Management_Views_Projects_Details), @"mvc.1.0.view", @"/Areas/Management/Views/Projects/Details.cshtml")]
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
#line 1 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\_ViewImports.cshtml"
using WebApplication.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\_ViewImports.cshtml"
using WebApplication.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"103b709da26d67ee5942c70d2b662a72e8ea3b9e", @"/Areas/Management/Views/Projects/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dbc63e91c5c3f5ee5e2a6f1912a9b0306f8b7fe", @"/Areas/Management/Views/_ViewImports.cshtml")]
    public class Areas_Management_Views_Projects_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication.Models.Project>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
  
    ViewData["Title"] = "Details";
    List<ProjectSchedule> projectSchedules = ViewBag.ProjectSchedules;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-3"">
        <div class=""card"">
            <div class=""card-body"">
                <ul class=""nav nav-pills nav-pills-primary flex-column"">
                    <!--Tổng quan-->
                    <li class=""nav-item""><a class=""nav-link active"" href=""#list-home"" data-toggle=""tab"">Tổng quan</a></li>
                    <!--Tiến trình-->
");
#nullable restore
#line 16 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
                     for (var i = 0; i < projectSchedules.Count; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"nav-item\"><a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 702, "\"", 726, 2);
            WriteAttributeValue("", 709, "#list-week-", 709, 11, true);
#nullable restore
#line 18 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
WriteAttributeValue("", 720, i+1, 720, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tab\">Tuần ");
#nullable restore
#line 18 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
                                                                                                             Write(i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 19 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </ul>
            </div>
        </div>
    </div>

    <div class=""col-md-9"">
        <div class=""tab-content"">
            <!--Tổng quan-->
            <div class=""tab-pane active"" id=""list-home"">
                <div class=""card"">
                    <div class=""card-header card-header-text card-header-primary"">
                        <div class=""card-text"">
                            <h4 class=""card-title"">Tổng quan</h4>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <h3 class=""info-title"">Thành viên</h3>
                        <dl class=""row"">
");
#nullable restore
#line 38 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
                             foreach (ProjectMember item in ViewBag.ProjectMembers)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <dt class=\"col-md-2\">\r\n                                    Tên:\r\n                                </dt>\r\n                                <dd class=\"col-md-10\">\r\n                                    ");
#nullable restore
#line 44 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
                               Write(item.Student.ApplicationUser.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 44 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
                                                                      Write(item.Student.ApplicationUser.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </dd>
                                <dt class=""col-md-2"">
                                    MSSV:
                                </dt>
                                <dd class=""col-md-10"">
                                    ");
#nullable restore
#line 50 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
                               Write(item.Student.StudentCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n");
#nullable restore
#line 52 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </dl>\r\n\r\n                        <hr />\r\n                        <h3 class=\"info-title\">Thông tin</h3>\r\n                        <dl class=\"row\">\r\n                            <dt class=\"col-md-2\">\r\n                                ");
#nullable restore
#line 59 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </dt>\r\n                            <dd class=\"col-md-10\">\r\n                                ");
#nullable restore
#line 62 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-md-2\">\r\n                                ");
#nullable restore
#line 65 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.ProjectType));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </dt>\r\n                            <dd class=\"col-md-10\">\r\n                                ");
#nullable restore
#line 68 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
                           Write(Html.DisplayFor(model => model.ProjectType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-md-2\">\r\n                                ");
#nullable restore
#line 71 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Lecturer));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </dt>\r\n                            <dd class=\"col-md-10\">\r\n                                ");
#nullable restore
#line 74 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
                           Write(Model.Lecturer.ApplicationUser.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 74 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
                                                                     Write(Model.Lecturer.ApplicationUser.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-md-2\">\r\n                                ");
#nullable restore
#line 77 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </dt>\r\n                            <dd");
            BeginWriteAttribute("class", " class=\"", 3649, "\"", 3703, 2);
            WriteAttributeValue("", 3657, "col-md-10", 3657, 9, true);
#nullable restore
#line 79 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
WriteAttributeValue(" ", 3666, Model.StatusViewModel.TextClassName, 3667, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
#nullable restore
#line 80 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
                           Write(Html.DisplayFor(model => model.StatusViewModel.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-md-2\">\r\n                                ");
#nullable restore
#line 83 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </dt>\r\n                            <dd class=\"col-md-10\">\r\n                                ");
#nullable restore
#line 86 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
                           Write(Html.DisplayFor(model => model.CreatedDate.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-md-2\">\r\n                                ");
#nullable restore
#line 89 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </dt>\r\n                            <dd class=\"col-md-10\">\r\n                                ");
#nullable restore
#line 92 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                        </dl>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <!--Tuần-->\r\n            <!--Tiến trình-->\r\n");
#nullable restore
#line 100 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
             for (var i = 0; i < projectSchedules.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"tab-pane\"");
            BeginWriteAttribute("id", " id=\"", 4776, "\"", 4797, 2);
            WriteAttributeValue("", 4781, "list-week-", 4781, 10, true);
#nullable restore
#line 102 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
WriteAttributeValue("", 4791, i+1, 4791, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""card"">
                        <div class=""card-body"">
                            <ul class=""nav nav-pills nav-pills-primary nav-pills-icons"" role=""tablist"">
                                <li class=""nav-item"">
                                    <a class=""nav-link active""");
            BeginWriteAttribute("href", " href=\"", 5112, "\"", 5133, 2);
            WriteAttributeValue("", 5119, "#demand-", 5119, 8, true);
#nullable restore
#line 107 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
WriteAttributeValue("", 5127, i+1, 5127, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" role=""tab"" data-toggle=""tab"">
                                        <i class=""material-icons"">event_note</i>
                                        Yêu cầu
                                    </a>
                                </li>

                                <li class=""nav-item"">
                                    <a class=""nav-link""");
            BeginWriteAttribute("href", " href=\"", 5490, "\"", 5511, 2);
            WriteAttributeValue("", 5497, "#report-", 5497, 8, true);
#nullable restore
#line 114 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
WriteAttributeValue("", 5505, i+1, 5505, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" role=""tab"" data-toggle=""tab"">
                                        <i class=""material-icons"">schedule</i>
                                        Báo cáo
                                    </a>
                                </li>

                                <li class=""nav-item"">
                                    <a class=""nav-link""");
            BeginWriteAttribute("href", " href=\"", 5866, "\"", 5887, 2);
            WriteAttributeValue("", 5873, "#rating-", 5873, 8, true);
#nullable restore
#line 121 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
WriteAttributeValue("", 5881, i+1, 5881, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" role=""tab"" data-toggle=""tab"">
                                        <i class=""material-icons"">format_list_numbered</i>
                                        Đánh giá
                                    </a>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <!--Yêu cầu-->
                    <div class=""tab-content"">
                        <div class=""tab-pane active""");
            BeginWriteAttribute("id", " id=\"", 6373, "\"", 6391, 2);
            WriteAttributeValue("", 6378, "demand-", 6378, 7, true);
#nullable restore
#line 131 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
WriteAttributeValue("", 6385, i+1, 6385, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""row"">
                                <div class=""col-12"">
                                    <div class=""card"">
                                        <div class=""card-header card-header-text card-header-primary"">
                                            <div class=""card-text"">
                                                <h4 class=""card-title"">Yêu cầu</h4>
                                            </div>
                                        </div>
                                        <div class=""card-body"">
                                            <dl class=""row"">
                                                <dt class=""col-md-2"">
                                                    Tên tiến trình:
                                                </dt>
                                                <dd class=""col-md-10"">
                                                    ");
#nullable restore
#line 146 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
                                               Write(projectSchedules[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </dd>
                                                <dt class=""col-md-2"">
                                                    Ngày hết hạn:
                                                </dt>
                                                <dd class=""col-md-10"">
                                                    <span");
            BeginWriteAttribute("class", " class=\"", 7760, "\"", 7858, 1);
#nullable restore
#line 152 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
WriteAttributeValue("", 7768, projectSchedules[i].ExpiredDate.Date < DateTime.Now.Date ? "text-danger":"text-success", 7768, 90, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        ");
#nullable restore
#line 153 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
                                                   Write(projectSchedules[i].ExpiredDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                    </span>
                                                </dd>
                                            </dl>
                                        </div>
                                    </div>
                                </div>
");
#nullable restore
#line 160 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
                                 if (!string.IsNullOrWhiteSpace(projectSchedules[i].Description))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""col-12"">
                                        <div class=""card"">
                                            <div class=""card-header card-header-text card-header-info"">
                                                <div class=""card-text"">
                                                    <h4 class=""card-title"">Mô tả</h4>
                                                </div>
                                            </div>
                                            <div class=""card-body"">
                                                ");
#nullable restore
#line 170 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
                                           Write(Html.Raw(projectSchedules[i].Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 174 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                        <!--Báo cáo-->\r\n                        <div class=\"tab-pane\"");
            BeginWriteAttribute("id", " id=\"", 9389, "\"", 9407, 2);
            WriteAttributeValue("", 9394, "report-", 9394, 7, true);
#nullable restore
#line 178 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
WriteAttributeValue("", 9401, i+1, 9401, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 179 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
                       Write(await Component.InvokeAsync("ProjectScheduleReports", new { id = projectSchedules[i].Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <!--Đánh giá-->\r\n                        <div class=\"tab-pane\"");
            BeginWriteAttribute("id", " id=\"", 9650, "\"", 9668, 2);
            WriteAttributeValue("", 9655, "rating-", 9655, 7, true);
#nullable restore
#line 182 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
WriteAttributeValue("", 9662, i+1, 9662, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""row"">
                                <div class=""col-12"">
                                    <div class=""card"">
                                        <div class=""card-header card-header-text card-header-primary"">
                                            <div class=""card-text"">
                                                <h4 class=""card-title"">Đánh giá</h4>
                                            </div>
                                        </div>
                                        <div class=""card-body"">
                                            <dl class=""row"">
                                                <dt class=""col-md-2"">
                                                    Điểm:
                                                </dt>
                                                <dd class=""col-md-10"">
                                                    ");
#nullable restore
#line 197 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
                                                Write(projectSchedules[i].Rating?.ToString() ?? "Chưa chấm điểm");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </dd>
                                                <dt class=""col-md-2"">
                                                    Đánh giá:
                                                </dt>
                                                <dd class=""col-md-10"">
                                                    ");
#nullable restore
#line 203 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
                                               Write(Html.Raw(projectSchedules[i].Comment));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </dd>
                                            </dl>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 213 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication.Models.Project> Html { get; private set; }
    }
}
#pragma warning restore 1591
