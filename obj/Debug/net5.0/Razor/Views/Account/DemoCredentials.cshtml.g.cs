#pragma checksum "C:\Users\msh32\source\repos\SDA_Simplilearn\.NET FSD Capstone Project\malshetwi_CapstoneProject_SDA.LMS\Views\Account\DemoCredentials.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "645215d3e548495a8f9dfa918381d8e164121439"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_DemoCredentials), @"mvc.1.0.view", @"/Views/Account/DemoCredentials.cshtml")]
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
#line 1 "C:\Users\msh32\source\repos\SDA_Simplilearn\.NET FSD Capstone Project\malshetwi_CapstoneProject_SDA.LMS\Views\_ViewImports.cshtml"
using malshetwi_CapstoneProject_SDA.LMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\msh32\source\repos\SDA_Simplilearn\.NET FSD Capstone Project\malshetwi_CapstoneProject_SDA.LMS\Views\_ViewImports.cshtml"
using malshetwi_CapstoneProject_SDA.LMS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\msh32\source\repos\SDA_Simplilearn\.NET FSD Capstone Project\malshetwi_CapstoneProject_SDA.LMS\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"645215d3e548495a8f9dfa918381d8e164121439", @"/Views/Account/DemoCredentials.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58194685c21b75e558213e4f6c403eca1baf8640", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_DemoCredentials : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/UX_UI_Design/GitHub_malshetwi.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 46%; width: 26%; position: fixed; right: 220px; bottom: 27.9px; z-index: 0;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\msh32\source\repos\SDA_Simplilearn\.NET FSD Capstone Project\malshetwi_CapstoneProject_SDA.LMS\Views\Account\DemoCredentials.cshtml"
  
    ViewData["Title"] = "Demo credentials";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-8 offset-2\" style=\"z-index:1\">\r\n        <h1><b>");
#nullable restore
#line 7 "C:\Users\msh32\source\repos\SDA_Simplilearn\.NET FSD Capstone Project\malshetwi_CapstoneProject_SDA.LMS\Views\Account\DemoCredentials.cshtml"
          Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></h1>

        <br />
        <h2>Manual of credentials, for Demo use</h2>
        <h3 style=""color:cornflowerblue""><i class=""bi bi-info-circle-fill""></i> Default credentials seeded and created automatically</h3>
        <hr>
        <br />
        <br />
        <h5><b>Admin user credential</b></h5>
        <div class=""form-group"">
            <label class=""control-label"">Email:</label>
            <label class=""control-label"">admin@capstone.com</label>
            <br />
            <label class=""control-label"">Password:</label>
            <label class=""control-label"">!Admin1</label>
        </div>
        <hr>
        <h5><b>Normal/Standard user credential</b></h5>
        <div class=""form-group"">
            <label class=""control-label"">Email:</label>
            <label class=""control-label"">xuser@capstone.com</label>
            <br />
            <label class=""control-label"">Password:</label>
            <label class=""control-label"">!User1</label>
        </div>
    </div>");
            WriteLiteral("\n</div>\r\n<div class=\"col-md-8 offset-2\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "645215d3e548495a8f9dfa918381d8e1641214396533", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
