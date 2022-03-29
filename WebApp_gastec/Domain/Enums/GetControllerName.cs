namespace WebApp_gastec.Domain
{
    public static class GetControllerName
    {
        public static string GetControllerNameByParentID(string parentID_)
        {
            string controllerName = "";
            switch (parentID_)
            {
                case "125":
                    controllerName = "About";
                    break;
                case "3":
                    controllerName = "Car_Conversion";
                    break;
                case "4":
                    controllerName = "Catering_Stations";
                    break;
                case "5":
                    controllerName = "Cylindar_Test";
                    break;
                case "6":
                    controllerName = "Oil";
                    break;
                case "7":
                    controllerName = "Statistics";
                    break;
                case "28":
                    controllerName = "Catering_Stations";
                    break;
                case "50":
                    controllerName = "MediaCenter";
                    break;
                case "51":
                    controllerName = "MediaCenter";
                    break;
                case "56":
                    controllerName = "MediaCenter";
                    break;
                case "57":
                    controllerName = "MediaCenter";
                    break;
                case "58":
                    controllerName = "MediaCenter";
                    break;
                default:
                    controllerName = "Home";
                    break;
            }
            return controllerName;
        }
    }
}
