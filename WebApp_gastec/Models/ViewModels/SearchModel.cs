using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_gastec.Models
{
    public class SearchModel
    {
        public string keyWord_ { get; set; }
        public List<SearchClassFicationTreeModel> ListClassFicationTree { get; set; }
        public List<SearchListNewsModel> ListNews { get; set; }
        public List<SearchListVideosModel> ListVideos { get; set; }
    }
}
