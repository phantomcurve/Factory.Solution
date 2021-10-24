#pragma checksum "/Users/phantom/Desktop/Factory.Solution/Factory/Views/Machines/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbf8ee606501815ddc78c3ec9c5357c1c8bc0574"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Machines_Details), @"mvc.1.0.view", @"/Views/Machines/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbf8ee606501815ddc78c3ec9c5357c1c8bc0574", @"/Views/Machines/Details.cshtml")]
    public class Views_Machines_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Factory.Models.Machine>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/phantom/Desktop/Factory.Solution/Factory/Views/Machines/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("<div class=\"container\">\n<h2>Machine Name</h2>\n<hr />\n<h3>");
#nullable restore
#line 9 "/Users/phantom/Desktop/Factory.Solution/Factory/Views/Machines/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 9 "/Users/phantom/Desktop/Factory.Solution/Factory/Views/Machines/Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\n");
#nullable restore
#line 11 "/Users/phantom/Desktop/Factory.Solution/Factory/Views/Machines/Details.cshtml"
 if(@Model.JoinEntities.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>This machine does not have any assigned engineers</p>\n");
#nullable restore
#line 14 "/Users/phantom/Desktop/Factory.Solution/Factory/Views/Machines/Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h4>This machine is assigned to the following engineers:</h4>\n  <ul>\n");
#nullable restore
#line 19 "/Users/phantom/Desktop/Factory.Solution/Factory/Views/Machines/Details.cshtml"
   foreach(var join in Model.JoinEntities)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 21 "/Users/phantom/Desktop/Factory.Solution/Factory/Views/Machines/Details.cshtml"
   Write(join.Engineer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 22 "/Users/phantom/Desktop/Factory.Solution/Factory/Views/Machines/Details.cshtml"
     using (Html.BeginForm("DeleteEngineer", "Machines"))
    {
      

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "/Users/phantom/Desktop/Factory.Solution/Factory/Views/Machines/Details.cshtml"
 Write(Html.Hidden("joinId", @join.EngineerMachineId));

#line default
#line hidden
#nullable disable
            WriteLiteral("      <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" />\n");
#nullable restore
#line 26 "/Users/phantom/Desktop/Factory.Solution/Factory/Views/Machines/Details.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "/Users/phantom/Desktop/Factory.Solution/Factory/Views/Machines/Details.cshtml"
     
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ul>\n");
#nullable restore
#line 29 "/Users/phantom/Desktop/Factory.Solution/Factory/Views/Machines/Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("  \n\n\n<p>");
#nullable restore
#line 33 "/Users/phantom/Desktop/Factory.Solution/Factory/Views/Machines/Details.cshtml"
Write(Html.ActionLink("Assign an existing Engineer to this machine", "AddEngineer", new { id = Model.MachineId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 34 "/Users/phantom/Desktop/Factory.Solution/Factory/Views/Machines/Details.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 35 "/Users/phantom/Desktop/Factory.Solution/Factory/Views/Machines/Details.cshtml"
Write(Html.ActionLink("Edit Machine", "Edit", new { id = Model.MachineId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 36 "/Users/phantom/Desktop/Factory.Solution/Factory/Views/Machines/Details.cshtml"
Write(Html.ActionLink("Delete Machine", "Delete", new { id = Model.MachineId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Factory.Models.Machine> Html { get; private set; }
    }
}
#pragma warning restore 1591
