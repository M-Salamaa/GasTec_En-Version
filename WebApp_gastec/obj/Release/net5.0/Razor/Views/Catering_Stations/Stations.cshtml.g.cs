#pragma checksum "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a50187e36b8e30f5abed3606ea5257e9d702a127"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catering_Stations_Stations), @"mvc.1.0.view", @"/Views/Catering_Stations/Stations.cshtml")]
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
#line 1 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\_ViewImports.cshtml"
using WebApp_gastec;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\_ViewImports.cshtml"
using WebApp_gastec.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
using WebApp_gastec.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a50187e36b8e30f5abed3606ea5257e9d702a127", @"/Views/Catering_Stations/Stations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c714fee471500ac0555f931cba968b228d83c63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Catering_Stations_Stations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding:10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 200px; width: 300px; padding: 10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
  
    ViewData["Title"] = "GASTEC";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- Page Title-->\r\n<section class=\"page-title\" style=\"background-image:url(\'../../wwwroot/public/assets/softextwo/images/background/Stations.jpg\');\">\r\n    <div class=\"auto-container\">\r\n");
#nullable restore
#line 13 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
         foreach (var entity in Model.Sub_Section)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- <h1>");
#nullable restore
#line 15 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
                Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h1>-->\r\n");
#nullable restore
#line 16 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n<!-- End Page Title-->\r\n<!-- Page Info-->\r\n<div class=\"page-info\">\r\n    <div class=\"auto-container\">\r\n        <div class=\"inner-container clearfix\">\r\n            <ul class=\"bread-crumb pull-right\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 692, "\"", 726, 1);
#nullable restore
#line 25 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
WriteAttributeValue("", 699, Url.Action("Index","Home"), 699, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">الرئيسية</a></li>\r\n");
#nullable restore
#line 26 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
                 foreach (var entity in Model.Sub_Section)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 28 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
                   Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 29 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </ul>
        </div>
    </div>
</div>
<!-- End Page Info-->
<div class=""sidebar-page-container"">
    <div class=""auto-container"">
        <div class=""row clearfix"">
            <!--Sidebar Side-->
            <div class=""sidebar-side col-lg-3 col-md-4 col-sm-12 col-xs-12 pull-right"">
                <aside class=""sidebar"">
                    <!--Blog Category Widget-->
                    <div id=""sidenavelist"">
                        <div class=""sidebar-widget sidebar-blog-category"">
                            <ul class=""blog-cat"">
");
#nullable restore
#line 45 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
                                 foreach (var mainSection in Model.Main_Section)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
                                     foreach (var entity in mainSection.LstChildClassification)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
                                         if (entity.IsActive == true)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"active\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 1954, "\"", 2051, 1);
#nullable restore
#line 52 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
WriteAttributeValue("", 1961, Url.Action("Index", "Catering_Stations", new { ID_ = entity.ClassificationID.ToString()}), 1961, 90, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 52 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
                                                                                                                                                Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 54 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2368, "\"", 2465, 1);
#nullable restore
#line 58 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
WriteAttributeValue("", 2375, Url.Action("Index", "Catering_Stations", new { ID_ = entity.ClassificationID.ToString()}), 2375, 90, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 58 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
                                                                                                                                                Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 60 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </ul>
                        </div>
                    </div>
                </aside>
            </div>
            <!--Content Side-->
            <div class=""content-side pull-left col-lg-9 col-md-8 col-sm-12 col-xs-12"">
                <div class=""services-single"" dir=""rtl"">
                    <div class=""inner-box"">
                        <div id=""cmspage1"">
                            <!--//end backend to retrieve variables  -->
                            <!--//Start backend to retrieve variables  -->
");
#nullable restore
#line 75 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
                             foreach (var station in Model.Sub_Section)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h2>\r\n                                    ");
#nullable restore
#line 78 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
                               Write(station.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </h2>\r\n                                <link");
            BeginWriteAttribute("href", " href=\"", 3509, "\"", 3516, 0);
            EndWriteAttribute();
            WriteLiteral(" rel=\"stylesheet\" type=\"text/css\">\r\n                                <div style=\"font-size:14px; position:relative\">\r\n");
#nullable restore
#line 82 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
                                     foreach (var webSection in station.LstWebSections)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
                                   Write(Html.Raw(webSection.Body));

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
                                         foreach (var image in webSection.LstImages)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
                                             if (webSection.WebSectionID == 231 || webSection.WebSectionID == 233 || webSection.WebSectionID == 127 || webSection.WebSectionID == 130 || webSection.WebSectionID == 136 || webSection.WebSectionID == 142 || webSection.WebSectionID == 148)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a50187e36b8e30f5abed3606ea5257e9d702a12714612", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4350, "~/Images/Integrated_Stations/", 4350, 29, true);
#nullable restore
#line 89 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
AddHtmlAttributeValue("", 4379, image.ImageGUID, 4379, 16, false);

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
#line 90 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
                                            }
                                            else if (webSection.WebSectionID == 232 || webSection.WebSectionID == 128 || webSection.WebSectionID == 129 || webSection.WebSectionID == 137)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a50187e36b8e30f5abed3606ea5257e9d702a12716748", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4760, "~/Images/Integrated_Stations/", 4760, 29, true);
#nullable restore
#line 93 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
AddHtmlAttributeValue("", 4789, image.ImageGUID, 4789, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 94 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
                                            }
                                            else if (webSection.WebSectionID == 149 || webSection.WebSectionID == 143)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a50187e36b8e30f5abed3606ea5257e9d702a12718816", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5132, "~/Images/Integrated_Stations/", 5132, 29, true);
#nullable restore
#line 97 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
AddHtmlAttributeValue("", 5161, image.ImageGUID, 5161, 16, false);

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
#line 98 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p> &nbsp; &nbsp; </p>\r\n");
#nullable restore
#line 101 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n");
#nullable restore
#line 103 "C:\Users\Softex\Desktop\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\Stations.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </div>
                <div class=""team-column col-md-12 col-sm-12 col-xs-12"" style=""margin-top: 30px"">
                    <div class=""inner-column"">
                        <div class=""row clearfix"">
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
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
