#pragma checksum "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6486f5bb4218b9643a1a711d8789b897a406b497"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NewsDetails), @"mvc.1.0.view", @"/Views/Home/NewsDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6486f5bb4218b9643a1a711d8789b897a406b497", @"/Views/Home/NewsDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c714fee471500ac0555f931cba968b228d83c63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_NewsDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
  
    ViewData["Title"] = "GASTEC";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Page Title-->
<section class=""page-title"" style=""background-image:url('../../wwwroot/public/assets/softextwo/images/background/news.jpg');"">
    <div class=""auto-container"">

        <!-- <h1>أحدث الأخبار</h1>-->
    </div>
</section>

<!-- End Page Title-->
<!-- Page Info-->
<div class=""page-info"">
    <div class=""auto-container"">
        <div class=""inner-container clearfix"">
");
#nullable restore
#line 22 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
             if (Gastech_Vault.TranslationLanguageID == 0)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <ul class=\"bread-crumb pull-right\">\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 654, "\"", 689, 1);
#nullable restore
#line 26 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
WriteAttributeValue("", 661, Url.Action("Index", "Home"), 661, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">الرئيسية</a></li>\r\n                    <li>\r\n                        أخبار وفاعليات غازتك\r\n                    </li>\r\n                </ul>\r\n");
#nullable restore
#line 31 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <ul class=\"bread-crumb pull-left\">\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 958, "\"", 993, 1);
#nullable restore
#line 35 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
WriteAttributeValue("", 965, Url.Action("Index", "Home"), 965, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Home</a></li>\r\n                    <li>\r\n                        GASTEC Events and News\r\n                    </li>\r\n                </ul>\r\n");
#nullable restore
#line 40 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<!-- End Page Info-->\r\n<div class=\"sidebar-page-container\">\r\n    <div class=\"auto-container\">\r\n        <div class=\"row clearfix\">\r\n");
#nullable restore
#line 48 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
             if (Gastech_Vault.TranslationLanguageID == 0)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <!-- Slider Side-->
                <div class=""sidebar-side col-lg-3 col-md-4 col-sm-12 col-xs-12 pull-left"">
                    <aside class=""sidebar"">
                        <div id=""sideevents"">
                            <!-- Popular Posts -->
                            <div class=""sidebar-widget popular-posts"">
                                <div class=""sidebar-title""><h2>آخر الأخبار</h2></div>
");
#nullable restore
#line 58 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
                                 foreach (var topic in Model.NewsTopics.LstNews.Take(10))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <!--//Start backend to retrieve variables  -->
                                    <article class=""post"">
                                        <figure class=""post-thumb"">
                                            <a");
            BeginWriteAttribute("href", " href=\"", 2210, "\"", 2282, 1);
#nullable restore
#line 63 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
WriteAttributeValue("", 2217, Url.Action("NewsDetails", "Home", new { serial_ = topic.Serial}), 2217, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6486f5bb4218b9643a1a711d8789b897a406b4977917", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2344, "~/Images/MediaCenter_NewsSection/", 2344, 33, true);
#nullable restore
#line 64 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
AddHtmlAttributeValue("", 2377, topic.ImageGUID, 2377, 16, false);

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
            WriteLiteral("\r\n                                            </a>\r\n                                        </figure>\r\n                                        <div class=\"text\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2611, "\"", 2683, 1);
#nullable restore
#line 68 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
WriteAttributeValue("", 2618, Url.Action("NewsDetails", "Home", new { serial_ = topic.Serial}), 2618, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
#nullable restore
#line 69 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
                                           Write(topic.NewsTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </a>\r\n                                        </div>\r\n                                        <div class=\"post-info\">");
#nullable restore
#line 72 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
                                                          Write(topic.TopicDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    </article>\r\n");
#nullable restore
#line 74 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>
                    </aside>
                </div>
                <!--Content Side-->
                <div class=""content-side col-lg-9 col-md-8 col-sm-12 col-xs-12 pull-right"">
                    <div class=""services-single"" dir=""rtl"">
                        <div class=""inner-box"">
                            <div id=""events1"">
                                <div class=""blog-classic padding-right"" style=""padding-right:0;"">
                                    <!--Large Image Posts-->
                                    <div class=""large-image-posts"">

                                        <!--News Block Three-->
                                        <div class=""news-block-three"">
                                            <div class=""inner-box"">
                                                <div class=""image"">
");
#nullable restore
#line 92 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
                                                     foreach (var entity in Model.News_Details)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <a href=\"#\"");
            BeginWriteAttribute("alt", " alt=\"", 4177, "\"", 4244, 1);
#nullable restore
#line 94 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
WriteAttributeValue("", 4183, entity.LstImages.Select(x=>x.Image_AltText).FirstOrDefault(), 4183, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 4245, "\"", 4270, 1);
#nullable restore
#line 94 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
WriteAttributeValue("", 4253, entity.NewsTitle, 4253, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6486f5bb4218b9643a1a711d8789b897a406b49713310", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4344, "~/Images/News/", 4344, 14, true);
#nullable restore
#line 95 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
AddHtmlAttributeValue("", 4358, entity.LstImages.Select(x=>x.ImageGUID).FirstOrDefault(), 4358, 57, false);

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
            WriteLiteral("\r\n                                                        </a>\r\n");
#nullable restore
#line 97 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                </div>
                                                <div class=""lower-content"">
                                                    <div class=""lower-box"">
                                                        <p style=""color: #999"">
                                                            <i class=""fa fa-calendar""></i> 05/01/2021
                                                        </p>
                                                        <h3>
                                                            <a href=""#"">تقرير قناة Extra News عن المعرض الأول لتكنولوجيا تحويل وإحلال المركبات للعمل بالطاقة النظيفة</a>
                                                        </h3>
                                                        <p>
                                                            تقرير قناة Extra News عن المعرض الأول لتكنولوجيا تحويل وإحلال المركبات للعمل بالطاقة النظيفة<br> <a href=""https://www.youtube.com/watch?fbclid=IwAR0XzTY");
            WriteLiteral(@"IBVJisX94wOEJ1XybHbSx2jNS2bikPn6zWLTP8Ol6qGXopZ28f9E&amp;v=KqTsY92fECI&amp;feature=youtu.be"">
                                                                https://www.youtube.com/watch?fbclid=IwAR0XzTYIBVJisX94wOEJ1XybHbSx2jNS2bikPn6zWLTP8Ol6qGXopZ28f9E&amp;v=KqTsY92fECI&amp;feature=youtu.be
                                                            </a>
                                                        </p>
                                                        <a href=""https://www.gastec-egypt.com/public/allnews/32817"" class=""theme-btn read-more"" style=""float: left;direction: rtl;font-size: 18px;"">
                                                            عرض جميع الأخبار<span class=""icon flaticon-left-arrow"" style=""margin-right: 10px;font-size: 20px;vertical-align: sub;"">
                                                            </span>
                                                        </a>

                                                    </div>
                          ");
            WriteLiteral(@"                      </div>
                                            </div>
                                        </div>

                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
");
#nullable restore
#line 129 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <!-- Slider Side-->
                <div class=""sidebar-side col-lg-3 col-md-4 col-sm-12 col-xs-12 pull-right"">
                    <aside class=""sidebar"">
                        <div id=""sideevents"">
                            <!-- Popular Posts -->
                            <div class=""sidebar-widget popular-posts"">
                                <div class=""sidebar-title"">
                                    <h2>
                                        Latest News
                                    </h2>
                                </div>
");
#nullable restore
#line 143 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
                                 foreach (var topic in Model.NewsTopics.LstNews.Take(10))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <!--//Start backend to retrieve variables  -->
                                    <article class=""post"">
                                        <figure class=""post-thumb"">
                                            <a");
            BeginWriteAttribute("href", " href=\"", 7947, "\"", 8019, 1);
#nullable restore
#line 148 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
WriteAttributeValue("", 7954, Url.Action("NewsDetails", "Home", new { serial_ = topic.Serial}), 7954, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6486f5bb4218b9643a1a711d8789b897a406b49719560", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8081, "~/Images/MediaCenter_NewsSection/", 8081, 33, true);
#nullable restore
#line 149 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
AddHtmlAttributeValue("", 8114, topic.ImageGUID, 8114, 16, false);

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
            WriteLiteral("\r\n                                            </a>\r\n                                        </figure>\r\n                                        <div class=\"text\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 8348, "\"", 8420, 1);
#nullable restore
#line 153 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
WriteAttributeValue("", 8355, Url.Action("NewsDetails", "Home", new { serial_ = topic.Serial}), 8355, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
#nullable restore
#line 154 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
                                           Write(topic.NewsTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </a>\r\n                                        </div>\r\n                                        <div class=\"post-info\">");
#nullable restore
#line 157 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
                                                          Write(topic.TopicDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    </article>\r\n");
#nullable restore
#line 159 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>
                    </aside>
                </div>
                <!--Content Side-->
                <div class=""content-side col-lg-9 col-md-8 col-sm-12 col-xs-12 pull-left"">
                    <div class=""services-single"" dir=""ltr"">
                        <div class=""inner-box"">
                            <div id=""events1"">
                                <div class=""blog-classic padding-right"" style=""padding-right:0;"">
                                    <!--Large Image Posts-->
                                    <div class=""large-image-posts"">

                                        <!--News Block Three-->
                                        <div class=""news-block-three"">
                                            <div class=""inner-box"">
                                                <div class=""image"">
");
#nullable restore
#line 177 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
                                                     foreach (var entity in Model.News_Details)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <a href=\"#\"");
            BeginWriteAttribute("alt", " alt=\"", 9913, "\"", 9980, 1);
#nullable restore
#line 179 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
WriteAttributeValue("", 9919, entity.LstImages.Select(x=>x.Image_AltText).FirstOrDefault(), 9919, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 9981, "\"", 10006, 1);
#nullable restore
#line 179 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
WriteAttributeValue("", 9989, entity.NewsTitle, 9989, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6486f5bb4218b9643a1a711d8789b897a406b49724962", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 10080, "~/Images/News/", 10080, 14, true);
#nullable restore
#line 180 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
AddHtmlAttributeValue("", 10094, entity.LstImages.Select(x=>x.ImageGUID).FirstOrDefault(), 10094, 57, false);

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
            WriteLiteral("\r\n                                                        </a>\r\n");
#nullable restore
#line 182 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                </div>
                                                <div class=""lower-content"">
                                                    <div class=""lower-box"">
                                                        <p style=""color: #999"">
                                                            <i class=""fa fa-calendar""></i> 05/01/2021
                                                        </p>
                                                        <h3>
                                                            <a href=""#"">تقرير قناة Extra News عن المعرض الأول لتكنولوجيا تحويل وإحلال المركبات للعمل بالطاقة النظيفة</a>
                                                        </h3>
                                                        <p>
                                                            تقرير قناة Extra News عن المعرض الأول لتكنولوجيا تحويل وإحلال المركبات للعمل بالطاقة النظيفة<br> <a href=""#"">
                                         ");
            WriteLiteral(@"                   </a>
                                                        </p>
                                                        <a href=""https://www.gastec-egypt.com/public/allnews/32817"" class=""theme-btn read-more"" style=""float: right;direction: ltr;font-size: 18px;"">
                                                            عرض جميع الأخبار<span class=""icon flaticon-right-arrow-1"" style=""margin-right: 10px;font-size: 20px;vertical-align: sub;"">
                                                            </span>
                                                        </a>

                                                    </div>
                                                </div>
                                            </div>
                                        </div>

                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                </div");
            WriteLiteral(">\r\n");
#nullable restore
#line 213 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Home\NewsDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
