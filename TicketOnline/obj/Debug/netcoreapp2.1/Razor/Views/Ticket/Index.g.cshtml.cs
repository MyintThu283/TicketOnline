#pragma checksum "D:\friends\mt\TicketOnline\TicketOnline\Views\Ticket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70d85f12d4a6bb0b70beec48d56ae90c2ab81daf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticket_Index), @"mvc.1.0.view", @"/Views/Ticket/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ticket/Index.cshtml", typeof(AspNetCore.Views_Ticket_Index))]
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
#line 1 "D:\friends\mt\TicketOnline\TicketOnline\Views\_ViewImports.cshtml"
using TicketOnline;

#line default
#line hidden
#line 2 "D:\friends\mt\TicketOnline\TicketOnline\Views\_ViewImports.cshtml"
using TicketOnline.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70d85f12d4a6bb0b70beec48d56ae90c2ab81daf", @"/Views/Ticket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f53d8d5345080c1b33f3f97657ea571b9a5c7e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TicketOnline.Models.Ticket>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\friends\mt\TicketOnline\TicketOnline\Views\Ticket\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(82, 379, true);
            WriteLiteral(@"    <br />
    <div class=""row"">
        <div class=""col-md-8"">
            <h2>Index</h2>
        </div>
        <div class=""col-md-4"">
            <a class=""btn"" style=""background-color:white;color:black"" href=""create"">Create New</a>
            <a class=""btn btn-danger""  href=""/ticket/orders"">Check Orders</a>
        </div>
    </div>

<br />
<div class=""row"">
");
            EndContext();
#line 18 "D:\friends\mt\TicketOnline\TicketOnline\Views\Ticket\Index.cshtml"
     foreach(var ticket in Model)
    {

#line default
#line hidden
            BeginContext(503, 40, true);
            WriteLiteral("    <div class=\"col-md-4\">\r\n        <div");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 543, "\"", 675, 3);
            WriteAttributeValue("", 551, "width:90%;height:300px;background-size:cover;background-position:center;background-image:url(/img/posts/", 551, 104, true);
#line 21 "D:\friends\mt\TicketOnline\TicketOnline\Views\Ticket\Index.cshtml"
WriteAttributeValue("", 655, ticket.TicketPhoto, 655, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 674, ")", 674, 1, true);
            EndWriteAttribute();
            BeginContext(676, 21, true);
            WriteLiteral("></div>\r\n        <h5>");
            EndContext();
            BeginContext(698, 11, false);
#line 22 "D:\friends\mt\TicketOnline\TicketOnline\Views\Ticket\Index.cshtml"
       Write(ticket.Name);

#line default
#line hidden
            EndContext();
            BeginContext(709, 51, true);
            WriteLiteral("</h5>\r\n        <hr />\r\n        <br />\r\n    </div>\r\n");
            EndContext();
#line 26 "D:\friends\mt\TicketOnline\TicketOnline\Views\Ticket\Index.cshtml"
    
    }

#line default
#line hidden
            BeginContext(773, 12, true);
            WriteLiteral("    \r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TicketOnline.Models.Ticket>> Html { get; private set; }
    }
}
#pragma warning restore 1591