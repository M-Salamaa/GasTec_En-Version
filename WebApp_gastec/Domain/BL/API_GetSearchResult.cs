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
    public class API_GetSearchResult
    {
        public static async Task<SearchModel> GetSearchResult(string keyWord_, int translationID_)
        {
            SearchModel searchResult = new SearchModel();
            using (var client = new HttpClient())
            {
                StringBuilder ApiURL = new StringBuilder();
                ApiURL.Append(Gastech_Vault.baseURL);
                ApiURL.Append($"SearchInWebSIte/GetSearchResult?");
                // Add Security String
                ApiURL.Append($"InputX.securityString={Gastech_Vault.SecurityString}");
                //Add ServerIP
                ApiURL.Append($"&InputX.serverIP={Gastech_Vault.ServerIP}");
                //Add Database Name
                ApiURL.Append($"&InputX.databaseName={Gastech_Vault.DatabaseName}");
                //Add Encrypted ExAppId 
                ApiURL.Append($"&InputX.encryptedEXAppID={Gastech_Vault.EncryptedEXAppID}");
                // Add Search KEy Word
                ApiURL.Append($"&InputX.searchKeyWord={keyWord_}");
                //Add Search In Tree = True
                ApiURL.Append($"&InputX.searcInTree={true}");
                //Add Search In News = True
                ApiURL.Append($"&InputX.searchInNews={true}");
                //Add Search In Videos = True
                ApiURL.Append($"&InputX.searchInVideos={true}");
                // Add Language
                ApiURL.Append($"&InputX.translationLanguageID={translationID_}");

                var responseTask = await client.GetAsync(ApiURL.ToString());
                if(responseTask.IsSuccessStatusCode)
                {
                    var response = responseTask.Content.ReadAsStringAsync().Result;
                    searchResult = JsonConvert.DeserializeObject<SearchModel>(response);
                }
                return searchResult;
            }
        }



    }
}
