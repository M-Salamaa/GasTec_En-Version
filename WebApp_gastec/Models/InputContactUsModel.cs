using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_gastec.Models
{
    public class InputContactUsModel
    {
        public string SecurityString { get; set; }
        public string ServerIP { get; set; }
        public string DatabaseName { get; set; }
        public string EncryptedEXAppID { get; set; }
        public string EncryptedPageURL { get; set; }
        public string ClientIPAddress { get; set; }
        public string Subject { get; set; }
        public string RequestDetails { get; set; }
        public string SecurityDetails { get; set; }
    }
}
