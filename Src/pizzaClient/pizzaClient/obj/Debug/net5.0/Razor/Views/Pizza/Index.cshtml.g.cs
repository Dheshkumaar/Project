#pragma checksum "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Pizza\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb9b9dc38e449f0671e5f69cb8cee653c9b5bb59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_Index), @"mvc.1.0.view", @"/Views/Pizza/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb9b9dc38e449f0671e5f69cb8cee653c9b5bb59", @"/Views/Pizza/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6b6ef930cb10e94410bf8e038133888d990715e", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizza_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<pizzaClient.Models.Pizza>>
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
#line 3 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Pizza\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb9b9dc38e449f0671e5f69cb8cee653c9b5bb593394", async() => {
                WriteLiteral(@"
    <style>
        body {
            background-image: url(/image.jpg);
            height: 700px;
            background-position: center;
            background-repeat: no-repeat;
            background-size: cover;
            position: relative;
        }
        .big-check-box {
            height: 20px;
            width: 20px;
            margin-left: -15px;
            margin-top: 12px;
        }
        .order{
            text-align: right;
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 29 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Pizza\Index.cshtml"
 using (Html.BeginForm("InitiateOrder", "Order", FormMethod.Post, new { id = "pizzalist"}))
{ 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <header class="" order"">
        <div class=""row"">
            <div class=""col-11"">
                <h3 class=""text-white text-center"">Welcome To Pizza Store </h3>
            </div>
            <div class=""col-1"">
                <input type=""button"" class=""btn btn-primary rounded"" value=""Order Now"" onclick=""orderNow()"" />
                <input type=""hidden"" id=""selectedPizza"">
            </div>
        </div>    
    </header>
");
#nullable restore
#line 42 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Pizza\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card float-left form-check m-3 \" style=\"width: 20rem;\">\r\n            <input type=\"checkbox\" class=\"big-check-box form-check-input\"");
            BeginWriteAttribute("name", " name=\"", 1346, "\"", 1366, 1);
#nullable restore
#line 45 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Pizza\Index.cshtml"
WriteAttributeValue("", 1353, item.PizzaId, 1353, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img class=\"card-img-top p-2\"");
            BeginWriteAttribute("src", " src=\"", 1411, "\"", 1444, 2);
            WriteAttributeValue("", 1417, "/Images/", 1417, 8, true);
#nullable restore
#line 46 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Pizza\Index.cshtml"
WriteAttributeValue("", 1425, item.ImageFileName, 1425, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\" height=\"250\" alt=\"Card image cap\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\"><i>");
#nullable restore
#line 48 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Pizza\Index.cshtml"
                                     Write(Html.DisplayFor(modelItem => item.PizzaName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></h5>\r\n                <p class=\"card-text\"><b>");
#nullable restore
#line 49 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Pizza\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</b>&nbsp;&#x20B9;<i>");
#nullable restore
#line 49 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Pizza\Index.cshtml"
                                                                                                   Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n                <p>\r\n");
#nullable restore
#line 51 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Pizza\Index.cshtml"
                     if (item.IsVeg == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"badge badge-success\">Veg</span>\r\n");
#nullable restore
#line 54 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Pizza\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"badge badge-danger\">Non Veg</span>\r\n");
#nullable restore
#line 58 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Pizza\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </p>\r\n                <input type=\"button\" class=\"btn btn-outline-secondary rounded\" value=\"View Details\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2233, "\"", 2314, 3);
            WriteAttributeValue("", 2243, "location.href=\'", 2243, 15, true);
#nullable restore
#line 60 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Pizza\Index.cshtml"
WriteAttributeValue("", 2258, Url.Action("Detail", "Pizza",new { id = item.PizzaId}), 2258, 55, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2313, "\'", 2313, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 63 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Pizza\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\DHESH KUMAAR A\Desktop\Project\Src\PizzaClient\pizzaClient\Views\Pizza\Index.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script>
    function orderNow() {

        var selected = [];
        $('.big-check-box:checked').each(function () {
            selected.push($(this).attr('name'));
        });
        if (selected.length == 0) {
            alert('Select any pizza to order.');
            return false;
        }
        var selectedPizza = selected.join("","");
        $('#SelectedPizza').val(selectedPizza);

        var action = $('#pizzalist').attr(""action"");
        action += '?pizzaIds=' + selectedPizza;
        $('#pizzalist').attr(""action"", action);
        $('#pizzalist').submit();        
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<pizzaClient.Models.Pizza>> Html { get; private set; }
    }
}
#pragma warning restore 1591
