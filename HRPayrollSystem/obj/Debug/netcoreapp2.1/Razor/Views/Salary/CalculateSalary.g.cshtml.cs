#pragma checksum "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\CalculateSalary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76c1e1059da0197371a28488e1cd90552e916e7c"
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
#line 1 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\_ViewImports.cshtml"
using HRPayrollSystem;

#line default
#line hidden
#line 2 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\_ViewImports.cshtml"
using HRPayrollSystem.Models;

#line default
#line hidden
#line 3 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\_ViewImports.cshtml"
using HRPayrollSystem.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76c1e1059da0197371a28488e1cd90552e916e7c", @"/Views/Salary/CalculateSalary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bddf2b62846d498147e7df70aa91c40a643666ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Salary_CalculateSalary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HRPayrollSystem.Models.ViewModels.SalaryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", ":nth-child(9)", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", ":nth-child(10)", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", ":nth-child(11)", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", ":nth-child(12)", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CalculateSalary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Salary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\CalculateSalary.cshtml"
  
    ViewData["Title"] = "CalculateSalary";

#line default
#line hidden
            BeginContext(105, 115, true);
            WriteLiteral("    <div class=\"col-md-12\">\r\n        <div style=\"margin-top:10px; overflow-x:auto; overflow-y:auto;\">\r\n            ");
            EndContext();
            BeginContext(220, 4199, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f89ec1cd5d6747f8af9874041250d224", async() => {
                BeginContext(279, 139, true);
                WriteLiteral("\r\n                <div class=\"d-flex\">\r\n                    <select class=\"form-control col-md-3\" id=\"selectFor\">\r\n                        ");
                EndContext();
                BeginContext(418, 27, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4145bc10015e4cf3acd2e44dd0d59f02", async() => {
                    BeginContext(426, 10, true);
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
                BeginContext(445, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(471, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a32bbd602c1f49d09c74b88fc8a29fca", async() => {
                    BeginContext(501, 4, true);
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
                BeginContext(514, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(540, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "512b0037a62244b3a21cb8226d58fd89", async() => {
                    BeginContext(571, 7, true);
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
                BeginContext(587, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(613, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5d913a84b344c2ba4935212c0e79f52", async() => {
                    BeginContext(644, 8, true);
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
                BeginContext(661, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(687, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f29e65e9305437aa08f086855193199", async() => {
                    BeginContext(718, 10, true);
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
                BeginContext(737, 1414, true);
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
                            <t");
                WriteLiteral(@"h>Bonus</th>
                            <th>Monthly Salary</th>
                            <th>SelectedDate</th>
                            <th>Excusable Absens</th>
                            <th>UnExcusable Absens</th>
                            <th>Total Salary</th>
                        </tr>
                    </thead>
                    <tbody id=""calcSalAppend"">
");
                EndContext();
#line 44 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\CalculateSalary.cshtml"
                         for (int i = 0; i < Model.AvialableWorkers.Count; i++)
                        {

#line default
#line hidden
                BeginContext(2259, 89, true);
                WriteLiteral("                            <tr>\r\n                                <td style=\"padding:0;\">");
                EndContext();
                BeginContext(2349, 57, false);
#line 47 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\CalculateSalary.cshtml"
                                                  Write(Html.HiddenFor(x => Model.AvialableWorkers[i].EmployeeId));

#line default
#line hidden
                EndContext();
                BeginContext(2406, 62, true);
                WriteLiteral("</td>\r\n                                <td style=\"padding:0;\">");
                EndContext();
                BeginContext(2469, 59, false);
#line 48 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\CalculateSalary.cshtml"
                                                  Write(Html.HiddenFor(x => Model.AvialableWorkers[i].IDCardNumber));

#line default
#line hidden
                EndContext();
                BeginContext(2528, 62, true);
                WriteLiteral("</td>\r\n                                <td style=\"padding:0;\">");
                EndContext();
                BeginContext(2591, 58, false);
#line 49 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\CalculateSalary.cshtml"
                                                  Write(Html.HiddenFor(x => Model.AvialableWorkers[i].TotalSalary));

#line default
#line hidden
                EndContext();
                BeginContext(2649, 62, true);
                WriteLiteral("</td>\r\n                                <td style=\"padding:0;\">");
                EndContext();
                BeginContext(2712, 59, false);
#line 50 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\CalculateSalary.cshtml"
                                                  Write(Html.HiddenFor(x => Model.AvialableWorkers[i].OldCalculate));

#line default
#line hidden
                EndContext();
                BeginContext(2771, 62, true);
                WriteLiteral("</td>\r\n                                <td style=\"padding:0;\">");
                EndContext();
                BeginContext(2834, 51, false);
#line 51 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\CalculateSalary.cshtml"
                                                  Write(Html.HiddenFor(x => Model.AvialableWorkers[i].Name));

#line default
#line hidden
                EndContext();
                BeginContext(2885, 62, true);
                WriteLiteral("</td>\r\n                                <td style=\"padding:0;\">");
                EndContext();
                BeginContext(2948, 54, false);
#line 52 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\CalculateSalary.cshtml"
                                                  Write(Html.HiddenFor(x => Model.AvialableWorkers[i].Surname));

#line default
#line hidden
                EndContext();
                BeginContext(3002, 62, true);
                WriteLiteral("</td>\r\n                                <td style=\"padding:0;\">");
                EndContext();
                BeginContext(3065, 55, false);
#line 53 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\CalculateSalary.cshtml"
                                                  Write(Html.HiddenFor(x => Model.AvialableWorkers[i].Position));

#line default
#line hidden
                EndContext();
                BeginContext(3120, 81, true);
                WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
                EndContext();
                BeginContext(3202, 59, false);
#line 55 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\CalculateSalary.cshtml"
                               Write(Html.CheckBoxFor(it => Model.AvialableWorkers[i].IsChecked));

#line default
#line hidden
                EndContext();
                BeginContext(3261, 77, true);
                WriteLiteral("\r\n                                </td>\r\n                                <td>");
                EndContext();
                BeginContext(3339, 30, false);
#line 57 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\CalculateSalary.cshtml"
                               Write(Model.AvialableWorkers[i].Name);

#line default
#line hidden
                EndContext();
                BeginContext(3369, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(3413, 33, false);
#line 58 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\CalculateSalary.cshtml"
                               Write(Model.AvialableWorkers[i].Surname);

#line default
#line hidden
                EndContext();
                BeginContext(3446, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(3490, 34, false);
#line 59 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\CalculateSalary.cshtml"
                               Write(Model.AvialableWorkers[i].Position);

#line default
#line hidden
                EndContext();
                BeginContext(3524, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(3568, 36, false);
#line 60 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\CalculateSalary.cshtml"
                               Write(Model.AvialableWorkers[i].Department);

#line default
#line hidden
                EndContext();
                BeginContext(3604, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(3648, 31, false);
#line 61 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\CalculateSalary.cshtml"
                               Write(Model.AvialableWorkers[i].Bonus);

#line default
#line hidden
                EndContext();
                BeginContext(3679, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(3723, 39, false);
#line 62 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\CalculateSalary.cshtml"
                               Write(Model.AvialableWorkers[i].MonthlySalary);

#line default
#line hidden
                EndContext();
                BeginContext(3762, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(3806, 63, false);
#line 63 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\CalculateSalary.cshtml"
                               Write(Model.AvialableWorkers[i].OldCalculate.Date.ToShortDateString());

#line default
#line hidden
                EndContext();
                BeginContext(3869, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(3913, 41, false);
#line 64 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\CalculateSalary.cshtml"
                               Write(Model.AvialableWorkers[i].ExcusableAbsens);

#line default
#line hidden
                EndContext();
                BeginContext(3954, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(3998, 43, false);
#line 65 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\CalculateSalary.cshtml"
                               Write(Model.AvialableWorkers[i].UnExcusableAbsens);

#line default
#line hidden
                EndContext();
                BeginContext(4041, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(4085, 37, false);
#line 66 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\CalculateSalary.cshtml"
                               Write(Model.AvialableWorkers[i].TotalSalary);

#line default
#line hidden
                EndContext();
                BeginContext(4122, 42, true);
                WriteLiteral("</td>\r\n                            </tr>\r\n");
                EndContext();
#line 68 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\CalculateSalary.cshtml"
                        }

#line default
#line hidden
                BeginContext(4191, 221, true);
                WriteLiteral("                    </tbody>\r\n                </table>\r\n                <div class=\"form-group\">\r\n                    <input type=\"submit\" value=\"Calculate\" class=\"btn btn-success\" />\r\n                </div>\r\n            ");
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
            BeginContext(4419, 94, true);
            WriteLiteral("\r\n        </div>\r\n        <input type=\"hidden\" class=\"calcSalSkipcount\" id=\"calcSalTotalCount\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4513, "\"", 4539, 1);
#line 76 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\CalculateSalary.cshtml"
WriteAttributeValue("", 4521, ViewBag.SkipCount, 4521, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4540, 17, true);
            WriteLiteral(" />\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HRPayrollSystem.Models.ViewModels.SalaryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
