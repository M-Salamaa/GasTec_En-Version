using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_gastec.Domain
{
    public static class GetActionName
    {
        public static string GetActionNameforEniImagesByID(string id_)
        {
            string sectionID_ = "";
            if (Gastech_Vault.TranslationLanguageID == 0)
            {
                switch (id_)
                {
                    case "310":
                        sectionID_ = "40"; // Advantage
                        break;
                    case "311":
                        sectionID_ = "42"; // Commerical
                        break;
                    case "312":
                        sectionID_ = "41"; // Industrial 
                        break;
                    case "313":
                        sectionID_ = "43"; // Distributer
                        break;
                    default:
                        sectionID_ = "40";
                        break;
                }
            }
            else
            {
                switch (id_)
                {
                    case "314":
                        sectionID_ = "94";
                        break;
                    case "315":
                        sectionID_ = "96";
                        break;
                    case "316":
                        sectionID_ = "95";
                        break;
                    case "317":
                        sectionID_ = "97";
                        break;
                    default:
                        sectionID_ = "94";
                        break;
                }
                // 94 : 97
            }
            return sectionID_;
        }
        public static string GetActionNameForSearch(string parentID_)
        {
            string actionName_ = "";
            switch (parentID_)
            {
                case "28":
                    actionName_ = "Stations";
                    break;
                case "123":
                    actionName_ = "HR";
                    break;
                default:
                    actionName_ = "Index";
                    break;
            }
            return actionName_;
        }


    }
}
