using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_gastec.Models
{
    public class LstChildClassificationModel
    {
        public int ClassificationID { get; set; }
        public string ClassificationName { get; set; }
        public int TreeLevel { get; set; }
        public string ShortDescription { get; set; }
        public string Classification_HTMLLink { get; set; }
        public string HTML_GUID { get; set; }
        public int DisplayOrder { get; set; }
        public List<object> LstCategories { get; set; }
        public List<ListWebSectionModel> LstWebSections { get; set; }
        public List<LstImageModel> LstImages { get; set; }
        public List<LstFile> LstFiles { get; set; }
        public List<LstChildClassificationModel> LstChildClassification { get; set; }
        public bool IsActive { get; set; }

    }
}
