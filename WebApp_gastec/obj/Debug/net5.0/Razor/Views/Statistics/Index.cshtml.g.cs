#pragma checksum "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f08693807562d1d88e0fa71a7bd39263ec806214"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Statistics_Index), @"mvc.1.0.view", @"/Views/Statistics/Index.cshtml")]
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
#line 1 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\_ViewImports.cshtml"
using WebApp_gastec;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\_ViewImports.cshtml"
using WebApp_gastec.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f08693807562d1d88e0fa71a7bd39263ec806214", @"/Views/Statistics/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c714fee471500ac0555f931cba968b228d83c63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Statistics_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: max-content;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
  
    ViewData["Title"] = "GASTEC";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Page Title-->\r\n<section class=\"page-title\" style=\"background-image:url(\'../../wwwroot/public/assets/softextwo/images/background/Stat.jpg\');\">\r\n    <div class=\"auto-container\">\r\n");
#nullable restore
#line 11 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
         foreach (var entity in Model.Sub_Section)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- <h1>");
#nullable restore
#line 13 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h1>-->\r\n");
#nullable restore
#line 14 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n<!-- End Page Title-->\r\n<!-- Page Info-->\r\n<div class=\"page-info\">\r\n    <div class=\"auto-container\">\r\n        <div class=\"inner-container clearfix\">\r\n");
#nullable restore
#line 22 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
             if (Gastech_Vault.TranslationLanguageID == 0)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <ul class=\"bread-crumb pull-right\">\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 742, "\"", 776, 1);
#nullable restore
#line 26 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
WriteAttributeValue("", 749, Url.Action("Index","Home"), 749, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">????????????????</a></li>\r\n");
#nullable restore
#line 27 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                     foreach (var entity in Model.Sub_Section)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>");
#nullable restore
#line 29 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                       Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 30 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n");
#nullable restore
#line 32 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <ul class=\"bread-crumb pull-left\">\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1117, "\"", 1151, 1);
#nullable restore
#line 36 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
WriteAttributeValue("", 1124, Url.Action("Index","Home"), 1124, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Home</a></li>\r\n");
#nullable restore
#line 37 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                     foreach (var entity in Model.Sub_Section)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>");
#nullable restore
#line 39 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                       Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 40 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n");
#nullable restore
#line 42 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<!-- End Page Info-->\r\n<div class=\"sidebar-page-container\">\r\n    <div class=\"auto-container\">\r\n        <div class=\"row clearfix\">\r\n");
#nullable restore
#line 50 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
             if (Gastech_Vault.TranslationLanguageID == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <!--Sidebar Side-->
                <div class=""sidebar-side col-lg-3 col-md-4 col-sm-12 col-xs-12 pull-right"">
                    <aside class=""sidebar"">
                        <!--Blog Category Widget-->
                        <div id=""sidenavelist"">
                            <div class=""sidebar-widget sidebar-blog-category"">
                                <ul class=""blog-cat"">
");
#nullable restore
#line 59 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                     foreach (var mainSection in Model.Main_Section)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                         foreach (var entity in mainSection.LstChildClassification)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                             if (entity.IsActive == true)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li class=\"active\">\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 2545, "\"", 2634, 1);
#nullable restore
#line 66 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
WriteAttributeValue("", 2552, Url.Action("Index", "Statistics",new { ID_ = entity.ClassificationID.ToString()}), 2552, 82, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 66 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                                                                                                                            Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                </li>\r\n");
#nullable restore
#line 68 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li>\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 2975, "\"", 3064, 1);
#nullable restore
#line 72 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
WriteAttributeValue("", 2982, Url.Action("Index", "Statistics",new { ID_ = entity.ClassificationID.ToString()}), 2982, 82, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 72 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                                                                                                                            Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                </li>\r\n");
#nullable restore
#line 74 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                             

                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </ul>
                            </div>
                        </div>
                    </aside>
                </div>
                <!--Content Side-->
                <div class=""content-side pull-left col-lg-9 col-md-8 col-sm-12 col-xs-12"">
                    <div class=""services-single"" dir=""rtl"">
                        <div class=""inner-box"">
                            <div id=""cmspage1"">
");
#nullable restore
#line 88 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                 foreach (var entity in Model.Sub_Section)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h2>");
#nullable restore
#line 90 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                   Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                    <div style=\"font-size:14px; position:relative\">\r\n");
#nullable restore
#line 92 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                         foreach (var webSection in entity.LstWebSections)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <h3 style=\"text-align: justify;\">\r\n                                                <span style=\"color:#263a69;\">\r\n                                                    ");
#nullable restore
#line 96 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                               Write(Html.Raw(webSection.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </span>\r\n                                            </h3>\r\n");
#nullable restore
#line 99 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                             foreach (var image in webSection.LstImages)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f08693807562d1d88e0fa71a7bd39263ec80621415255", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4678, "~/Images/Statistics/", 4678, 20, true);
#nullable restore
#line 101 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
AddHtmlAttributeValue("", 4698, image.ImageGUID, 4698, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 102 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <hr />\r\n");
#nullable restore
#line 104 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n");
#nullable restore
#line 106 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>
                    </div>
                    <div class=""team-column col-md-12 col-sm-12 col-xs-12"" style=""margin-top: 30px"">
                        <div class=""inner-column"">
                            <div class=""row clearfix"">
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 117 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <!--Sidebar Side-->
                <div class=""sidebar-side col-lg-3 col-md-4 col-sm-12 col-xs-12 pull-left"">
                    <aside class=""sidebar"">
                        <!--Blog Category Widget-->
                        <div id=""sidenavelist"">
                            <div class=""sidebar-widget sidebar-blog-category"">
                                <ul class=""blog-cat"">
");
#nullable restore
#line 127 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                     foreach (var mainSection in Model.Main_Section)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                         foreach (var entity in mainSection.LstChildClassification)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                             if (entity.IsActive == true)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li class=\"active\">\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 6368, "\"", 6457, 1);
#nullable restore
#line 134 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
WriteAttributeValue("", 6375, Url.Action("Index", "Statistics",new { ID_ = entity.ClassificationID.ToString()}), 6375, 82, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 134 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                                                                                                                            Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                </li>\r\n");
#nullable restore
#line 136 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li>\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 6798, "\"", 6887, 1);
#nullable restore
#line 140 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
WriteAttributeValue("", 6805, Url.Action("Index", "Statistics",new { ID_ = entity.ClassificationID.ToString()}), 6805, 82, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 140 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                                                                                                                            Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                </li>\r\n");
#nullable restore
#line 142 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 142 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                             

                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 144 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </ul>
                            </div>
                        </div>
                    </aside>
                </div>
                <!--Content Side-->
                <div class=""content-side pull-right col-lg-9 col-md-8 col-sm-12 col-xs-12"">
                    <div class=""services-single"" dir=""ltr"">
                        <div class=""inner-box"">
                            <div id=""cmspage1"">
");
#nullable restore
#line 156 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                 foreach (var entity in Model.Sub_Section)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h2>");
#nullable restore
#line 158 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                   Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                    <div style=\"font-size:14px; position:relative\">\r\n");
#nullable restore
#line 160 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                         foreach (var webSection in entity.LstWebSections)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 162 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                       Write(Html.Raw(webSection.Body));

#line default
#line hidden
#nullable disable
#nullable restore
#line 164 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                             foreach (var image in webSection.LstImages)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f08693807562d1d88e0fa71a7bd39263ec80621424737", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8230, "~/Images/Statistics/", 8230, 20, true);
#nullable restore
#line 166 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
AddHtmlAttributeValue("", 8250, image.ImageGUID, 8250, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 167 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <hr />\r\n");
#nullable restore
#line 169 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n");
#nullable restore
#line 171 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>
                    </div>
                    <div class=""team-column col-md-12 col-sm-12 col-xs-12"" style=""margin-top: 30px"">
                        <div class=""inner-column"">
                            <div class=""row clearfix"">
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 182 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Statistics\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomePageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
