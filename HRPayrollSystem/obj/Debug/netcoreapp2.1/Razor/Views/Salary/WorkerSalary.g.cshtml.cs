#pragma checksum "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\WorkerSalary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7389852a5af1f45afc273a85e0e0cf24fae7e7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Salary_WorkerSalary), @"mvc.1.0.view", @"/Views/Salary/WorkerSalary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Salary/WorkerSalary.cshtml", typeof(AspNetCore.Views_Salary_WorkerSalary))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7389852a5af1f45afc273a85e0e0cf24fae7e7c", @"/Views/Salary/WorkerSalary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bddf2b62846d498147e7df70aa91c40a643666ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Salary_WorkerSalary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HRPayrollSystem.Models.ViewModels.SalaryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", ":nth-child(1)", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", ":nth-child(2)", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", ":nth-child(3)", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", ":nth-child(4)", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CalculateSalary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Salary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\WorkerSalary.cshtml"
  
    ViewData["Title"] = "WorkerSalary";

#line default
#line hidden
            BeginContext(102, 103, true);
            WriteLiteral("<div class=\"col-md-12\">\r\n    <div style=\"margin-top:10px; overflow-x:auto; overflow-y:auto;\">\r\n        ");
            EndContext();
            BeginContext(205, 1321, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81d4dddb63cf4144aeb33ab4ff2208fc", async() => {
                BeginContext(277, 127, true);
                WriteLiteral("\r\n            <div class=\"d-flex\">\r\n                <select class=\"form-control col-md-3\" id=\"selectFor\">\r\n                    ");
                EndContext();
                BeginContext(404, 27, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "596202d39f5847808b04f335663d8670", async() => {
                    BeginContext(412, 10, true);
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
                BeginContext(431, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(453, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2da0143e91074b4396b2fb23732fd250", async() => {
                    BeginContext(483, 4, true);
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
                BeginContext(496, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(518, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c38d565f2464450836d5f888a98e627", async() => {
                    BeginContext(548, 7, true);
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
                BeginContext(564, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(586, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1db5073d9d1c43d4b3870581b9e7abec", async() => {
                    BeginContext(616, 8, true);
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
                BeginContext(633, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(655, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8890dfea495a468dbdc1085279c78ef4", async() => {
                    BeginContext(685, 10, true);
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
                BeginContext(704, 815, true);
                WriteLiteral(@"
                </select>
                <div class=""form-group col-md-3"">
                    <input type=""text"" class=""form-control"" id=""txtSearch"" placeholder=""Write..."" />
                </div>
                <div class=""form-group col-md-3"">
                    <input type=""text"" value=""Select date""
                           class=""datepicker-here form-control""
                           data-language='en'
                           data-min-view=""months""
                           data-view=""months""
                           data-date-format=""MM yyyy"" name=""selectedDate"" />
                </div>
                <div class=""form-group"">
                    <input type=""submit"" value=""Calculate"" class=""btn btn-primary calc"" />
                </div>
            </div>
        ");
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1526, 544, true);
            WriteLiteral(@"
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Surname</th>
                    <th>Position</th>
                    <th>Department</th>
                    <th>Bonus</th>
                    <th>Monthly Salary</th>
                    <th>Excusable Absens</th>
                    <th>UnExcusable Absens</th>
                    <th>Total Salary</th>
                </tr>
            </thead>
            <tbody id=""forappend"">
");
            EndContext();
#line 47 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\WorkerSalary.cshtml"
                 for (int i = 0; i < Model.AvialableWorkers.Count; i++)
                {

#line default
#line hidden
            BeginContext(2162, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(2217, 30, false);
#line 50 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\WorkerSalary.cshtml"
                       Write(Model.AvialableWorkers[i].Name);

#line default
#line hidden
            EndContext();
            BeginContext(2247, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2283, 33, false);
#line 51 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\WorkerSalary.cshtml"
                       Write(Model.AvialableWorkers[i].Surname);

#line default
#line hidden
            EndContext();
            BeginContext(2316, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2352, 34, false);
#line 52 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\WorkerSalary.cshtml"
                       Write(Model.AvialableWorkers[i].Position);

#line default
#line hidden
            EndContext();
            BeginContext(2386, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2422, 36, false);
#line 53 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\WorkerSalary.cshtml"
                       Write(Model.AvialableWorkers[i].Department);

#line default
#line hidden
            EndContext();
            BeginContext(2458, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2494, 31, false);
#line 54 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\WorkerSalary.cshtml"
                       Write(Model.AvialableWorkers[i].Bonus);

#line default
#line hidden
            EndContext();
            BeginContext(2525, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2561, 57, false);
#line 55 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\WorkerSalary.cshtml"
                       Write(decimal.Round(@Model.AvialableWorkers[i].MonthlySalary,2));

#line default
#line hidden
            EndContext();
            BeginContext(2618, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2654, 41, false);
#line 56 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\WorkerSalary.cshtml"
                       Write(Model.AvialableWorkers[i].ExcusableAbsens);

#line default
#line hidden
            EndContext();
            BeginContext(2695, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2731, 43, false);
#line 57 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\WorkerSalary.cshtml"
                       Write(Model.AvialableWorkers[i].UnExcusableAbsens);

#line default
#line hidden
            EndContext();
            BeginContext(2774, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2810, 55, false);
#line 58 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\WorkerSalary.cshtml"
                       Write(decimal.Round(@Model.AvialableWorkers[i].TotalSalary,2));

#line default
#line hidden
            EndContext();
            BeginContext(2865, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 60 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\WorkerSalary.cshtml"
                }

#line default
#line hidden
            BeginContext(2918, 110, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <input type=\"hidden\" class=\"skipcount\" id=\"totalCount\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3028, "\"", 3054, 1);
#line 64 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Salary\WorkerSalary.cshtml"
WriteAttributeValue("", 3036, ViewBag.SkipCount, 3036, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3055, 13, true);
            WriteLiteral(" />\r\n</div>\r\n");
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
