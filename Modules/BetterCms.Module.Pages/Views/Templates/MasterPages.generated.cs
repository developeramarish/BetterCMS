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
    
    #line 1 "..\..\Views\Templates\MasterPages.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Templates\MasterPages.cshtml"
    using BetterCms.Module.Pages.Controllers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Templates\MasterPages.cshtml"
    using BetterCms.Module.Pages.ViewModels.SiteSettings;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Templates\MasterPages.cshtml"
    using BetterCms.Module.Root;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Templates\MasterPages.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Views\Templates\MasterPages.cshtml"
    using BetterCms.Module.Root.Mvc;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Views\Templates\MasterPages.cshtml"
    using BetterCms.Module.Root.Mvc.Grids.Extensions;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Views\Templates\MasterPages.cshtml"
    using BetterCms.Module.Root.Mvc.Grids.TableRenderers;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Views\Templates\MasterPages.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 10 "..\..\Views\Templates\MasterPages.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 11 "..\..\Views\Templates\MasterPages.cshtml"
    using MvcContrib.UI.Grid;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Templates/MasterPages.cshtml")]
    public partial class _Views_Templates_MasterPages_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Pages.ViewModels.Filter.PagesGridViewModel<SiteSettingPageViewModel>>
    {
        public _Views_Templates_MasterPages_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 14 "..\..\Views\Templates\MasterPages.cshtml"
  
    var controller = (CmsControllerBase)ViewContext.Controller;
    var roles = string.Format("{0},{1},{2}",
        RootModuleConstants.UserRoles.PublishContent,
        RootModuleConstants.UserRoles.EditContent,
        RootModuleConstants.UserRoles.DeleteContent);
    var canViewPages = controller.SecurityService.IsAuthorized(roles);
    
    Action<ColumnBuilder<SiteSettingPageViewModel>> columns = column =>
    {
        column.EditButtonColumn();
        column.For(m => string.Format("<a class=\"bcms-tables-link bcms-page-title\" data-id=\"{0}\" data-url=\"{2}\">{1}</a>", m.Id, System.Web.Security.AntiXss.AntiXssEncoder.HtmlEncode(m.Title ?? "", true), m.Url))
            .Named(PagesGlobalization.SiteSettings_Pages_TitleColumn)
            .SortColumnName("Title")
            .Attributes()
            .Encode(false);

        if (canViewPages) {
            column.For(f => string.Format("<a class=\"bcms-template-usage\" data-id=\"{0}\">{1}</a>", f.Id, PagesGlobalization.SiteSettings_MasterPages_Usage))
               .Named("")
               .HeaderAttributes(@style => "width: 100px;")
               .Sortable(false)
               .Encode(false);
        }
        
        if ((ViewContext.Controller as CmsControllerBase).SecurityService.IsAuthorized(RootModuleConstants.UserRoles.DeleteContent))
        {
            column.DeleteButtonColumn();
        }
        else
        {
            column.EmptyColumn();
        }
    };

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 50 "..\..\Views\Templates\MasterPages.cshtml"
 using (Html.BeginForm<TemplatesController>(f => f.MasterPages(null), FormMethod.Post, new { @id = "bcms-master-pages-form", @class = "bcms-ajax-form" }))
{
    
            
            #line default
            #line hidden
            
            #line 52 "..\..\Views\Templates\MasterPages.cshtml"
Write(Html.MessagesBox());

            
            #line default
            #line hidden
            
            #line 52 "..\..\Views\Templates\MasterPages.cshtml"
                       

        
            
            #line default
            #line hidden
            
            #line 54 "..\..\Views\Templates\MasterPages.cshtml"
   Write(Html.HiddenGridOptions(Model.GridOptions));

            
            #line default
            #line hidden
            
            #line 54 "..\..\Views\Templates\MasterPages.cshtml"
                                                  

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"bcms-top-block-holder\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-btn-main\"");

WriteLiteral(" id=\"bcms-create-page-button\"");

WriteLiteral(">");

            
            #line 56 "..\..\Views\Templates\MasterPages.cshtml"
                                                               Write(PagesGlobalization.SiteSettings_Pages_AddNew);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-top-block-inner\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-btn-search\"");

WriteLiteral(" id=\"bcms-pages-search-btn\"");

WriteLiteral(">");

            
            #line 59 "..\..\Views\Templates\MasterPages.cshtml"
                                                                       Write(PagesGlobalization.SiteSettings_Pages_Search);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-search-block\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 61 "..\..\Views\Templates\MasterPages.cshtml"
                   Write(Html.TextBoxFor(m => m.SearchQuery, new { @class = "bcms-field-text bcms-search-query", @placeholder = RootGlobalization.WaterMark_Search }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n            <div");

WriteLiteral(" class=\"bcms-top-block-pager\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 66 "..\..\Views\Templates\MasterPages.cshtml"
           Write(Html.RenderPaging(Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n");

            
            #line 69 "..\..\Views\Templates\MasterPages.cshtml"


            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"bcms-window-settings\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 71 "..\..\Views\Templates\MasterPages.cshtml"
   Write(Html.Grid(Model.Items).Sort(Model.GridOptions).Columns(columns).Attributes(@class => "bcms-tables").RenderUsing(new EditableHtmlTableGridRenderer<SiteSettingPageViewModel>()));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");

            
            #line 73 "..\..\Views\Templates\MasterPages.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"bcms-pages-list-row-template\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 76 "..\..\Views\Templates\MasterPages.cshtml"
Write(Html.Grid(new List<SiteSettingPageViewModel> { new SiteSettingPageViewModel() }).Columns(columns).Attributes(@class => "bcms-tables").RenderUsing(new HtmlTableGridSingleRowRenderer<SiteSettingPageViewModel>()));

            
            #line default
            #line hidden
WriteLiteral("\r\n</script>\r\n");

        }
    }
}
#pragma warning restore 1591
