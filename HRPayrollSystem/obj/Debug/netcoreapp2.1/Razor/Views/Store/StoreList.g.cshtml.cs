#pragma checksum "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Store\StoreList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec2a86b4ec7327b81a824bba5086c362b0cf29ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_StoreList), @"mvc.1.0.view", @"/Views/Store/StoreList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Store/StoreList.cshtml", typeof(AspNetCore.Views_Store_StoreList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec2a86b4ec7327b81a824bba5086c362b0cf29ac", @"/Views/Store/StoreList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bddf2b62846d498147e7df70aa91c40a643666ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_StoreList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StoreViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StoreBonus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Bonus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Store", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Store\StoreList.cshtml"
  
    ViewData["Title"] = "StoreList";

#line default
#line hidden
            BeginContext(81, 51, true);
            WriteLiteral("\r\n<h2>StoreList</h2>\r\n<div class=\"container\">\r\n    ");
            EndContext();
            BeginContext(132, 786, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c4b30cd96e745548d1b33ee897bac0b", async() => {
                BeginContext(198, 32, true);
                WriteLiteral("\r\n        <div class=\"d-flex\">\r\n");
                EndContext();
#line 10 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Store\StoreList.cshtml"
             if (User.IsInRole(SD.PayrollSpecalist))
            {

#line default
#line hidden
                BeginContext(299, 575, true);
                WriteLiteral(@"                <div class=""form-group col-md-3"">
                    <input type=""text"" value=""Select date""
                           class=""datepicker-here form-control""
                           data-language='en'
                           data-min-view=""months""
                           data-view=""months""
                           data-date-format=""MM yyyy"" name=""selectedDate"" />
                </div>
                <div class=""form-group"">
                    <input type=""submit"" value=""Get"" class=""btn btn-primary calc"" />
                </div>
");
                EndContext();
#line 23 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Store\StoreList.cshtml"
            }

#line default
#line hidden
                BeginContext(889, 22, true);
                WriteLiteral("\r\n        </div>\r\n    ");
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
            BeginContext(918, 174, true);
            WriteLiteral("\r\n    <table class=\"table table-striped\">\r\n        <thead style=\"font-weight:bold;\">\r\n            <tr>\r\n                <td>Name</td>\r\n                <td>Company Name</td>\r\n");
            EndContext();
#line 32 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Store\StoreList.cshtml"
                 if (User.IsInRole(SD.Admin.ToString()))
                {

#line default
#line hidden
            BeginContext(1169, 41, true);
            WriteLiteral("                    <td>Operations</td>\r\n");
            EndContext();
#line 35 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Store\StoreList.cshtml"
                }

#line default
#line hidden
            BeginContext(1229, 75, true);
            WriteLiteral("                </tr>\r\n        </thead>\r\n        <tbody id=\"storeAppend\">\r\n");
            EndContext();
#line 39 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Store\StoreList.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1361, 64, true);
            WriteLiteral("                <tr class=\"td-height\">\r\n                    <td>");
            EndContext();
            BeginContext(1426, 9, false);
#line 42 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Store\StoreList.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1435, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1467, 17, false);
#line 43 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Store\StoreList.cshtml"
                   Write(item.Company.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1484, 33, true);
            WriteLiteral("</td>\r\n                    <td>\r\n");
            EndContext();
#line 45 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Store\StoreList.cshtml"
                         if (User.IsInRole(SD.Admin.ToString()))
                        {

#line default
#line hidden
            BeginContext(1610, 74, true);
            WriteLiteral("                        <div class=\"d-flex\">\r\n                            ");
            EndContext();
            BeginContext(1684, 300, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae06fe22978e4220b3970f2f28b5f7aa", async() => {
                BeginContext(1769, 64, true);
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"ID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1833, "\"", 1849, 1);
#line 49 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Store\StoreList.cshtml"
WriteAttributeValue("", 1841, item.ID, 1841, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1850, 127, true);
                WriteLiteral(" />\r\n                                <input type=\"submit\" value=\"Edit\" class=\"btn btn-primary\" />\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Store\StoreList.cshtml"
                                                                                          WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1984, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2014, 316, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60182b8326dd43b2a60db87783907fe1", async() => {
                BeginContext(2102, 64, true);
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"ID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2166, "\"", 2182, 1);
#line 53 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Store\StoreList.cshtml"
WriteAttributeValue("", 2174, item.ID, 2174, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2183, 140, true);
                WriteLiteral(" />\r\n                                <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger btn-padding\" />\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Store\StoreList.cshtml"
                                                                                             WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2330, 34, true);
            WriteLiteral("\r\n                        </div>\r\n");
            EndContext();
#line 57 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Store\StoreList.cshtml"
                        }  

#line default
#line hidden
            BeginContext(2393, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 60 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Store\StoreList.cshtml"
            }

#line default
#line hidden
            BeginContext(2458, 100, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <input type=\"hidden\" class=\"storeSkipcount\" id=\"storeTotalCount\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2558, "\"", 2584, 1);
#line 63 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Store\StoreList.cshtml"
WriteAttributeValue("", 2566, ViewBag.SkipCount, 2566, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2585, 13, true);
            WriteLiteral(" />\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StoreViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
