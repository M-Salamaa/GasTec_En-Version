using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_gastec.Models
{
    public class InputHomePageViewModel
    {
        public string encryptedMajorTreeID { get; set; }
        public InputGetClassificationTreeModel Input_MainNavigationBar { get; set; }
        public InputGetClassificationTreeModel Input_BannersHome { get; set; }
        public InputGetClassificationTreeModel Input_GastechNumbers { get; set; }
        public InputGetClassificationTreeModel Input_MidSection { get; set; }
        public InputGetClassificationTreeModel Input_MidBanner { get; set; }
        public InputGetClassificationTreeModel Input_MapFiles { get; set; }
        public InputGetClassificationTreeModel Input_HR { get; set; }
        public InputGetClassificationTreeModel Main_Section { get; set; }
        public InputGetClassificationTreeModel Sub_Section { get; set; }
        #region About Us Input Models
        public InputGetClassificationTreeModel Input_AboutUs_MainSection { get; set; }
        #endregion
        #region Vehicles Conversion Input Models
        public InputGetClassificationTreeModel Input_CarConversion_MainSection { get; set; }
        #endregion
        #region Cylindar Test Input Models
        public InputGetClassificationTreeModel Input_CylindarTest_MainSection { get; set; }
        #endregion
        #region Statistics Input Models
        public InputGetClassificationTreeModel Input_Stat_MainSection { get; set; }
        #endregion
        #region Media Center Input Models
        public InputGetClassificationTreeModel Input_MediaCenter { get; set; }
        #endregion
        public OutputGetNewsTopicsModel EniGastech { get; set; }
        public OutputGetNewsTopicsModel NewsSection { get; set; }
        public OutputGetNewsTopicsModel NewsTopics { get; set; }
        public List<OutputGetCities> Cities { get; set; }
        public List<OutPutGetNewsGroupModel> News_Group { get; set; }
        public List<OutputGetNewsDetails> News_Details { get; set; }
        public ContactUsViewModel ContactUs { get; set; }
        public ConversionFormModel Car_Conversion { get; set; }
    }
}
