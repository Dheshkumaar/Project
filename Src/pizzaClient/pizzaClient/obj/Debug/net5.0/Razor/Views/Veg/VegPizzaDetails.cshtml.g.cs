#pragma checksum "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Veg\VegPizzaDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c212118ac47c59deaa4880a44be18bc3853b9e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Veg_VegPizzaDetails), @"mvc.1.0.view", @"/Views/Veg/VegPizzaDetails.cshtml")]
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
#line 1 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\_ViewImports.cshtml"
using pizzaClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\_ViewImports.cshtml"
using pizzaClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c212118ac47c59deaa4880a44be18bc3853b9e8", @"/Views/Veg/VegPizzaDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6b6ef930cb10e94410bf8e038133888d990715e", @"/Views/_ViewImports.cshtml")]
    public class Views_Veg_VegPizzaDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<pizzaClient.Models.Pizza>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Veg\VegPizzaDetails.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c212118ac47c59deaa4880a44be18bc3853b9e83430", async() => {
                WriteLiteral(@"
    <style>
        body {
            background-image: url(/image.jpg);
            height: 1000px;
            background-position: center;
            background-repeat: no-repeat;
            background-size: cover;
            position: relative;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"row bg-white text-dark rounded m-4 p-4\">\r\n    <div class=\"col-md-6 order-md-6\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 489, "\"", 549, 2);
            WriteAttributeValue("", 495, "/Images/", 495, 8, true);
#nullable restore
#line 22 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Veg\VegPizzaDetails.cshtml"
WriteAttributeValue("", 503, Html.DisplayFor(model => model.ImageFileName), 503, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 550, "\"", 556, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"w-75 img-thumbnail\" />\r\n    </div>\r\n    <div class=\"col-md-6 order-md-1\">\r\n        <div class=\"row align-items-center h-100\">\r\n            <div class=\"col\">\r\n                <h1 class=\"display-3\">");
#nullable restore
#line 27 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Veg\VegPizzaDetails.cshtml"
                                 Write(Html.DisplayFor(model => model.PizzaName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                <p class=""lead"">
                    <dl>
                        <dd class=""col-sm-12"">
                                <span class=""badge badge-success"">Veg</span>
                        </dd>
                        <dt class=""col-sm-2"">
                            ");
#nullable restore
#line 34 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Veg\VegPizzaDetails.cshtml"
                       Write(Html.DisplayNameFor(model => model.Speciality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 37 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Veg\VegPizzaDetails.cshtml"
                       Write(Html.DisplayFor(model => model.Speciality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 40 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Veg\VegPizzaDetails.cshtml"
                       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            &#x20B9;");
#nullable restore
#line 43 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Veg\VegPizzaDetails.cshtml"
                               Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 46 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Veg\VegPizzaDetails.cshtml"
                       Write(Html.DisplayNameFor(model => model.PizzaDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 49 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Veg\VegPizzaDetails.cshtml"
                       Write(Html.DisplayFor(model => model.PizzaDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n\r\n                    </dl>\r\n                    <input type=\"button\" class=\"btn btn-danger rounded\" value=\"Back To Menu\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2079, "\"", 2135, 3);
            WriteAttributeValue("", 2089, "location.href=\'", 2089, 15, true);
#nullable restore
#line 53 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Veg\VegPizzaDetails.cshtml"
WriteAttributeValue("", 2104, Url.Action("VegPizza", "Veg"), 2104, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2134, "\'", 2134, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<pizzaClient.Models.Pizza> Html { get; private set; }
    }
}
#pragma warning restore 1591
