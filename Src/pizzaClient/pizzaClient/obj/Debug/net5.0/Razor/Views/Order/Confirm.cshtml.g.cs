#pragma checksum "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\Order\Confirm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "614186eb05c16c9fe62183f94bc6853866d52e5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Confirm), @"mvc.1.0.view", @"/Views/Order/Confirm.cshtml")]
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
#line 1 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\_ViewImports.cshtml"
using pizzaClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\_ViewImports.cshtml"
using pizzaClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"614186eb05c16c9fe62183f94bc6853866d52e5f", @"/Views/Order/Confirm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6b6ef930cb10e94410bf8e038133888d990715e", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Confirm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<pizzaClient.Models.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SaveOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
  
    ViewData["Title"] = "Confirm";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "614186eb05c16c9fe62183f94bc6853866d52e5f3953", async() => {
                WriteLiteral(@"
    <style>
        body {
            background-image: url(/image.jpg);
            height: 500px;
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
            WriteLiteral("\r\n<div class=\"bg-white m-4 p-4 rounded\">\r\n    <h4 class=\"text-center\">Confirm Details</h4>\r\n    <hr />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "614186eb05c16c9fe62183f94bc6853866d52e5f5319", async() => {
                WriteLiteral("\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                Pizza Name\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 28 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(TempData["PizzaName"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                Pizza Price\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 34 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(TempData["PizzaPrice"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 37 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 40 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.DisplayFor(model => model.CustomerName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 41 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.HiddenFor(model => model.CustomerName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 44 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerPhone));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 47 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.DisplayFor(model => model.CustomerPhone));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 48 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.HiddenFor(model => model.CustomerPhone));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 51 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 54 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 55 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.HiddenFor(model => model.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 59 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 62 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 63 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.HiddenFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 66 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.DisplayNameFor(model => model.Toppings));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 69 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.DisplayFor(model => model.Toppings));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 70 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.HiddenFor(model => model.Toppings));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 73 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.DisplayNameFor(model => model.CrustType));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 76 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.DisplayFor(model => model.CrustType));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 77 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.HiddenFor(model => model.CrustType));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 80 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 83 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.DisplayFor(model => model.Amount));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 84 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.HiddenFor(model => model.Amount));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 87 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.DisplayNameFor(model => model.DeliveryDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 90 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.DisplayFor(model => model.DeliveryDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 91 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.HiddenFor(model => model.DeliveryDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n        <div class=\"form-group\">\r\n            <input type=\"submit\" value=\"Confirm Order\" class=\"btn btn-primary rounded-pill\" />\r\n            <input type=\"button\" class=\"btn btn-danger rounded-pill\" value=\"Back\"");
                BeginWriteAttribute("onclick", " onclick=\"", 3474, "\"", 3529, 3);
                WriteAttributeValue("", 3484, "location.href=\'", 3484, 15, true);
#nullable restore
#line 96 "C:\Users\DHESH KUMAAR A\source\repos\pizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
WriteAttributeValue("", 3499, Url.Action("Index", "Pizza"), 3499, 29, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3528, "\'", 3528, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<pizzaClient.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591