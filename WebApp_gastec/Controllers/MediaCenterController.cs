﻿using Microsoft.AspNetCore.Hosting;
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
    public class MediaCenterController : Controller
    {
        public readonly IWebHostEnvironment _hostingEnvironment;
        public MediaCenterController(IWebHostEnvironment hostEnvironment)
        {
            _hostingEnvironment = hostEnvironment;
        }
        // Caching All Images Returned From API via Model
        private async Task CachedAllImagesAsync(HomePageViewModel model_, string folderName_)
        {
            #region Caching images returned from API 
            Cache cachedImages = new Cache(_hostingEnvironment);
            foreach (var entity in model_.Sub_Section)
            {
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
        private async Task CachedAllIPhotoCentermagesAsync(HomePageViewModel model_, string folderName_)
        {
            #region Caching images returned from API 
            Cache cachedImages = new Cache(_hostingEnvironment);
            foreach (var entity in model_.Sub_Section)
            {
                foreach (var classification in entity.LstChildClassification)
                {
                    foreach (var child in classification.LstChildClassification)
                    {
                        foreach (var image in child.LstImages)
                        {
                            image.ImageGUID = await cachedImages.CahceAllImageAsync(folderName_, image.ImageGUID, image.ImageLink);
                        }
                    }
                }
            }
            #endregion Caching images returned from API
        }
        // Caching All News Images
        private async Task CacheAllNewsImages(HomePageViewModel model_, string folderName_)
        {
            #region caching images 
            Cache cachedImages = new Cache(_hostingEnvironment);
            foreach (var entity in model_.NewsTopics.LstNews)
            {
                entity.ImageGUID = await cachedImages.CahceAllImageAsync(folderName_, entity.ImageGUID, entity.ImageLink);
            }
            #endregion
        }
        private HomePageViewModel GetHomeViewModel(string encryptedClassificationId_, int translationID_)
        {
            var inputModel = GetClassificationIDByLang.GetClassificationIdByLanguageID();
            // Create Instance for home page view model to return Main Home Page View
            HomePageViewModel homePageViewModel = new()
            {
                // Consuming Main Cylindar Test Menu from Classification Tree API 
                Main_Section = API_GetClassificationTree.GetClassificationTree(inputModel.Input_MediaCenter.EncryptedTreeClassificationID, inputModel.Input_MediaCenter.EncryptedSpecificTreeClassificationID, translationID_),
                // Consuming Cylindar Category from Classification Tree API 
                Sub_Section = API_GetClassificationTree.GetClassificationTree(encryptedClassificationId_, inputModel.Input_MediaCenter.EncryptedSpecificTreeClassificationID, translationID_),
            };
            return homePageViewModel;
        }
        private async Task<HomePageViewModel> GetNewsModel()
        {
            var inputModel = GetClassificationIDByLang.GetClassificationIdByLanguageID();
            HomePageViewModel homePageViewModel = new()
            {
                // Consuming Main Cylindar Test Menu from Classification Tree API 
                Main_Section = API_GetClassificationTree.GetClassificationTree(inputModel.Input_MediaCenter.EncryptedTreeClassificationID, inputModel.Input_MediaCenter.EncryptedSpecificTreeClassificationID, int.Parse(HttpContext.Session.GetString("Localization"))),
                // Consuming News Groups from Get News Topic API
                News_Group = await API_GetNewsGroup.GetNewsGroup(),
                // Consuming All News from Get News Topic API
                NewsTopics = await API_GetNewsTopics.GetAllNewsTopics(0),
            };
            return homePageViewModel;
        }
        public async Task<IActionResult> NewsAsync()
        {
            SessionHelper.SetObjectAsJson(HttpContext.Session, "Localization", Gastech_Vault.TranslationLanguageID);
            var model = await this.GetNewsModel();
            await CacheAllNewsImages(model, "MediaCenter_NewsSection");
            model.IsActive = true;
            return View(model);
        }
        public async Task<IActionResult> IndexAsync(string ID_)
        {
            SessionHelper.SetObjectAsJson(HttpContext.Session, "Localization", Gastech_Vault.TranslationLanguageID);

            var model = this.GetHomeViewModel(Domain.Service.Encrypt(ID_), int.Parse(HttpContext.Session.GetString("Localization")));
            foreach (var section in model.Sub_Section)
            {
                if (section.ClassificationID == 48 || section.ClassificationID == 102)
                {
                    await CachedAllIPhotoCentermagesAsync(model, "PhotoCenter_MediaCenter");
                }
                else
                    await CachedAllImagesAsync(model, "MediaCenter");
            }
            foreach (var child in model.Main_Section)
            {
                foreach (var classification in child.LstChildClassification)
                {
                    if (classification.ClassificationID.ToString() == ID_)
                        classification.IsActive = true;
                }
            }
            return View(model);
        }
    }
}
