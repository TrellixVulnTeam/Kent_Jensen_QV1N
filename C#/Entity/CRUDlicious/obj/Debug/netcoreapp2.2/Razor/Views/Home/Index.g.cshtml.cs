#pragma checksum "C:\Users\zelin\Desktop\Code\UPLOAD TO GIT\Kent_Jensen\C#\Entity\CRUDlicious\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20ecd45a6c3df0f6df11e9b58c73c4ff8614e768"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\zelin\Desktop\Code\UPLOAD TO GIT\Kent_Jensen\C#\Entity\CRUDlicious\Views\_ViewImports.cshtml"
using Crudlicious;

#line default
#line hidden
#line 2 "C:\Users\zelin\Desktop\Code\UPLOAD TO GIT\Kent_Jensen\C#\Entity\CRUDlicious\Views\_ViewImports.cshtml"
using Crudlicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20ecd45a6c3df0f6df11e9b58c73c4ff8614e768", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02cde5fe96f9b9e0de57c6cb38ae4923b7006a88", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\zelin\Desktop\Code\UPLOAD TO GIT\Kent_Jensen\C#\Entity\CRUDlicious\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(64, 109, true);
            WriteLiteral("<h1>Welcome to Crudlicious</h1>\r\n<h2>Check out some recent dishes!</h2>\r\n<a href=\"/new\">Add a Dish </a>\r\n<ul>");
            EndContext();
#line 8 "C:\Users\zelin\Desktop\Code\UPLOAD TO GIT\Kent_Jensen\C#\Entity\CRUDlicious\Views\Home\Index.cshtml"
      foreach(Dish d in Model)
    {

#line default
#line hidden
            BeginContext(208, 14, true);
            WriteLiteral("        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 222, "\"", 234, 1);
#line 10 "C:\Users\zelin\Desktop\Code\UPLOAD TO GIT\Kent_Jensen\C#\Entity\CRUDlicious\Views\Home\Index.cshtml"
WriteAttributeValue("", 229, d.ID, 229, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(235, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(238, 6, false);
#line 10 "C:\Users\zelin\Desktop\Code\UPLOAD TO GIT\Kent_Jensen\C#\Entity\CRUDlicious\Views\Home\Index.cshtml"
                        Write(d.Name);

#line default
#line hidden
            EndContext();
            BeginContext(244, 8, true);
            WriteLiteral("</a> by ");
            EndContext();
            BeginContext(253, 6, false);
#line 10 "C:\Users\zelin\Desktop\Code\UPLOAD TO GIT\Kent_Jensen\C#\Entity\CRUDlicious\Views\Home\Index.cshtml"
                                       Write(d.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(259, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 11 "C:\Users\zelin\Desktop\Code\UPLOAD TO GIT\Kent_Jensen\C#\Entity\CRUDlicious\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(276, 5, true);
            WriteLiteral("</ul>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
