using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_gastec.Models
{
    public class ListNewsModel
    {
        public int Serial { get; set; }
        public int EXAppID { get; set; }
        public int NewsPriority { get; set; }
        public int GroupID { get; set; }
        public string NewsTitle { get; set; }
        public DateTime TopicDate { get; set; }
        public int AllowComments { get; set; }
        public int AllowInteractions { get; set; }
        public string ShortDescription { get; set; }
        public string ImageLink { get; set; }
        public string ImageGUID { get; set; }
        public bool IsActive { get; set; }
    }
}
