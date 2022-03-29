using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using WebApp_gastec.Models;

namespace WebApp_gastec.Domain
{
    public class Service
    {
        private static string FirstSalt = "*&*$(#-j90";
        private static string SecondSalt = "($34#45(*)";
        public static string Encrypt(string TextToEncrypt_)
        {
            var ByteX = Encoding.ASCII.GetBytes(FirstSalt + TextToEncrypt_ + SecondSalt);
            return Convert.ToBase64String(ByteX);
        }
        public static string Decrypt(string TextToDecrypt_)
        {
            try
            {
                var ByteX = Convert.FromBase64String(TextToDecrypt_);
                return Encoding.ASCII.GetString(ByteX).Replace(FirstSalt, "").Replace(SecondSalt, "");
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        // Function To get sub string between two words in string
        public string Between(string STR, string FirstString, string LastString)
        {
            string FinalString;
            int Pos1 = STR.IndexOf(FirstString) + FirstString.Length;
            int Pos2 = STR.IndexOf(LastString);
            FinalString = STR.Substring(Pos1, Pos2 - Pos1);
            return FinalString;
        }
        // Function To Read Files and Return Body Tags
        public static string ReadFileAsStringForBody(string fuulPath_)
        {

            using (StreamReader reader = new StreamReader(fuulPath_))
            {
                string line = "";
                StringBuilder stringBuilder = new StringBuilder();
                while ((line = reader.ReadLine()) != null)
                {
                    stringBuilder.Append(line);
                }
                string html_Result = stringBuilder.ToString();
                //Final = Between(html_Result, "<body>", "</body>");
                return html_Result;
            }
        }
        // Function To Read Files and Return Style Tags
        public string ReadFileAsStringForStyle(string fuulPath_)
        {
            using (StreamReader reader = new StreamReader(fuulPath_))
            {
                string Final;
                string line = "";
                StringBuilder stringBuilder = new StringBuilder();
                while ((line = reader.ReadLine()) != null)
                {
                    stringBuilder.Append(line);
                }
                string html_Result = stringBuilder.ToString();
                Final = Between(html_Result, "<head>", "</head>");
                return Final;
            }
        }
        // Function to gt Video Image
        public string getYouTubeThumbnail(string YoutubeUrl)
        {
            string youTubeThumb = string.Empty;
            if (YoutubeUrl == "")
                return "";

            if (YoutubeUrl.IndexOf("=") > 0)
            {
                youTubeThumb = YoutubeUrl.Split('=')[1];
            }
            else if (YoutubeUrl.IndexOf("/v/") > 0)
            {
                string strVideoCode = YoutubeUrl.Substring(YoutubeUrl.IndexOf("/v/") + 3);
                int ind = strVideoCode.IndexOf("?");
                youTubeThumb = strVideoCode.Substring(0, ind == -1 ? strVideoCode.Length : ind);
            }
            else if (YoutubeUrl.IndexOf('/') < 6)
            {
                youTubeThumb = YoutubeUrl.Split('/')[3];
            }
            else if (YoutubeUrl.IndexOf('/') > 6)
            {
                youTubeThumb = YoutubeUrl.Split('/')[1];
            }

            return "http://img.youtube.com/vi/" + youTubeThumb + "/default.jpg";
        }

        // Function to Check reCAPTCHA Response and Deserialize it to CaptchaResponseModel 
        public static CaptchaResponseViewModel IsValid(string captchaResponse)
        {
            // Check if reCAPTCHA Response is Empty
            if (string.IsNullOrWhiteSpace(captchaResponse))
            {
                return new CaptchaResponseViewModel()
                { Success = false };
            }
            //Creating Instance of HTTP Client
            HttpClient client = new HttpClient();
            // Declare the Base Address to the client variable
            client.BaseAddress = new Uri("https://www.google.com");
            // Create Instance to Pass Secret Key and reCAPTCHA Response
            var values = new List<KeyValuePair<string, string>>();
            values.Add(new KeyValuePair<string, string>("secret", SiteSettings.GoogleRecaptchaSecretKey));
            values.Add(new KeyValuePair<string, string>("response", captchaResponse));
            FormUrlEncodedContent content = new FormUrlEncodedContent(values);
            //Posting the content of the Response
            HttpResponseMessage response = client.PostAsync("/recaptcha/api/siteverify", content).Result;
            // Extract the reCAPTCHA Response Result
            string verificationResponse = response.Content.ReadAsStringAsync().Result;
            // Deserialize reCAPTCHA Response to CaptchaResponseModel
            var verificationResult = JsonConvert.DeserializeObject<CaptchaResponseViewModel>(verificationResponse);
            return verificationResult;
        }

    }
}
