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
    public class API_GetNewsTopics
    {
        // this functions to Get Topics for Latest News Section
        public static async Task<OutputGetNewsTopicsModel> GetAllNewsTopics(int groupId_, int translationID_)
        {
            // Create instance for Save returned API Consuming
            OutputGetNewsTopicsModel newsTopics = new();
            // build new request using HTTP Client
            using (var client = new HttpClient())
            {
                // Passing Base EX APP URL 
                // Create new instance for Complete URL Request
                StringBuilder ApiURL = new StringBuilder();
                ApiURL.Append(Gastech_Vault.baseURL);
                // Add APi Controller, function name
                ApiURL.Append($"NewsTopics/GetNewsTopics?");
                // Add Security String
                ApiURL.Append($"InputX.securityString={Gastech_Vault.SecurityString}");
                //Add ServerIP
                ApiURL.Append($"&InputX.serverIP={Gastech_Vault.ServerIP}");
                //Add Database Name
                ApiURL.Append($"&InputX.databaseName={Gastech_Vault.DatabaseName}");
                //Add Encrypted ExAppId 
                ApiURL.Append($"&InputX.encryptedEXAppID={Gastech_Vault.EncryptedEXAppID}");
                //Add resultCount to specify the number of returned Data
                ApiURL.Append($"&InputX.groupID={groupId_}");
                //Add showFeaturedOnly
                ApiURL.Append($"&InputX.translationLanguageID={translationID_}");
                // Create instance to get a Response from the URL Passed
                var responseTask = await client.GetAsync(ApiURL.ToString());
                // Check if Request Successed
                if (responseTask.IsSuccessStatusCode)
                {
                    // Get the Response Content
                    var response = responseTask.Content.ReadAsStringAsync().Result;
                    // Convert the Response Content into Model To View
                    newsTopics = JsonConvert.DeserializeObject<OutputGetNewsTopicsModel>(response);
                }
                return newsTopics;

            }
        }
        // this functions to Get Specific News for
        public static async Task<List<OutputGetNewsDetails>> GetNewsDetails(int serial_, int translationID_)
        {
            // Create instance for Save returned API Consuming
            List<OutputGetNewsDetails> newsDetails = new();
            // build new request using HTTP Client
            using (var client = new HttpClient())
            {
                // Passing Base EX APP URL 
                // Create new instance for Complete URL Request
                StringBuilder ApiURL = new StringBuilder();
                ApiURL.Append(Gastech_Vault.baseURL);
                // Add APi Controller, function name
                ApiURL.Append($"NewsTopics/GetNewsDetails?");
                // Add Security String
                ApiURL.Append($"InputX.securityString={Gastech_Vault.SecurityString}");
                //Add ServerIP
                ApiURL.Append($"&InputX.serverIP={Gastech_Vault.ServerIP}");
                //Add Database Name
                ApiURL.Append($"&InputX.databaseName={Gastech_Vault.DatabaseName}");
                //Add Encrypted ExAppId 
                ApiURL.Append($"&InputX.encryptedEXAppID={Gastech_Vault.EncryptedEXAppID}");
                //Add resultCount to specify the number of returned Data
                ApiURL.Append($"&InputX.newsID={serial_}");
                //Add showFeaturedOnly
                ApiURL.Append($"&InputX.translationLanguageID={translationID_}");
                // Create instance to get a Response from the URL Passed
                var responseTask = await client.GetAsync(ApiURL.ToString());
                // Check if Request Successed
                if (responseTask.IsSuccessStatusCode)
                {
                    // Get the Response Content
                    var response = responseTask.Content.ReadAsStringAsync().Result;
                    // Convert the Response Content into Model To View
                    newsDetails = JsonConvert.DeserializeObject<List<OutputGetNewsDetails>>(response);
                }
                return newsDetails;

            }
        }
    }
}
