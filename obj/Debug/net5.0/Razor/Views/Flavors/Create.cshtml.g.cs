#pragma checksum "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9d26c134b82bbe7b1cc8ece38385f5918fdb285"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flavors_Create), @"mvc.1.0.view", @"/Views/Flavors/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9d26c134b82bbe7b1cc8ece38385f5918fdb285", @"/Views/Flavors/Create.cshtml")]
    public class Views_Flavors_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FactoryTreats.Models.Flavor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h4>Add a new flavor</h4>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Create.cshtml"
Write(Html.LabelFor(model => model.FlavorName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Create.cshtml"
Write(Html.TextBoxFor(model => model.FlavorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <div>\r\n        ");
#nullable restore
#line 15 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Create.cshtml"
   Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <input type=\"submit\" value=\"Add new flavor\" class=\"btn btn-default\" />\r\n");
#nullable restore
#line 19 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 20 "C:\Users\lilia\Epicodus\ASP.NET\SweetSavoryTreats\FactoryTreats\Views\Flavors\Create.cshtml"
Write(Html.ActionLink("Show all flavors", "Index"));

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