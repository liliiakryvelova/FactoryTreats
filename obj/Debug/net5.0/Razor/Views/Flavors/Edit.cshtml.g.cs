#pragma checksum "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b42e0bdf6c8bca0077978f5cb323cfe8faa77dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flavors_Edit), @"mvc.1.0.view", @"/Views/Flavors/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b42e0bdf6c8bca0077978f5cb323cfe8faa77dc", @"/Views/Flavors/Edit.cshtml")]
    public class Views_Flavors_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FactoryTreats.Models.Flavor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n<h4>Edit this task: ");
#nullable restore
#line 9 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Edit.cshtml"
               Write(Html.DisplayFor(model => model.FlavorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Edit.cshtml"
Write(Html.HiddenFor(model => model.FlavorId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Edit.cshtml"
Write(Html.LabelFor(model => model.FlavorName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Edit.cshtml"
Write(Html.EditorFor(model => model.FlavorName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Edit.cshtml"
Write(Html.Label("Select treat"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Edit.cshtml"
Write(Html.DropDownList("TreatId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\r\n");
#nullable restore
#line 22 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>");
#nullable restore
#line 24 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FactoryTreats.Models.Flavor> Html { get; private set; }
    }
}
#pragma warning restore 1591
