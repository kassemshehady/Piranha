﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Piranha.Areas.Manager.Views.Template
{
    using System;
    using System.Collections.Generic;
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
    using Piranha.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/Template/PageEdit.cshtml")]
    public partial class PageEdit : System.Web.Mvc.WebViewPage<Piranha.Models.Manager.TemplateModels.PageEditModel>
    {
        public PageEdit()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
  
    ViewBag.Selected = "Settings" ;
    ViewBag.SelectedTab = "PageType" ;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("Head", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\"", 195), Tuple.Create("\"", 255)
, Tuple.Create(Tuple.Create("", 201), Tuple.Create<System.Object, System.Int32>(Href("~/res.ashx/areas/manager/content/js/jquery.template.js")
, 201), false)
);

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\"", 302), Tuple.Create("\"", 368)
, Tuple.Create(Tuple.Create("", 308), Tuple.Create<System.Object, System.Int32>(Href("~/res.ashx/areas/manager/content/js/jquery.regiontemplate.js")
, 308), false)
);

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\"", 415), Tuple.Create("\"", 469)
, Tuple.Create(Tuple.Create("", 421), Tuple.Create<System.Object, System.Int32>(Href("~/res.ashx/areas/manager/content/js/ext/json2.js")
, 421), false)
);

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        /**\r\n         * This var is needed by the regiontemplate script.\r\n    " +
"     */\r\n        var templateid = \'");

            
            #line 14 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                     Write(Model.Template.Id);

            
            #line default
            #line hidden
WriteLiteral("\';\r\n\r\n        $(document).ready(function () {\r\n            $(\'#Template_Name\').fo" +
"cus();\r\n        });\r\n    </script>\r\n");

            
            #line 20 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
    
            
            #line default
            #line hidden
            
            #line 20 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
     if (Model.Template.IsLocked) {

            
            #line default
            #line hidden
WriteLiteral("    <style");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(">\r\n        .region-editor .icon {\r\n            display: none;\r\n        }\r\n       " +
" .region-editor tr.dark {\r\n            display: none;\r\n        }\r\n    </style>\r\n" +
"");

            
            #line 29 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
    }

            
            #line default
            #line hidden
});

DefineSection("Toolbar", () => {

WriteLiteral("\r\n");

            
            #line 32 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
Write(Html.Partial("Partial/Tabs"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"toolbar\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n        <ul>\r\n");

            
            #line 36 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
            
            
            #line default
            #line hidden
            
            #line 36 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
             if (!Model.Template.IsLocked) {

            
            #line default
            #line hidden
WriteLiteral("            <li><a");

WriteLiteral(" class=\"save submit\"");

WriteLiteral(">");

            
            #line 37 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                  Write(Piranha.Resources.Global.ToolbarSave);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

WriteLiteral("            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1265), Tuple.Create("\"", 1329)
            
            #line 38 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
, Tuple.Create(Tuple.Create("", 1272), Tuple.Create<System.Object, System.Int32>(Url.Action("deletepage", new { id = Model.Template.Id })
            
            #line default
            #line hidden
, 1272), false)
);

WriteLiteral(" class=\"delete\"");

WriteLiteral(" title=\"\"");

WriteLiteral(">");

            
            #line 38 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                                                                                       Write(Piranha.Resources.Global.ToolbarDelete);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 39 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1438), Tuple.Create("\"", 1468)
            
            #line 40 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
, Tuple.Create(Tuple.Create("", 1445), Tuple.Create<System.Object, System.Int32>(Url.Action("pagelist")
            
            #line default
            #line hidden
, 1445), false)
);

WriteLiteral(" class=\"back\"");

WriteLiteral(">");

            
            #line 40 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                                          Write(Piranha.Resources.Global.ToolbarBack);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1549), Tuple.Create("\"", 1607)
            
            #line 41 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
, Tuple.Create(Tuple.Create("", 1556), Tuple.Create<System.Object, System.Int32>(Url.Action("page", new { id = Model.Template.Id })
            
            #line default
            #line hidden
, 1556), false)
);

WriteLiteral(" class=\"refresh\"");

WriteLiteral(">");

            
            #line 41 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                                                                         Write(Piranha.Resources.Global.ToolbarReload);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n        </ul>\r\n        <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n    </div>\r\n</div>\r\n");

});

WriteLiteral("\r\n");

            
            #line 48 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
   Html.BeginForm("page", "template") ; 
            
            #line default
            #line hidden
WriteLiteral("\r\n<div>\r\n");

WriteLiteral("    ");

            
            #line 50 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.Id));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 51 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.IsNew));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 52 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.IsSiteTemplate));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 53 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.Type));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 54 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.Created));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 55 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.Updated));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 56 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.CreatedBy));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 57 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.UpdatedBy));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 58 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
    
            
            #line default
            #line hidden
            
            #line 58 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
     if (!Piranha.Application.Current.IsMvc) {
    
            
            #line default
            #line hidden
            
            #line 59 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.View));

            
            #line default
            #line hidden
            
            #line 59 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                         
    
            
            #line default
            #line hidden
            
            #line 60 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.ShowView));

            
            #line default
            #line hidden
            
            #line 60 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                             
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n<div");

WriteLiteral(" class=\"grid_9\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"box expandable\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 65 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                          Write(Piranha.Resources.Global.Information);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                <li>");

            
            #line 68 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
               Write(Html.LabelFor(m => m.Template.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 70 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                   Write(Html.TextBoxFor(m => m.Template.Name));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                    ");

            
            #line 71 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
               Write(Html.ValidationMessageFor(m => m.Template.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n                <li>");

            
            #line 73 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
               Write(Html.LabelFor(m => m.Template.Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 75 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                   Write(Html.TextAreaFor(m => m.Template.Description, 
                            new { @placeholder = Piranha.Resources.Global.Optional }));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </li>\r\n            </ul>\r\n            <ul");

WriteLiteral(" class=\"form optional\"");

WriteLiteral(">               \r\n                <li>");

            
            #line 80 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
               Write(Html.LabelFor(m => m.Template.Preview));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 82 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                   Write(Html.TextAreaFor(m => m.Template.Preview, new { @rows = 8} ));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </li>                \r\n            </ul>\r\n        </div>\r" +
"\n    </div>\r\n    <div");

WriteLiteral(" class=\"box content-editor\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 88 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                          Write(Piranha.Resources.Global.Regions);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n            <table");

WriteLiteral(" class=\"list region-editor\"");

WriteLiteral(">\r\n                <tbody>\r\n                    <tr>\r\n                        <th" +
">");

            
            #line 93 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                       Write(Piranha.Resources.Global.Name);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                        <th>");

            
            #line 94 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                       Write(Piranha.Resources.Global.InternalId);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                        <th>");

            
            #line 95 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                       Write(Piranha.Resources.Global.Type);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                        <th></th>\r\n                    </tr>\r\n");

WriteLiteral("                    ");

            
            #line 98 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
               Write(Html.EditorFor(m => m.Regions));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <tr");

WriteLiteral(" class=\"dark\"");

WriteLiteral(">\r\n                        <td");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n                                <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"newregionName\"");

WriteLiteral(" /></div>\r\n                        </td>\r\n                        <td");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n                                <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"newregionInternalId\"");

WriteLiteral(" /></div>\r\n                        </td>\r\n                        <td");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 110 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                           Write(Html.DropDownList("newregionType",
                                    new SelectList(Model.RegionTypes, "Type", "Name")));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        </td>\r\n                        <td");

WriteLiteral(" class=\"buttons four\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" id=\"btnAddRegion\"");

WriteLiteral(" class=\"btn marg-big\"");

WriteLiteral(">");

            
            #line 114 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                                                      Write(Piranha.Resources.Global.Add);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                        </td>\r\n                    </tr>\r\n            " +
"    </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"box\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 122 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                          Write(Piranha.Resources.Global.Advanced);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                <li>");

            
            #line 125 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
               Write(Html.LabelFor(m => m.Template.Controller, 
                        Piranha.Application.Current.IsMvc ? Piranha.Resources.Page.Route : Piranha.Resources.Page.Template));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 128 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                   Write(Html.TextBoxFor(m => m.Template.Controller, 
                            new { @placeholder = "Page" }));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <label>&nbsp;</label>\r\n                    <p>");

            
            #line 131 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                  Write(Html.CheckBoxFor(m => m.Template.ShowController));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 132 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                    Write(Piranha.Application.Current.IsMvc ? Piranha.Resources.Template.PageRouteOverride : Piranha.Resources.Template.PageTemplateOverride);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                </li>\r\n");

            
            #line 134 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 134 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                 if (Piranha.Application.Current.IsMvc) {

            
            #line default
            #line hidden
WriteLiteral("                <li>");

            
            #line 135 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
               Write(Html.LabelFor(m => m.Template.View));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 137 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                   Write(Html.TextBoxFor(m => m.Template.View, new { @placeholder = "Index" }));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <label>&nbsp;</label>\r\n                    <p>");

            
            #line 139 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                  Write(Html.CheckBoxFor(m => m.Template.ShowView));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 139 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                                              Write(Piranha.Resources.Template.PageViewOverride);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                </li>\r\n");

            
            #line 141 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <li>");

            
            #line 142 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
               Write(Html.LabelFor(m => m.Template.Redirect));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 144 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                   Write(Html.TextBoxFor(m => m.Template.Redirect, 
                            new { @placeholder = Piranha.Resources.Global.Optional }));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <label>&nbsp;</label>\r\n                    <p>");

            
            #line 147 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                  Write(Html.CheckBoxFor(m => m.Template.ShowRedirect));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 147 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                                                  Write(Piranha.Resources.Template.PageRedirectOverride);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</div" +
">\r\n<div");

WriteLiteral(" class=\"grid_3\"");

WriteLiteral(">\r\n");

            
            #line 154 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
    
            
            #line default
            #line hidden
            
            #line 154 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
     if (!Model.Template.IsNew && !String.IsNullOrEmpty(Model.Template.Preview.ToHtmlString())) {

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"box pagetemplate\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 156 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                          Write(Piranha.Resources.Page.HtmlPreview);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"edit\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 159 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
           Write(Model.Template.Preview);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");

            
            #line 163 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"box\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 165 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                          Write(Piranha.Resources.Global.Properties);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" id=\"region_data\"");

WriteLiteral("></div>\r\n            <ul");

WriteLiteral(" id=\"properties\"");

WriteLiteral(" class=\"list buttons\"");

WriteLiteral(">\r\n");

            
            #line 169 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 169 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                 foreach (var property in Model.Template.Properties) {

            
            #line default
            #line hidden
WriteLiteral("                <li><span>");

            
            #line 170 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                     Write(property);

            
            #line default
            #line hidden
WriteLiteral("</span><button");

WriteLiteral(" class=\"btn delete right remove-region\"");

WriteLiteral("></button></li>\r\n");

            
            #line 171 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </ul>\r\n            <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" id=\"po_name\"");

WriteLiteral(" type=\"text\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 7749), Tuple.Create("\"", 7810)
            
            #line 174 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
, Tuple.Create(Tuple.Create("", 7763), Tuple.Create<System.Object, System.Int32>(Piranha.Resources.Template.PropertyPlaceholder
            
            #line default
            #line hidden
, 7763), false)
);

WriteLiteral(" /></div>\r\n            <button");

WriteLiteral(" id=\"po_add\"");

WriteLiteral(" class=\"btn right\"");

WriteLiteral(">");

            
            #line 175 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                             Write(Piranha.Resources.Global.Add);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n            <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n         </div>\r\n    </div>\r\n</div>\r\n");

            
            #line 180 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
   Html.EndForm() ; 
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
