using PaloZombies.Shared.Models.CollectionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaloZombies.Client.Helpers
{
    public static class Extensions
    {
        public static string GetUrlParametersFromPage(Page page)
        {
            string urlToReturn = "Size=10";
            if (page == null)
                return urlToReturn;
            if (page.Number != 0)
                urlToReturn = urlToReturn + "&TotalElements=" + page.TotalElements.ToString();

            urlToReturn = urlToReturn + "&TotalPages=" + page.TotalPages.ToString();
            urlToReturn = urlToReturn + "&Number=" + page.Number.ToString();
            return urlToReturn;
        }

        public static string GetUrlParameterFromLevelOfPain(int painlevel)
        {
            return $"LevelOfPain={painlevel}";
        }
    }
}
