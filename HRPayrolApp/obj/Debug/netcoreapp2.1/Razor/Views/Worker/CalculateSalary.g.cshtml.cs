#pragma checksum "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\CalculateSalary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ab29f6ceca77d5b7c9167b60c528a2b22dc2e2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Worker_CalculateSalary), @"mvc.1.0.view", @"/Views/Worker/CalculateSalary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Worker/CalculateSalary.cshtml", typeof(AspNetCore.Views_Worker_CalculateSalary))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ab29f6ceca77d5b7c9167b60c528a2b22dc2e2f", @"/Views/Worker/CalculateSalary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13263d9f1f4b08adc862554d106b6318a79e7036", @"/Views/_ViewImports.cshtml")]
    public class Views_Worker_CalculateSalary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HRPayrolApp.Models.ViewModels.SalaryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", ":nth-child(9)", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", ":nth-child(10)", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", ":nth-child(11)", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", ":nth-child(12)", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CalculateSalary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/dist/js/datepicker.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\CalculateSalary.cshtml"
  
    ViewData["Title"] = "CalculateSalary";

#line default
#line hidden
            BeginContext(101, 103, true);
            WriteLiteral("<div class=\"col-md-12\">\r\n    <div style=\"margin-top:10px; overflow-x:auto; overflow-y:auto;\">\r\n        ");
            EndContext();
            BeginContext(204, 3805, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bb932098b3345168cc8fa8764cd0ccd", async() => {
                BeginContext(239, 127, true);
                WriteLiteral("\r\n            <div class=\"d-flex\">\r\n                <select class=\"form-control col-md-3\" id=\"selectFor\">\r\n                    ");
                EndContext();
                BeginContext(366, 27, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fa8a68bcb26430cbe03b1901c9dc770", async() => {
                    BeginContext(374, 10, true);
                    WriteLiteral("Select for");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(393, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(415, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f163a4e8f84d4493ba73de6cdcb987e6", async() => {
                    BeginContext(445, 4, true);
                    WriteLiteral("Name");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(458, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(480, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "877ed47046864e90b44887d73dd85a9b", async() => {
                    BeginContext(511, 7, true);
                    WriteLiteral("Surname");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(527, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(549, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4474fe98b0e642edaee005bc92d801ed", async() => {
                    BeginContext(580, 8, true);
                    WriteLiteral("Position");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(597, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(619, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a84f00653c4414cb0ff27ba22e2cc53", async() => {
                    BeginContext(650, 10, true);
                    WriteLiteral("Department");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(669, 1279, true);
                WriteLiteral(@"
                </select>
                <div class=""form-group col-md-3"">
                    <input type=""text"" class=""form-control"" id=""txtSearch"" placeholder=""Write..."" />
                </div>
            </div>
            <table class=""table table-striped"">
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
                        <th>Position</th>
                        <th>Department</th>
                        <th>Bonus</th>
                        <th>Monthly Salary</th>
                     ");
                WriteLiteral("   <th>SelectedDate</th>\r\n                        <th>Excusable Absens</th>\r\n                        <th>UnExcusable Absens</th>\r\n                        <th>Total Salary</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
                EndContext();
#line 44 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\CalculateSalary.cshtml"
                     for (int i = 0; i < Model.AvialableWorkers.Count; i++)
                    {

#line default
#line hidden
                BeginContext(2048, 73, true);
                WriteLiteral("                    <tr>\r\n                        <td style=\"padding:0;\">");
                EndContext();
                BeginContext(2122, 57, false);
#line 47 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\CalculateSalary.cshtml"
                                          Write(Html.HiddenFor(x => Model.AvialableWorkers[i].EmployeeId));

#line default
#line hidden
                EndContext();
                BeginContext(2179, 54, true);
                WriteLiteral("</td>\r\n                        <td style=\"padding:0;\">");
                EndContext();
                BeginContext(2234, 59, false);
#line 48 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\CalculateSalary.cshtml"
                                          Write(Html.HiddenFor(x => Model.AvialableWorkers[i].IDCardNumber));

#line default
#line hidden
                EndContext();
                BeginContext(2293, 54, true);
                WriteLiteral("</td>\r\n                        <td style=\"padding:0;\">");
                EndContext();
                BeginContext(2348, 58, false);
#line 49 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\CalculateSalary.cshtml"
                                          Write(Html.HiddenFor(x => Model.AvialableWorkers[i].TotalSalary));

#line default
#line hidden
                EndContext();
                BeginContext(2406, 54, true);
                WriteLiteral("</td>\r\n                        <td style=\"padding:0;\">");
                EndContext();
                BeginContext(2461, 59, false);
#line 50 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\CalculateSalary.cshtml"
                                          Write(Html.HiddenFor(x => Model.AvialableWorkers[i].OldCalculate));

#line default
#line hidden
                EndContext();
                BeginContext(2520, 54, true);
                WriteLiteral("</td>\r\n                        <td style=\"padding:0;\">");
                EndContext();
                BeginContext(2575, 51, false);
#line 51 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\CalculateSalary.cshtml"
                                          Write(Html.HiddenFor(x => Model.AvialableWorkers[i].Name));

#line default
#line hidden
                EndContext();
                BeginContext(2626, 54, true);
                WriteLiteral("</td>\r\n                        <td style=\"padding:0;\">");
                EndContext();
                BeginContext(2681, 54, false);
#line 52 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\CalculateSalary.cshtml"
                                          Write(Html.HiddenFor(x => Model.AvialableWorkers[i].Surname));

#line default
#line hidden
                EndContext();
                BeginContext(2735, 54, true);
                WriteLiteral("</td>\r\n                        <td style=\"padding:0;\">");
                EndContext();
                BeginContext(2790, 55, false);
#line 53 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\CalculateSalary.cshtml"
                                          Write(Html.HiddenFor(x => Model.AvialableWorkers[i].Position));

#line default
#line hidden
                EndContext();
                BeginContext(2845, 65, true);
                WriteLiteral("</td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(2911, 59, false);
#line 55 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\CalculateSalary.cshtml"
                       Write(Html.CheckBoxFor(it => Model.AvialableWorkers[i].IsChecked));

#line default
#line hidden
                EndContext();
                BeginContext(2970, 61, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>");
                EndContext();
                BeginContext(3032, 30, false);
#line 57 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\CalculateSalary.cshtml"
                       Write(Model.AvialableWorkers[i].Name);

#line default
#line hidden
                EndContext();
                BeginContext(3062, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(3098, 33, false);
#line 58 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\CalculateSalary.cshtml"
                       Write(Model.AvialableWorkers[i].Surname);

#line default
#line hidden
                EndContext();
                BeginContext(3131, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(3167, 34, false);
#line 59 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\CalculateSalary.cshtml"
                       Write(Model.AvialableWorkers[i].Position);

#line default
#line hidden
                EndContext();
                BeginContext(3201, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(3237, 36, false);
#line 60 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\CalculateSalary.cshtml"
                       Write(Model.AvialableWorkers[i].Department);

#line default
#line hidden
                EndContext();
                BeginContext(3273, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(3309, 31, false);
#line 61 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\CalculateSalary.cshtml"
                       Write(Model.AvialableWorkers[i].Bonus);

#line default
#line hidden
                EndContext();
                BeginContext(3340, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(3376, 39, false);
#line 62 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\CalculateSalary.cshtml"
                       Write(Model.AvialableWorkers[i].MonthlySalary);

#line default
#line hidden
                EndContext();
                BeginContext(3415, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(3451, 63, false);
#line 63 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\CalculateSalary.cshtml"
                       Write(Model.AvialableWorkers[i].OldCalculate.Date.ToShortDateString());

#line default
#line hidden
                EndContext();
                BeginContext(3514, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(3550, 41, false);
#line 64 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\CalculateSalary.cshtml"
                       Write(Model.AvialableWorkers[i].ExcusableAbsens);

#line default
#line hidden
                EndContext();
                BeginContext(3591, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(3627, 43, false);
#line 65 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\CalculateSalary.cshtml"
                       Write(Model.AvialableWorkers[i].UnExcusableAbsens);

#line default
#line hidden
                EndContext();
                BeginContext(3670, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(3706, 37, false);
#line 66 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\CalculateSalary.cshtml"
                       Write(Model.AvialableWorkers[i].TotalSalary);

#line default
#line hidden
                EndContext();
                BeginContext(3743, 34, true);
                WriteLiteral("</td>\r\n                    </tr>\r\n");
                EndContext();
#line 68 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Worker\CalculateSalary.cshtml"
                    }

#line default
#line hidden
                BeginContext(3800, 202, true);
                WriteLiteral("                </tbody>\r\n            </table>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Calculate\" class=\"btn btn-default calc\" />\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4009, 114, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js\"></script>\r\n\r\n");
            EndContext();
            BeginContext(4123, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66d95c5fc5404de6bb760c843ba19d11", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4160, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4162, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1533170351394fc7a7c03c4271fa3569", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HRPayrolApp.Models.ViewModels.SalaryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
