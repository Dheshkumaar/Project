#pragma checksum "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed4ee20126f380d101227ca80701c784d5f21731"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed4ee20126f380d101227ca80701c784d5f21731", @"/Views/Order/Confirm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6b6ef930cb10e94410bf8e038133888d990715e", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Confirm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<pizzaClient.Models.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SaveOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("ConfirmOrder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
  
    ViewData["Title"] = "Confirm";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed4ee20126f380d101227ca80701c784d5f217315192", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ed4ee20126f380d101227ca80701c784d5f217315454", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n<div class=\"bg-white m-4 p-4 rounded\">\r\n    <h4 class=\"text-center\">Confirm Details</h4>\r\n    <p class=\"text-center text-danger\">(Once order placed cannot be Cancelled)</p>\r\n    <hr />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed4ee20126f380d101227ca80701c784d5f217317540", async() => {
                WriteLiteral("\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 17 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 20 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.DisplayFor(model => model.CustomerName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 21 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.HiddenFor(model => model.CustomerName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 24 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerPhone));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 27 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.DisplayFor(model => model.CustomerPhone));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 28 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.HiddenFor(model => model.CustomerPhone));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 31 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 34 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 35 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.HiddenFor(model => model.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 38 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 41 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 42 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.HiddenFor(model => model.City));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 45 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.DisplayNameFor(model => model.Pincode));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 48 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.DisplayFor(model => model.Pincode));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 49 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.HiddenFor(model => model.Pincode));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 52 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                &#x20B9;");
#nullable restore
#line 55 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
                   Write(Html.DisplayFor(model => model.Amount));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 56 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.HiddenFor(model => model.Amount));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 59 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.DisplayNameFor(model => model.DeliveryDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 62 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.DisplayFor(model => model.DeliveryDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 63 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
           Write(Html.HiddenFor(model => model.DeliveryDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n        ");
#nullable restore
#line 66 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
   Write(Html.HiddenFor(model => model.AlterOrder));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <div class=""row"">
            <div class=""col-sm-12"">
                <table class=""table table-bordered"">
                    <thead>
                        <tr>
                            <th>Pizza Name</th>
                            <th>Pizza Price</th>
                            <th>Quantity</th>
                            <th>Toppings</th>
                            <th>Crust Type</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 80 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
                          
                            for (var i = 0; i < Model.orderDetails.Count; i++)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr id=\"orderDetails\">\r\n                                    ");
#nullable restore
#line 84 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
                               Write(Html.HiddenFor(m => m.orderDetails[i].pizzaId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 86 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
                                   Write(Model.orderDetails[i].PizzaName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        ");
#nullable restore
#line 87 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
                                   Write(Html.HiddenFor(m => m.orderDetails[i].PizzaName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        &#x20B9;");
#nullable restore
#line 90 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
                                           Write(Model.orderDetails[i].Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        ");
#nullable restore
#line 91 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
                                   Write(Html.HiddenFor(m => m.orderDetails[i].Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 94 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
                                   Write(Model.orderDetails[i].Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        ");
#nullable restore
#line 95 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
                                   Write(Html.HiddenFor(m => m.orderDetails[i].Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 98 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
                                   Write(Model.orderDetails[i].Toppings);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        ");
#nullable restore
#line 99 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
                                   Write(Html.HiddenFor(m=>m.orderDetails[i].Toppings));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 102 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
                                   Write(Model.orderDetails[i].CrustType);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        ");
#nullable restore
#line 103 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
                                   Write(Html.HiddenFor(m=>m.orderDetails[i].CrustType));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 106 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>

        <div class=""form-group text-center"">
            <input type=""submit"" value=""Confirm Order"" class=""btn btn-primary rounded moving-down"" />
            <input type=""button"" value=""Alter Order"" class=""btn btn-outline-success rounded moving-down"" onclick=""alter();"" >
            <input type=""button"" class=""btn btn-danger rounded moving-down"" value=""Cancel Order""");
                BeginWriteAttribute("onclick", " onclick=\"", 5125, "\"", 5180, 3);
                WriteAttributeValue("", 5135, "location.href=\'", 5135, 15, true);
#nullable restore
#line 116 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Order\Confirm.cshtml"
WriteAttributeValue("", 5150, Url.Action("Index", "Pizza"), 5150, 29, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5179, "\'", 5179, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<script>\r\n    function alter() {\r\n        var form = document.forms[\"ConfirmOrder\"];\r\n        form.AlterOrder.value = true;\r\n        form.submit();\r\n    }\r\n</script>\r\n\r\n");
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
