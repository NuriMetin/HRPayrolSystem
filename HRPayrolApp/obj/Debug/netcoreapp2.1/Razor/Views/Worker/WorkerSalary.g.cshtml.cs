#pragma checksum "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\WorkerSalary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9bb74e24562bfe184ec9d840c3c0b8467640a2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Worker_WorkerSalary), @"mvc.1.0.view", @"/Views/Worker/WorkerSalary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Worker/WorkerSalary.cshtml", typeof(AspNetCore.Views_Worker_WorkerSalary))]
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
#line 1 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\_ViewImports.cshtml"
using HRPayrolApp;

#line default
#line hidden
#line 2 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\_ViewImports.cshtml"
using HRPayrolApp.Models;

#line default
#line hidden
#line 3 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\_ViewImports.cshtml"
using HRPayrolApp.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9bb74e24562bfe184ec9d840c3c0b8467640a2d", @"/Views/Worker/WorkerSalary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ce8ed261b6145b8e374bec8b2996a9722a15e5d", @"/Views/_ViewImports.cshtml")]
    public class Views_Worker_WorkerSalary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HRPayrolApp.Models.ViewModels.WorkerView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "WorkerSalary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\WorkerSalary.cshtml"
  
    ViewData["Title"] = "WorkerSalary";

#line default
#line hidden
            BeginContext(97, 69, true);
            WriteLiteral("<div class=\"col-md-12\">\r\n    <div style=\"margin-top:10px;\">\r\n        ");
            EndContext();
            BeginContext(166, 3100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46af7708c6a543d297a8be0d00c5c84e", async() => {
                BeginContext(198, 1034, true);
                WriteLiteral(@"
            <table class=""table"">
                <thead>
                    <tr>
                        <th style=""padding:0;""></th>
                        <th style=""padding:0;""></th>
                        <th style=""padding:0;""></th>
                        <th style=""padding:0;""></th>
                        <th style=""padding:0;""></th>
                        <th style=""padding:0;""></th>
                        <th style=""padding:0;""></th>
                        <th>Select</th>
                        <th>Name</th>
                        <th>Surname</th>
                        <th>Email</th>
                        <th>Position</th>
                        <th>Department</th>
                        <th>Bonus</th>
                        <th>Monthly Salary</th>
                        <th>Excusable Absens</th>
                        <th>UnExcusable Absens</th>
                        <th>Total Salary</th>
                    </tr>
                </thead>
               ");
                WriteLiteral(" <tbody>\r\n");
                EndContext();
#line 32 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\WorkerSalary.cshtml"
                     for (int i = 0; i < Model.AvialableWorkers.Capacity; i++)
                    {

#line default
#line hidden
                BeginContext(1335, 73, true);
                WriteLiteral("                    <tr>\r\n                        <td style=\"padding:0;\">");
                EndContext();
                BeginContext(1409, 57, false);
#line 35 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\WorkerSalary.cshtml"
                                          Write(Html.HiddenFor(x => Model.AvialableWorkers[i].EmployeeId));

#line default
#line hidden
                EndContext();
                BeginContext(1466, 54, true);
                WriteLiteral("</td>\r\n                        <td style=\"padding:0;\">");
                EndContext();
                BeginContext(1521, 59, false);
#line 36 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\WorkerSalary.cshtml"
                                          Write(Html.HiddenFor(x => Model.AvialableWorkers[i].IDCardNumber));

#line default
#line hidden
                EndContext();
                BeginContext(1580, 54, true);
                WriteLiteral("</td>\r\n                        <td style=\"padding:0;\">");
                EndContext();
                BeginContext(1635, 58, false);
#line 37 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\WorkerSalary.cshtml"
                                          Write(Html.HiddenFor(x => Model.AvialableWorkers[i].TotalSalary));

#line default
#line hidden
                EndContext();
                BeginContext(1693, 54, true);
                WriteLiteral("</td>\r\n                        <td style=\"padding:0;\">");
                EndContext();
                BeginContext(1748, 59, false);
#line 38 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\WorkerSalary.cshtml"
                                          Write(Html.HiddenFor(x => Model.AvialableWorkers[i].OldCalculate));

#line default
#line hidden
                EndContext();
                BeginContext(1807, 54, true);
                WriteLiteral("</td>\r\n                        <td style=\"padding:0;\">");
                EndContext();
                BeginContext(1862, 51, false);
#line 39 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\WorkerSalary.cshtml"
                                          Write(Html.HiddenFor(x => Model.AvialableWorkers[i].Name));

#line default
#line hidden
                EndContext();
                BeginContext(1913, 54, true);
                WriteLiteral("</td>\r\n                        <td style=\"padding:0;\">");
                EndContext();
                BeginContext(1968, 54, false);
#line 40 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\WorkerSalary.cshtml"
                                          Write(Html.HiddenFor(x => Model.AvialableWorkers[i].Surname));

#line default
#line hidden
                EndContext();
                BeginContext(2022, 54, true);
                WriteLiteral("</td>\r\n                        <td style=\"padding:0;\">");
                EndContext();
                BeginContext(2077, 55, false);
#line 41 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\WorkerSalary.cshtml"
                                          Write(Html.HiddenFor(x => Model.AvialableWorkers[i].Position));

#line default
#line hidden
                EndContext();
                BeginContext(2132, 66, true);
                WriteLiteral("</td>z\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(2199, 59, false);
#line 43 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\WorkerSalary.cshtml"
                       Write(Html.CheckBoxFor(it => Model.AvialableWorkers[i].IsChecked));

#line default
#line hidden
                EndContext();
                BeginContext(2258, 61, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>");
                EndContext();
                BeginContext(2320, 30, false);
#line 45 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\WorkerSalary.cshtml"
                       Write(Model.AvialableWorkers[i].Name);

#line default
#line hidden
                EndContext();
                BeginContext(2350, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(2386, 33, false);
#line 46 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\WorkerSalary.cshtml"
                       Write(Model.AvialableWorkers[i].Surname);

#line default
#line hidden
                EndContext();
                BeginContext(2419, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(2455, 31, false);
#line 47 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\WorkerSalary.cshtml"
                       Write(Model.AvialableWorkers[i].Email);

#line default
#line hidden
                EndContext();
                BeginContext(2486, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(2522, 34, false);
#line 48 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\WorkerSalary.cshtml"
                       Write(Model.AvialableWorkers[i].Position);

#line default
#line hidden
                EndContext();
                BeginContext(2556, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(2592, 36, false);
#line 49 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\WorkerSalary.cshtml"
                       Write(Model.AvialableWorkers[i].Department);

#line default
#line hidden
                EndContext();
                BeginContext(2628, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(2664, 31, false);
#line 50 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\WorkerSalary.cshtml"
                       Write(Model.AvialableWorkers[i].Bonus);

#line default
#line hidden
                EndContext();
                BeginContext(2695, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(2731, 39, false);
#line 51 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\WorkerSalary.cshtml"
                       Write(Model.AvialableWorkers[i].MonthlySalary);

#line default
#line hidden
                EndContext();
                BeginContext(2770, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(2806, 41, false);
#line 52 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\WorkerSalary.cshtml"
                       Write(Model.AvialableWorkers[i].ExcusableAbsens);

#line default
#line hidden
                EndContext();
                BeginContext(2847, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(2883, 43, false);
#line 53 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\WorkerSalary.cshtml"
                       Write(Model.AvialableWorkers[i].UnExcusableAbsens);

#line default
#line hidden
                EndContext();
                BeginContext(2926, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(2962, 37, false);
#line 54 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\WorkerSalary.cshtml"
                       Write(Model.AvialableWorkers[i].TotalSalary);

#line default
#line hidden
                EndContext();
                BeginContext(2999, 34, true);
                WriteLiteral("</td>\r\n                    </tr>\r\n");
                EndContext();
#line 56 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\WorkerSalary.cshtml"
                    }

#line default
#line hidden
                BeginContext(3056, 203, true);
                WriteLiteral("                </tbody>\r\n            </table>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Calculate\" class=\"btn btn-default calc\" />\r\n            </div> \r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3266, 205, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\".work\").hide();\r\n        $(\".calc\").click(function () {\r\n            $(\".work\").show();\r\n        })\r\n    \r\n    }\r\n</script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HRPayrolApp.Models.ViewModels.WorkerView> Html { get; private set; }
    }
}
#pragma warning restore 1591
