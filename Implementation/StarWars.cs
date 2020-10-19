using Newtonsoft.Json;
using SwaggerAPI.Models;
using SwaggerAPI.Repository;
using SwaggerAPI.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerAPI.Implementation
{
    public class StarWars : IStarWars
    {
        public async Task<IEnumerable<People>> GetAll()
        {
            var callswapi = await SD.GetStringAsync(SD.baseUrlSwapi + "people/");
            var people = JsonConvert.DeserializeObject<IEnumerable<People>>(callswapi);
            return people;
        }

        public async Task<People> GetAllPeople()
        {
            var callswapi = await SD.GetStringAsync(SD.baseUrlSwapi + "people/");
            var people = JsonConvert.DeserializeObject<People>(callswapi);
            return people;
        }
    }
}
