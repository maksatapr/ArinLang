#pragma checksum "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9c5b2ad2ec3ec2e54654cb025e74a586b363e89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Names_Details), @"mvc.1.0.view", @"/Views/Names/Details.cshtml")]
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
#line 5 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
using DAL.Models.Dto.NamesDTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
using ARINLAB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c5b2ad2ec3ec2e54654cb025e74a586b363e89", @"/Views/Names/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e119a08238c3c4a5c8eaf5a5256788f2de43111b", @"/Views/_ViewImports.cshtml")]
    public class Views_Names_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DAL.Models.Dto.NamesDTO.NameImagesDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("object-cover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
  
    ViewData["Title"] = "Index";


#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
  
    NamesImagesViewModel mod = (NamesImagesViewModel)ViewBag.Model;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""flex justify-between flex-col xl:flex-row py-10 h-full xl:mb-0 blog"">
    <div class=""h-full xl:container xl:px-0 px-4"">
        <div class=""row"" style=""margin-left:35%"">
            <div class=""col-2""></div>
            <div class=""col-4 items-center"">
                <label style=""font-size:24px; font-weight:600"">");
#nullable restore
#line 19 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
                                                          Write(SharedLocalizer["Name in Arab"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </label>\r\n                <label class=\"text-success\" style=\"font-size:30px; font-weight:600\">");
#nullable restore
#line 20 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
                                                                               Write(mod.ArabName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\" col-4\">\r\n                <label style=\"font-size:24px; font-weight:600\">");
#nullable restore
#line 23 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
                                                          Write(SharedLocalizer["Name in"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 23 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
                                                                                      Write(mod.DictName);

#line default
#line hidden
#nullable disable
            WriteLiteral(": </label>\r\n                <label class=\"text-success\" style=\"font-size:30px; font-weight:600\">");
#nullable restore
#line 24 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
                                                                               Write(mod.OtherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"col-2\"></div>\r\n        </div>\r\n        <div class=\"mt-8 mb-16\">\r\n            <div class=\"grid xl:grid-cols-4 md:grid-cols-3 sm:grid-cols-2 gap-y-8 sm:gap-4 pb-8\">\r\n");
#nullable restore
#line 30 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
                 foreach (var name in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"rounded flex flex-col max-w-xs relative overflow-hidden\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b9c5b2ad2ec3ec2e54654cb025e74a586b363e897141", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1522, "~/images/Names/", 1522, 15, true);
#nullable restore
#line 33 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
AddHtmlAttributeValue("", 1537, name.ImageUri, 1537, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 35 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DAL.Models.Dto.NamesDTO.NameImagesDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
