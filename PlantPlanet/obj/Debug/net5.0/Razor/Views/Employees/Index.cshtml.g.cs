#pragma checksum "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf20605cc06146641c0a7f484312e314e663ed90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Index), @"mvc.1.0.view", @"/Views/Employees/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf20605cc06146641c0a7f484312e314e663ed90", @"/Views/Employees/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"850ef60c086d6fc30b5e6574db55d42576e80cda", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PlantPlanet.Models.Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf20605cc06146641c0a7f484312e314e663ed904861", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TeudatZehut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BonusRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsCurrentlyEmployed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HouseNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FloorNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 55 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FlatNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 58 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ZipCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 64 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TeudatZehut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 82 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 88 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BonusRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 91 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsCurrentlyEmployed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 94 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 97 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 100 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HouseNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 103 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FloorNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 106 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FlatNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 109 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ZipCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf20605cc06146641c0a7f484312e314e663ed9018166", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 112 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
                                       WriteLiteral(item.EmployeeId);

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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf20605cc06146641c0a7f484312e314e663ed9020411", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 113 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
                                          WriteLiteral(item.EmployeeId);

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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf20605cc06146641c0a7f484312e314e663ed9022662", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 114 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
                                         WriteLiteral(item.EmployeeId);

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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 117 "C:\Users\romko\OneDrive\שולחן העבודה\תואר\שנה ב\סימסטר ב\פיתוח אפליקציות אינטרנטיות\פרויקט סיכום\PlantPlanet\PlantPlanet\Views\Employees\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PlantPlanet.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
