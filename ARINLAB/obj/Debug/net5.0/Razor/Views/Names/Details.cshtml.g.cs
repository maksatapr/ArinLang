#pragma checksum "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f21655c336db42bddf7ed9722678030e6884e75a"
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
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
using DAL.Models.Dto.NamesDTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
using ARINLAB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f21655c336db42bddf7ed9722678030e6884e75a", @"/Views/Names/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e119a08238c3c4a5c8eaf5a5256788f2de43111b", @"/Views/_ViewImports.cshtml")]
    public class Views_Names_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DAL.Models.Dto.NamesDTO.NameImagesDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Names", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SetRating", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("object-cover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
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
#line 12 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
  
    NamesImagesViewModel mod = (NamesImagesViewModel)ViewBag.Model;
    bool res = false;
    if (ViewBag.RatingResult != null)
        res = (bool)ViewBag.RatingResult;


#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
 if (CultureInfo.CurrentCulture.Name.StartsWith("ar"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div dir=\"rtl\" class=\"flex justify-between flex-col xl:flex-row py-10 h-full xl:mb-0 blog\">\r\n        <div class=\"h-full xl:container xl:px-0 px-4\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 724, "\"", 761, 1);
#nullable restore
#line 23 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
WriteAttributeValue("", 731, (string)ViewBag.ExportImage, 731, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ><i style=\"position:fixed\" class=\"fas fa-file-export\">");
#nullable restore
#line 23 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
                                                                                                      Write(SharedLocalizer["Export"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></a>\r\n            <div class=\"row\" style=\"margin-right:35%\">\r\n                <div class=\"col-2\"></div>\r\n                <div class=\"col-4 items-center\">\r\n                    <label style=\"font-size:24px; font-weight:600\">");
#nullable restore
#line 27 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
                                                              Write(SharedLocalizer["Name in Arab"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": </label>\r\n                    <label class=\"text-success\" style=\"font-size:30px; font-weight:600\">");
#nullable restore
#line 28 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
                                                                                   Write(mod.ArabName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </div>\r\n                <div class=\" col-4\">\r\n                    <label style=\"font-size:24px; font-weight:600\">");
#nullable restore
#line 31 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
                                                              Write(SharedLocalizer["Name in"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 31 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
                                                                                          Write(mod.DictName);

#line default
#line hidden
#nullable disable
            WriteLiteral(": </label>\r\n                    <label class=\"text-success\" style=\"font-size:30px; font-weight:600\">");
#nullable restore
#line 32 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
                                                                                   Write(mod.OtherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </div>\r\n                <div class=\"col-2\"></div>\r\n            </div>\r\n            <div dir=\"ltr\" style=\"margin-top:20px;margin-left:40%\">\r\n                <h2 dir=\"rtl\" style=\"margin-top:20px;margin-right:55%\">");
#nullable restore
#line 37 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
                                                                  Write(SharedLocalizer["Current rating:"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <input id=\"kartik\" disabled name=\"Rating\" class=\"rating\"");
            BeginWriteAttribute("value", " value=\"", 1859, "\"", 1882, 1);
#nullable restore
#line 38 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
WriteAttributeValue("", 1867, ViewBag.Rating, 1867, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-stars=\"5\" data-step=\"0.1\"");
            BeginWriteAttribute("title", " title=\"", 1914, "\"", 1922, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n\r\n            <div dir=\"ltr\" style=\"margin-top:30px;margin-left:40%\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f21655c336db42bddf7ed9722678030e6884e75a10317", async() => {
                WriteLiteral("\r\n                    <input id=\"kartik\" name=\"Rating\" class=\"rating\" data-stars=\"5\" data-step=\"0.1\"");
                BeginWriteAttribute("title", " title=\"", 2201, "\"", 2209, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2255, "\"", 2270, 1);
#nullable restore
#line 44 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
WriteAttributeValue("", 2263, mod.Id, 2263, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"NameId\" />\r\n                    <div class=\"form-group\" style=\"margin-top:10px\">\r\n                        <button type=\"submit\" class=\"bg-secondary text-white sm:rounded-none rounded px-8 py-3 font-semibold text-center cursor-pointer select-none\">");
#nullable restore
#line 46 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
                                                                                                                                                                Write(SharedLocalizer["Submit your Rating"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
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
            WriteLiteral("\r\n            </div>\r\n            <div class=\"mt-8 mb-16\">\r\n                <div class=\"grid xl:grid-cols-4 md:grid-cols-3 sm:grid-cols-2 gap-y-8 sm:gap-4 pb-8\">\r\n");
#nullable restore
#line 52 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
                     foreach (var name in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"rounded flex flex-col max-w-xs relative overflow-hidden\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f21655c336db42bddf7ed9722678030e6884e75a14065", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2994, "~/images/Names/", 2994, 15, true);
#nullable restore
#line 55 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
AddHtmlAttributeValue("", 3009, name.ImageUri, 3009, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 57 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 62 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"flex justify-between flex-col xl:flex-row py-10 h-full xl:mb-0 blog\">\r\n        <div class=\"h-full xl:container xl:px-0 px-4\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 3351, "\"", 3388, 1);
#nullable restore
#line 67 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
WriteAttributeValue("", 3358, (string)ViewBag.ExportImage, 3358, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i style=\"position:fixed\" class=\"fas fa-file-export\">");
#nullable restore
#line 67 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
                                                                                                     Write(SharedLocalizer["Export"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></a>\r\n            <div class=\"row\" style=\"margin-left:35%\">\r\n                <div class=\"col-2\"></div>\r\n                <div class=\"col-4 items-center\">\r\n                    <label style=\"font-size:24px; font-weight:600\">");
#nullable restore
#line 71 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
                                                              Write(SharedLocalizer["Name in Arab"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </label>\r\n                    <label class=\"text-success\" style=\"font-size:30px; font-weight:600\">");
#nullable restore
#line 72 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
                                                                                   Write(mod.ArabName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </div>\r\n                <div class=\" col-4\">\r\n                    <label style=\"font-size:24px; font-weight:600\">");
#nullable restore
#line 75 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
                                                              Write(SharedLocalizer["Name in"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 75 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
                                                                                          Write(mod.DictName);

#line default
#line hidden
#nullable disable
            WriteLiteral(": </label>\r\n                    <label class=\"text-success\" style=\"font-size:30px; font-weight:600\">");
#nullable restore
#line 76 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
                                                                                   Write(mod.OtherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </div>\r\n                <div class=\"col-2\"></div>\r\n            </div>\r\n            <div style=\"margin-top:20px;margin-left:40%\">\r\n                <h2>");
#nullable restore
#line 81 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
               Write(SharedLocalizer["Current rating:"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <input id=\"kartik\" disabled name=\"Rating\" class=\"rating\"");
            BeginWriteAttribute("value", " value=\"", 4422, "\"", 4445, 1);
#nullable restore
#line 82 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
WriteAttributeValue("", 4430, ViewBag.Rating, 4430, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-stars=\"5\" data-step=\"0.1\"");
            BeginWriteAttribute("title", " title=\"", 4477, "\"", 4485, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n\r\n            <div style=\"margin-top:30px;margin-left:40%\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f21655c336db42bddf7ed9722678030e6884e75a20206", async() => {
                WriteLiteral("\r\n                    <input id=\"kartik\" name=\"Rating\" class=\"rating\" data-stars=\"5\" data-step=\"0.1\"");
                BeginWriteAttribute("title", " title=\"", 4754, "\"", 4762, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 4808, "\"", 4823, 1);
#nullable restore
#line 88 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
WriteAttributeValue("", 4816, mod.Id, 4816, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"NameId\" />\r\n                    <div class=\"form-group\" style=\"margin-top:10px\">\r\n                        <button type=\"submit\" class=\"bg-secondary text-white sm:rounded-none rounded px-8 py-3 font-semibold text-center cursor-pointer select-none\">");
#nullable restore
#line 90 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
                                                                                                                                                                Write(SharedLocalizer["Submit your Rating"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
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
            WriteLiteral("\r\n            </div>\r\n\r\n\r\n            <div class=\"mt-8 mb-16\">\r\n                <div class=\"grid xl:grid-cols-4 md:grid-cols-3 sm:grid-cols-2 gap-y-8 sm:gap-4 pb-8\">\r\n");
#nullable restore
#line 98 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
                     foreach (var name in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"rounded flex flex-col max-w-xs relative overflow-hidden\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f21655c336db42bddf7ed9722678030e6884e75a23962", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5551, "~/images/Names/", 5551, 15, true);
#nullable restore
#line 101 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
AddHtmlAttributeValue("", 5566, name.ImageUri, 5566, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 103 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 108 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<button id=\"btn\" hidden></button>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <!-- <script src=""https://cdn.jsdelivr.net/npm/simple-notify@0.5.4/dist/simple-notify.min.js""></script> -->
    <script async defer src=""https://buttons.github.io/buttons.js""></script>
    <!-- <script src=""https://cdn.jsdelivr.net/npm/simple-notify@0.5.4/dist/simple-notify.min.js""></script> -->
    <script src=""/dist/simple-notify.min.js""></script>
    <script src=""/assets/js/prism.js""></script>
    <script src=""/assets/js/OverlayScrollbars.min.js""></script>
    <script src=""/assets/js/main.js""></script>
    <script>
         const btn = document.querySelector('#btn')

        btn.addEventListener('click', () => {
            new Notify({
                status: 'success',
                title: '");
#nullable restore
#line 126 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
                   Write(SharedLocalizer["Thank you"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                text: \'");
#nullable restore
#line 127 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
                  Write(SharedLocalizer["Your rating have been successfully recorded"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                effect: 'fade',
                speed: 300,
                customClass: '',
                customIcon: '',
                showIcon: true,
                showCloseButton: true,
                autoclose: false,
                autotimeout: 3000,
                gap: 60,
                distance: 20,
                type: 1,
                position: 'right top',
                customWrapper: '',
            })
        });

    </script>
");
#nullable restore
#line 145 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
     if (res)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script>\r\n            document.getElementById(\"btn\").click();\r\n        </script>\r\n");
#nullable restore
#line 150 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Names\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
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
