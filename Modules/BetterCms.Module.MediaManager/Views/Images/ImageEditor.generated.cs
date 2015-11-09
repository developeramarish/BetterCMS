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
    
    #line 8 "..\..\Views\Images\ImageEditor.cshtml"
    using BetterCms.Module.MediaManager.Content.Resources;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Views\Images\ImageEditor.cshtml"
    using BetterCms.Module.MediaManager.Controllers;
    
    #line default
    #line hidden
    
    #line 1 "..\..\Views\Images\ImageEditor.cshtml"
    using BetterCms.Module.MediaManager.Models;
    
    #line default
    #line hidden
    
    #line 10 "..\..\Views\Images\ImageEditor.cshtml"
    using BetterCms.Module.MediaManager.ViewModels.Images;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Views\Images\ImageEditor.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Images\ImageEditor.cshtml"
    using BetterCms.Module.Root.Mvc.Extensions;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Views\Images\ImageEditor.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Images\ImageEditor.cshtml"
    using BetterCms.Module.Root.ViewModels.Category;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Images\ImageEditor.cshtml"
    using BetterCms.Module.Root.ViewModels.Tags;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Images\ImageEditor.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Images/ImageEditor.cshtml")]
    public partial class _Views_Images_ImageEditor_cshtml : System.Web.Mvc.WebViewPage<ImageViewModel>
    {
        public _Views_Images_ImageEditor_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 13 "..\..\Views\Images\ImageEditor.cshtml"
  
    var tagsTemplateViewModel = new TagsTemplateViewModel
    {
        TooltipDescription = MediaGlobalization.FileEditor_Dialog_AddTags_Tooltip_Description
    };

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 19 "..\..\Views\Images\ImageEditor.cshtml"
  
    var categoriesTemplateViewModel = new CategoryTemplateViewModel
    {
        TooltipDescription = MediaGlobalization.FileEditor_Dialog_Category_Tooltip_Description
    };

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"bcms-modal-frame-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 27 "..\..\Views\Images\ImageEditor.cshtml"
Write(Html.MessagesBox());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-window-options\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-file-manager-inner bcms-clearfix\"");

WriteLiteral(">\r\n");

            
            #line 31 "..\..\Views\Images\ImageEditor.cshtml"
            
            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\Images\ImageEditor.cshtml"
             using (Html.BeginForm<ImagesController>(f => f.ImageEditor((ImageViewModel)null), FormMethod.Post, new { @class = "bcms-ajax-form", @enctype = "multipart/form-data" }))
            {
                
            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\Images\ImageEditor.cshtml"
           Write(Html.HiddenFor(model => model.Id));

            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\Images\ImageEditor.cshtml"
                                                  
                
            
            #line default
            #line hidden
            
            #line 34 "..\..\Views\Images\ImageEditor.cshtml"
           Write(Html.HiddenFor(model => model.Version, new { @id = "image-version-field" }));

            
            #line default
            #line hidden
            
            #line 34 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                            
                
            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\Images\ImageEditor.cshtml"
           Write(Html.HiddenFor(model => model.CropCoordX1, new { @data_bind = "value: Math.floor(imageEditorViewModel.cropCoordX1())" }));

            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                                                         
                
            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\Images\ImageEditor.cshtml"
           Write(Html.HiddenFor(model => model.CropCoordX2, new { @data_bind = "value: Math.floor(imageEditorViewModel.cropCoordX2())" }));

            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                                                         
                
            
            #line default
            #line hidden
            
            #line 37 "..\..\Views\Images\ImageEditor.cshtml"
           Write(Html.HiddenFor(model => model.CropCoordY1, new { @data_bind = "value: Math.floor(imageEditorViewModel.cropCoordY1())" }));

            
            #line default
            #line hidden
            
            #line 37 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                                                         
                
            
            #line default
            #line hidden
            
            #line 38 "..\..\Views\Images\ImageEditor.cshtml"
           Write(Html.HiddenFor(model => model.CropCoordY2, new { @data_bind = "value: Math.floor(imageEditorViewModel.cropCoordY2())" }));

            
            #line default
            #line hidden
            
            #line 38 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                                                         
                
            
            #line default
            #line hidden
            
            #line 39 "..\..\Views\Images\ImageEditor.cshtml"
           Write(Html.HiddenFor(model => model.ShouldOverride, new { @id = "image-override-field" }));

            
            #line default
            #line hidden
            
            #line 39 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                    


            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 42 "..\..\Views\Images\ImageEditor.cshtml"
               Write(Html.Tooltip(MediaGlobalization.ImageEditor_Dialog_CropImage_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 44 "..\..\Views\Images\ImageEditor.cshtml"
                   Write(MediaGlobalization.ImageEditor_Dialog_CropImage_Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <a");

WriteLiteral(" class=\"bcms-icn-delete-link\"");

WriteLiteral(" data-bind=\"visible: imageEditorViewModel.hasCrop(), click: imageEditorViewModel." +
"removeCrop\"");

WriteLiteral(">Remove crop</a>\r\n                        <div");

WriteLiteral(" class=\"bcms-crop-checkbox\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" data-bind=\"checked: imageEditorViewModel.fit\"");

WriteLiteral(" />\r\n                            <div");

WriteLiteral(" class=\"bcms-edit-label\"");

WriteLiteral(" data-bind=\"click: imageEditorViewModel.changeFit\"");

WriteLiteral(">");

            
            #line 48 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                      Write(MediaGlobalization.ImageEditor_Dialog_FitImage_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        </div>\r\n                    </div>\r\n             " +
"   </div>\r\n");

            
            #line 52 "..\..\Views\Images\ImageEditor.cshtml"


            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"bcms-croped-block\"");

WriteLiteral(">\r\n                    <img");

WriteLiteral(" src=\"\"");

WriteLiteral(" data-bind=\"style: { width: imageEditorViewModel.calculatedWidth() + \'px\', height" +
": imageEditorViewModel.calculatedHeight() + \'px\' }\"");

WriteLiteral(" />\r\n                </div>\r\n");

            
            #line 56 "..\..\Views\Images\ImageEditor.cshtml"


            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"bcms-edit-file-info\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-file-info-text\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 59 "..\..\Views\Images\ImageEditor.cshtml"
                                                    Write(MediaGlobalization.ImageEditor_Dialog_PublicUrl);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div");

WriteLiteral(" class=\"bcms-edit-file-info\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" class=\"bcms-field-text bcms-editor-selectable-field-box\"");

WriteLiteral(" type=\"text\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3519), Tuple.Create("\"", 3537)
            
            #line 61 "..\..\Views\Images\ImageEditor.cshtml"
                               , Tuple.Create(Tuple.Create("", 3527), Tuple.Create<System.Object, System.Int32>(Model.Url
            
            #line default
            #line hidden
, 3527), false)
);

WriteLiteral(" readonly=\"readonly\"");

WriteLiteral(" />\r\n                        </div>\r\n                    </div>\r\n                " +
"    <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 65 "..\..\Views\Images\ImageEditor.cshtml"
                   Write(Html.Tooltip(MediaGlobalization.ImageEditor_Dialog_Caption_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 66 "..\..\Views\Images\ImageEditor.cshtml"
                                                    Write(MediaGlobalization.ImageEditor_Dialog_Caption);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 68 "..\..\Views\Images\ImageEditor.cshtml"
                       Write(Html.TextBoxFor(f => f.Caption, new { @class = "bcms-field-text", @id = "Caption", data_bind = "event: {change: onValueChange}" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 69 "..\..\Views\Images\ImageEditor.cshtml"
                       Write(Html.BcmsValidationMessageFor(f => f.Caption));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                   " +
" <div");

WriteLiteral(" class=\"bcms-file-info-text\"");

WriteLiteral(" data-bind=\"with: titleEditorViewModel\"");

WriteLiteral(" id=\"bcms-image-title-editor-box\"");

WriteLiteral(">\r\n                        <b>");

            
            #line 73 "..\..\Views\Images\ImageEditor.cshtml"
                      Write(MediaGlobalization.ImageEditor_Dialog_ImageName_Title);

            
            #line default
            #line hidden
WriteLiteral(":</b><div");

WriteLiteral(" class=\"bcms-editing-text\"");

WriteLiteral(" data-bind=\"text: oldTitle()\"");

WriteLiteral("></div>\r\n                        <a");

WriteLiteral(" class=\"bcms-file-link\"");

WriteLiteral(" data-bind=\"click: open, visible: !isOpened()\"");

WriteLiteral(">");

            
            #line 74 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                           Write(RootGlobalization.Button_Edit);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                        <div");

WriteLiteral(" class=\"bcms-file-edit\"");

WriteLiteral(" data-bind=\"style: { \'display\': isOpened() ? \'block\' : \'none\' }\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 76 "..\..\Views\Images\ImageEditor.cshtml"
                                                        Write(MediaGlobalization.ImageEditor_Dialog_ImageTitle_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                            <div");

WriteLiteral(" class=\"bcms-custom-input-box\"");

WriteLiteral(" style=\"width: 255px;\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 78 "..\..\Views\Images\ImageEditor.cshtml"
                           Write(Html.TextBoxFor(f => f.Title, new
                       {
                           @class = "bcms-field-text",
                           @id = "bcms-image-title-editor",
                           @data_bind = "value: title, valueUpdate: 'afterkeydown', enterPress: save, escPress: close, event: {change: $parent.onValueChange}"
                       }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                ");

            
            #line 84 "..\..\Views\Images\ImageEditor.cshtml"
                           Write(Html.BcmsValidationMessageFor(f => f.Title));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                            <div");

WriteLiteral(" class=\"bcms-btn-small\"");

WriteLiteral(" data-bind=\"click: save\"");

WriteLiteral(">");

            
            #line 86 "..\..\Views\Images\ImageEditor.cshtml"
                                                                           Write(RootGlobalization.Button_Ok);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                            <div");

WriteLiteral(" class=\"bcms-btn-links-small\"");

WriteLiteral(" data-bind=\"click: close\"");

WriteLiteral(">");

            
            #line 87 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                  Write(RootGlobalization.Button_Cancel);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        </div>\r\n                    </div>\r\n             " +
"       <div");

WriteLiteral(" class=\"bcms-file-info-text\"");

WriteLiteral(">\r\n                        <b>");

            
            #line 91 "..\..\Views\Images\ImageEditor.cshtml"
                      Write(MediaGlobalization.ImageEditor_Dialog_FileSize);

            
            #line default
            #line hidden
WriteLiteral(":</b>\r\n                        <div");

WriteLiteral(" class=\"bcms-editing-text\"");

WriteLiteral(" id=\"image-file-size\"");

WriteLiteral(">");

            
            #line 92 "..\..\Views\Images\ImageEditor.cshtml"
                                                                       Write(Model.FileSize);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"bcms-file-info-text\"");

WriteLiteral(">\r\n                        <b>");

            
            #line 95 "..\..\Views\Images\ImageEditor.cshtml"
                      Write(MediaGlobalization.ImageEditor_Dialog_CroppedDimensions);

            
            #line default
            #line hidden
WriteLiteral(":</b>\r\n                        <div");

WriteLiteral(" class=\"bcms-editing-text\"");

WriteLiteral(" id=\"image-file-size\"");

WriteLiteral(" data-bind=\"text: imageEditorViewModel.croppedWidthAndHeight()\"");

WriteLiteral(">");

            
            #line 96 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                                                      Write(Model.CroppedWidth);

            
            #line default
            #line hidden
WriteLiteral(" x ");

            
            #line 96 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                                                                            Write(Model.CroppedHeight);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"bcms-file-info-text\"");

WriteLiteral(" data-bind=\"with: imageEditorViewModel\"");

WriteLiteral(" id=\"bcms-image-dimensions-editor-box\"");

WriteLiteral(">\r\n                        <b>");

            
            #line 99 "..\..\Views\Images\ImageEditor.cshtml"
                      Write(MediaGlobalization.ImageEditor_Dialog_Dimensions);

            
            #line default
            #line hidden
WriteLiteral(":</b>\r\n                        <div");

WriteLiteral(" class=\"bcms-editing-text\"");

WriteLiteral(" data-bind=\"text: widthAndHeight()\"");

WriteLiteral(">");

            
            #line 100 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                     Write(Model.ImageWidth);

            
            #line default
            #line hidden
WriteLiteral(" x ");

            
            #line 100 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                         Write(Model.ImageHeight);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <a");

WriteLiteral(" class=\"bcms-file-link\"");

WriteLiteral(" data-bind=\"click: open, visible: !isOpened()\"");

WriteLiteral(">");

            
            #line 101 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                           Write(RootGlobalization.Button_Edit);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                        <div");

WriteLiteral(" class=\"bcms-file-edit\"");

WriteLiteral(" data-bind=\"style: { \'display\': isOpened() ? \'block\' : \'none\' }\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 104 "..\..\Views\Images\ImageEditor.cshtml"
                           Write(MediaGlobalization.ImageEditor_Dialog_ChangeSize_Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                            <span>");

            
            #line 106 "..\..\Views\Images\ImageEditor.cshtml"
                             Write(MediaGlobalization.ImageEditor_Dialog_ChangeSize_Width);

            
            #line default
            #line hidden
WriteLiteral(":</span>\r\n                            <div");

WriteLiteral(" class=\"bcms-custom-input-box\"");

WriteLiteral(" style=\"width: 75px;\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 108 "..\..\Views\Images\ImageEditor.cshtml"
                           Write(Html.TextBoxFor(f => f.ImageWidth, new
                            {
                                @class = "bcms-field-text",
                                @id = "image-width",
                                @data_bind = "value: width, valueUpdate: 'afterkeydown', enterPress: save, escPress: close, event: { change: changeHeight }"
                            }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                ");

            
            #line 114 "..\..\Views\Images\ImageEditor.cshtml"
                           Write(Html.BcmsValidationMessageFor(f => f.ImageWidth));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                            <span>");

            
            #line 116 "..\..\Views\Images\ImageEditor.cshtml"
                             Write(MediaGlobalization.ImageEditor_Dialog_ChangeSize_Height);

            
            #line default
            #line hidden
WriteLiteral(":</span>\r\n                            <div");

WriteLiteral(" class=\"bcms-custom-input-box\"");

WriteLiteral(" style=\"width: 75px;\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 118 "..\..\Views\Images\ImageEditor.cshtml"
                           Write(Html.TextBoxFor(f => f.ImageHeight, new
                            {
                                @class = "bcms-field-text",
                                @id = "image-height",
                                @data_bind = "value: height, valueUpdate: 'afterkeydown', enterPress: save, escPress: close, event: { change: changeWidth }"
                            }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                ");

            
            #line 124 "..\..\Views\Images\ImageEditor.cshtml"
                           Write(Html.BcmsValidationMessageFor(f => f.ImageHeight));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                            <div");

WriteLiteral(" class=\"bcms-btn-small\"");

WriteLiteral(" data-bind=\"click: save\"");

WriteLiteral(">");

            
            #line 126 "..\..\Views\Images\ImageEditor.cshtml"
                                                                           Write(RootGlobalization.Button_Ok);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                            <div");

WriteLiteral(" class=\"bcms-btn-links-small\"");

WriteLiteral(" data-bind=\"click: close\"");

WriteLiteral(">");

            
            #line 127 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                  Write(RootGlobalization.Button_Cancel);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                            <a");

WriteLiteral(" data-bind=\"click: restoreOriginalSize\"");

WriteLiteral(">");

            
            #line 128 "..\..\Views\Images\ImageEditor.cshtml"
                                                                 Write(MediaGlobalization.ImageEditor_Dialog_RestoreOriginalSize_Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                        </div>\r\n                    </div>\r\n               " +
" </div>\r\n");

            
            #line 132 "..\..\Views\Images\ImageEditor.cshtml"


            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"bcms-file-alignment\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 134 "..\..\Views\Images\ImageEditor.cshtml"
                                                Write(MediaGlobalization.ImageEditor_Dialog_AligmentTitle);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-alignment-controls\"");

WriteLiteral(">\r\n                        <div");

WriteAttribute("class", Tuple.Create(" class=\"", 9397), Tuple.Create("\"", 9494)
, Tuple.Create(Tuple.Create("", 9405), Tuple.Create("bcms-align-center", 9405), true)
            
            #line 136 "..\..\Views\Images\ImageEditor.cshtml"
, Tuple.Create(Tuple.Create("", 9422), Tuple.Create<System.Object, System.Int32>(Model.ImageAlign == MediaImageAlign.Center ? "-active" : string.Empty
            
            #line default
            #line hidden
, 9422), false)
);

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" name=\"ImageAlign\"");

WriteAttribute("value", Tuple.Create(" value=\"", 9563), Tuple.Create("\"", 9601)
            
            #line 137 "..\..\Views\Images\ImageEditor.cshtml"
, Tuple.Create(Tuple.Create("", 9571), Tuple.Create<System.Object, System.Int32>((int)MediaImageAlign.Center
            
            #line default
            #line hidden
, 9571), false)
);

WriteLiteral(" ");

            
            #line 137 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                     Write(Model.ImageAlign == MediaImageAlign.Center ? "checked" : string.Empty);

            
            #line default
            #line hidden
WriteLiteral(" data-bind=\"checked: imageAlign\" />\r\n                        </div>\r\n            " +
"            <div");

WriteAttribute("class", Tuple.Create(" class=\"", 9772), Tuple.Create("\"", 9865)
, Tuple.Create(Tuple.Create("", 9780), Tuple.Create("bcms-align-left", 9780), true)
            
            #line 139 "..\..\Views\Images\ImageEditor.cshtml"
, Tuple.Create(Tuple.Create("", 9795), Tuple.Create<System.Object, System.Int32>(Model.ImageAlign == MediaImageAlign.Left ? "-active" : string.Empty
            
            #line default
            #line hidden
, 9795), false)
);

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" name=\"ImageAlign\"");

WriteAttribute("value", Tuple.Create(" value=\"", 9934), Tuple.Create("\"", 9970)
            
            #line 140 "..\..\Views\Images\ImageEditor.cshtml"
, Tuple.Create(Tuple.Create("", 9942), Tuple.Create<System.Object, System.Int32>((int)MediaImageAlign.Left
            
            #line default
            #line hidden
, 9942), false)
);

WriteLiteral(" ");

            
            #line 140 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                   Write(Model.ImageAlign == MediaImageAlign.Left ? "checked" : string.Empty);

            
            #line default
            #line hidden
WriteLiteral(" data-bind=\"checked: imageAlign\" />\r\n                        </div>\r\n            " +
"            <div");

WriteAttribute("class", Tuple.Create(" class=\"", 10139), Tuple.Create("\"", 10234)
, Tuple.Create(Tuple.Create("", 10147), Tuple.Create("bcms-align-right", 10147), true)
            
            #line 142 "..\..\Views\Images\ImageEditor.cshtml"
, Tuple.Create(Tuple.Create("", 10163), Tuple.Create<System.Object, System.Int32>(Model.ImageAlign == MediaImageAlign.Right ? "-active" : string.Empty
            
            #line default
            #line hidden
, 10163), false)
);

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" name=\"ImageAlign\"");

WriteAttribute("value", Tuple.Create(" value=\"", 10303), Tuple.Create("\"", 10340)
            
            #line 143 "..\..\Views\Images\ImageEditor.cshtml"
, Tuple.Create(Tuple.Create("", 10311), Tuple.Create<System.Object, System.Int32>((int)MediaImageAlign.Right
            
            #line default
            #line hidden
, 10311), false)
);

WriteLiteral(" ");

            
            #line 143 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                    Write(Model.ImageAlign == MediaImageAlign.Right ? "checked" : string.Empty);

            
            #line default
            #line hidden
WriteLiteral(" data-bind=\"checked: imageAlign\" />\r\n                        </div>\r\n            " +
"        </div>\r\n                    <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 147 "..\..\Views\Images\ImageEditor.cshtml"
                   Write(Html.Tooltip(MediaGlobalization.ImageEditor_Dialog_Description_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 148 "..\..\Views\Images\ImageEditor.cshtml"
                                                    Write(MediaGlobalization.ImageEditor_Dialog_Description);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div");

WriteLiteral(" class=\"bcms-textarea-box\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 150 "..\..\Views\Images\ImageEditor.cshtml"
                       Write(Html.TextAreaFor(f => f.Description, new { @class = "bcms-field-textarea", @id = "Description", @style = "width: 380px;", data_bind = "event: {change: onValueChange}" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 151 "..\..\Views\Images\ImageEditor.cshtml"
                       Write(Html.BcmsValidationMessageFor(f => f.Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </d" +
"iv>\r\n");

            
            #line 155 "..\..\Views\Images\ImageEditor.cshtml"


            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"bcms-categories-box-holder\"");

WriteLiteral(" data-bind=\"with: categories\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 157 "..\..\Views\Images\ImageEditor.cshtml"
               Write(Html.Partial("~/Areas/bcms-root/Views/Category/CategoriesTemplate.cshtml", categoriesTemplateViewModel));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n");

            
            #line 159 "..\..\Views\Images\ImageEditor.cshtml"


            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"bcms-media-tags-box-holder bcms-clearfix\"");

WriteLiteral(" data-bind=\"with: tags\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 161 "..\..\Views\Images\ImageEditor.cshtml"
               Write(Html.Partial("~/Areas/bcms-root/Views/Tags/TagsTemplate.cshtml", tagsTemplateViewModel));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n");

            
            #line 163 "..\..\Views\Images\ImageEditor.cshtml"


            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"bcms-media-reupload\"");

WriteLiteral(" data-bind=\"click: reupload\"");

WriteLiteral(">");

            
            #line 164 "..\..\Views\Images\ImageEditor.cshtml"
                                                                        Write(MediaGlobalization.ImageEditor_Dialog_Reupload_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 165 "..\..\Views\Images\ImageEditor.cshtml"

                
            
            #line default
            #line hidden
            
            #line 166 "..\..\Views\Images\ImageEditor.cshtml"
           Write(Html.HiddenSubmit());

            
            #line default
            #line hidden
            
            #line 166 "..\..\Views\Images\ImageEditor.cshtml"
                                    
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
