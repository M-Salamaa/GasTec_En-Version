using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_gastec.Models
{
    public class ListWebSectionModel
    {
        public int WebSectionID { get; set; }
        public string WebSectionTitle { get; set; }
        public string DisplayOrder { get; set; }
        public int IsHTML { get; set; }
        public string ActionURL { get; set; }
        public string ToolTip { get; set; }
        public string WebSection_HTM_Link { get; set; }
        public string WebSection_PlainText { get; set; }
        public List<LstImageModel> LstImages { get; set; }
        public string HTML_GUID { get; set; }
        public int EntityType { get; set; }
        public int EntityID { get; set; }
        public string Style { get; set; }
        public string Body { get; set; }
    }
}
