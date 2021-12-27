#pragma checksum "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20b8181d63d182dd7fdd0379b50409c9350fee18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WordClauses_Details), @"mvc.1.0.view", @"/Views/WordClauses/Details.cshtml")]
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
#line 1 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
using ARINLAB.Areas.Admin.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
using DAL.Models.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
using ARINLAB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20b8181d63d182dd7fdd0379b50409c9350fee18", @"/Views/WordClauses/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e119a08238c3c4a5c8eaf5a5256788f2de43111b", @"/Views/_ViewImports.cshtml")]
    public class Views_WordClauses_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DAL.Models.Dto.AudioFileForClauseDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("audio/mpeg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 9 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
  
    string dictName = "";
    ViewData["Title"] = "Index";
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
    }
    catch (Exception e)
    {

    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""flex justify-between flex-col xl:flex-row py-10 h-full xl:mb-0 blog"">
    <div class=""xl:w-8/12 xl:px-0 px-4 flex-grow"">
        <div class=""row"" style=""margin-left:35%"">
            <div class=""col-2""></div>
            <div class=""col-4 items-center"">
                <label style=""font-size:24px; font-weight:600"">");
#nullable restore
#line 37 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
                                                          Write(SharedLocalizer["Arab Clause"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": </label>\r\n                <label class=\"text-success\" style=\"font-size:30px; font-weight:600; color:darkgreen\">");
#nullable restore
#line 38 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
                                                                                                Write(m.ArabClause);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\" col-4\">\r\n                <label style=\"font-size:24px; font-weight:600\">");
#nullable restore
#line 41 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
                                                          Write(SharedLocalizer["Reads"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" in ");
#nullable restore
#line 41 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
                                                                                       Write(dictName);

#line default
#line hidden
#nullable disable
            WriteLiteral(": </label>\r\n                <label class=\"text-success\" style=\"font-size: 30px; font-weight: 600; color: maroon\">");
#nullable restore
#line 42 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
                                                                                                Write(m.OtherReader);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
            </div>
            <div class=""col-2""></div>
        </div>
        <div class=""row"" style=""margin-left:35%"">
            <div class=""col-2""></div>
            <div class=""col-4 items-center"">
                <label style=""font-size:24px; font-weight:600"">");
#nullable restore
#line 49 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
                                                          Write(dictName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 49 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
                                                                    Write(SharedLocalizer["Clause"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": </label>\r\n                <label class=\"text-success\" style=\"font-size: 30px; font-weight: 600; color: darkgreen\">");
#nullable restore
#line 50 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
                                                                                                   Write(m.OtherClause);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\" col-4\">\r\n                <label style=\"font-size:24px; font-weight:600\">");
#nullable restore
#line 53 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
                                                          Write(SharedLocalizer["Reads in Arab"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": </label>\r\n                <label class=\"text-success\" style=\"font-size: 30px; font-weight: 600; color: maroon\">");
#nullable restore
#line 54 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
                                                                                                Write(m.ArabReader);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
            </div>
            <div class=""col-2""></div>
        </div>


        <div class=""row"" style=""margin-left:35%; margin-top:50px;"">
            <div class=""col-2""></div>
            <div class=""col-8 items-center"">
                <label class=""text-success"" style=""font-size:30px; font-weight:600"">");
#nullable restore
#line 63 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
                                                                               Write(SharedLocalizer["Voices"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
            </div>
            <div class=""col-2""></div>
        </div>
        <div class=""wrapper_green"">
            <div class=""green_table"">
                <div class=""row_green header green"">
                    <div class=""cell"">
                        ");
#nullable restore
#line 71 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
                   Write(SharedLocalizer["Arab Voice"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"cell\">\r\n                        ");
#nullable restore
#line 74 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
                   Write(dictName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 74 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
                             Write(SharedLocalizer["Voice"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n             \r\n");
#nullable restore
#line 78 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row_green\">\r\n\r\n                            <div class=\"cell\" data-title=\"Audio\">\r\n                                <audio");
            BeginWriteAttribute("id", " id=\"", 3413, "\"", 3435, 2);
            WriteAttributeValue("", 3418, "myAudio", 3418, 7, true);
#nullable restore
#line 83 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
WriteAttributeValue("", 3425, item.Id, 3425, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "20b8181d63d182dd7fdd0379b50409c9350fee1811517", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3488, "~/", 3488, 2, true);
#nullable restore
#line 84 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
AddHtmlAttributeValue("", 3490, item.ArabVoice, 3490, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </audio>\r\n                                <button class=\"btn btn-success\" style=\"background-color: green; padding: 20px; border-radius: 15px;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3701, "\"", 3741, 3);
            WriteAttributeValue("", 3711, "playAudio(\'myAudio", 3711, 18, true);
#nullable restore
#line 86 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
WriteAttributeValue("", 3729, item.Id, 3729, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3739, "\')", 3739, 2, true);
            EndWriteAttribute();
            WriteLiteral(">PLAY</button>\r\n                                <button class=\"btn btn-success\" style=\"background-color: red; padding: 20px; border-radius: 15px;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3888, "\"", 3929, 3);
            WriteAttributeValue("", 3898, "pauseAudio(\'myAudio", 3898, 19, true);
#nullable restore
#line 87 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
WriteAttributeValue("", 3917, item.Id, 3917, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3927, "\')", 3927, 2, true);
            EndWriteAttribute();
            WriteLiteral(">STOP</button>\r\n                            </div>\r\n                            <div class=\"cell\" data-title=\"Audio\">\r\n                                <audio");
            BeginWriteAttribute("id", " id=\"", 4087, "\"", 4111, 3);
            WriteAttributeValue("", 4092, "myAudio", 4092, 7, true);
#nullable restore
#line 90 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
WriteAttributeValue("", 4099, item.Id, 4099, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4109, "_o", 4109, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "20b8181d63d182dd7fdd0379b50409c9350fee1815080", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4164, "~/", 4164, 2, true);
#nullable restore
#line 91 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
AddHtmlAttributeValue("", 4166, item.OtherVoice, 4166, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </audio>\r\n                                <button class=\"btn btn-success\" style=\"background-color: green; padding: 20px; border-radius: 15px;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4378, "\"", 4420, 3);
            WriteAttributeValue("", 4388, "playAudio(\'myAudio", 4388, 18, true);
#nullable restore
#line 93 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
WriteAttributeValue("", 4406, item.Id, 4406, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4416, "_o\')", 4416, 4, true);
            EndWriteAttribute();
            WriteLiteral(">PLAY</button>\r\n                                <button class=\"btn btn-success\" style=\"background-color: red; padding: 20px; border-radius: 15px;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4567, "\"", 4610, 3);
            WriteAttributeValue("", 4577, "pauseAudio(\'myAudio", 4577, 19, true);
#nullable restore
#line 94 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
WriteAttributeValue("", 4596, item.Id, 4596, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4606, "_o\')", 4606, 4, true);
            EndWriteAttribute();
            WriteLiteral(">STOP</button>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 97 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
                    }                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>

<script>
        function playAudio(id) {

            var x = document.getElementById(id);
            x.play();
        }

        function pauseAudio(id) {

            var x = document.getElementById(id);
            x.pause();
        }
</script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer localizer { get; private set; }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DAL.Models.Dto.AudioFileForClauseDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
