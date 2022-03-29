using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_gastec.Models;
namespace WebApp_gastec.Domain
{
    public class GetClassificationIDByLang
    {

        public static InputHomePageViewModel GetClassificationIdByLanguageID()
        {
            InputHomePageViewModel inputHomePageViewModel = new InputHomePageViewModel();
            if (Gastech_Vault.TranslationLanguageID == 0)
            {
                inputHomePageViewModel.encryptedMajorTreeID = Service.Encrypt("1");
                inputHomePageViewModel.Input_MainNavigationBar = new()
                {
                    EncryptedSpecificTreeClassificationID = Service.Encrypt("0"),
                    EncryptedTreeClassificationID = Service.Encrypt("0"),
                };
                inputHomePageViewModel.Input_BannersHome = new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("1"),
                    EncryptedSpecificTreeClassificationID = Service.Encrypt("118")
                };
                inputHomePageViewModel.Input_GastechNumbers = new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("1"),
                    EncryptedSpecificTreeClassificationID = Service.Encrypt("349")
                };
                inputHomePageViewModel.Input_MidSection = new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("1"),
                    EncryptedSpecificTreeClassificationID = Service.Encrypt("353")
                };
                inputHomePageViewModel.Input_MidBanner = new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("1"),
                    EncryptedSpecificTreeClassificationID = Service.Encrypt("350"),
                };
                inputHomePageViewModel.Input_MediaCenter = new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("8"),
                    EncryptedSpecificTreeClassificationID = Service.Encrypt("0"),
                };
                inputHomePageViewModel.Input_AboutUs_MainSection = new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("125"),
                };
                inputHomePageViewModel.Input_HR = new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("123"),
                };

            }
            else
            {
                inputHomePageViewModel.encryptedMajorTreeID = Service.Encrypt("2");
                inputHomePageViewModel.Input_MainNavigationBar = new()
                {
                    EncryptedSpecificTreeClassificationID = Service.Encrypt("0"),
                    EncryptedTreeClassificationID = Service.Encrypt("0"),
                };
                inputHomePageViewModel.Input_BannersHome = new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("59"),
                    EncryptedSpecificTreeClassificationID = Service.Encrypt("119"),
                };
                inputHomePageViewModel.Input_GastechNumbers = new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("59"),
                    EncryptedSpecificTreeClassificationID = Service.Encrypt("348"),
                };
                inputHomePageViewModel.Input_MidSection = new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("59"),
                    EncryptedSpecificTreeClassificationID = Service.Encrypt("356"),
                };
                inputHomePageViewModel.Input_MidBanner = new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("59"),
                    EncryptedSpecificTreeClassificationID = Service.Encrypt("351"),
                };
                inputHomePageViewModel.Input_MediaCenter = new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("76"),
                    EncryptedSpecificTreeClassificationID = Service.Encrypt("0"),
                };
                inputHomePageViewModel.Input_AboutUs_MainSection = new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("60"),
                };
                inputHomePageViewModel.Input_HR = new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("66"),
                };

            }
            return inputHomePageViewModel;
        }


    }
}
