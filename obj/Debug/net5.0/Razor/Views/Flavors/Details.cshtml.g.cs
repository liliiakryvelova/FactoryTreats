#pragma checksum "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5ea8687c142a06d6f2f2b24c638ce33e4b6333a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flavors_Details), @"mvc.1.0.view", @"/Views/Flavors/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5ea8687c142a06d6f2f2b24c638ce33e4b6333a", @"/Views/Flavors/Details.cshtml")]
    public class Views_Flavors_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FactoryTreats.Models.Flavor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Flaovr Details</h2>\r\n<hr />\r\n<h3>");
#nullable restore
#line 9 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Details.cshtml"
Write(Html.DisplayNameFor(model => model.FlavorName));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 9 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Details.cshtml"
                                                Write(Html.DisplayFor(model => model.FlavorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Details.cshtml"
 if(@Model.JoinEntities.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>This Flavor does not belong to any Treat</p>\r\n");
#nullable restore
#line 14 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h4>Treats the Flavor belongs to:</h4>\r\n  <ul>\r\n");
#nullable restore
#line 19 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Details.cshtml"
     foreach(var join in Model.JoinEntities)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <li>");
#nullable restore
#line 21 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Details.cshtml"
     Write(join.Treat.TreatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 22 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Details.cshtml"
       using (Html.BeginForm("DeleteMachine", "Engineers"))
      {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Details.cshtml"
   Write(Html.Hidden("joinId", @join.TreatFlavorId));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"submit\" value=\"Delete\"/>\r\n");
#nullable restore
#line 26 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Details.cshtml"
      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Details.cshtml"
       
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </ul>\r\n");
#nullable restore
#line 30 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>");
#nullable restore
#line 32 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Details.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 33 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Details.cshtml"
Write(Html.ActionLink("Edit Flavor", "Edit", new { id = Model.FlavorId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 34 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Details.cshtml"
Write(Html.ActionLink("Delete Flavor", "Delete", new { id = Model.FlavorId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 35 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Details.cshtml"
Write(Html.ActionLink("Add a Treat", "AddTreat", new { id = Model.FlavorId }));

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