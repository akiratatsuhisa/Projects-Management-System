#pragma checksum "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c36b90742c40840f5859d7294992defab3d172d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Details), @"mvc.1.0.view", @"/Views/Projects/Details.cshtml")]
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
#line 1 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c36b90742c40840f5859d7294992defab3d172d8", @"/Views/Projects/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication.Models.Project>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateNewReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
  
    ViewData["Title"] = "Đồ án - " + Model.Title;
    List<ProjectSchedule> projectSchedules = ViewBag.ProjectSchedules;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"section\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-8 ml-auto mr-auto\">\r\n                <h2 class=\"title\">\r\n                    ");
#nullable restore
#line 13 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
               Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </h2>
            </div>
        </div>
    </div>
</div>

<div class=""section"" style=""background: #EEEEEE;"">
    <div class=""container"">
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
#line 30 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
                             for (var i = 0; i < projectSchedules.Count; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"nav-item\"><a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 1194, "\"", 1218, 2);
            WriteAttributeValue("", 1201, "#list-week-", 1201, 11, true);
#nullable restore
#line 32 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
WriteAttributeValue("", 1212, i+1, 1212, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tab\">Tuần ");
#nullable restore
#line 32 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
                                                                                                                     Write(i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 33 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
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
#line 52 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
                                     foreach (ProjectMember item in ViewBag.ProjectMembers)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <dt class=""col-md-2"">
                                            Tên:
                                        </dt>
                                        <dd class=""col-md-10"">
                                            ");
#nullable restore
#line 58 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
                                       Write(item.Student.ApplicationUser.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 58 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
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
#line 64 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
                                       Write(item.Student.StudentCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dd>\r\n");
#nullable restore
#line 66 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </dl>

                                <hr />
                                <h3 class=""info-title"">Thông tin</h3>
                                <dl class=""row"">
                                    <dt class=""col-md-2"">
                                        ");
#nullable restore
#line 73 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
                                   Write(Html.DisplayNameFor(model => model.LecturerId));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                                    </dt>\r\n                                    <dd class=\"col-md-10\">\r\n                                        ");
#nullable restore
#line 76 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
                                   Write(Model.Lecturer.ApplicationUser.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 76 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
                                                                             Write(Model.Lecturer.ApplicationUser.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dd>\r\n                                    <dt class=\"col-md-2\">\r\n                                        ");
#nullable restore
#line 79 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                                    </dt>\r\n                                    <dd class=\"col-md-10\">\r\n                                        ");
#nullable restore
#line 82 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dd>\r\n                                </dl>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <!--Tuần-->\r\n                    <!--Tiến trình-->\r\n");
#nullable restore
#line 90 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
                     for (var i = 0; i < projectSchedules.Count; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"tab-pane\"");
            BeginWriteAttribute("id", " id=\"", 4359, "\"", 4380, 2);
            WriteAttributeValue("", 4364, "list-week-", 4364, 10, true);
#nullable restore
#line 92 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
WriteAttributeValue("", 4374, i+1, 4374, 6, false);

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
            BeginWriteAttribute("href", " href=\"", 4735, "\"", 4756, 2);
            WriteAttributeValue("", 4742, "#demand-", 4742, 8, true);
#nullable restore
#line 97 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
WriteAttributeValue("", 4750, i+1, 4750, 6, false);

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
            BeginWriteAttribute("href", " href=\"", 5161, "\"", 5182, 2);
            WriteAttributeValue("", 5168, "#report-", 5168, 8, true);
#nullable restore
#line 104 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
WriteAttributeValue("", 5176, i+1, 5176, 6, false);

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
            BeginWriteAttribute("href", " href=\"", 5585, "\"", 5606, 2);
            WriteAttributeValue("", 5592, "#rating-", 5592, 8, true);
#nullable restore
#line 111 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
WriteAttributeValue("", 5600, i+1, 5600, 6, false);

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
            BeginWriteAttribute("id", " id=\"", 6172, "\"", 6190, 2);
            WriteAttributeValue("", 6177, "demand-", 6177, 7, true);
#nullable restore
#line 121 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
WriteAttributeValue("", 6184, i+1, 6184, 6, false);

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
            WriteLiteral("                                                            ");
#nullable restore
#line 136 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
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
            BeginWriteAttribute("class", " class=\"", 7727, "\"", 7825, 1);
#nullable restore
#line 142 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
WriteAttributeValue("", 7735, projectSchedules[i].ExpiredDate.Date < DateTime.Now.Date ? "text-danger":"text-success", 7735, 90, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                ");
#nullable restore
#line 143 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
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
#line 150 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
                                         if (!string.IsNullOrWhiteSpace(projectSchedules[i].Description))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <div class=""col-12"">
                                                <div class=""card"">
                                                    <div class=""card-header card-header-text card-header-info"">
                                                        <div class=""card-text"">
                                                            <h4 class=""card-title"">Mô tả</h4>
                                                        </div>
                                                    </div>
                                                    <div class=""card-body"">
                                                        ");
#nullable restore
#line 160 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
                                                   Write(Html.Raw(projectSchedules[i].Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </div>\r\n                                                </div>\r\n                                            </div>\r\n");
#nullable restore
#line 164 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div>\r\n                                <!--Báo cáo-->\r\n                                <div class=\"tab-pane\"");
            BeginWriteAttribute("id", " id=\"", 9564, "\"", 9582, 2);
            WriteAttributeValue("", 9569, "report-", 9569, 7, true);
#nullable restore
#line 168 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
WriteAttributeValue("", 9576, i+1, 9576, 6, false);

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
                                                        <h4 class=""card-title"">Báo cáo</h4>
                                                    </div>
                                                </div>
                                                <div class=""card-body"">
");
#nullable restore
#line 178 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
                                                     if (projectSchedules[i].ExpiredDate.Date < DateTime.Now.Date)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <h3 class=\"title text-danger text-center\">Đã hết hạn nộp</h3>\r\n");
#nullable restore
#line 181 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c36b90742c40840f5859d7294992defab3d172d823953", async() => {
                WriteLiteral("\r\n                                                            <input type=\"hidden\" name=\"ProjectId\"");
                BeginWriteAttribute("value", " value=\"", 10900, "\"", 10917, 1);
#nullable restore
#line 185 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
WriteAttributeValue("", 10908, Model.Id, 10908, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                            <input type=\"hidden\" name=\"ProjectScheduleId\"");
                BeginWriteAttribute("value", " value=\"", 11026, "\"", 11057, 1);
#nullable restore
#line 186 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
WriteAttributeValue("", 11034, projectSchedules[i].Id, 11034, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                                            <div class=""form-group"">
                                                                <label for=""ReportUrl"">Report Url</label>
                                                                <input type=""url"" class=""form-control"" name=""ReportUrl"" placeholder=""Nhập Url"">
                                                            </div>
                                                            <div class=""form-group"">
                                                                <label for=""Note"">Ghi chú</label>
                                                                <textarea class=""form-control"" name=""Note"" rows=""4""></textarea>
                                                            </div>
                                                            <div class=""form-group"">
                                                                <button type=""submit"" class=""btn btn-success btn-block"">Gửi báo cáo</button>
     ");
                WriteLiteral("                                                       </div>\r\n                                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 199 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                    ");
#nullable restore
#line 204 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
                               Write(await Component.InvokeAsync("ProjectScheduleReports", new { id = projectSchedules[i].Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <!--Đánh giá-->\r\n                                <div class=\"tab-pane\"");
            BeginWriteAttribute("id", " id=\"", 12736, "\"", 12754, 2);
            WriteAttributeValue("", 12741, "rating-", 12741, 7, true);
#nullable restore
#line 207 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
WriteAttributeValue("", 12748, i+1, 12748, 6, false);

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
            WriteLiteral("                                                   ");
#nullable restore
#line 222 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
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
#line 228 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
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
#line 238 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Views\Projects\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
