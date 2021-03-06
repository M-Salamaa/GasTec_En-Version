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
    public class API_GetNewsGroup
    {
        public static async Task<List<OutPutGetNewsGroupModel>> GetNewsGroup()
        {
            List<OutPutGetNewsGroupModel> newsGroups = new();
            using(var client = new HttpClient())
            {
                StringBuilder ApiURL = new StringBuilder();
                ApiURL.Append(Gastech_Vault.baseURL);
                // Add APi Controller, function name
                ApiURL.Append($"NewsTopics/GetNewGroup?");
                // Add Security String
                ApiURL.Append($"InputX.securityString={Gastech_Vault.SecurityString}");
                //Add ServerIP
                ApiURL.Append($"&InputX.serverIP={Gastech_Vault.ServerIP}");
                //Add Database Name
                ApiURL.Append($"&InputX.databaseName={Gastech_Vault.DatabaseName}");
                //Add Encrypted ExAppId 
                ApiURL.Append($"&InputX.encryptedEXAppID={Gastech_Vault.EncryptedEXAppID}");
                // Create instance to get a Response from the URL Passed
                var responseTask = await client.GetAsync(ApiURL.ToString());
                // Check if Request Successed
                if (responseTask.IsSuccessStatusCode)
                {
                    // Get the Response Content
                    var response = responseTask.Content.ReadAsStringAsync().Result;
                    // Convert the Response Content into Model To View
                    newsGroups = JsonConvert.DeserializeObject<List<OutPutGetNewsGroupModel>>(response);
                }
                return newsGroups;
            }
        }
    }
}
