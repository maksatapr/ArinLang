#pragma checksum "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Email\ErrorView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0231bd4d0fc5a2fcd7f667c0b10e4be3425070c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Email_ErrorView), @"mvc.1.0.view", @"/Areas/Admin/Views/Email/ErrorView.cshtml")]
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
#line 2 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Email\ErrorView.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0231bd4d0fc5a2fcd7f667c0b10e4be3425070c", @"/Areas/Admin/Views/Email/ErrorView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5944270c8b5d9816cf52d026e4a62ac0184f904f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Email_ErrorView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bool>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Email\ErrorView.cshtml"
  
    ViewData["Title"] = "Information";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Email\ErrorView.cshtml"
 if (Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2 class=\"text-success\"> ");
#nullable restore
#line 11 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Email\ErrorView.cshtml"
                         Write(SharedLocalizer["Email was send successfullt"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 12 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Email\ErrorView.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2 class=\"text-danger\"> ");
#nullable restore
#line 15 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Email\ErrorView.cshtml"
                        Write(SharedLocalizer["Some thing went wrong !! Try resend the Email"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 16 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Email\ErrorView.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bool> Html { get; private set; }
    }
}
#pragma warning restore 1591
