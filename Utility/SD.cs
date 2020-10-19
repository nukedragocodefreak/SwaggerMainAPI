using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SwaggerAPI.Utility
{
    public static class SD
    {
        public static string baseUrlChuck = "https://api.chucknorris.io/jokes/";
        public static string baseUrlSwapi = "https://swapi.dev/api/";

        public static async Task<string> GetStringAsync(string url)
        {
            using (var httpClient = new HttpClient())
            {
                return await httpClient.GetStringAsync(url);
            }
        }
    }
}
