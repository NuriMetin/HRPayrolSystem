#pragma checksum "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6bd2b063dd4a5e517969f6fe347d5f7a71fb474"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6bd2b063dd4a5e517969f6fe347d5f7a71fb474", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bddf2b62846d498147e7df70aa91c40a643666ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HRPayrollSystem.Models.ViewModels.SalaryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Salary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(95, 105, true);
            WriteLiteral("\r\n<div class=\"col-md-12\">\r\n    <div style=\"margin-top:10px; overflow-x:auto; overflow-y:auto;\">\r\n        ");
            EndContext();
            BeginContext(200, 713, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f51809c8a350421db21d1e171aa626c7", async() => {
                BeginContext(261, 645, true);
                WriteLiteral(@"
            <div class=""d-flex"">
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(913, 544, true);
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
#line 38 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Home\Index.cshtml"
                 for (int i = 0; i < Model.AvialableWorkers.Count; i++)
                {

#line default
#line hidden
            BeginContext(1549, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1604, 30, false);
#line 41 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Home\Index.cshtml"
                       Write(Model.AvialableWorkers[i].Name);

#line default
#line hidden
            EndContext();
            BeginContext(1634, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1670, 33, false);
#line 42 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Home\Index.cshtml"
                       Write(Model.AvialableWorkers[i].Surname);

#line default
#line hidden
            EndContext();
            BeginContext(1703, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1739, 34, false);
#line 43 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Home\Index.cshtml"
                       Write(Model.AvialableWorkers[i].Position);

#line default
#line hidden
            EndContext();
            BeginContext(1773, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1809, 36, false);
#line 44 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Home\Index.cshtml"
                       Write(Model.AvialableWorkers[i].Department);

#line default
#line hidden
            EndContext();
            BeginContext(1845, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1881, 31, false);
#line 45 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Home\Index.cshtml"
                       Write(Model.AvialableWorkers[i].Bonus);

#line default
#line hidden
            EndContext();
            BeginContext(1912, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1948, 57, false);
#line 46 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Home\Index.cshtml"
                       Write(decimal.Round(@Model.AvialableWorkers[i].MonthlySalary,2));

#line default
#line hidden
            EndContext();
            BeginContext(2005, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2041, 41, false);
#line 47 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Home\Index.cshtml"
                       Write(Model.AvialableWorkers[i].ExcusableAbsens);

#line default
#line hidden
            EndContext();
            BeginContext(2082, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2118, 43, false);
#line 48 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Home\Index.cshtml"
                       Write(Model.AvialableWorkers[i].UnExcusableAbsens);

#line default
#line hidden
            EndContext();
            BeginContext(2161, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2197, 55, false);
#line 49 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Home\Index.cshtml"
                       Write(decimal.Round(@Model.AvialableWorkers[i].TotalSalary,2));

#line default
#line hidden
            EndContext();
            BeginContext(2252, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 51 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2305, 58, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
