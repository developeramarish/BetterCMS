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
    
    #line 1 "..\..\Views\Option\Partial\OptionCell.cshtml"
    using BetterCms.Module.Root;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Option\Partial\OptionCell.cshtml"
    using BetterCms.Module.Root.Mvc.Grids;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Option/Partial/OptionCell.cshtml")]
    public partial class _Views_Option_Partial_OptionCell_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Pages.Mvc.EditableGrid.OptionValueEditableGridColumn>
    {
        public _Views_Option_Partial_OptionCell_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n<!-- ko if: !useDefaultValue() && type() != 5 && type() != 4 && type() != 21 &&" +
" type() != 99 -->\r\n");

WriteLiteral("    ");

            
            #line 8 "..\..\Views\Option\Partial\OptionCell.cshtml"
Write(Html.Partial(RootModuleConstants.EditableGridCellTemplate));

            
            #line default
            #line hidden
WriteLiteral("\r\n<!-- /ko -->\r\n\r\n");

WriteLiteral("\r\n<!-- ko if: !useDefaultValue() && type() == 21 -->\r\n");

WriteLiteral("    ");

            
            #line 13 "..\..\Views\Option\Partial\OptionCell.cshtml"
Write(Html.Partial(RootModuleConstants.EditableGridMultilineTextCellTemplate));

            
            #line default
            #line hidden
WriteLiteral("\r\n<!-- /ko -->\r\n\r\n");

WriteLiteral("\r\n<!-- ko if: !useDefaultValue() && type() == 5  -->\r\n");

WriteLiteral("    ");

            
            #line 18 "..\..\Views\Option\Partial\OptionCell.cshtml"
Write(Html.Partial(RootModuleConstants.EditableGridBooleanCellTemplate, new EditableGridBooleanColumn(Model.HeaderTitle, Model.SortColumn, Model.ValueBind)
                                                                           {
                                                                               HiddenFieldName = Model.HiddenFieldName,
                                                                               HeaderAttributes = Model.HeaderAttributes,
                                                                               AutoFocus = Model.AutoFocus,
                                                                               CanBeEdited = Model.CanBeEdited,
                                                                               ShowValueAsText = true
                                                                           }));

            
            #line default
            #line hidden
WriteLiteral("\r\n<!-- /ko -->\r\n\r\n");

WriteLiteral("\r\n<!-- ko if: !useDefaultValue() && type() == 4  -->\r\n<td ");

            
            #line 30 "..\..\Views\Option\Partial\OptionCell.cshtml"
Write(Html.Raw(Model.Attributes));

            
            #line default
            #line hidden
WriteLiteral(">\r\n");

            
            #line 31 "..\..\Views\Option\Partial\OptionCell.cshtml"
    
            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\Option\Partial\OptionCell.cshtml"
     if (Model.CanBeEdited)
    {

            
            #line default
            #line hidden
WriteLiteral("        <!-- ko if: isActive() -->\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"bcms-input-field-holder\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-date-input-box bcms-options-date\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" class=\"bcms-editor-field-box bcms-datepicker\"");

WriteLiteral(" data-bind=\"\r\n                    css: { \'bcms-input-validation-error\': !isNew() " +
"&& ");

            
            #line 37 "..\..\Views\Option\Partial\OptionCell.cshtml"
                                                                  Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(".hasError && ");

            
            #line 37 "..\..\Views\Option\Partial\OptionCell.cshtml"
                                                                                                 Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(".hasError() },\r\n                    value: ");

            
            #line 38 "..\..\Views\Option\Partial\OptionCell.cshtml"
                       Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(@",
                    valueUpdate: 'afterkeydown', 
                    click: onItemSelect,
                    event: {blur: onBlurField, focus: onItemSelect},
                    enterPress: onSave, 
                    escPress: onCancelEdit,
                    afterRender: initDatePickers()
");

WriteLiteral("                    ");

            
            #line 45 "..\..\Views\Option\Partial\OptionCell.cshtml"
                Write(Model.AutoFocus ? ", hasfocus: isActive() && hasFocus" : "");

            
            #line default
            #line hidden
WriteLiteral(" \"");

WriteLiteral(" />\r\n            \r\n                <!-- ko if: !isNew() &&  ");

            
            #line 47 "..\..\Views\Option\Partial\OptionCell.cshtml"
                                     Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(".hasError && ");

            
            #line 47 "..\..\Views\Option\Partial\OptionCell.cshtml"
                                                                    Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(".hasError() -->\r\n                <span");

WriteLiteral(" class=\"bcms-field-validation-error\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" data-bind=\"html: ");

            
            #line 49 "..\..\Views\Option\Partial\OptionCell.cshtml"
                                       Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(".validationMessage()\"");

WriteLiteral("></span>\r\n                </span>\r\n                <!-- /ko -->\r\n            </di" +
"v>\r\n        </div>\r\n");

WriteLiteral("        <!-- /ko -->\r\n");

WriteLiteral("        <!-- ko ifnot: isActive() -->\r\n");

            
            #line 56 "..\..\Views\Option\Partial\OptionCell.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteLiteral(" class=\"bcms-tables-link\"");

WriteLiteral(" data-bind=\"text: ");

            
            #line 57 "..\..\Views\Option\Partial\OptionCell.cshtml"
                                             Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral("()\"");

WriteLiteral("></a>    \r\n");

            
            #line 58 "..\..\Views\Option\Partial\OptionCell.cshtml"
    
            
            #line default
            #line hidden
            
            #line 58 "..\..\Views\Option\Partial\OptionCell.cshtml"
     if (Model.CanBeEdited)
    {

            
            #line default
            #line hidden
WriteLiteral("        <!-- /ko -->\r\n");

            
            #line 61 "..\..\Views\Option\Partial\OptionCell.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n<!-- /ko -->\r\n\r\n");

WriteLiteral("\r\n<!-- ko if: !useDefaultValue() && type() == 99  -->\r\n<td ");

            
            #line 67 "..\..\Views\Option\Partial\OptionCell.cshtml"
Write(Html.Raw(Model.Attributes));

            
            #line default
            #line hidden
WriteLiteral(">\r\n");

            
            #line 68 "..\..\Views\Option\Partial\OptionCell.cshtml"
    
            
            #line default
            #line hidden
            
            #line 68 "..\..\Views\Option\Partial\OptionCell.cshtml"
     if (Model.CanBeEdited)
    {

            
            #line default
            #line hidden
WriteLiteral("        <!-- ko if: isActive() -->\r\n");

WriteLiteral("        <input");

WriteLiteral(" style=\"width: 70%\"");

WriteLiteral(" class=\"bcms-editor-field-box\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" readonly=\"readonly\"");

WriteLiteral(" data-bind=\"value: ");

            
            #line 71 "..\..\Views\Option\Partial\OptionCell.cshtml"
                                                                                                              Write(Model.CustomValueBind);

            
            #line default
            #line hidden
WriteLiteral("() || ");

            
            #line 71 "..\..\Views\Option\Partial\OptionCell.cshtml"
                                                                                                                                            Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral("(), \r\n            click: onItemSelect,\r\n            event: {blur: onBlurFieldDela" +
"yed, focus: onItemSelect},\r\n            enterPress: onSave, \r\n            escPre" +
"ss: onCancelEdit\r\n");

WriteLiteral("            ");

            
            #line 76 "..\..\Views\Option\Partial\OptionCell.cshtml"
        Write(Model.AutoFocus ? ", hasfocus: isActive() && hasFocus" : "");

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" />\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"bcms-btn-small\"");

WriteLiteral(" data-bind=\"\r\n                    click: onCustomOptionExecute.bind($data, $data," +
" ");

            
            #line 78 "..\..\Views\Option\Partial\OptionCell.cshtml"
                                                                Write(Model.CustomValueBind);

            
            #line default
            #line hidden
WriteLiteral(", ");

            
            #line 78 "..\..\Views\Option\Partial\OptionCell.cshtml"
                                                                                          Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral("),\r\n                    event: {blur: onBlurField, focus: onItemSelect},\r\n       " +
"             enterPress: onSave, \r\n                    escPress: onCancelEdit\"");

WriteLiteral(">...</div>\r\n");

WriteLiteral("        <!-- /ko -->\r\n");

WriteLiteral("        <!-- ko ifnot: isActive() -->\r\n");

            
            #line 84 "..\..\Views\Option\Partial\OptionCell.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteLiteral(" class=\"bcms-tables-link\"");

WriteLiteral(" data-bind=\"text: ");

            
            #line 85 "..\..\Views\Option\Partial\OptionCell.cshtml"
                                             Write(Model.CustomValueBind);

            
            #line default
            #line hidden
WriteLiteral("() || ");

            
            #line 85 "..\..\Views\Option\Partial\OptionCell.cshtml"
                                                                           Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral("()\"");

WriteLiteral("></a>    \r\n");

            
            #line 86 "..\..\Views\Option\Partial\OptionCell.cshtml"
    
            
            #line default
            #line hidden
            
            #line 86 "..\..\Views\Option\Partial\OptionCell.cshtml"
     if (Model.CanBeEdited)
    {

            
            #line default
            #line hidden
WriteLiteral("        <!-- /ko -->\r\n");

            
            #line 89 "..\..\Views\Option\Partial\OptionCell.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n<!-- /ko -->\r\n\r\n");

WriteLiteral("\r\n<!-- ko if: useDefaultValue() && type() == 5  -->\r\n");

WriteLiteral("    ");

            
            #line 95 "..\..\Views\Option\Partial\OptionCell.cshtml"
Write(Html.Partial(RootModuleConstants.EditableGridBooleanCellTemplate, new EditableGridBooleanColumn(null, null, Model.ValueBind)
                                                                           {
                                                                               CanBeEdited = false,
                                                                               ShowValueAsText = true
                                                                           }));

            
            #line default
            #line hidden
WriteLiteral("\r\n<!-- /ko -->\r\n\r\n<!-- ko if: useDefaultValue() && type() != 5  -->\r\n<td ");

            
            #line 103 "..\..\Views\Option\Partial\OptionCell.cshtml"
Write(Html.Raw(Model.Attributes));

            
            #line default
            #line hidden
WriteLiteral(">\r\n    <a");

WriteLiteral(" class=\"bcms-tables-link\"");

WriteLiteral(" data-bind=\"text: ");

            
            #line 104 "..\..\Views\Option\Partial\OptionCell.cshtml"
                                             Write(Model.CustomValueBind);

            
            #line default
            #line hidden
WriteLiteral("() || ");

            
            #line 104 "..\..\Views\Option\Partial\OptionCell.cshtml"
                                                                           Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral("()\"");

WriteLiteral("></a>\r\n</td>\r\n<!-- /ko -->\r\n");

        }
    }
}
#pragma warning restore 1591
