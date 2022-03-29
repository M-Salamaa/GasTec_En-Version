using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_gastec.Models
{
    public class InputGetClassificationTreeModel
    {

        public string SecurityString { get; set; }
        public string ServerIP { get; set; }
        public string DatabaseName { get; set; }
        public string EncryptedEXAppID { get; set; }
        public string EncryptedMajorTreeNodeID { get; set; }
        public string EncryptedTreeClassificationID { get; set; }
        public string EncryptedSpecificTreeClassificationID { get; set; }
        public int MaxTreeLevel { get; set; }
        public int TranslationLanguageID { get; set; }
        public ClassificationSettings ClassificationSettings { get; set; }
    }
}
