using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_gastec.Models
{
    public class InputGetMapOfStations
    {
        public string SecurityString { get; set; }
        public string ServerIP { get; set; }
        public string DatabaseName { get; set; }
        public string EncryptedEXAppID { get; set; }
        public string EncryptedLinkedEntityType { get; set; }
        public string EncryptedLinkedEntityID { get; set; }
        public string FileName { get; set; }
        public int GovernorateID { get; set; }
    }
}
