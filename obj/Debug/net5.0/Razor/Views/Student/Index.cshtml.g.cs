#pragma checksum "D:\asp\studentmanagement\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc8e3a50b52315710bd11dd7f550988cb45b1810"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
#line 1 "D:\asp\studentmanagement\Views\_ViewImports.cshtml"
using studentmanagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\asp\studentmanagement\Views\_ViewImports.cshtml"
using studentmanagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc8e3a50b52315710bd11dd7f550988cb45b1810", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b72591a8c0c2c2a00e0e0f0b412d8bde98bc32a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Person>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\asp\studentmanagement\Views\Student\Index.cshtml"
    
    ViewData["Title"]="Student Home";
  

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>List Of Students....</h1>
<table class=""table table-striped"">
  <thead>
    <tr>
      <th scope=""col"">Id</th>
      <th scope=""col"">FirstName</th>
      <th scope=""col"">LastName</th>
      <th scope=""col"">Class</th>
      <th scope=""col"">Roll No</th>
      <th></th>
      <th></th>
      
    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 20 "D:\asp\studentmanagement\Views\Student\Index.cshtml"
    foreach (var student in Model)
   {

#line default
#line hidden
#nullable disable
            WriteLiteral("     <tr scope=\"row\">\r\n         <td>\r\n          <a");
            BeginWriteAttribute("href", " href=\"", 505, "\"", 542, 2);
            WriteAttributeValue("", 512, "/Student/detail?id=", 512, 19, true);
#nullable restore
#line 24 "D:\asp\studentmanagement\Views\Student\Index.cshtml"
WriteAttributeValue("", 531, student.Id, 531, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 24 "D:\asp\studentmanagement\Views\Student\Index.cshtml"
                                              Write(student.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> \r\n           </td>\r\n         <td>");
#nullable restore
#line 26 "D:\asp\studentmanagement\Views\Student\Index.cshtml"
        Write(student.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 27 "D:\asp\studentmanagement\Views\Student\Index.cshtml"
        Write(student.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 28 "D:\asp\studentmanagement\Views\Student\Index.cshtml"
        Write(student.Class);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 29 "D:\asp\studentmanagement\Views\Student\Index.cshtml"
        Write(student.Roll);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td> \r\n<a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 764, "\"", 799, 2);
            WriteAttributeValue("", 771, "/Student/edit?id=", 771, 17, true);
#nullable restore
#line 31 "D:\asp\studentmanagement\Views\Student\Index.cshtml"
WriteAttributeValue("", 788, student.Id, 788, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n\r\n         </td>\r\n<td><a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 858, "\"", 895, 2);
            WriteAttributeValue("", 865, "/Student/delete?id=", 865, 19, true);
#nullable restore
#line 34 "D:\asp\studentmanagement\Views\Student\Index.cshtml"
WriteAttributeValue("", 884, student.Id, 884, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n</td>\r\n         \r\n</tr>  \r\n");
#nullable restore
#line 38 "D:\asp\studentmanagement\Views\Student\Index.cshtml"
   }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>\r\n<span>\r\n<a class=\"btn btn-primary\" href=\"/Student/Add\">Click here to add Student</a>\r\n<a class=\"btn btn-primary\" href=\"/Home/Index\">Goto Home</a>\r\n</span>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591
