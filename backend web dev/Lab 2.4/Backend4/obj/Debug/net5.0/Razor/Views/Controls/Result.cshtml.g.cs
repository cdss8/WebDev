#pragma checksum "E:\Universidad\I+D\МатематческоеОбеспечение и А.И.С\6 cемак\Web Технологии 2.0\ERM\931901.eremenko_web4-main\931901.eremenko_web4-main\Backend4\Views\Controls\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60a917ccad2510d29c3cc0666aac5d88014ebcbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Controls_Result), @"mvc.1.0.view", @"/Views/Controls/Result.cshtml")]
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
#line 1 "E:\Universidad\I+D\МатематческоеОбеспечение и А.И.С\6 cемак\Web Технологии 2.0\ERM\931901.eremenko_web4-main\931901.eremenko_web4-main\Backend4\Views\_ViewImports.cshtml"
using Backend4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Universidad\I+D\МатематческоеОбеспечение и А.И.С\6 cемак\Web Технологии 2.0\ERM\931901.eremenko_web4-main\931901.eremenko_web4-main\Backend4\Views\_ViewImports.cshtml"
using Backend4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60a917ccad2510d29c3cc0666aac5d88014ebcbf", @"/Views/Controls/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96619c4a8d13af5dee7982e58002d641c54e06c6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Controls_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1 >");
#nullable restore
#line 1 "E:\Universidad\I+D\МатематческоеОбеспечение и А.И.С\6 cемак\Web Технологии 2.0\ERM\931901.eremenko_web4-main\931901.eremenko_web4-main\Backend4\Views\Controls\Result.cshtml"
Write(ViewBag.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<div style=\"display: flex\";>\n    <b class=\"m-2\">");
#nullable restore
#line 4 "E:\Universidad\I+D\МатематческоеОбеспечение и А.И.С\6 cемак\Web Технологии 2.0\ERM\931901.eremenko_web4-main\931901.eremenko_web4-main\Backend4\Views\Controls\Result.cshtml"
              Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b>\n");
#nullable restore
#line 5 "E:\Universidad\I+D\МатематческоеОбеспечение и А.И.С\6 cемак\Web Технологии 2.0\ERM\931901.eremenko_web4-main\931901.eremenko_web4-main\Backend4\Views\Controls\Result.cshtml"
         for (int i = 0; i < ViewBag.MyArray.Length; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<pre class=\"m-2\" style=\"font-family:Arial; font-size:16px;\">");
#nullable restore
#line 6 "E:\Universidad\I+D\МатематческоеОбеспечение и А.И.С\6 cемак\Web Технологии 2.0\ERM\931901.eremenko_web4-main\931901.eremenko_web4-main\Backend4\Views\Controls\Result.cshtml"
                                                                Write(ViewBag.MyArray[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre> <br />");
#nullable restore
#line 6 "E:\Universidad\I+D\МатематческоеОбеспечение и А.И.С\6 cемак\Web Технологии 2.0\ERM\931901.eremenko_web4-main\931901.eremenko_web4-main\Backend4\Views\Controls\Result.cshtml"
                                                                                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>");
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
