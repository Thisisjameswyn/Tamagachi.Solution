#pragma checksum "D:\Epicodus\ToDoList.Solution\tamagotchi\Views\Tamagotchis\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a26c57804a2804483ebc7eb048dcf77587868de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tamagotchis_Index), @"mvc.1.0.view", @"/Views/Tamagotchis/Index.cshtml")]
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
#line 1 "D:\Epicodus\ToDoList.Solution\tamagotchi\Views\Tamagotchis\Index.cshtml"
using Tamagotchis.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a26c57804a2804483ebc7eb048dcf77587868de", @"/Views/Tamagotchis/Index.cshtml")]
    public class Views_Tamagotchis_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Build yourself a Tamagotchi!!</h1>\r\n");
#nullable restore
#line 4 "D:\Epicodus\ToDoList.Solution\tamagotchi\Views\Tamagotchis\Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>There are no Tamagotchis on the list.</p>\r\n");
#nullable restore
#line 7 "D:\Epicodus\ToDoList.Solution\tamagotchi\Views\Tamagotchis\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul>\r\n");
#nullable restore
#line 9 "D:\Epicodus\ToDoList.Solution\tamagotchi\Views\Tamagotchis\Index.cshtml"
   foreach (Tamagotchi tama in Model)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li><a");
            BeginWriteAttribute("href", " href=\'", 208, "\'", 236, 2);
            WriteAttributeValue("", 215, "/tamagotchis/", 215, 13, true);
#nullable restore
#line 11 "D:\Epicodus\ToDoList.Solution\tamagotchi\Views\Tamagotchis\Index.cshtml"
WriteAttributeValue("", 228, tama.Id, 228, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 11 "D:\Epicodus\ToDoList.Solution\tamagotchi\Views\Tamagotchis\Index.cshtml"
                                   Write(tama.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 12 "D:\Epicodus\ToDoList.Solution\tamagotchi\Views\Tamagotchis\Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<a href=\"/tamagotchis/new\">Add a new tamagotchi.</a>\r\n\r\n<form action=\"/tamagotchis/delete\" method=\"post\">\r\n  <button type=\"submit\" name=\"button\">Clear All tamagotchis</button> ");
            WriteLiteral("\r\n</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591