#pragma checksum "C:\Users\zelin\Desktop\Code\UPLOAD TO GIT\Kent_Jensen\C#\Entity\WeddingPlanner\Views\Home\EventListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "153b50dce4b42c379d66f57b6625c0b39d82daf4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EventListPartial), @"mvc.1.0.view", @"/Views/Home/EventListPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/EventListPartial.cshtml", typeof(AspNetCore.Views_Home_EventListPartial))]
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
#line 1 "C:\Users\zelin\Desktop\Code\UPLOAD TO GIT\Kent_Jensen\C#\Entity\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#line 2 "C:\Users\zelin\Desktop\Code\UPLOAD TO GIT\Kent_Jensen\C#\Entity\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"153b50dce4b42c379d66f57b6625c0b39d82daf4", @"/Views/Home/EventListPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EventListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Event>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 241, true);
            WriteLiteral("<nav>\r\n\r\n<table class=\"table table-striped\">\r\n  <thead>\r\n    <tr>\r\n      <th scope=\"col\">Wedding</th>\r\n      <th scope=\"col\">Date</th>\r\n      <th scope=\"col\">Guests</th>\r\n      <th scope=\"col\">Actions</th>\r\n    </tr>\r\n  </thead>\r\n  <tbody>\r\n");
            EndContext();
#line 14 "C:\Users\zelin\Desktop\Code\UPLOAD TO GIT\Kent_Jensen\C#\Entity\WeddingPlanner\Views\Home\EventListPartial.cshtml"
     foreach(Event e in @Model)
    {

#line default
#line hidden
            BeginContext(301, 22, true);
            WriteLiteral("    <tr>\r\n      <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 323, "\"", 351, 2);
            WriteAttributeValue("", 330, "/showEvent/", 330, 11, true);
#line 17 "C:\Users\zelin\Desktop\Code\UPLOAD TO GIT\Kent_Jensen\C#\Entity\WeddingPlanner\Views\Home\EventListPartial.cshtml"
WriteAttributeValue("", 341, e.EventId, 341, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(352, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(354, 9, false);
#line 17 "C:\Users\zelin\Desktop\Code\UPLOAD TO GIT\Kent_Jensen\C#\Entity\WeddingPlanner\Views\Home\EventListPartial.cshtml"
                                     Write(e.Wedder1);

#line default
#line hidden
            EndContext();
            BeginContext(363, 3, true);
            WriteLiteral(" & ");
            EndContext();
            BeginContext(367, 9, false);
#line 17 "C:\Users\zelin\Desktop\Code\UPLOAD TO GIT\Kent_Jensen\C#\Entity\WeddingPlanner\Views\Home\EventListPartial.cshtml"
                                                  Write(e.Wedder2);

#line default
#line hidden
            EndContext();
            BeginContext(376, 21, true);
            WriteLiteral("</a></td>\r\n      <td>");
            EndContext();
            BeginContext(398, 11, false);
#line 18 "C:\Users\zelin\Desktop\Code\UPLOAD TO GIT\Kent_Jensen\C#\Entity\WeddingPlanner\Views\Home\EventListPartial.cshtml"
     Write(e.SetDate());

#line default
#line hidden
            EndContext();
            BeginContext(409, 17, true);
            WriteLiteral("</td>\r\n      <td>");
            EndContext();
            BeginContext(427, 25, false);
#line 19 "C:\Users\zelin\Desktop\Code\UPLOAD TO GIT\Kent_Jensen\C#\Entity\WeddingPlanner\Views\Home\EventListPartial.cshtml"
     Write(e.allUsersAttending.Count);

#line default
#line hidden
            EndContext();
            BeginContext(452, 21, true);
            WriteLiteral("</td>\r\n        <td>\r\n");
            EndContext();
#line 21 "C:\Users\zelin\Desktop\Code\UPLOAD TO GIT\Kent_Jensen\C#\Entity\WeddingPlanner\Views\Home\EventListPartial.cshtml"
              
            var toggle = 0;
            foreach (var j in @e.allUsersAttending)
            {
                if(@ViewBag.UserId == j.UserId )
                {
                    toggle ++;
                }
            }
            if(toggle == 0)
            {
                if(@ViewBag.UserId == @e.OwnerId)
                {

#line default
#line hidden
            BeginContext(835, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href =\"", 857, "\"", 883, 2);
            WriteAttributeValue("", 865, "/delete/", 865, 8, true);
#line 34 "C:\Users\zelin\Desktop\Code\UPLOAD TO GIT\Kent_Jensen\C#\Entity\WeddingPlanner\Views\Home\EventListPartial.cshtml"
WriteAttributeValue("", 873, e.EventId, 873, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(884, 30, true);
            WriteLiteral("><button>Delete</button></a>\r\n");
            EndContext();
#line 35 "C:\Users\zelin\Desktop\Code\UPLOAD TO GIT\Kent_Jensen\C#\Entity\WeddingPlanner\Views\Home\EventListPartial.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(974, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href =\"", 996, "\"", 1020, 2);
            WriteAttributeValue("", 1004, "/RSVP/", 1004, 6, true);
#line 38 "C:\Users\zelin\Desktop\Code\UPLOAD TO GIT\Kent_Jensen\C#\Entity\WeddingPlanner\Views\Home\EventListPartial.cshtml"
WriteAttributeValue("", 1010, e.EventId, 1010, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1021, 28, true);
            WriteLiteral("><button>RSVP</button></a>\r\n");
            EndContext();
#line 39 "C:\Users\zelin\Desktop\Code\UPLOAD TO GIT\Kent_Jensen\C#\Entity\WeddingPlanner\Views\Home\EventListPartial.cshtml"
                }
            }
            else
            {

#line default
#line hidden
            BeginContext(1116, 18, true);
            WriteLiteral("                <a");
            EndContext();
            BeginWriteAttribute("href", " href =\"", 1134, "\"", 1158, 2);
            WriteAttributeValue("", 1142, "/RSVP/", 1142, 6, true);
#line 43 "C:\Users\zelin\Desktop\Code\UPLOAD TO GIT\Kent_Jensen\C#\Entity\WeddingPlanner\Views\Home\EventListPartial.cshtml"
WriteAttributeValue("", 1148, e.EventId, 1148, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1159, 31, true);
            WriteLiteral("><button>Un-RSVP</button></a>\r\n");
            EndContext();
#line 44 "C:\Users\zelin\Desktop\Code\UPLOAD TO GIT\Kent_Jensen\C#\Entity\WeddingPlanner\Views\Home\EventListPartial.cshtml"
            }
            

#line default
#line hidden
            BeginContext(1220, 26, true);
            WriteLiteral("        </td>\r\n    </tr>\r\n");
            EndContext();
#line 48 "C:\Users\zelin\Desktop\Code\UPLOAD TO GIT\Kent_Jensen\C#\Entity\WeddingPlanner\Views\Home\EventListPartial.cshtml"
        }

#line default
#line hidden
            BeginContext(1257, 27, true);
            WriteLiteral(" </tbody>\r\n</table>\r\n</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Event>> Html { get; private set; }
    }
}
#pragma warning restore 1591
