#pragma checksum "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\Components\FooterSettings\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2261bfc7386743fef3954ff396fafc667f327c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FooterSettings_Default), @"mvc.1.0.view", @"/Views/Shared/Components/FooterSettings/Default.cshtml")]
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
#line 1 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\_ViewImports.cshtml"
using ARINLAB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\_ViewImports.cshtml"
using ARINLAB.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\Components\FooterSettings\Default.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\Components\FooterSettings\Default.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2261bfc7386743fef3954ff396fafc667f327c1", @"/Views/Shared/Components/FooterSettings/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e119a08238c3c4a5c8eaf5a5256788f2de43111b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_FooterSettings_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DAL.Models.Settings>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Char_1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Char_2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("  \r\n");
#nullable restore
#line 7 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\Components\FooterSettings\Default.cshtml"
 if (CultureInfo.CurrentCulture.Name.StartsWith("ar"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <footer dir=""rtl"" class=""bg-gray-100 flex flex-col"">
        <div class=""xl:container xl:px-0 px-4 py-8"">
            <div class=""grid gap-y-4 justify-between sm:flex"">
                <div class=""sm:flex flex-col grid"" style=""width:15%"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e2261bfc7386743fef3954ff396fafc667f327c15199", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 15 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\Components\FooterSettings\Default.cshtml"
                 foreach (var setting in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"sm:flex flex-col grid\">\r\n                        <span class=\"text-gray-400 select-none font-roboto\"> ");
#nullable restore
#line 18 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\Components\FooterSettings\Default.cshtml"
                                                                        Write(SharedLocalizer[setting.Name]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                        <span class=\"font-semibold font-roboto\"> ");
#nullable restore
#line 19 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\Components\FooterSettings\Default.cshtml"
                                                            Write(Html.Raw(setting.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                    </div>\r\n");
#nullable restore
#line 21 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\Components\FooterSettings\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"sm:flex flex-col grid\" style=\"width:15%\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e2261bfc7386743fef3954ff396fafc667f327c17779", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"border-t border-gray-200\">\r\n            <div class=\"xl:container xl:px-0 px-4 text-gray-400 py-4 font-roboto sm:text-base text-sm\">\r\n                ");
#nullable restore
#line 39 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\Components\FooterSettings\Default.cshtml"
           Write(SharedLocalizer["ARINLAG"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 39 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\Components\FooterSettings\Default.cshtml"
                                        Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 39 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\Components\FooterSettings\Default.cshtml"
                                                            Write(SharedLocalizer["All rights reserved"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".\r\n            </div>\r\n        </div>\r\n    </footer>\r\n");
#nullable restore
#line 43 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\Components\FooterSettings\Default.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <footer class=""bg-gray-100 flex flex-col"">
        <div class=""xl:container xl:px-0 px-4 py-8"">
            <div class=""grid gap-y-4 justify-between sm:flex"">
                <div class=""sm:flex flex-col grid"" style=""width:15%"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e2261bfc7386743fef3954ff396fafc667f327c110526", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 52 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\Components\FooterSettings\Default.cshtml"
                 foreach (var setting in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"sm:flex flex-col grid\">\r\n                        <span class=\"text-gray-400 select-none font-roboto\"> ");
#nullable restore
#line 55 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\Components\FooterSettings\Default.cshtml"
                                                                        Write(SharedLocalizer[setting.Name]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                        <span class=\"font-semibold font-roboto\"> ");
#nullable restore
#line 56 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\Components\FooterSettings\Default.cshtml"
                                                            Write(Html.Raw(setting.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                    </div>\r\n");
#nullable restore
#line 58 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\Components\FooterSettings\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"sm:flex flex-col grid\" style=\"width:15%\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e2261bfc7386743fef3954ff396fafc667f327c113107", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"border-t border-gray-200\">\r\n            <div class=\"xl:container xl:px-0 px-4 text-gray-400 py-4 font-roboto sm:text-base text-sm\">\r\n                ");
#nullable restore
#line 76 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\Components\FooterSettings\Default.cshtml"
           Write(SharedLocalizer["ARINLAG"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 76 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\Components\FooterSettings\Default.cshtml"
                                        Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 76 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\Components\FooterSettings\Default.cshtml"
                                                            Write(SharedLocalizer["All rights reserved"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".\r\n            </div>\r\n        </div>\r\n    </footer>\r\n");
#nullable restore
#line 80 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\Components\FooterSettings\Default.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<SharedResource> SharedLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DAL.Models.Settings>> Html { get; private set; }
    }
}
#pragma warning restore 1591
