#pragma checksum "C:\Users\lilia\Epicodus\ASP.NET\Factory\Factory\Views\Engineers\AddCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c34090c338f3e554c985f99c7a1dae6b84ca8517"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Engineers_AddCategory), @"mvc.1.0.view", @"/Views/Engineers/AddCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c34090c338f3e554c985f99c7a1dae6b84ca8517", @"/Views/Engineers/AddCategory.cshtml")]
    public class Views_Engineers_AddCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Factory.Models.Engineer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\lilia\Epicodus\ASP.NET\Factory\Factory\Views\Engineers\AddCategory.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Add a machine</h2>\r\n\r\n<h4>Add a machine to this engineer: ");
#nullable restore
#line 9 "C:\Users\lilia\Epicodus\ASP.NET\Factory\Factory\Views\Engineers\AddCategory.cshtml"
                               Write(Html.DisplayFor(model => model.EngineerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\lilia\Epicodus\ASP.NET\Factory\Factory\Views\Engineers\AddCategory.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\lilia\Epicodus\ASP.NET\Factory\Factory\Views\Engineers\AddCategory.cshtml"
Write(Html.HiddenFor(model => model.EngineerId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\lilia\Epicodus\ASP.NET\Factory\Factory\Views\Engineers\AddCategory.cshtml"
Write(Html.Label("Select machine"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\lilia\Epicodus\ASP.NET\Factory\Factory\Views\Engineers\AddCategory.cshtml"
Write(Html.DropDownList("MachineId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\r\n");
#nullable restore
#line 19 "C:\Users\lilia\Epicodus\ASP.NET\Factory\Factory\Views\Engineers\AddCategory.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>");
#nullable restore
#line 21 "C:\Users\lilia\Epicodus\ASP.NET\Factory\Factory\Views\Engineers\AddCategory.cshtml"
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
