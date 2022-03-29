using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebApp_gastec.Domain;
using WebApp_gastec.Models;

namespace WebApp_gastec.Controllers
{
    public class PartialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //Contact Us GET Action
        [HttpGet]
        public IActionResult _ContactUsPartial()
        {
            ContactUsViewModel contactModel_ = new ContactUsViewModel();
            return PartialView(contactModel_);
        }
        //Contact Us POST Action
        [HttpPost]
        public IActionResult ContactUs(ContactUsViewModel contactModel_)
        {
            SessionHelper.SetObjectAsJson(HttpContext.Session, "Localization", Gastech_Vault.TranslationLanguageID);
            if (contactModel_ != null)
            {
                // Return reCAPTCHA Response as String
                string captchaResponse = HttpContext.Request.Form["g-Recaptcha-Response"];
                // Return Captcha Response Model using IsValid Function
                CaptchaResponseViewModel result = Service.IsValid(captchaResponse);
                if (result.Success)
                {
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri(Gastech_Vault.baseURL);
                        InputContactUsModel inputContactUsModel = new()
                        {
                            SecurityString = Gastech_Vault.SecurityString,
                            ServerIP = Gastech_Vault.ServerIP,
                            DatabaseName = Gastech_Vault.DatabaseName,
                            EncryptedEXAppID = Gastech_Vault.EncryptedEXAppID,
                            ClientIPAddress = HttpContext.Connection.RemoteIpAddress.ToString(),
                            Subject = "Contact Us",
                            RequestDetails = contactModel_.Message,
                            SecurityDetails = contactModel_.Name + "\r\r\r\n" + contactModel_.Email + "\r\r\r\n" + contactModel_.PhoneNumber,
                            EncryptedPageURL = Domain.Service.Encrypt(Gastech_Vault.baseURL)
                        };
                        string getContactUsInputObject = JsonConvert.SerializeObject(inputContactUsModel);
                        var httpContent = new StringContent(getContactUsInputObject, Encoding.UTF8, "application/json");
                        var responseTask = client.PostAsync("Main/AddNewContactLog", httpContent);
                        responseTask.Wait();
                        if (responseTask.Result.IsSuccessStatusCode)
                        {
                            return RedirectToAction("Index","Home");
                        }
                        else
                            return BadRequest("Can't Submit Please Check Your Internet Connection.");
                    }
                }
            }
            return RedirectToAction("Index","Home");

        }
        // Action for Main Menu in Navigation bar
        public IActionResult _HeaderMainMenuPartial()
        {
            var inputModel = GetClassificationIDByLang.GetClassificationIdByLanguageID();
            SessionHelper.SetObjectAsJson(HttpContext.Session, "Localization", Gastech_Vault.TranslationLanguageID);
            MainMenuModel mainMenuModel_ = new()
            {
                // Consuming Main Menu from Classification Tree API 
                MainNavigationBar = API_GetClassificationTree.GetClassificationTree(inputModel.Input_MainNavigationBar.EncryptedTreeClassificationID, inputModel.Input_MainNavigationBar.EncryptedSpecificTreeClassificationID, int.Parse(HttpContext.Session.GetString("Localization"))),
            };
            return PartialView(mainMenuModel_);
        }
        // Action for Main Menu in Footer
        public IActionResult _FooterMainMenuPartial()
        {
            var inputModel = GetClassificationIDByLang.GetClassificationIdByLanguageID();
            SessionHelper.SetObjectAsJson(HttpContext.Session, "Localization", Gastech_Vault.TranslationLanguageID);
            MainMenuModel mainMenuModel_ = new()
            {
                // Consuming Main Menu from Classification Tree API 
                MainNavigationBar = API_GetClassificationTree.GetClassificationTree(inputModel.Input_MainNavigationBar.EncryptedTreeClassificationID, inputModel.Input_MainNavigationBar.EncryptedSpecificTreeClassificationID, int.Parse(HttpContext.Session.GetString("Localization"))),
            };
            return PartialView(mainMenuModel_);
        }
        //Action for Header Top
        public IActionResult _HeaderTopPartial()
        {
            var inputModel = GetClassificationIDByLang.GetClassificationIdByLanguageID();
            SessionHelper.SetObjectAsJson(HttpContext.Session, "Localization", Gastech_Vault.TranslationLanguageID);
            MainMenuModel mainMenuModel_ = new()
            {
                // Consuming Main Menu from Classification Tree API 
                MainNavigationBar = API_GetClassificationTree.GetClassificationTree(inputModel.Input_MainNavigationBar.EncryptedTreeClassificationID, inputModel.Input_MainNavigationBar.EncryptedSpecificTreeClassificationID, int.Parse(HttpContext.Session.GetString("Localization"))),
            };
            return PartialView(mainMenuModel_);
        }
        //Search GET Action 
        [HttpGet]
        public IActionResult _SearchPartial()
        {
            SessionHelper.SetObjectAsJson(HttpContext.Session, "Localization", Gastech_Vault.TranslationLanguageID);
            SearchModel model_ = new SearchModel();
            return PartialView(model_);

        }
        //Search POST Action 
        public async Task<IActionResult> SearchResult(SearchModel model_)
        {
            SessionHelper.SetObjectAsJson(HttpContext.Session, "Localization", Gastech_Vault.TranslationLanguageID);
            model_ = await API_GetSearchResult.GetSearchResult(model_.keyWord_, int.Parse(HttpContext.Session.GetString("Localization")));
            return View(model_);
        }
    }
}
