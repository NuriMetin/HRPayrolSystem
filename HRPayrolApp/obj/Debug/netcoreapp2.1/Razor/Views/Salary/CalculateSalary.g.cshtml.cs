#pragma checksum "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Salary\CalculateSalary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "392f9734b808fca22c94762cbfe22828c1d87ae4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Salary_CalculateSalary), @"mvc.1.0.view", @"/Views/Salary/CalculateSalary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Salary/CalculateSalary.cshtml", typeof(AspNetCore.Views_Salary_CalculateSalary))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"392f9734b808fca22c94762cbfe22828c1d87ae4", @"/Views/Salary/CalculateSalary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13263d9f1f4b08adc862554d106b6318a79e7036", @"/Views/_ViewImports.cshtml")]
    public class Views_Salary_CalculateSalary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HRPayrolApp.Models.ViewModels.SalaryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", ":nth-child(9)", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", ":nth-child(10)", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", ":nth-child(11)", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", ":nth-child(12)", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CalculateSalary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Salary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/dist/js/datepicker.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Salary\CalculateSalary.cshtml"
  
    ViewData["Title"] = "CalculateSalary";

#line default
#line hidden
            BeginContext(101, 103, true);
            WriteLiteral("<div class=\"col-md-12\">\r\n    <div style=\"margin-top:10px; overflow-x:auto; overflow-y:auto;\">\r\n        ");
            EndContext();
            BeginContext(204, 3917, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3706700c8a594fe89f949ea506a89026", async() => {
                BeginContext(263, 127, true);
                WriteLiteral("\r\n            <div class=\"d-flex\">\r\n                <select class=\"form-control col-md-3\" id=\"selectFor\">\r\n                    ");
                EndContext();
                BeginContext(390, 27, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74a35b6eb83b44318b4d8d29eaeea77a", async() => {
                    BeginContext(398, 10, true);
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
                BeginContext(417, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(439, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a9153cae4314a2b97f03a6f2e51bf9a", async() => {
                    BeginContext(469, 4, true);
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
                BeginContext(482, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(504, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b035d75f97bf4e8ab415e4aa74608473", async() => {
                    BeginContext(535, 7, true);
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
                BeginContext(551, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(573, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c3e76c7a1204f2388e9068791f71ae3", async() => {
                    BeginContext(604, 8, true);
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
                BeginContext(621, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(643, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75cef693cfb54b8f9084948113693841", async() => {
                    BeginContext(674, 10, true);
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
                BeginContext(693, 1279, true);
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
#line 44 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Salary\CalculateSalary.cshtml"
                     for (int i = 0; i < Model.AvialableWorkers.Count; i++)
                    {

#line default
#line hidden
                BeginContext(2072, 81, true);
                WriteLiteral("                        <tr>\r\n                            <td style=\"padding:0;\">");
                EndContext();
                BeginContext(2154, 57, false);
#line 47 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Salary\CalculateSalary.cshtml"
                                              Write(Html.HiddenFor(x => Model.AvialableWorkers[i].EmployeeId));

#line default
#line hidden
                EndContext();
                BeginContext(2211, 58, true);
                WriteLiteral("</td>\r\n                            <td style=\"padding:0;\">");
                EndContext();
                BeginContext(2270, 59, false);
#line 48 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Salary\CalculateSalary.cshtml"
                                              Write(Html.HiddenFor(x => Model.AvialableWorkers[i].IDCardNumber));

#line default
#line hidden
                EndContext();
                BeginContext(2329, 58, true);
                WriteLiteral("</td>\r\n                            <td style=\"padding:0;\">");
                EndContext();
                BeginContext(2388, 58, false);
#line 49 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Salary\CalculateSalary.cshtml"
                                              Write(Html.HiddenFor(x => Model.AvialableWorkers[i].TotalSalary));

#line default
#line hidden
                EndContext();
                BeginContext(2446, 58, true);
                WriteLiteral("</td>\r\n                            <td style=\"padding:0;\">");
                EndContext();
                BeginContext(2505, 59, false);
#line 50 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Salary\CalculateSalary.cshtml"
                                              Write(Html.HiddenFor(x => Model.AvialableWorkers[i].OldCalculate));

#line default
#line hidden
                EndContext();
                BeginContext(2564, 58, true);
                WriteLiteral("</td>\r\n                            <td style=\"padding:0;\">");
                EndContext();
                BeginContext(2623, 51, false);
#line 51 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Salary\CalculateSalary.cshtml"
                                              Write(Html.HiddenFor(x => Model.AvialableWorkers[i].Name));

#line default
#line hidden
                EndContext();
                BeginContext(2674, 58, true);
                WriteLiteral("</td>\r\n                            <td style=\"padding:0;\">");
                EndContext();
                BeginContext(2733, 54, false);
#line 52 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Salary\CalculateSalary.cshtml"
                                              Write(Html.HiddenFor(x => Model.AvialableWorkers[i].Surname));

#line default
#line hidden
                EndContext();
                BeginContext(2787, 58, true);
                WriteLiteral("</td>\r\n                            <td style=\"padding:0;\">");
                EndContext();
                BeginContext(2846, 55, false);
#line 53 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Salary\CalculateSalary.cshtml"
                                              Write(Html.HiddenFor(x => Model.AvialableWorkers[i].Position));

#line default
#line hidden
                EndContext();
                BeginContext(2901, 73, true);
                WriteLiteral("</td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(2975, 59, false);
#line 55 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Salary\CalculateSalary.cshtml"
                           Write(Html.CheckBoxFor(it => Model.AvialableWorkers[i].IsChecked));

#line default
#line hidden
                EndContext();
                BeginContext(3034, 69, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>");
                EndContext();
                BeginContext(3104, 30, false);
#line 57 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Salary\CalculateSalary.cshtml"
                           Write(Model.AvialableWorkers[i].Name);

#line default
#line hidden
                EndContext();
                BeginContext(3134, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(3174, 33, false);
#line 58 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Salary\CalculateSalary.cshtml"
                           Write(Model.AvialableWorkers[i].Surname);

#line default
#line hidden
                EndContext();
                BeginContext(3207, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(3247, 34, false);
#line 59 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Salary\CalculateSalary.cshtml"
                           Write(Model.AvialableWorkers[i].Position);

#line default
#line hidden
                EndContext();
                BeginContext(3281, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(3321, 36, false);
#line 60 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Salary\CalculateSalary.cshtml"
                           Write(Model.AvialableWorkers[i].Department);

#line default
#line hidden
                EndContext();
                BeginContext(3357, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(3397, 31, false);
#line 61 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Salary\CalculateSalary.cshtml"
                           Write(Model.AvialableWorkers[i].Bonus);

#line default
#line hidden
                EndContext();
                BeginContext(3428, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(3468, 39, false);
#line 62 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Salary\CalculateSalary.cshtml"
                           Write(Model.AvialableWorkers[i].MonthlySalary);

#line default
#line hidden
                EndContext();
                BeginContext(3507, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(3547, 63, false);
#line 63 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Salary\CalculateSalary.cshtml"
                           Write(Model.AvialableWorkers[i].OldCalculate.Date.ToShortDateString());

#line default
#line hidden
                EndContext();
                BeginContext(3610, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(3650, 41, false);
#line 64 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Salary\CalculateSalary.cshtml"
                           Write(Model.AvialableWorkers[i].ExcusableAbsens);

#line default
#line hidden
                EndContext();
                BeginContext(3691, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(3731, 43, false);
#line 65 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Salary\CalculateSalary.cshtml"
                           Write(Model.AvialableWorkers[i].UnExcusableAbsens);

#line default
#line hidden
                EndContext();
                BeginContext(3774, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(3814, 37, false);
#line 66 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Salary\CalculateSalary.cshtml"
                           Write(Model.AvialableWorkers[i].TotalSalary);

#line default
#line hidden
                EndContext();
                BeginContext(3851, 38, true);
                WriteLiteral("</td>\r\n                        </tr>\r\n");
                EndContext();
#line 68 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Salary\CalculateSalary.cshtml"
                    }

#line default
#line hidden
                BeginContext(3912, 202, true);
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4121, 114, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js\"></script>\r\n\r\n");
            EndContext();
            BeginContext(4235, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd4a8560beef468697f7c2b5beb7e51d", async() => {
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
            BeginContext(4272, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4274, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4ebeb8a621e43f2be1ce5885bc1d07a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
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
