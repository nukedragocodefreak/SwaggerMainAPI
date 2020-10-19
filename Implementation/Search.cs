using Newtonsoft.Json;
using SwaggerAPI.Models;
using SwaggerAPI.Repository;
using SwaggerAPI.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SwaggerAPI.Implementation
{
    public class Search : ISearch
    {
        public async Task<object> SearchData(SearchData searchData)
        {
            var call_chuck = await SD.GetStringAsync(SD.baseUrlChuck + "categories/" + searchData.q_category);
            var call_swapi = await SD.GetStringAsync(SD.baseUrlChuck + "people/" + searchData.q_people);
            var people = JsonConvert.DeserializeObject<object>(call_swapi);
            var categories = JsonConvert.DeserializeObject<object>(call_chuck);

            var results = new
            {
                Chuck = call_chuck,
                Swapi = call_swapi
            };

            var chuck_swapi = JsonConvert.SerializeObject(results);
            return chuck_swapi;
        }
       
    }
}
