#pragma checksum "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Ajax\LoadBonusWorkerList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e1f710dcfbd7856f81c882256400fbfe103566a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ajax_LoadBonusWorkerList), @"mvc.1.0.view", @"/Views/Ajax/LoadBonusWorkerList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ajax/LoadBonusWorkerList.cshtml", typeof(AspNetCore.Views_Ajax_LoadBonusWorkerList))]
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
#line 1 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Ajax\LoadBonusWorkerList.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e1f710dcfbd7856f81c882256400fbfe103566a", @"/Views/Ajax/LoadBonusWorkerList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bddf2b62846d498147e7df70aa91c40a643666ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Ajax_LoadBonusWorkerList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WorkersViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddBonus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Bonus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Ajax\LoadBonusWorkerList.cshtml"
  
    Layout = null;

#line default
#line hidden
#line 6 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Ajax\LoadBonusWorkerList.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(136, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(159, 9, false);
#line 9 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Ajax\LoadBonusWorkerList.cshtml"
       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(168, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(188, 12, false);
#line 10 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Ajax\LoadBonusWorkerList.cshtml"
       Write(item.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(200, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(220, 13, false);
#line 11 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Ajax\LoadBonusWorkerList.cshtml"
       Write(item.Position);

#line default
#line hidden
            EndContext();
            BeginContext(233, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(253, 15, false);
#line 12 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Ajax\LoadBonusWorkerList.cshtml"
       Write(item.Department);

#line default
#line hidden
            EndContext();
            BeginContext(268, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(288, 34, false);
#line 13 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Ajax\LoadBonusWorkerList.cshtml"
       Write(item.BeginDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(322, 33, true);
            WriteLiteral("</td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(355, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "775d945eb6114c32b50c356b4f688c86", async() => {
                BeginContext(433, 9, true);
                WriteLiteral("Add Bonus");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 15 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Ajax\LoadBonusWorkerList.cshtml"
                                                              WriteLiteral(item.WorkerId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(446, 28, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 18 "M:\Dərslər\Programmer\BackEnd\Projects\FinalProject\HRPayrol\HRPayrollSystem\Views\Ajax\LoadBonusWorkerList.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WorkersViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
