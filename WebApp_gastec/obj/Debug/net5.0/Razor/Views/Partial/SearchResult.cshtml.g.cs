#pragma checksum "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21af635484c2e81c8eb36646639431e26b65f0d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partial_SearchResult), @"mvc.1.0.view", @"/Views/Partial/SearchResult.cshtml")]
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
#nullable restore
#line 2 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
using WebApp_gastec.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21af635484c2e81c8eb36646639431e26b65f0d5", @"/Views/Partial/SearchResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c714fee471500ac0555f931cba968b228d83c63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Partial_SearchResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SearchModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
  
    ViewData["Title"] = "GASTEC";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--Page Title-->
<section class=""page-title"" style=""background-image:url(../../wwwroot/public/assets/softextwo/images/background/4.jpg);"">
    <div class=""auto-container"">
        <!--<h1>عن غازتك</h1>-->
    </div>
</section>
<!--End Page Title-->
<!--Page Info-->
<div class=""page-info"">
    <div class=""auto-container"">
        <div class=""inner-container clearfix"">
            <ul class=""bread-crumb pull-right"">
                <li><a");
            BeginWriteAttribute("href", " href=\"", 573, "\"", 608, 1);
#nullable restore
#line 21 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
WriteAttributeValue("", 580, Url.Action("Index", "Home"), 580, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">الرئيسية</a></li>
            </ul>
        </div>
    </div>
</div>
<!--End Page Info-->
<!--Sidebar Page Container-->
<div class=""sidebar-page-container"">
    <div class=""auto-container"">
        <div class=""row clearfix"">
            <!--Sidebar Side-->
            <!--Content Side-->
            <div class=""content-side col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                <div class=""auto-container text-right"">

                    <h2>نتائج البحث</h2>
                    <hr>
                    <div id=""searchblocks""></div>

");
#nullable restore
#line 40 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
                     if (Model.ListClassFicationTree != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""row clearfix"">
                            <div class=""page-info"">
                                <div class=""auto-container"">
                                    <div class=""inner-container clearfix text-right"">
                                        <h4>صفحات</h4>
                                    </div>
                                </div>
                            </div>
                            <div class=""team-column col-md-12 col-sm-12 col-xs-12"" style=""margin-top: 30px"">
                                <div class=""inner-column"">
                                    <div class=""row clearfix"">
");
#nullable restore
#line 53 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
                                         foreach (var classification in Model.ListClassFicationTree)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
                                             if (classification.ParentID == 56 || classification.ParentID == 57 || classification.ParentID == 58)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div style=\"margin-bottom: 10px\" class=\"text-right\">\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 2416, "\"", 2611, 1);
#nullable restore
#line 58 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
WriteAttributeValue("", 2423, Url.Action(GetActionName.GetActionNameForSearch(@classification.ParentID.ToString()),GetControllerName.GetControllerNameByParentID(@classification.ParentID.ToString()) , new {ID_ = "48"}), 2423, 188, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" data-caption=\"");
#nullable restore
#line 58 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
                                                                                                                                                                                                                                                                                    Write(classification.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                                        ");
#nullable restore
#line 59 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
                                                   Write(classification.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </a>\r\n                                                </div>\r\n");
#nullable restore
#line 62 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div style=\"margin-bottom: 10px\" class=\"text-right\">\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 3159, "\"", 3383, 1);
#nullable restore
#line 66 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
WriteAttributeValue("", 3166, Url.Action(GetActionName.GetActionNameForSearch(@classification.ParentID.ToString()),GetControllerName.GetControllerNameByParentID(@classification.ParentID.ToString()) , new {ID_ = @classification.Serial.ToString()}), 3166, 217, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" data-caption=\"");
#nullable restore
#line 66 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
                                                                                                                                                                                                                                                                                                                 Write(classification.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                                        ");
#nullable restore
#line 67 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
                                                   Write(classification.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </a>\r\n                                                </div>\r\n");
#nullable restore
#line 70 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 76 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
                     if (Model.ListNews != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""row clearfix"">
                            <div class=""page-info"">
                                <div class=""auto-container"">
                                    <div class=""inner-container clearfix text-right"">
                                        <h4>أخبار</h4>
                                    </div>
                                </div>
                            </div>
                            <div class=""team-column col-md-12 col-sm-12 col-xs-12"" style=""margin-top: 30px"">
                                <div class=""inner-column"">
                                    <div class=""row clearfix"">
");
#nullable restore
#line 90 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
                                         foreach (var classification in Model.ListNews)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div style=\"margin-bottom: 10px\" class=\"text-right\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 4913, "\"", 4994, 1);
#nullable restore
#line 93 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
WriteAttributeValue("", 4920, Url.Action("NewsDetails", "Home", new { serial_ = classification.Serial}), 4920, 74, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" data-caption=\"");
#nullable restore
#line 93 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
                                                                                                                                                              Write(classification.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                                    ");
#nullable restore
#line 94 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
                                               Write(classification.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </a>\r\n                                            </div>\r\n");
#nullable restore
#line 97 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 102 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
                     if (Model.ListVideos != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""row clearfix"">
                            <div class=""page-info"">
                                <div class=""auto-container"">
                                    <div class=""inner-container clearfix text-right"">
                                        <h4>فيديوهات</h4>
                                    </div>
                                </div>
                            </div>
                            <div class=""team-column col-md-12 col-sm-12 col-xs-12"" style=""margin-top: 30px"">
                                <div class=""inner-column"">
                                    <div class=""row clearfix"">
");
#nullable restore
#line 116 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
                                         foreach (var classification in Model.ListVideos)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div style=\"margin-bottom: 10px\" class=\"text-right\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 6472, "\"", 6498, 1);
#nullable restore
#line 119 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
WriteAttributeValue("", 6479, classification.URL, 6479, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"lightbox-image overlay-box\" data-caption=\"");
#nullable restore
#line 119 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
                                                                                                                          Write(classification.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                                    ");
#nullable restore
#line 120 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
                                               Write(classification.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </a>\r\n                                            </div>\r\n");
#nullable restore
#line 123 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 128 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Partial\SearchResult.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>
<script>
    //LightBox / Fancybox
    if ($('.lightbox-image').length) {
        $('.lightbox-image').fancybox({
            openEffect: 'fade',
            closeEffect: 'fade',
            helpers: {
                media: {}
            }
        });
    }
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SearchModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
