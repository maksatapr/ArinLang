#pragma checksum "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a70cc313bf33ec119ffb31fb684342463a1cfb19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_WordClause_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/WordClause/Index.cshtml")]
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
#line 4 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\Index.cshtml"
using DAL.Models.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\Index.cshtml"
using ARINLAB.Areas.Admin.Utils;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a70cc313bf33ec119ffb31fb684342463a1cfb19", @"/Areas/Admin/Views/WordClause/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5944270c8b5d9816cf52d026e4a62ac0184f904f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_WordClause_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1> ");
#nullable restore
#line 6 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\Index.cshtml"
Write(SharedLocalizer["Category Controller"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <h3 class=\"page-header\">\r\n                ");
#nullable restore
#line 11 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\Index.cshtml"
           Write(SharedLocalizer["Word Clause List"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h3>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div id=\"gridContainer\">\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(function () {\r\n            let url = `");
#nullable restore
#line 25 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\Index.cshtml"
                  Write(API.GetAllWordClauses);

#line default
#line hidden
#nullable disable
                WriteLiteral("`;\r\n            var returnUrl = \'");
#nullable restore
#line 26 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\Index.cshtml"
                        Write(Context.Request.Path);

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\Index.cshtml"
                                             Write(Context.Request.QueryString);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
            $(""#gridContainer"").dxDataGrid({
                dataSource: DevExpress.data.AspNet.createStore({
                    key: ""id"",
                    loadUrl: url,
                    insertUrl: url,
                    updateUrl: url,
                    deleteUrl: url,
                    onBeforeSend: function (method, ajaxOptions) {
                        ajaxOptions.xhrFields = { withCredentials: true };
                    }
                }),
                onInitNewRow: function(e) {
                    var url = `");
#nullable restore
#line 39 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\Index.cshtml"
                          Write(Url.Action("Create", "WordClause", new { Area = "Admin" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"`;
                    window.location = url;
                },
                selection: {
                    mode: ""multiple""
                },
                ""export"": {
                    enabled: true,
                    fileName: ""WordClause"",
                    allowExportSelectedData: true
                },
                filterPanel: {
                    visible: false
                },
                filterRow: { visible: false },
                remoteOperations: true,
                onRowUpdating: function (e) {
                    e.newData = Object.assign(e.oldData, e.newData)
                },
                scrolling: {
                    mode: ""virtual"",
                    rowRenderingMode: ""virtual""
                },
                paging: {
                    pageSize: 100
                },
                editing: {
                    useIcons: true,
                    allowUpdating: true,
                    allowDeleting: true,
      ");
                WriteLiteral(@"              allowAdding: true
                },
                headerFilter: {
                    visible: true
                },
                wordWrapEnabled: true,
                showColumnLines: true,
                showRowLines: true,
                rowAlternationEnabled: true,
                showBorders: true,
                searchPanel: {
                    visible: true
                },
                stateStoring: {
                    enabled:false,
                    type: ""localStorage"",
                    storageKey: ""WordClauseAdmin""
                },
                columns: [
                    {
                        caption: '");
#nullable restore
#line 89 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\Index.cshtml"
                             Write(SharedLocalizer["Arab CLause"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                        dataField: \"arabClause\",\r\n                        allowHeaderFiltering: false,\r\n                    },{\r\n                        caption: \'");
#nullable restore
#line 93 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\Index.cshtml"
                             Write(SharedLocalizer["Other Language read"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                                    dataField: \"otherReader\",\r\n                        allowHeaderFiltering: false,\r\n                    },\r\n\r\n                     {\r\n                        caption: \'");
#nullable restore
#line 99 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\Index.cshtml"
                             Write(SharedLocalizer["Other Language clause"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                         dataField: \"otherClause\",\r\n                        allowHeaderFiltering: false,\r\n                    },{\r\n                        caption: \'");
#nullable restore
#line 103 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\Index.cshtml"
                             Write(SharedLocalizer["Arab read"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                        dataField: \"arabReader\",\r\n                        allowHeaderFiltering: false,\r\n                    },\r\n\r\n                                {\r\n                        caption: \'");
#nullable restore
#line 109 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\Index.cshtml"
                             Write(SharedLocalizer["Dictionary"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                                    dataField: \"dictionaryName\",\r\n                        allowHeaderFiltering: true,\r\n                    },\r\n                     {\r\n                        caption: \'");
#nullable restore
#line 114 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\Index.cshtml"
                             Write(SharedLocalizer["Category"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                        dataField: \"categoryName\",\r\n                        allowHeaderFiltering: true,\r\n                    },\r\n                     {\r\n                        caption: \'");
#nullable restore
#line 119 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\Index.cshtml"
                             Write(SharedLocalizer["Approved"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                         dataField: \"isApproved\",\r\n                        allowHeaderFiltering: true,\r\n                    },\r\n                     {\r\n                        caption: \'");
#nullable restore
#line 124 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\Index.cshtml"
                             Write(SharedLocalizer["User name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                        dataField: ""userName"",
                        allowHeaderFiltering: true,
                    },
                    {
                        type: ""buttons"",
                        width: 110,
                        buttons: [
                            {
                                hint: '");
#nullable restore
#line 133 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\Index.cshtml"
                                  Write(SharedLocalizer["Edit"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                                icon: \"edit\",\r\n                                onClick: function (e) {\r\n                                    var idString = e.row.data.id;\r\n                                    var url = `");
#nullable restore
#line 137 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\Index.cshtml"
                                          Write(Url.Action("Edit", "WordClause", new { Area = "Admin" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("`;\r\n                                    window.location = url + \'?id=\' + idString;\r\n                                }\r\n                            },\r\n                             {\r\n                                hint: \'");
#nullable restore
#line 142 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\Index.cshtml"
                                  Write(SharedLocalizer["Edit Voices"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                                 icon: \"fa fa-volume-up\",\r\n                                onClick: function (e) {\r\n                                    var idString = e.row.data.id;\r\n                                    var url = `");
#nullable restore
#line 146 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\WordClause\Index.cshtml"
                                          Write(Url.Action("EditClauseVoice", "WordClause", new { Area = "Admin" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"`;
                                    window.location = url + '?id=' + idString;
                                }
                            },
                            ""delete""
                        ]
                    }
                ]
            });
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
