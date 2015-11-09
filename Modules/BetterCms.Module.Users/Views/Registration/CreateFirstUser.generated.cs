﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Registration\CreateFirstUser.cshtml"
    using BetterCms.Module.Users.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Registration\CreateFirstUser.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Registration/CreateFirstUser.cshtml")]
    public partial class _Views_Registration_CreateFirstUser_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Users.ViewModels.Registration.CreateFirstUserViewModel>
    {
        public _Views_Registration_CreateFirstUser_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 6 "..\..\Views\Registration\CreateFirstUser.cshtml"
  
    Layout = "~/Areas/bcms-users/Views/Shared/PublicActionLayout.cshtml";
    ViewBag.Title = "Better CMS - Users Module Registration";

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 11 "..\..\Views\Registration\CreateFirstUser.cshtml"
 using (Html.BeginForm())
{

            
            #line default
            #line hidden
WriteLiteral("    <h2>Create first user for the Better CMS</h2>\n");

WriteLiteral("    <div");

WriteLiteral(" class=\"validation-summary-valid\"");

WriteLiteral(" data-valmsg-summary=\"true\"");

WriteLiteral(">\n");

WriteLiteral("        ");

            
            #line 15 "..\..\Views\Registration\CreateFirstUser.cshtml"
   Write(Html.ValidationSummary());

            
            #line default
            #line hidden
WriteLiteral("\n    </div>\n");

WriteLiteral("    <div>\n        <span");

WriteLiteral(" class=\"bcms-title\"");

WriteLiteral(">");

            
            #line 18 "..\..\Views\Registration\CreateFirstUser.cshtml"
                            Write(UsersGlobalization.EditUser_FirstName_Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\n        <p>\n");

WriteLiteral("            ");

            
            #line 20 "..\..\Views\Registration\CreateFirstUser.cshtml"
       Write(Html.TextBoxFor(m => m.FirstName, new { @class = "bcms-field-text", @id = "firstName" }));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("            ");

            
            #line 21 "..\..\Views\Registration\CreateFirstUser.cshtml"
       Write(Html.ValidationMessageFor(m => m.FirstName));

            
            #line default
            #line hidden
WriteLiteral("\n        </p>\n    </div>\n");

            
            #line 24 "..\..\Views\Registration\CreateFirstUser.cshtml"


            
            #line default
            #line hidden
WriteLiteral("    <div>\n        <span");

WriteLiteral(" class=\"bcms-title\"");

WriteLiteral(">");

            
            #line 26 "..\..\Views\Registration\CreateFirstUser.cshtml"
                            Write(UsersGlobalization.EditUser_LastName);

            
            #line default
            #line hidden
WriteLiteral("</span>\n        <p>\n");

WriteLiteral("            ");

            
            #line 28 "..\..\Views\Registration\CreateFirstUser.cshtml"
       Write(Html.TextBoxFor(m => m.LastName, new { @class = "bcms-field-text" }));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("            ");

            
            #line 29 "..\..\Views\Registration\CreateFirstUser.cshtml"
       Write(Html.ValidationMessageFor(m => m.LastName));

            
            #line default
            #line hidden
WriteLiteral("\n        </p>\n    </div>\n");

            
            #line 32 "..\..\Views\Registration\CreateFirstUser.cshtml"


            
            #line default
            #line hidden
WriteLiteral("    <div>\n        <span");

WriteLiteral(" class=\"bcms-title\"");

WriteLiteral(">");

            
            #line 34 "..\..\Views\Registration\CreateFirstUser.cshtml"
                            Write(UsersGlobalization.EditUser_UserName_Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\n        <p>\n");

WriteLiteral("            ");

            
            #line 36 "..\..\Views\Registration\CreateFirstUser.cshtml"
       Write(Html.TextBoxFor(m => m.UserName, new { @class = "bcms-field-text" }));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("            ");

            
            #line 37 "..\..\Views\Registration\CreateFirstUser.cshtml"
       Write(Html.ValidationMessageFor(m => m.UserName));

            
            #line default
            #line hidden
WriteLiteral("\n        </p>\n    </div>\n");

            
            #line 40 "..\..\Views\Registration\CreateFirstUser.cshtml"


            
            #line default
            #line hidden
WriteLiteral("    <div>\n        <span");

WriteLiteral(" class=\"bcms-title\"");

WriteLiteral(">");

            
            #line 42 "..\..\Views\Registration\CreateFirstUser.cshtml"
                            Write(UsersGlobalization.EditUser_Email_Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\n        <p>\n");

WriteLiteral("            ");

            
            #line 44 "..\..\Views\Registration\CreateFirstUser.cshtml"
       Write(Html.TextBoxFor(m => m.Email, new { @class = "bcms-field-text" }));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("            ");

            
            #line 45 "..\..\Views\Registration\CreateFirstUser.cshtml"
       Write(Html.ValidationMessageFor(m => m.Email));

            
            #line default
            #line hidden
WriteLiteral("\n        </p>\n    </div>\n");

            
            #line 48 "..\..\Views\Registration\CreateFirstUser.cshtml"


            
            #line default
            #line hidden
WriteLiteral("    <div>\n        <span");

WriteLiteral(" class=\"bcms-title\"");

WriteLiteral(">");

            
            #line 50 "..\..\Views\Registration\CreateFirstUser.cshtml"
                            Write(UsersGlobalization.EditUser_Password_Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\n        <p>\n");

WriteLiteral("            ");

            
            #line 52 "..\..\Views\Registration\CreateFirstUser.cshtml"
       Write(Html.PasswordFor(m => m.Password, new { @class = "bcms-field-text" }));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("            ");

            
            #line 53 "..\..\Views\Registration\CreateFirstUser.cshtml"
       Write(Html.ValidationMessageFor(m => m.Password));

            
            #line default
            #line hidden
WriteLiteral("\n        </p>\n    </div>\n");

            
            #line 56 "..\..\Views\Registration\CreateFirstUser.cshtml"


            
            #line default
            #line hidden
WriteLiteral("    <div>\n        <span");

WriteLiteral(" class=\"bcms-title\"");

WriteLiteral(">");

            
            #line 58 "..\..\Views\Registration\CreateFirstUser.cshtml"
                            Write(UsersGlobalization.EditUser_RetypePassword_Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\n        <p>\n");

WriteLiteral("            ");

            
            #line 60 "..\..\Views\Registration\CreateFirstUser.cshtml"
       Write(Html.PasswordFor(m => m.RetypedPassword, new { @class = "bcms-field-text" }));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("            ");

            
            #line 61 "..\..\Views\Registration\CreateFirstUser.cshtml"
       Write(Html.ValidationMessageFor(m => m.RetypedPassword));

            
            #line default
            #line hidden
WriteLiteral("\n        </p>\n    </div>\n");

            
            #line 64 "..\..\Views\Registration\CreateFirstUser.cshtml"
    
            
            #line default
            #line hidden
            
            #line 64 "..\..\Views\Registration\CreateFirstUser.cshtml"
Write(Html.SubmitButton("submit", "Save", new { @class = "bcms-btn-small" }));

            
            #line default
            #line hidden
            
            #line 64 "..\..\Views\Registration\CreateFirstUser.cshtml"
                                                                           
}

            
            #line default
            #line hidden
WriteLiteral("\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\n    (function() {\n        document.getElementById(\'firstName\').focus();\n    })(" +
");    \n</script>");

        }
    }
}
#pragma warning restore 1591
