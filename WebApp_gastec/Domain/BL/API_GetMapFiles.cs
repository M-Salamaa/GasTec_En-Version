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
    public class API_GetMapFiles
    {
        //if property want to show set by one 
        private static readonly int showProperty = 1;
        private static readonly string encryptedMajorTreeNodeID = Service.Encrypt("1");

        public static async Task<List<OutputGetClassificationTreeModel>> GetMapFilesAsync(string encryptedTreeClassificationID_, int translationID_)
        {
            List<OutputGetClassificationTreeModel> descrptionText = new();
            //create Client to consume the API
            using (var client = new HttpClient())
            {
                //Create Base Address
                client.BaseAddress = new Uri(Gastech_Vault.baseURL);
                // just for testing encryption
                //var test = Domain.System.Encrypt("126");
                // Creating Instance To Pass Input to API 
                InputGetClassificationTreeModel getClassificationInputObject = new InputGetClassificationTreeModel()
                {
                    // Get Security String
                    SecurityString = Gastech_Vault.SecurityString,
                    // Get Server IP
                    ServerIP = Gastech_Vault.ServerIP,
                    // Get Datbase Name
                    DatabaseName = Gastech_Vault.DatabaseName,
                    // Get Encrypted EXApp ID
                    EncryptedEXAppID = Gastech_Vault.EncryptedEXAppID,
                    // Get Encrypted Major Tree Node ID
                    EncryptedMajorTreeNodeID = encryptedMajorTreeNodeID,
                    // Get Encrypted Tree Classification ID
                    EncryptedTreeClassificationID = encryptedTreeClassificationID_,
                    // Get Encrypted Specific Tree Classification ID
                    EncryptedSpecificTreeClassificationID = Domain.Service.Encrypt("0"),
                    // Get Max Tree Level
                    MaxTreeLevel = 0,
                    // Get Translation Language ID
                    TranslationLanguageID = translationID_,
                    // Get Classification Settings
                    ClassificationSettings = new ClassificationSettings()
                    {
                        ShowFiles = showProperty,
                        ShowImages = 0,
                        ShowWebSections = 0,
                        PageNumber = showProperty,
                        ResultCount = 0
                    }
                };
                string getClassificationInputJson = JsonConvert.SerializeObject(getClassificationInputObject);
                var httpContent = new StringContent(getClassificationInputJson, Encoding.UTF8, "application/json");
                var responseTask = await client.PostAsync("ClassificationTree/GetClassificationTree", httpContent);
                if (responseTask.IsSuccessStatusCode)
                {
                    var response = responseTask.Content.ReadAsStringAsync().Result;
                    descrptionText = JsonConvert.DeserializeObject<List<OutputGetClassificationTreeModel>>(response);
                }
                // Returned Data From API
                return descrptionText;
            }
        }
    }
}
