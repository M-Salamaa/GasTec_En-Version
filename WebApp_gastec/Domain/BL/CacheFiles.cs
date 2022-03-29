using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebApp_gastec.Models;
using System.Text.Json.Serialization;


namespace WebApp_gastec.Domain
{
    public class CacheFiles
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public CacheFiles(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public string CahceAllFiles(string fileGuid_, string jsonFileName_, string fileLink_)
        {
            // Remove All Special Char
            fileGuid_ = ReplaceSpecialCharInFileGuidForEmptyFile(fileGuid_);
            //Get Full Path to Search in Cach folder
            var fullPathForTextFile = GetCacheFullPathforEmptyFiles(fileGuid_);

            // Check if the Image Exist in our full Path or not 
            if (!File.Exists(fullPathForTextFile))
            {
                //Create Empty File with File GUID Name To Check every Time before caching
                File.Create(fullPathForTextFile);
                //Check if Json File Exist and Cahcing it if not
                GetCacheFullPathforJsonFile(jsonFileName_, fileLink_);
            }
            //Return Full Path for File GUID  
            return fullPathForTextFile;
        }
        // Function to Get Empty File Full Path
        public string GetCacheFullPathforEmptyFiles(string fileGuid_)
        {
            // Set Local Path in Local Machine
            string localPath = $"public/src/json/ar/";
            // combine Root_Folder with Local_Path To get the Path for Caching
            string contentRootPath = Path.Combine(_hostingEnvironment.WebRootPath, localPath);
            // Create Directory for Cahcing images with our combined Path
            Directory.CreateDirectory(contentRootPath);
            // Return Full Path and Image GUID 
            return contentRootPath + fileGuid_;
        }
        // Function to Sace Json File if not exist
        public void GetCacheFullPathforJsonFile(string fileName_, string fileLink_)
        {
            // Set Local Path in Local Machine
            string localPath = $"public/src/json/ar/{fileName_}";
            // combine Root_Folder with Local_Path To get the Path for Caching
            string contentRootPath = Path.Combine(_hostingEnvironment.WebRootPath, localPath);
            // Create Directory for Cahcing images with our combined Path
            string backupFile = contentRootPath + ".bak";
            // Check if Json File Exist
            if (!File.Exists(contentRootPath))
            {
                // Create Instance for Http Client
                using var client = new WebClient();
                {
                    // Get Content of Json File Using Fike URL 
                    string jsonFileContent = client.DownloadString(fileLink_);
                    // Create New File with to the specified path and Append all text to it
                    File.AppendAllText(contentRootPath, jsonFileContent);
                }
            }
            else
            {
                // Create Instance for Web Client
                using var client = new WebClient();
                // Get Content of Json File Using Fike URL 
                var jsonFileContent = client.DownloadString(fileLink_);
                // Write All Json Content to the file as String
                File.WriteAllText(contentRootPath, jsonFileContent);
                //// Over write the Existing File with the new one
                //File.Replace(contentRootPath, contentRootPath, backupFile);
            }
        }
        // Function To Remove Special Characters From File GUID
        public string ReplaceSpecialCharInFileGuidForEmptyFile(string fileGuid_)
        {
            return fileGuid_.Replace(":", "_").Replace(" ", "").Replace("/", "_") + ".txt";
        }
    }
}
