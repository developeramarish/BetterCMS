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
    
    #line 1 "..\..\Views\User\EditUser.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\User\EditUser.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\User\EditUser.cshtml"
    using BetterCms.Module.Users.Content.Resources;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\User\EditUser.cshtml"
    using BetterCms.Module.Users.Controllers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\User\EditUser.cshtml"
    using BetterCms.Module.Users.ViewModels.User;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Views\User\EditUser.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/User/EditUser.cshtml")]
    public partial class _Views_User_EditUser_cshtml : System.Web.Mvc.WebViewPage<EditUserViewModel>
    {
        public _Views_User_EditUser_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"bcms-modal-frame-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 11 "..\..\Views\User\EditUser.cshtml"
Write(Html.MessagesBox());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-window-options\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-new-blog-content\"");

WriteLiteral(">\r\n");

            
            #line 15 "..\..\Views\User\EditUser.cshtml"
            
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\User\EditUser.cshtml"
             using (Html.BeginForm<UserController>(c => c.SaveUser(null), FormMethod.Post, new { @class = "bcms-ajax-form" }))
            {
                
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\User\EditUser.cshtml"
           Write(Html.HiddenFor(m => m.Id));

            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\User\EditUser.cshtml"
                                          
                
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\User\EditUser.cshtml"
           Write(Html.HiddenFor(m => m.Version));

            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\User\EditUser.cshtml"
                                               
                
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\User\EditUser.cshtml"
           Write(Html.HiddenFor(model => model.Image.ImageId, new { data_bind = "value: image().id()" }));

            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\User\EditUser.cshtml"
                                                                                                        


            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"bcms-blog-left\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-tooltip-mark\"");

WriteLiteral(" data-message=\"");

            
            #line 23 "..\..\Views\User\EditUser.cshtml"
                                                                Write(UsersGlobalization.EditUser_FirstName_Tooltip_Description);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("></div>\r\n                        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 24 "..\..\Views\User\EditUser.cshtml"
                                                    Write(UsersGlobalization.EditUser_FirstName_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 26 "..\..\Views\User\EditUser.cshtml"
                       Write(Html.TextBoxFor(m => m.FirstName, new { @class = "bcms-field-text", data_bind = "value: firstName, valueUpdate: 'afterkeydown'" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 27 "..\..\Views\User\EditUser.cshtml"
                       Write(Html.BcmsValidationMessageFor(m => m.FirstName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                   " +
" <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-tooltip-mark\"");

WriteLiteral(" data-message=\"");

            
            #line 31 "..\..\Views\User\EditUser.cshtml"
                                                                Write(UsersGlobalization.EditUser_LastName_Tooltip_Description);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("></div>\r\n                        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 32 "..\..\Views\User\EditUser.cshtml"
                                                    Write(UsersGlobalization.EditUser_LastName);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 34 "..\..\Views\User\EditUser.cshtml"
                       Write(Html.TextBoxFor(m => m.LastName, new { @class = "bcms-field-text", data_bind = "value: lastName, valueUpdate: 'afterkeydown'" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 35 "..\..\Views\User\EditUser.cshtml"
                       Write(Html.BcmsValidationMessageFor(m => m.LastName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                   " +
" <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-tooltip-mark\"");

WriteLiteral(" data-message=\"");

            
            #line 39 "..\..\Views\User\EditUser.cshtml"
                                                                Write(UsersGlobalization.EditUser_UserName_Tooltip_Description);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("></div>\r\n                        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 40 "..\..\Views\User\EditUser.cshtml"
                                                    Write(UsersGlobalization.EditUser_UserName_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 42 "..\..\Views\User\EditUser.cshtml"
                       Write(Html.TextBoxFor(m => m.UserName, new { @class = "bcms-field-text", data_bind = "value: userName, valueUpdate: 'afterkeydown', event: {keyup: userNameOnKeyUp}" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 43 "..\..\Views\User\EditUser.cshtml"
                       Write(Html.BcmsValidationMessageFor(m => m.UserName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                   " +
" <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-tooltip-mark\"");

WriteLiteral(" data-message=\"");

            
            #line 47 "..\..\Views\User\EditUser.cshtml"
                                                                Write(UsersGlobalization.EditUser_Email_Tooltip_Description);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("></div>\r\n                        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 48 "..\..\Views\User\EditUser.cshtml"
                                                    Write(UsersGlobalization.EditUser_Email_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 50 "..\..\Views\User\EditUser.cshtml"
                       Write(Html.TextBoxFor(m => m.Email, new { @class = "bcms-field-text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 51 "..\..\Views\User\EditUser.cshtml"
                       Write(Html.BcmsValidationMessageFor(m => m.Email));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                   " +
" <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-tooltip-mark\"");

WriteLiteral(" data-message=\"");

            
            #line 55 "..\..\Views\User\EditUser.cshtml"
                                                                Write(UsersGlobalization.EditUser_Password_Tooltip_Description);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("></div>\r\n                        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 56 "..\..\Views\User\EditUser.cshtml"
                                                    Write(UsersGlobalization.EditUser_Password_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 58 "..\..\Views\User\EditUser.cshtml"
                       Write(Html.TextBoxFor(m => m.Password, new { @class = "bcms-field-text", @type = "password" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 59 "..\..\Views\User\EditUser.cshtml"
                       Write(Html.BcmsValidationMessageFor(m => m.Password));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                   " +
" <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-tooltip-mark\"");

WriteLiteral(" data-message=\"");

            
            #line 63 "..\..\Views\User\EditUser.cshtml"
                                                                Write(UsersGlobalization.EditUser_RetypePassword_Tooltip_Description);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("></div>\r\n                        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 64 "..\..\Views\User\EditUser.cshtml"
                                                    Write(UsersGlobalization.EditUser_RetypePassword_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 66 "..\..\Views\User\EditUser.cshtml"
                       Write(Html.TextBoxFor(m => m.RetypedPassword, new { @class = "bcms-field-text", @type = "password" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 67 "..\..\Views\User\EditUser.cshtml"
                       Write(Html.BcmsValidationMessageFor(m => m.RetypedPassword));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </d" +
"iv>\r\n");

            
            #line 71 "..\..\Views\User\EditUser.cshtml"


            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"bcms-blog-right\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-create-author-holder\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-tooltip-mark\"");

WriteLiteral(" data-message=\"");

            
            #line 74 "..\..\Views\User\EditUser.cshtml"
                                                                Write(UsersGlobalization.EditUser_UserImage_Tooltip_Description);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("></div>\r\n                        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 75 "..\..\Views\User\EditUser.cshtml"
                                                    Write(UsersGlobalization.EditUser_Image_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div");

WriteLiteral(" class=\"bcms-uploaded-image\"");

WriteLiteral(">\r\n                            <!-- ko if: image().url() -->\r\n                   " +
"         <a");

WriteLiteral(" class=\"bcms-remove-image\"");

WriteLiteral(" data-bind=\"click: image().remove.bind(image())\"");

WriteLiteral(">");

            
            #line 78 "..\..\Views\User\EditUser.cshtml"
                                                                                                    Write(RootGlobalization.Button_Remove);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                            <a");

WriteLiteral(" data-bind=\"click: image().preview.bind(image())\"");

WriteLiteral(">\r\n                                <img");

WriteLiteral(" data-bind=\"attr: { src: image().thumbnailUrl(), alt: image().tooltip() }\"");

WriteLiteral(" />\r\n                            </a>\r\n                            <!-- /ko -->\r\n" +
"                        </div>\r\n                        <div");

WriteLiteral(" class=\"bcms-upload-info\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"bcms-upload-info-text\"");

WriteLiteral(">");

            
            #line 85 "..\..\Views\User\EditUser.cshtml"
                                                          Write(UsersGlobalization.EditUser_UploadImage_Info);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                            <div");

WriteLiteral(" class=\"bcms-btn-small\"");

WriteLiteral(" data-bind=\"click: image().select.bind(image())\"");

WriteLiteral(">");

            
            #line 86 "..\..\Views\User\EditUser.cshtml"
                                                                                                   Write(UsersGlobalization.EditUser_UploadImage_Button_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        </div>\r\n                    </div>\r\n             " +
"       <div");

WriteLiteral(" class=\"bcms-blog-tags-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 90 "..\..\Views\User\EditUser.cshtml"
                   Write(Html.Partial("Partial/EditUserRoles"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");

            
            #line 93 "..\..\Views\User\EditUser.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
