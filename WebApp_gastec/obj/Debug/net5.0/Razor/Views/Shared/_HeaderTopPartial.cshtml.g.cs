#pragma checksum "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_HeaderTopPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "119f3a856fc54ddc486c1017ab7f5542956ef2d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__HeaderTopPartial), @"mvc.1.0.view", @"/Views/Shared/_HeaderTopPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"119f3a856fc54ddc486c1017ab7f5542956ef2d5", @"/Views/Shared/_HeaderTopPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c714fee471500ac0555f931cba968b228d83c63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__HeaderTopPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MainMenuModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/public/assets/softextwo/images/16528.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/public/assets/softextwo/images/complaint-portal.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"auto-container\">\r\n");
#nullable restore
#line 6 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_HeaderTopPartial.cshtml"
     if (Gastech_Vault.TranslationLanguageID == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""inner-container clearfix"">
            <!--Top left-->
            <div class=""top-left clearfix hidden-sm hidden-xs"">
                <!--social-icon-->
                <div class=""social-icon"">
                    <ul class=""clearfix"">
                        <li>
                            <a href=""https://www.shakwa.eg/GCP/Default.aspx"" target=""_blank"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "119f3a856fc54ddc486c1017ab7f5542956ef2d55262", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                        </li>
                        <li><a href=""https://www.facebook.com/gasteceg/"" target=""_blank""><span class=""fa fa-facebook""></span></a></li>
                        <li><a href=""https://www.youtube.com/channel/UCTLayD5SdoD3WCPk7T3jgcQ"" target=""_blank""><span class=""fa fa-youtube""></span></a></li>

                    </ul>
                </div>
                <ul class=""links clearfix"">
                    <li style=""padding-top: 8px"">|</li>
                    <li><a href=""mailto:gastec@gastec-egypt.com""><span class=""icon flaticon-note-1""></span></a></li>

                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1321, "\"", 1358, 1);
#nullable restore
#line 26 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_HeaderTopPartial.cshtml"
WriteAttributeValue("", 1328, Url.Action("Language","Home"), 1328, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><strong>English</strong><span class=""icon flaticon-chat""></span></a></li>
                </ul>
            </div>
            <!--Top Right-->
            <div class=""top-right clearfix hidden-sm"">
                <!--social-icon-->
                <div class=""links clearfix"">
                    <ul class=""clearfix"">
");
#nullable restore
#line 34 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_HeaderTopPartial.cshtml"
                         foreach (var entity in Model.MainNavigationBar)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_HeaderTopPartial.cshtml"
                             if (entity.ClassificationID == 8)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1923, "\"", 1964, 1);
#nullable restore
#line 38 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_HeaderTopPartial.cshtml"
WriteAttributeValue("", 1930, Url.Action("News", "MediaCenter"), 1930, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 38 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_HeaderTopPartial.cshtml"
                                                                            Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 39 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_HeaderTopPartial.cshtml"
                            }
                            else
                                continue;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_HeaderTopPartial.cshtml"
                                         
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a href=\"#\">??????????</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2224, "\"", 2262, 1);
#nullable restore
#line 44 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_HeaderTopPartial.cshtml"
WriteAttributeValue("", 2231, Url.Action("Contacts", "Home"), 2231, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">???????? ??????</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2313, "\"", 2357, 1);
#nullable restore
#line 45 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_HeaderTopPartial.cshtml"
WriteAttributeValue("", 2320, Url.Action("Conversion_Form","Home"), 2320, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">?????? ?????????? ??????????</a></li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 50 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_HeaderTopPartial.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""inner-container clearfix"">
            <!--Top Right-->
            <div class=""top-right clearfix hidden-sm"">
                <!--social-icon-->
                <div class=""links clearfix"">
                    <ul class=""clearfix"">
");
#nullable restore
#line 59 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_HeaderTopPartial.cshtml"
                         foreach (var entity in Model.MainNavigationBar)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_HeaderTopPartial.cshtml"
                             if (entity.ClassificationID == 76)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2990, "\"", 3031, 1);
#nullable restore
#line 63 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_HeaderTopPartial.cshtml"
WriteAttributeValue("", 2997, Url.Action("News", "MediaCenter"), 2997, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 63 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_HeaderTopPartial.cshtml"
                                                                            Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 64 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_HeaderTopPartial.cshtml"
                            }
                            else
                                continue;

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_HeaderTopPartial.cshtml"
                                         
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a href=\"#\">Careers</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 3293, "\"", 3331, 1);
#nullable restore
#line 69 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_HeaderTopPartial.cshtml"
WriteAttributeValue("", 3300, Url.Action("Contacts", "Home"), 3300, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Contact Us</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 3384, "\"", 3428, 1);
#nullable restore
#line 70 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_HeaderTopPartial.cshtml"
WriteAttributeValue("", 3391, Url.Action("Conversion_Form","Home"), 3391, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Car Conversion Request</a></li>
                    </ul>
                </div>
            </div>
            <!--Top left-->
            <div class=""top-left clearfix hidden-sm hidden-xs"">
                <ul class=""links clearfix"">

                    <li><a href=""mailto:gastec@gastec-egypt.com""><span class=""icon flaticon-note-1""></span></a></li>
                    <li><a");
            BeginWriteAttribute("href", " href=\"", 3819, "\"", 3856, 1);
#nullable restore
#line 79 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_HeaderTopPartial.cshtml"
WriteAttributeValue("", 3826, Url.Action("Language","Home"), 3826, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><strong>????????</strong><span class=""icon flaticon-chat""></span></a></li>
                    <li style=""padding-top: 8px"">|</li>
                </ul>
                <!--social-icon-->
                <div class=""social-icon"">
                    <ul class=""clearfix"">
                        <li>
                            <a href=""https://www.shakwa.eg/GCP/Default.aspx"" target=""_blank"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "119f3a856fc54ddc486c1017ab7f5542956ef2d515155", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                        </li>
                        <li><a href=""https://www.facebook.com/gasteceg/"" target=""_blank""><span class=""fa fa-facebook""></span></a></li>
                        <li><a href=""https://www.youtube.com/channel/UCTLayD5SdoD3WCPk7T3jgcQ"" target=""_blank""><span class=""fa fa-youtube""></span></a></li>

                    </ul>
                </div>
            </div>
        </div>
");
#nullable restore
#line 95 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_HeaderTopPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MainMenuModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
