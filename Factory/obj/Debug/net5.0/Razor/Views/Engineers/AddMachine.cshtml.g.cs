#pragma checksum "/Users/phantom/Desktop/Factory.Solution/Factory/Views/Engineers/AddMachine.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52d1533e4705d51b05b7e074902b876f3178b670"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Engineers_AddMachine), @"mvc.1.0.view", @"/Views/Engineers/AddMachine.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d1533e4705d51b05b7e074902b876f3178b670", @"/Views/Engineers/AddMachine.cshtml")]
    public class Views_Engineers_AddMachine : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Factory.Models.Engineer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/phantom/Desktop/Factory.Solution/Factory/Views/Engineers/AddMachine.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h2>Add a machine</h2>\n\n<h4>Assign a machine to this engineer: ");
#nullable restore
#line 9 "/Users/phantom/Desktop/Factory.Solution/Factory/Views/Engineers/AddMachine.cshtml"
                                  Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n");
#nullable restore
#line 11 "/Users/phantom/Desktop/Factory.Solution/Factory/Views/Engineers/AddMachine.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/phantom/Desktop/Factory.Solution/Factory/Views/Engineers/AddMachine.cshtml"
Write(Html.HiddenFor(model => model.EngineerId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/phantom/Desktop/Factory.Solution/Factory/Views/Engineers/AddMachine.cshtml"
Write(Html.Label("Select machine"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/phantom/Desktop/Factory.Solution/Factory/Views/Engineers/AddMachine.cshtml"
Write(Html.DropDownList("MachineId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Save\" class=\"btn btn-default\" />\n");
#nullable restore
#line 19 "/Users/phantom/Desktop/Factory.Solution/Factory/Views/Engineers/AddMachine.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p>");
#nullable restore
#line 21 "/Users/phantom/Desktop/Factory.Solution/Factory/Views/Engineers/AddMachine.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Factory.Models.Engineer> Html { get; private set; }
    }
}
#pragma warning restore 1591