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
    
    #line 1 "..\..\Views\History\ServerWidgetPropertiesHistory.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/History/ServerWidgetPropertiesHistory.cshtml")]
    public partial class _Views_History_ServerWidgetPropertiesHistory_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Pages.ViewModels.History.ServerWidgetHistoryViewModel>
    {
        public _Views_History_ServerWidgetPropertiesHistory_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"bcms-padded-content\"");

WriteLiteral(">\n    <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\n        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 6 "..\..\Views\History\ServerWidgetPropertiesHistory.cshtml"
                                    Write(PagesGlobalization.Widget_Title_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\n        <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\n");

WriteLiteral("            ");

            
            #line 8 "..\..\Views\History\ServerWidgetPropertiesHistory.cshtml"
       Write(Html.TextBoxFor(model => model.Name, new { @readonly = "readonly", @class = "bcms-field-text" }));

            
            #line default
            #line hidden
WriteLiteral("\n        </div>\n    </div>\n    <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\n        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 12 "..\..\Views\History\ServerWidgetPropertiesHistory.cshtml"
                                    Write(PagesGlobalization.Widget_Url_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\n        <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\n");

WriteLiteral("            ");

            
            #line 14 "..\..\Views\History\ServerWidgetPropertiesHistory.cshtml"
       Write(Html.TextBoxFor(model => model.Url, new { @readonly = "readonly", @class = "bcms-field-text" }));

            
            #line default
            #line hidden
WriteLiteral("\n        </div>\n    </div>\n");

WriteLiteral("\n");

WriteLiteral("\n");

WriteLiteral("\n    <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\n        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 21 "..\..\Views\History\ServerWidgetPropertiesHistory.cshtml"
                                    Write(PagesGlobalization.WidgetPreviewImageUrl_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\n        <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\n");

WriteLiteral("            ");

            
            #line 23 "..\..\Views\History\ServerWidgetPropertiesHistory.cshtml"
       Write(Html.TextBoxFor(model => model.PreviewUrl, new { @readonly = "readonly", @class = "bcms-field-text" }));

            
            #line default
            #line hidden
WriteLiteral("\n        </div>\n    </div>\n    <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\n        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 27 "..\..\Views\History\ServerWidgetPropertiesHistory.cshtml"
                                    Write(PagesGlobalization.WidgetPreviewImage_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\n        <div");

WriteLiteral(" class=\"bcms-preview-module-image\"");

WriteLiteral(">\n");

            
            #line 29 "..\..\Views\History\ServerWidgetPropertiesHistory.cshtml"
            
            
            #line default
            #line hidden
            
            #line 29 "..\..\Views\History\ServerWidgetPropertiesHistory.cshtml"
             if (!string.IsNullOrWhiteSpace(Model.PreviewUrl))
            {

            
            #line default
            #line hidden
WriteLiteral("                <div>\n                    <img");

WriteLiteral(" id=\"bcms-widget-preview-image\"");

WriteAttribute("src", Tuple.Create(" src=\"", 1624), Tuple.Create("\"", 1647)
            
            #line 32 "..\..\Views\History\ServerWidgetPropertiesHistory.cshtml"
, Tuple.Create(Tuple.Create("", 1630), Tuple.Create<System.Object, System.Int32>(Model.PreviewUrl
            
            #line default
            #line hidden
, 1630), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral("/>\n                </div>\n");

            
            #line 34 "..\..\Views\History\ServerWidgetPropertiesHistory.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\n    </div>\n</div>");

        }
    }
}
#pragma warning restore 1591
