#pragma checksum "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\CreateAdminAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a66aab5c20fe66513e36d79ec374754a44e491c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProject_Team11.Views.Account.Views_Account_CreateAdminAccount), @"mvc.1.0.view", @"/Views/Account/CreateAdminAccount.cshtml")]
namespace FinalProject_Team11.Views.Account
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a66aab5c20fe66513e36d79ec374754a44e491c2", @"/Views/Account/CreateAdminAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"649865e2201ccd796a1943f5083fd2adea151ba1", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_CreateAdminAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\CreateAdminAccount.cshtml"
  
    ViewBag.Title = "Create New Admin Account";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 6 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\CreateAdminAccount.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h2>\r\n");
#nullable restore
#line 7 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\CreateAdminAccount.cshtml"
 using (Html.BeginForm("CreateAdminAccount", "Account", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\CreateAdminAccount.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Create a new account.</h4>\r\n    <hr />\r\n");
#nullable restore
#line 12 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\CreateAdminAccount.cshtml"
Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>");
#nullable restore
#line 13 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\CreateAdminAccount.cshtml"
   Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 15 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\CreateAdminAccount.cshtml"
   Write(Html.LabelFor(m => m.Email, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\CreateAdminAccount.cshtml"
       Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 22 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\CreateAdminAccount.cshtml"
   Write(Html.LabelFor(m => m.FirstName, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\CreateAdminAccount.cshtml"
       Write(Html.TextBoxFor(m => m.FirstName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 28 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\CreateAdminAccount.cshtml"
   Write(Html.LabelFor(m => m.LastName, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\CreateAdminAccount.cshtml"
       Write(Html.TextBoxFor(m => m.LastName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 34 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\CreateAdminAccount.cshtml"
   Write(Html.LabelFor(m => m.MI, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\CreateAdminAccount.cshtml"
       Write(Html.TextBoxFor(m => m.MI, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 40 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\CreateAdminAccount.cshtml"
   Write(Html.LabelFor(m => m.Address, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\CreateAdminAccount.cshtml"
       Write(Html.TextBoxFor(m => m.Address, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 46 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\CreateAdminAccount.cshtml"
   Write(Html.LabelFor(m => m.ZipCode, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\CreateAdminAccount.cshtml"
       Write(Html.TextBoxFor(m => m.ZipCode, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 52 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\CreateAdminAccount.cshtml"
   Write(Html.LabelFor(m => m.Birthday, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\CreateAdminAccount.cshtml"
       Write(Html.TextBoxFor(m => m.Birthday, new { @class = "form-control datepicker" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 58 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\CreateAdminAccount.cshtml"
   Write(Html.LabelFor(m => m.PhoneNumber, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\CreateAdminAccount.cshtml"
       Write(Html.TextBoxFor(m => m.PhoneNumber, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 64 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\CreateAdminAccount.cshtml"
   Write(Html.LabelFor(m => m.Password, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\CreateAdminAccount.cshtml"
       Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 70 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\CreateAdminAccount.cshtml"
   Write(Html.LabelFor(m => m.ConfirmPassword, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 72 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\CreateAdminAccount.cshtml"
       Write(Html.PasswordFor(m => m.ConfirmPassword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <button type=\"submit\" class=\"btn btn-warning\">Hire Admin <i class=\"fas fa-user-plus\"></i></button>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 80 "C:\Users\lenovo\Desktop\mis\2pm\FinalProject_Team11\FinalProject_Team11\Views\Account\CreateAdminAccount.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
