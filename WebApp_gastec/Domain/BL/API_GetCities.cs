using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebApp_gastec.Models;

namespace WebApp_gastec.Domain
{
    public class API_GetCities
    {
        public static async Task<List<OutputGetCities>> GetAllCitiesAsync(int translationID_)
        {
            List<OutputGetCities> cities = new List<OutputGetCities>();
            using (var client = new HttpClient())
            {
                StringBuilder ApiURL = new StringBuilder();
                ApiURL.Append(Gastech_Vault.baseURL);
                ApiURL.Append($"General/GetCities?");
                ApiURL.Append($"InputX.securityString={Gastech_Vault.SecurityString}");
                ApiURL.Append($"&InputX.serverIP={Gastech_Vault.ServerIP}");
                ApiURL.Append($"&InputX.databaseName={Gastech_Vault.DatabaseName}");
                ApiURL.Append($"&InputX.encryptedEXAppID={Gastech_Vault.EncryptedEXAppID}");
                ApiURL.Append($"&InputX.translationLanguageID={translationID_}");

                var responseTask = await client.GetAsync(ApiURL.ToString());
                if (responseTask.IsSuccessStatusCode)
                {
                    var response = responseTask.Content.ReadAsStringAsync().Result;
                    cities = JsonConvert.DeserializeObject<List<OutputGetCities>>(response);
                }
                return cities;
            }
        }
    }
}
