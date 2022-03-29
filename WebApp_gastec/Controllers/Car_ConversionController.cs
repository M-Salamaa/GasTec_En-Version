using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_gastec.Domain;
using WebApp_gastec.Models;
using Microsoft.AspNetCore.Http;
namespace WebApp_gastec.Controllers
{
    public class Car_ConversionController : Controller
    {
        public readonly IWebHostEnvironment _hostingEnvironment;
        public Car_ConversionController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        private void ActivateSelectedForMainCategories(HomePageViewModel model_, string id_)
        {
            foreach (var child in model_.Main_Section)
            {
                foreach (var classification in child.LstChildClassification)
                {
                    if (classification.ClassificationID.ToString() == id_)
                        classification.IsActive = true;
                }
            }
        }
        // Caching All HTML Links Returned From API via Model
        private void CachedAllHtmlLinks(HomePageViewModel model_, string folderName_)
        {
            string path = "";
            #region Caching Html Links Returned from API
            //Create Instance from Caching Image Class
            Cache cachedHtml = new Cache(_hostingEnvironment);
            //Create Instance from System Class
            Domain.Service system = new Domain.Service();
            foreach (var entity in model_.Sub_Section)
            {
                if (entity.LstWebSections.Count > 0)
                {
                    foreach (var webSection in entity.LstWebSections)
                    {
                        path = cachedHtml.CahceAllHtmlLinks(folderName_, webSection.HTML_GUID, webSection.WebSection_HTM_Link);
                        webSection.Body = Domain.Service.ReadFileAsStringForBody(path);
                    }
                }
                else
                {
                    path = cachedHtml.CahceAllHtmlLinks(folderName_, entity.HTML_GUID, entity.Classification_HTMLLink);
                    entity.Body = Domain.Service.ReadFileAsStringForBody(path);
                }
            }
            #endregion
        }
        // Caching All Images Returned From API via Model
        private async Task CachedAllImagesAsync(HomePageViewModel model_, string folderName_)
        {
            #region Caching images returned from API 
            //Create Instance from Caching Image Class
            Cache cachedImages = new Cache(_hostingEnvironment);
            foreach (var entity in model_.Sub_Section)
            {
                // Check if there are a List of Web Sections
                if (entity.LstWebSections.Count > 0)
                {
                    foreach (var webSection in entity.LstWebSections)
                    {
                        foreach (var image in webSection.LstImages)
                        {
                            image.ImageGUID = await cachedImages.CahceAllImageAsync(folderName_, image.ImageGUID, image.ImageLink);
                        }
                    }
                }
                else
                {
                    foreach (var image in entity.LstImages)
                    {
                        image.ImageGUID = await cachedImages.CahceAllImageAsync(folderName_, image.ImageGUID, image.ImageLink);
                    }
                }
            }
            #endregion Caching images returned from API
        }
        // Get the OutPut Model after Consuming 
        private HomePageViewModel GetHomeViewModel(string encryptedClassificationId_, string encryptedTreeClassificationId_, int translationID_)
        {
            // Create Instance for home page view model to return Main Home Page View
            HomePageViewModel homePageViewModel = new()
            {
                // Consuming Main Navigation bar from Classification Tree API 
                MainNavigationBar = API_GetClassificationTree.GetClassificationTree(Domain.Service.Encrypt("0"), Domain.Service.Encrypt("0"), translationID_),
                // Consuming Main Menu of Car Conversion Section from Classification Tree API 
                Main_Section = API_GetClassificationTree.GetClassificationTree(Domain.Service.Encrypt("3"), Domain.Service.Encrypt("0"), translationID_),
                // Consuming Sub Categories of car Conversion Section from Classification Tree API 
                Sub_Section = API_GetClassificationTree.GetClassificationTree(encryptedClassificationId_, encryptedTreeClassificationId_, translationID_),

            };
            return homePageViewModel;
        }
        // Routing for Car Conversion Setcion Pages with Classification ID
        public async Task<IActionResult> Index(string ID_)
        {
            SessionHelper.SetObjectAsJson(HttpContext.Session, "Localization", Gastech_Vault.TranslationLanguageID);

            var model = this.GetHomeViewModel(Domain.Service.Encrypt("3"), Domain.Service.Encrypt(ID_), int.Parse(HttpContext.Session.GetString("Localization")));
            ActivateSelectedForMainCategories(model, ID_);
            await CachedAllImagesAsync(model, "Car_Conversion");
            CachedAllHtmlLinks(model, "Car_Conversion");
            return View(model);
        }
    }
}
