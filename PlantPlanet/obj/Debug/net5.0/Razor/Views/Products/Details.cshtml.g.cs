#pragma checksum "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a59d1f3b6ac6c7a57dd612d7116e6f22538784ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
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
#line 1 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\_ViewImports.cshtml"
using PlantPlanet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\_ViewImports.cshtml"
using PlantPlanet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a59d1f3b6ac6c7a57dd612d7116e6f22538784ac", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"850ef60c086d6fc30b5e6574db55d42576e80cda", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlantPlanet.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Product</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Treatment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Treatment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TreatmentTips));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.TreatmentTips));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BuyingCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.BuyingCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SellingPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.SellingPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Supplier));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Supplier.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StockId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.StockId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ImageURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.ImageURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NetIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.NetIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UnitsSold));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.UnitsSold));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a59d1f3b6ac6c7a57dd612d7116e6f22538784ac15363", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 100 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Products\Details.cshtml"
                           WriteLiteral(Model.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a59d1f3b6ac6c7a57dd612d7116e6f22538784ac17585", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlantPlanet.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
