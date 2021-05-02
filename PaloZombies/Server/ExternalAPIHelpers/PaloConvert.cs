using PaloZombies.Shared.Models.CollectionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaloZombies.Server.ExternalAPIHelpers
{
    public static class PaloConvert
    {
        public static string ConvertPageToAPIString(Page page)
        {
            string urlToReturn = "";

            if (page == null)
                return urlToReturn;

            urlToReturn = $"?limit={(page.Size==0?10:page.Size)}&page={page.Number}";
            return urlToReturn;
        }
    }
}
