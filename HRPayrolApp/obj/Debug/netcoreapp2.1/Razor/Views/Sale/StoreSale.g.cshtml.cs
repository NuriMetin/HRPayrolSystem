#pragma checksum "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Sale\StoreSale.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dd11c2b34d3353db8e5f4ddf846db0ae44bcd6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sale_StoreSale), @"mvc.1.0.view", @"/Views/Sale/StoreSale.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sale/StoreSale.cshtml", typeof(AspNetCore.Views_Sale_StoreSale))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dd11c2b34d3353db8e5f4ddf846db0ae44bcd6f", @"/Views/Sale/StoreSale.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13263d9f1f4b08adc862554d106b6318a79e7036", @"/Views/_ViewImports.cshtml")]
    public class Views_Sale_StoreSale : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AvialableStores>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", ":nth-child(1)", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Bonus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StoreBonus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Sale\StoreSale.cshtml"
  
    ViewData["Title"] = "StoreSale";

#line default
#line hidden
            BeginContext(82, 198, true);
            WriteLiteral("\r\n<h2>StoreSale</h2>\r\n\r\n<div class=\"container\">\r\n    <div style=\"overflow-x:auto;\">\r\n        <div class=\"d-flex\">\r\n            <select class=\"form-control col-md-2\" id=\"selectFor\">\r\n                ");
            EndContext();
            BeginContext(280, 27, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b9cef10a5404b838d683b1584e7df4c", async() => {
                BeginContext(288, 10, true);
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
            BeginContext(307, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(325, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4a299f9d08640b1a728b66299694619", async() => {
                BeginContext(355, 4, true);
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
            BeginContext(368, 246, true);
            WriteLiteral("\r\n            </select>\r\n            <div class=\"form-group col-md-3\">\r\n                <input type=\"search\" class=\"form-control\" id=\"txtSearch\" placeholder=\"Store name\" />\r\n            </div>\r\n            <div class=\"col-md-7\">\r\n                ");
            EndContext();
            BeginContext(614, 538, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "678cf7aa1fee477a8f7d7b92f9c2d8e8", async() => {
                BeginContext(667, 478, true);
                WriteLiteral(@"
                    <div class=""d-flex"">
                        <div class=""form-group col-md-6"">
                            <input type=""text"" class=""form-control"" name=""requiredSalary"" placeholder=""Required amount"" />
                        </div>
                        <div class=""col-md-3"">
                            <input type=""submit"" value=""Add Bonus"" class=""btn btn-success"" />
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1152, 264, true);
            WriteLiteral(@"
            </div>
        </div>
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Salary</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 39 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Sale\StoreSale.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1481, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1528, 14, false);
#line 42 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Sale\StoreSale.cshtml"
                   Write(item.StoreName);

#line default
#line hidden
            EndContext();
            BeginContext(1542, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1574, 15, false);
#line 43 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Sale\StoreSale.cshtml"
                   Write(item.SaleSalary);

#line default
#line hidden
            EndContext();
            BeginContext(1589, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 45 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrolApp\Views\Sale\StoreSale.cshtml"
                }

#line default
#line hidden
            BeginContext(1638, 150, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js\"></script>\r\n");
            EndContext();
            BeginContext(1788, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c49b3a607f64049ad172edc5992b1eb", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AvialableStores>> Html { get; private set; }
    }
}
#pragma warning restore 1591
