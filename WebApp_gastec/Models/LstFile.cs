using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_gastec.Models
{
    public class LstFile
    {
        public int FileID { get; set; }
        public string FileName { get; set; }
        public int DisplayOrder { get; set; }
        public int FileLinkedID { get; set; }
        public string FileLink { get; set; }
        public string FileGUID { get; set; }
        public string ImageOnlineDescription_HTMLLink { get; set; }
        public bool RenderedAsHTML { get; set; }
        public string HTML_GUID { get; set; }
    }
}
