#pragma checksum "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86b438ff4c51880daa2c2bbf296784eb93ad64af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_WordClause_EditClauseVoice), @"mvc.1.0.view", @"/Areas/Admin/Views/WordClause/EditClauseVoice.cshtml")]
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
#line 1 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\_ViewImports.cshtml"
using ARINLAB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
using ARINLAB.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
using DAL.Models.Dto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86b438ff4c51880daa2c2bbf296784eb93ad64af", @"/Areas/Admin/Views/WordClause/EditClauseVoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5944270c8b5d9816cf52d026e4a62ac0184f904f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_WordClause_EditClauseVoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AudioFileForClauseDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "WordClause", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateVoice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("audio/mpeg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
  
    ViewData["Title"] = "Index";
    string dictName = "";

    EditWordClauseDto m = null;

    if (ViewBag.Model != null)
    {
        m = ((EditWordClauseDto)ViewBag.Model);
    }
    try
    {
        if (ViewBag.Dictionaries != null)
        {
            var getdictName = ((List<DAL.Models.Dictionary>)ViewBag.Dictionaries).SingleOrDefault(p => p.Id == m.DictionaryId);
            dictName = getdictName.Language;
        }
    }catch(Exception e)
            {
                
            }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Manage Word Sentences and Audio File (Voice)</h1>\r\n<hr />\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-2\"></div>\r\n        <div class=\"col-4 items-center\">\r\n            <label style=\"font-size:24px; font-weight:600\">");
#nullable restore
#line 35 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                                                      Write(SharedLocalizer["Arab Clause"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </label>\r\n            <label class=\"text-success\" style=\"font-size:30px; font-weight:600\">");
#nullable restore
#line 36 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                                                                           Write(m.ArabClause);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n        <div class=\" col-4\">\r\n            <label style=\"font-size:24px; font-weight:600\">");
#nullable restore
#line 39 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                                                      Write(SharedLocalizer["Reads in"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 39 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                                                                                   Write(dictName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </label>\r\n            <h2 class=\"text-success\" style=\"font-size:30px; font-weight:600\">");
#nullable restore
#line 40 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                                                                        Write(m.OtherReader);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        </div>\r\n        <div class=\"col-2\"></div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-2\"></div>\r\n        <div class=\"col-4 items-center\">\r\n            <label style=\"font-size:24px; font-weight:600\">");
#nullable restore
#line 47 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                                                      Write(dictName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 47 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                                                                Write(SharedLocalizer["Clause"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </label>\r\n            <label class=\"text-success\" style=\"font-size:30px; font-weight:600\">");
#nullable restore
#line 48 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                                                                           Write(m.OtherClause);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n        <div class=\" col-4\">\r\n            <label style=\"font-size:24px; font-weight:600\">");
#nullable restore
#line 51 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                                                      Write(SharedLocalizer["Reads in Arab"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </label>\r\n            <h2 class=\"text-success\" style=\"font-size:30px; font-weight:600\">");
#nullable restore
#line 52 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                                                                        Write(m.ArabReader);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        </div>\r\n        <div class=\"col-2\"></div>\r\n    </div>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-8\">\r\n            <h2>");
#nullable restore
#line 59 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
           Write(SharedLocalizer["Voices"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        </div>\r\n        <div class=\"col-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86b438ff4c51880daa2c2bbf296784eb93ad64af10424", async() => {
                WriteLiteral("<button class=\"btn btn-success\"><i class=\"fa fa-plus\"></i></button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                                                                                       WriteLiteral(m.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                                                                                                                    WriteLiteral(m.ArabClause);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["arabClause"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-arabClause", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["arabClause"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                                                                                                                                                          WriteLiteral(m.OtherClause);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["otherClause"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-otherClause", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["otherClause"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                                                                                                                                                                                              WriteLiteral(dictName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dictName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-dictName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dictName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <table class=\"table table-bordered\">\r\n                <thead>\r\n                    <tr>\r\n                        <th scope=\"col\">");
#nullable restore
#line 71 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                                   Write(SharedLocalizer["#"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 72 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                                   Write(SharedLocalizer["Voice in Arab"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 73 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                                   Write(dictName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 73 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                                             Write(SharedLocalizer["Voice in "]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 73 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                                                                           Write(dictName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 74 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                                   Write(SharedLocalizer["Approved"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">Actions</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 79 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                     if (Model != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th scope=\"row\">");
#nullable restore
#line 84 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td>\r\n                                    <audio");
            BeginWriteAttribute("id", " id=\"", 3352, "\"", 3374, 2);
            WriteAttributeValue("", 3357, "myAudio", 3357, 7, true);
#nullable restore
#line 86 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
WriteAttributeValue("", 3364, item.Id, 3364, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "86b438ff4c51880daa2c2bbf296784eb93ad64af19233", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3431, "~/", 3431, 2, true);
#nullable restore
#line 87 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
AddHtmlAttributeValue("", 3433, item.ArabVoice, 3433, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </audio>\r\n                                    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 3559, "\"", 3599, 3);
            WriteAttributeValue("", 3569, "playAudio(\'myAudio", 3569, 18, true);
#nullable restore
#line 89 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
WriteAttributeValue("", 3587, item.Id, 3587, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3597, "\')", 3597, 2, true);
            EndWriteAttribute();
            WriteLiteral(">PLAY</button>\r\n                                    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 3659, "\"", 3700, 3);
            WriteAttributeValue("", 3669, "pauseAudio(\'myAudio", 3669, 19, true);
#nullable restore
#line 90 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
WriteAttributeValue("", 3688, item.Id, 3688, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3698, "\')", 3698, 2, true);
            EndWriteAttribute();
            WriteLiteral(">STOP</button>\r\n                                </td>\r\n                                <td>\r\n                                    <audio");
            BeginWriteAttribute("id", " id=\"", 3836, "\"", 3860, 3);
            WriteAttributeValue("", 3841, "myAudio", 3841, 7, true);
#nullable restore
#line 93 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
WriteAttributeValue("", 3848, item.Id, 3848, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3858, "_o", 3858, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "86b438ff4c51880daa2c2bbf296784eb93ad64af22670", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3917, "~/", 3917, 2, true);
#nullable restore
#line 94 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
AddHtmlAttributeValue("", 3919, item.OtherVoice, 3919, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </audio>\r\n                                    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 4046, "\"", 4088, 3);
            WriteAttributeValue("", 4056, "playAudio(\'myAudio", 4056, 18, true);
#nullable restore
#line 96 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
WriteAttributeValue("", 4074, item.Id, 4074, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4084, "_o\')", 4084, 4, true);
            EndWriteAttribute();
            WriteLiteral(">PLAY</button>\r\n                                    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 4148, "\"", 4191, 3);
            WriteAttributeValue("", 4158, "pauseAudio(\'myAudio", 4158, 19, true);
#nullable restore
#line 97 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
WriteAttributeValue("", 4177, item.Id, 4177, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4187, "_o\')", 4187, 4, true);
            EndWriteAttribute();
            WriteLiteral(@">STOP</button>
                                </td>
                                <td>
                                    <div class=""adomx-checkbox-radio-group inline"">
                                        <label class=""adomx-switch success"">
                                            <input");
            BeginWriteAttribute("id", " id=\"", 4498, "\"", 4520, 2);
            WriteAttributeValue("", 4503, "approve", 4503, 7, true);
#nullable restore
#line 102 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
WriteAttributeValue("", 4510, item.Id, 4510, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"checkbox\" ");
#nullable restore
#line 102 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                                                                                      Write(item.IsApproved ? "checked" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@">

                                            <i class=""lever""></i>
                                        </label>
                                    </div>
                                </td>
                                <td>
                                    <button type=""button""");
            BeginWriteAttribute("id", " id=\"", 4873, "\"", 4888, 1);
#nullable restore
#line 109 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
WriteAttributeValue("", 4878, item.Id, 4878, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 4889, "\"", 4903, 1);
#nullable restore
#line 109 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
WriteAttributeValue("", 4896, m.Id, 4896, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sweetalert sweetalert-clausevoice btn button-danger\"><i class=\"fa fa-trash\"></i></button>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 112 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 122 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
  
    string text1 = ViewBag.successs;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<button class=\"sweetalert sweetalert-success button button-success\" id=\"AlertButton1\" hidden></button>\r\n");
#nullable restore
#line 127 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
 if (!string.IsNullOrEmpty(text1))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script type=\"text/javascript\">\r\n        window.onload = function () {\r\n            document.getElementById(\"AlertButton1\").click();\r\n        }\r\n    </script>\r\n");
#nullable restore
#line 134 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 136 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
 if (Model != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 138 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            const checkbox");
#nullable restore
#line 141 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                      Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = document.getElementById(\'approve");
#nullable restore
#line 141 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                                                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\')\r\n            checkbox");
#nullable restore
#line 142 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(".addEventListener(\'change\', (event) => {\r\n                if (event.currentTarget.checked) {\r\n                    window.location.href = \"/Admin/WordClause/Approve/");
#nullable restore
#line 144 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                                                                 Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("/true/");
#nullable restore
#line 144 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                                                                               Write(m.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n                } else {\r\n                    window.location.href = \"/Admin/WordClause/Approve/");
#nullable restore
#line 146 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                                                                 Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("/false/");
#nullable restore
#line 146 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
                                                                                Write(m.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n                }\r\n            })\r\n        </script>\r\n");
#nullable restore
#line 150 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 150 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\EditClauseVoice.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n\r\n    function playAudio(id) {\r\n\r\n        var x = document.getElementById(id);\r\n        x.play();\r\n    }\r\n\r\n    function pauseAudio(id) {\r\n\r\n        var x = document.getElementById(id);\r\n        x.pause();\r\n    }\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AudioFileForClauseDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
