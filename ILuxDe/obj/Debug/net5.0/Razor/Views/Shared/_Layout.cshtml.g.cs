#pragma checksum "C:\Users\denis\source\repos\ILuxDe\ILuxDe\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64c6ed7a3bb435dac06de799c3ea6c2d120de18d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 2 "C:\Users\denis\source\repos\ILuxDe\ILuxDe\Views\_ViewImports.cshtml"
using ILuxDe.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\denis\source\repos\ILuxDe\ILuxDe\Views\_ViewImports.cshtml"
using ILuxDe.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\denis\source\repos\ILuxDe\ILuxDe\Views\_ViewImports.cshtml"
using ILuxDe.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\denis\source\repos\ILuxDe\ILuxDe\Views\_ViewImports.cshtml"
using ILuxDe.Models.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64c6ed7a3bb435dac06de799c3ea6c2d120de18d", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f142d4319f97e4f57a4fb0c84f077408d0377ac0", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/Shared/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE HTML>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64c6ed7a3bb435dac06de799c3ea6c2d120de18d3799", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\denis\source\repos\ILuxDe\ILuxDe\Views\Shared\_Layout.cshtml"
      await Html.RenderPartialAsync("MetatagsPartial");

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\denis\source\repos\ILuxDe\ILuxDe\Views\Shared\_Layout.cshtml"
      await Html.RenderPartialAsync("CssPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64c6ed7a3bb435dac06de799c3ea6c2d120de18d5213", async() => {
                WriteLiteral("\r\n\t\t<div id=\"page-wrapper\">\r\n");
#nullable restore
#line 9 "C:\Users\denis\source\repos\ILuxDe\ILuxDe\Views\Shared\_Layout.cshtml"
              await Html.RenderPartialAsync("HeaderPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t<div id=\"main\">\r\n\t\t\t\t<div class=\"container\">\r\n\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t");
#nullable restore
#line 13 "C:\Users\denis\source\repos\ILuxDe\ILuxDe\Views\Shared\_Layout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n\t\t\t\t\t\t<div class=\"col-12 \">\r\n\t\t\t\t\t\t      <!-- Portfolio -->\r\n\t\t\t\t\t\t\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-12\">\r\n\r\n\t\t\t\t\t\t\t<!-- Blog -->\r\n\t\t\t\t\t\t\t\r\n                        </div>\r\n\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t\r\n");
#nullable restore
#line 26 "C:\Users\denis\source\repos\ILuxDe\ILuxDe\Views\Shared\_Layout.cshtml"
                      await Html.RenderPartialAsync("SidebarPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t</div>\r\n\t\t\t</div>\r\n\r\n");
#nullable restore
#line 30 "C:\Users\denis\source\repos\ILuxDe\ILuxDe\Views\Shared\_Layout.cshtml"
              await Html.RenderPartialAsync("FooterPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t</div>\r\n");
#nullable restore
#line 32 "C:\Users\denis\source\repos\ILuxDe\ILuxDe\Views\Shared\_Layout.cshtml"
          await Html.RenderPartialAsync("ScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
