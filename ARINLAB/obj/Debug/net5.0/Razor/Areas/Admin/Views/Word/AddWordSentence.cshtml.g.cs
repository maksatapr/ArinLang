#pragma checksum "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\AddWordSentence.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2b13481cde8db403740b402f7cf32e67d85b01d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Word_AddWordSentence), @"mvc.1.0.view", @"/Areas/Admin/Views/Word/AddWordSentence.cshtml")]
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
#line 5 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\AddWordSentence.cshtml"
using ARINLAB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2b13481cde8db403740b402f7cf32e67d85b01d", @"/Areas/Admin/Views/Word/AddWordSentence.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5944270c8b5d9816cf52d026e4a62ac0184f904f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Word_AddWordSentence : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimpleWordModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\AddWordSentence.cshtml"
  
    ViewData["Title"] = "Index";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Add Sentence and Voice </h1>\r\n<hr />\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-2\"></div>\r\n        <div class=\"col-4 items-center\">\r\n\r\n            <label class=\"text-success\" style=\"font-size:30px; font-weight:600\">");
#nullable restore
#line 15 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\AddWordSentence.cshtml"
                                                                           Write(Model.ArabWord);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n        <div class=\" col-4\">\r\n\r\n            <h2 class=\"text-success\" style=\"font-size:30px; font-weight:600\">");
#nullable restore
#line 19 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\AddWordSentence.cshtml"
                                                                        Write(Model.OtherWord);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        </div>\r\n        <div class=\"col-2\"></div>\r\n    </div>\r\n    <hr />\r\n    <div class=\"col-12 mb-30\">\r\n        <div class=\"box\">\r\n            <div class=\"box-head\">\r\n                <h3 class=\"title\">");
#nullable restore
#line 27 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\AddWordSentence.cshtml"
                             Write(SharedLocalizer["Add Example Sentence"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
            </div>
            <div class=""box-body"">
                <div class=""row mbn-20"">

                    <!--Form Field-->
                    <div class=""col-lg-6 col-12 mb-20"">

                        <h6 class=""mb-15"">Arab</h6>

                        <div class=""row mbn-15"">
                            <div class=""col-12 mb-15""><input type=""text"" class=""form-control"" placeholder=""Input""></div>
                           
                            <div class=""col-12 mb-15""><textarea class=""form-control"" placeholder=""Textarea""></textarea></div>
                        </div>

                    </div>
                    <!--Form Field-->
                    <!--Readonly Field-->
                    <div class=""col-lg-6 col-12 mb-20"">

                        <h6 class=""mb-15"">");
#nullable restore
#line 48 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\AddWordSentence.cshtml"
                                     Write(Model.DictID);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>

                        <div class=""row mbn-15"">
                            <div class=""col-12 mb-15""><input type=""text"" class=""form-control"" placeholder=""Input""></div>
                          
                            <div class=""col-12 mb-15""><textarea class=""form-control"" placeholder=""Textarea""></textarea></div>
                        </div>  
                    </div>
                 
                </div>
            </div>
            <div class=""box-foot"">
                <p>Textual form controls—like inputs, selects, and textareas—are styled with the <code>.form-control</code> class. Included are styles for general appearance, focus state, sizing, and more.</p>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimpleWordModel> Html { get; private set; }
    }
}
#pragma warning restore 1591