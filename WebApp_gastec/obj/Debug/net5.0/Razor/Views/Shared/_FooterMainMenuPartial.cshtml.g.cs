#pragma checksum "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48be66bb951b2f33102fd6c31af3964b52ac792e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FooterMainMenuPartial), @"mvc.1.0.view", @"/Views/Shared/_FooterMainMenuPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48be66bb951b2f33102fd6c31af3964b52ac792e", @"/Views/Shared/_FooterMainMenuPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c714fee471500ac0555f931cba968b228d83c63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FooterMainMenuPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MainMenuModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"row d-flex flex-row-reverse seven-cols clearfix\">\r\n");
#nullable restore
#line 8 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
     if (Gastech_Vault.TranslationLanguageID == 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
         foreach (var classification in Model.MainNavigationBar)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
             if (classification.ClassificationID == 1 || classification.ClassificationID == 8 || classification.ClassificationID == 20 || classification.ClassificationID == 121)
            {
                continue;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"big-column col-md-2 col-sm-12 col-xs-12 pull-left\">\r\n                <div class=\"footer-column col-md-12 col-sm-12 col-xs-12\">\r\n                    <div class=\"footer-widget links-widget\">\r\n                        <h2>");
#nullable restore
#line 19 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                       Write(classification.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <div class=\"widget-content\">\r\n                            <ul class=\"list\">\r\n");
#nullable restore
#line 22 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                 if (classification.LstChildClassification.Count > 0)
                                {
                                    // check if Id = 125 for About us
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                     if (classification.ClassificationID == 125)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                         foreach (var entity in classification.LstChildClassification)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                             if (entity.ClassificationID == 123)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li>\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 1665, "\"", 1728, 1);
#nullable restore
#line 32 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
WriteAttributeValue("", 1672, Url.Action("HumanResources","About", new { ID_ = "15"}), 1672, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 32 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                                                                                                  Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                </li>\r\n");
#nullable restore
#line 34 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li>\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 2069, "\"", 2153, 1);
#nullable restore
#line 38 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
WriteAttributeValue("", 2076, Url.Action("Index","About", new { ID_ = entity.ClassificationID.ToString()}), 2076, 77, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 38 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                                                                                                                       Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                </li>\r\n");
#nullable restore
#line 40 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                         
                                    }
                                    // check if Id = 3 for Car Conversion
                                    else if (classification.ClassificationID == 3)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                         foreach (var entity in classification.LstChildClassification)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2816, "\"", 2898, 1);
#nullable restore
#line 49 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
WriteAttributeValue("", 2823, Url.Action("Index","Car_Conversion", new { ID_ = entity.ClassificationID}), 2823, 75, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 49 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                                                                                                                 Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 51 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                         

                                    }
                                    //Check if ID = 5 for Cylindar Test
                                    else if (classification.ClassificationID == 5)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                         foreach (var entity in classification.LstChildClassification)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 3510, "\"", 3602, 1);
#nullable restore
#line 60 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
WriteAttributeValue("", 3517, Url.Action("Index", "Cylindar_Test",new { ID_ = entity.ClassificationID.ToString()}), 3517, 85, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 60 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                                                                                                                           Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 62 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                         
                                    }
                                    // Check if ID = 4 for Catering Stations
                                    else if (classification.ClassificationID == 4)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                         foreach (var entity in classification.LstChildClassification)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 4217, "\"", 4313, 1);
#nullable restore
#line 70 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
WriteAttributeValue("", 4224, Url.Action("Index", "Catering_Stations",new { ID_ = entity.ClassificationID.ToString()}), 4224, 89, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 70 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                                                                                                                               Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 72 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                         
                                    }
                                    // Check iff ID = 7 for Statistics Section
                                    else if (classification.ClassificationID == 7)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                         foreach (var entity in classification.LstChildClassification)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 4930, "\"", 5019, 1);
#nullable restore
#line 80 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
WriteAttributeValue("", 4937, Url.Action("Index", "Statistics",new { ID_ = entity.ClassificationID.ToString()}), 4937, 82, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 80 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                                                                                                                        Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 82 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                         
                                    }
                                    // Check iff ID = 6 for Oils Section
                                    else if (classification.ClassificationID == 6)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                         foreach (var entity in classification.LstChildClassification)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 5630, "\"", 5709, 1);
#nullable restore
#line 90 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
WriteAttributeValue("", 5637, Url.Action("Index", "Lubricants", new { ID_ = entity.ClassificationID}), 5637, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 90 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                                                                                                              Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 92 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 100 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
         
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
         foreach (var classification in Model.MainNavigationBar)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
             if (classification.ClassificationID == 59 || classification.ClassificationID == 76 || classification.ClassificationID == 79 || classification.ClassificationID == 63)
            {
                continue;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"big-column col-md-2 col-sm-12 col-xs-12 pull-left\">\r\n                <div class=\"footer-column col-md-12 col-sm-12 col-xs-12\">\r\n                    <div class=\"footer-widget links-widget\">\r\n                        <h2>");
#nullable restore
#line 114 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                       Write(classification.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <div class=\"widget-content\">\r\n                            <ul class=\"list\">\r\n");
#nullable restore
#line 117 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                 if (classification.LstChildClassification.Count > 0)
                                {
                                    // check if Id = 60 for About us
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                     if (classification.ClassificationID == 60)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                         foreach (var entity in classification.LstChildClassification)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                             if (entity.ClassificationID == 66)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li>\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 7480, "\"", 7543, 1);
#nullable restore
#line 127 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
WriteAttributeValue("", 7487, Url.Action("HumanResources","About", new { ID_ = "15"}), 7487, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 127 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                                                                                                  Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                </li>\r\n");
#nullable restore
#line 129 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li>\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 7884, "\"", 7968, 1);
#nullable restore
#line 133 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
WriteAttributeValue("", 7891, Url.Action("Index","About", new { ID_ = entity.ClassificationID.ToString()}), 7891, 77, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 133 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                                                                                                                       Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                </li>\r\n");
#nullable restore
#line 135 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 135 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                         
                                    }
                                    // check if Id = 71 for Car Conversion
                                    else if (classification.ClassificationID == 71)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 141 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                         foreach (var entity in classification.LstChildClassification)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 8633, "\"", 8715, 1);
#nullable restore
#line 144 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
WriteAttributeValue("", 8640, Url.Action("Index","Car_Conversion", new { ID_ = entity.ClassificationID}), 8640, 75, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 144 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                                                                                                                 Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 146 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 146 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                         

                                    }
                                    //Check if ID = 73 for Cylindar Test
                                    else if (classification.ClassificationID == 73)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 152 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                         foreach (var entity in classification.LstChildClassification)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 9329, "\"", 9421, 1);
#nullable restore
#line 155 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
WriteAttributeValue("", 9336, Url.Action("Index", "Cylindar_Test",new { ID_ = entity.ClassificationID.ToString()}), 9336, 85, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 155 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                                                                                                                           Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 157 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 157 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                         
                                    }
                                    // Check if ID = 72 for Catering Stations
                                    else if (classification.ClassificationID == 72)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 162 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                         foreach (var entity in classification.LstChildClassification)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 10038, "\"", 10134, 1);
#nullable restore
#line 165 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
WriteAttributeValue("", 10045, Url.Action("Index", "Catering_Stations",new { ID_ = entity.ClassificationID.ToString()}), 10045, 89, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 165 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                                                                                                                               Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 167 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 167 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                         
                                    }
                                    // Check iff ID = 75 for Statistics Section
                                    else if (classification.ClassificationID == 75)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 172 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                         foreach (var entity in classification.LstChildClassification)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 10753, "\"", 10842, 1);
#nullable restore
#line 175 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
WriteAttributeValue("", 10760, Url.Action("Index", "Statistics",new { ID_ = entity.ClassificationID.ToString()}), 10760, 82, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 175 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                                                                                                                        Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 177 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 177 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                         
                                    }
                                    // Check iff ID = 74 for Oils Section
                                    else if (classification.ClassificationID == 74)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 182 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                         foreach (var entity in classification.LstChildClassification)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 11455, "\"", 11534, 1);
#nullable restore
#line 185 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
WriteAttributeValue("", 11462, Url.Action("Index", "Lubricants", new { ID_ = entity.ClassificationID}), 11462, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 185 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                                                                                                              Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 187 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 187 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 188 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 195 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 195 "D:\GitHub\GasTec_En-Version\WebApp_gastec\Views\Shared\_FooterMainMenuPartial.cshtml"
         
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
