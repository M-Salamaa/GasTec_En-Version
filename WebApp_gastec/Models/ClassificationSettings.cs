using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_gastec.Models
{
    public class ClassificationSettings
    {
        public int ShowShortDescription { get; set; }
        public int ShowClassificationDescriptionPlain { get; set; }
        public int ShowImages { get; set; }
        public int ShowFeaturedImagesOnly { get; set; }
        public int ShowImageDescriptionPlain { get; set; }
        public int ShowWebSections { get; set; }
        public int ShowFiles { get; set; }
        public int ShowFilesOnlineDescriptionPlain { get; set; }
        public int PageNumber { get; set; }
        public int ResultCount { get; set; }
    }
}
