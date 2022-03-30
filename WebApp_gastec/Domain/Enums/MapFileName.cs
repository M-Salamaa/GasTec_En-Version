using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_gastec.Domain
{
    public class MapFileName
    {
        public static string GetMApFileName(int fileID_)
        {
            string fileName = "";
            if (Gastech_Vault.TranslationLanguageID == 0)
            {
                switch (fileID_)
                {

                    case 245:
                        fileName = "convert-centers.json";
                        break;
                    case 256:
                        fileName = "cylinder-test.json";
                        break;
                    case 257:
                        fileName = "gas-station.json";
                        break;
                    case 258:
                        fileName = "oil-distribution.json";
                        break;
                    case 259:
                        fileName = "petrol-station.json";
                        break;
                }
            }
            else
            {
                switch(fileID_)
                {
                    case 260:
                        fileName = "convert-centers.json";
                        break;
                    case 261:
                        fileName = "cylinder-test.json";
                        break;
                    case 262:
                        fileName = "gas-station.json";
                        break;
                    case 263:
                        fileName = "oil-distribution.json";
                        break;
                    case 264:
                        fileName = "petrol-station.json";
                        break;
                }
            }
            return fileName;

        }
    }
}
