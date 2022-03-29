using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_gastec.Domain;

namespace WebApp_gastec
{
    public static class Gastech_Vault
    {
        public static string baseURL = "http://softextest020.azurewebsites.net/api/";
        public static string ApiVersion = "2";
        private static string EXAppId = "1";
        public static string EncryptedEXAppID = Domain.Service.Encrypt(EXAppId);
        public static string SecurityString = "ZuSNfho?O6]UG8tWk/zi";
        public static string ServerIP = "mc1";
        public static string DatabaseName = "Gastec-Egypt-Website"; 
        public static int TranslationLanguageID = (int)Translation.Arabic;
    }
}
