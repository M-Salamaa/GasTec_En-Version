using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_gastec.Models
{
    public class OutputGetNewsDetails
    {
        public int Serial { get; set; }
        public int EXAppID { get; set; }
        public int GroupID { get; set; }
        public string NewsTitle { get; set; }
        public DateTime TopicDate { get; set; }
        public string Description { get; set; }
        public List<LstImageModel> LstImages { get; set; }
        public string NewsTopic_HTMLLink { get; set; }
        public string Topic_Name { get; set; }
        public string body { get; set; }
    }

}
