using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using WebApp_gastec.Models;

namespace WebApp_gastec.Domain
{
    public class API_GetClassificationTree
    {
        //if property want to show set by one 
        private static readonly int showProperty = 1;
        private static string encryptedMajorTreeNodeID = "";


        // Function to get Tree Nodes for Clasification Tree with EncryptedSpecificTreeClassificationID
        public static List<OutputGetClassificationTreeModel> GetClassificationTree(string encryptedTreeClassificationID_, string encryptedSpecificTreeClassificationID_, int translationID_)
        {
            if (translationID_ == 0)
                encryptedMajorTreeNodeID = Service.Encrypt("1");
            else
                encryptedMajorTreeNodeID = Service.Encrypt("2");
            // Create instance for output
            List<OutputGetClassificationTreeModel> descrptionText = new ();
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
                    EncryptedSpecificTreeClassificationID = encryptedSpecificTreeClassificationID_,
                    // Get Max Tree Level
                    MaxTreeLevel = 3,
                    // Get Translation Language ID
                    TranslationLanguageID = translationID_,
                    // Get Classification Settings
                    ClassificationSettings = new ClassificationSettings()
                    {
                        ShowFiles = showProperty,
                        ShowImages = showProperty,
                        ShowWebSections = showProperty,
                        PageNumber = showProperty,
                        ResultCount = 0
                    }
                };
                // Get Json from Input Object to pass it to API
                string getClassificationInputJson = JsonConvert.SerializeObject(getClassificationInputObject);
                var httpContent = new StringContent(getClassificationInputJson, Encoding.UTF8, "application/json");
                var responseTask = client.PostAsync("ClassificationTree/GetClassificationTree", httpContent);   
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync().Result;
                    descrptionText = JsonConvert.DeserializeObject<List<OutputGetClassificationTreeModel>> (response);
                }
                // Returned Data From API
                return descrptionText;
            }
        }
    }
}
