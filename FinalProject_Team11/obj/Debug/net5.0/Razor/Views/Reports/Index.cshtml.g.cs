#pragma checksum "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c99ca7c5290acf509929e5a266489ca352d3dfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProject_Team11.Views.Reports.Views_Reports_Index), @"mvc.1.0.view", @"/Views/Reports/Index.cshtml")]
namespace FinalProject_Team11.Views.Reports
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
#line 13 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\_ViewImports.cshtml"
using FinalProject_Team11.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c99ca7c5290acf509929e5a266489ca352d3dfb", @"/Views/Reports/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"649865e2201ccd796a1943f5083fd2adea151ba1", @"/Views/_ViewImports.cshtml")]
    public class Views_Reports_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FinalProject_Team11.Models.Property>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Properties", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SortReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reports", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Below shows all your properties</h3>\r\n\r\n\r\n");
#nullable restore
#line 8 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c99ca7c5290acf509929e5a266489ca352d3dfb5869", async() => {
                WriteLiteral("View Orders");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
 if (User.IsInRole("Host"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c99ca7c5290acf509929e5a266489ca352d3dfb7546", async() => {
                WriteLiteral("View Properties");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c99ca7c5290acf509929e5a266489ca352d3dfb8801", async() => {
                WriteLiteral("Sort Report");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 15 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
                                                                                              }

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
 if (User.IsInRole("Admin")) {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
Write(Html.ActionLink("Totals", "AdminReport", "Reports", null, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
                                                                                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>\r\n\r\n</p>\r\n<p>Displaying ");
#nullable restore
#line 22 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
         Write(ViewBag.SelectedProperties);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 22 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
                                        Write(ViewBag.AllProperties);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Properties</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PropertyState));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PropertyCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WeekdayPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WeekendPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PropertyBedroom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PropertyBathroom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PropertyRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 55 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PropertyState));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PropertyCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 66 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.WeekdayPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.WeekendPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 72 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PropertyBedroom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 75 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PropertyBathroom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 78 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PropertyRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 81 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Category.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n");
#nullable restore
#line 84 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
                 if (User.Identity.IsAuthenticated)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
                     if (User.IsInRole("Admin") && User.IsInRole("Host"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
#nullable restore
#line 89 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
                       Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                            ");
#nullable restore
#line 90 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
                       Write(Html.ActionLink("Details", "Details", new { id = item.PropertyID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                            ");
#nullable restore
#line 91 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
                       Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 93 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
                     



                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 99 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
               Write(Html.ActionLink("Report", "HostReport", new { id = item.PropertyID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 103 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Reports\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FinalProject_Team11.Models.Property>> Html { get; private set; }
    }
}
#pragma warning restore 1591