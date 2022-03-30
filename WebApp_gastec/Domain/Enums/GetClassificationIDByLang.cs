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
                inputHomePageViewModel.Input_MapFiles = new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("1"),
                };
                inputHomePageViewModel.Input_CarConversion_MainSection= new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("3"),
                    EncryptedSpecificTreeClassificationID = Service.Encrypt("0"),
                };
                inputHomePageViewModel.Input_CylindarTest_MainSection = new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("5"),
                    EncryptedSpecificTreeClassificationID = Service.Encrypt("0"),
                };
                inputHomePageViewModel.Input_Stat_MainSection = new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("7"),
                    EncryptedSpecificTreeClassificationID = Service.Encrypt("0"),
                };
                inputHomePageViewModel.Input_Lubricants_MainSection = new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("6"),
                    EncryptedSpecificTreeClassificationID = Service.Encrypt("0"),
                };
                inputHomePageViewModel.Input_Industrial_Lub_MainSection = new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("41"),
                    EncryptedSpecificTreeClassificationID = Service.Encrypt("0"),
                };
                inputHomePageViewModel.Input_Commerical_Lub_MainSection = new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("42"),
                    EncryptedSpecificTreeClassificationID = Service.Encrypt("0"),
                };
                inputHomePageViewModel.Input_FuelingStations_MainSection = new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("4"),
                    EncryptedSpecificTreeClassificationID = Service.Encrypt("0"),
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
                inputHomePageViewModel.Input_MapFiles = new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("59"),
                };
                inputHomePageViewModel.Input_CarConversion_MainSection = new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("71"),
                    EncryptedSpecificTreeClassificationID = Service.Encrypt("0"),
                };
                inputHomePageViewModel.Input_CylindarTest_MainSection = new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("73"),
                    EncryptedSpecificTreeClassificationID = Service.Encrypt("0"),
                };
                inputHomePageViewModel.Input_Stat_MainSection = new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("75"),
                    EncryptedSpecificTreeClassificationID = Service.Encrypt("0"),
                };
                inputHomePageViewModel.Input_Lubricants_MainSection = new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("74"),
                    EncryptedSpecificTreeClassificationID = Service.Encrypt("0"),
                };
                inputHomePageViewModel.Input_Industrial_Lub_MainSection = new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("95"),
                    EncryptedSpecificTreeClassificationID = Service.Encrypt("0"),
                };
                inputHomePageViewModel.Input_Commerical_Lub_MainSection = new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("96"),
                    EncryptedSpecificTreeClassificationID = Service.Encrypt("0"),
                };
                inputHomePageViewModel.Input_FuelingStations_MainSection = new()
                {
                    EncryptedTreeClassificationID = Service.Encrypt("72"),
                    EncryptedSpecificTreeClassificationID = Service.Encrypt("0"),
                };

            }
            return inputHomePageViewModel;
        }


    }
}
