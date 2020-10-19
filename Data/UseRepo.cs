using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SwaggerAPI.Models.Data
{
    public class UseRepo : Repo
    {
         private static string baseUrlChuck = "https://api.chucknorris.io/jokes/";
         private static string baseUrlSwapi = "https://swapi.dev/api/";
          
         public async Task<object> GetCategories()
         {
             var callchuck = await GetStringAsync(baseUrlChuck + "categories/" );
            // Here I use Newtonsoft.Json to deserialize JSON string to User object
             var categories = JsonConvert.DeserializeObject<object>(callchuck);
             return categories;
         }
         public async Task<object> GetPeople()
         {
             var callswapi = await GetStringAsync(baseUrlSwapi + "people/" );
            // Here I use Newtonsoft.Json to deserialize JSON string to User object
             var people = JsonConvert.DeserializeObject<object>(callswapi);
            return people;
         }

        public async Task<object> Search(SearchData searchData)
        {
            var call_chuck = await GetStringAsync(baseUrlChuck + "categories/" + searchData.q_category);
            var call_swapi = await GetStringAsync(baseUrlSwapi + "people/" + searchData.q_people );
            // Here I use Newtonsoft.Json to deserialize JSON string to User object
            var people = JsonConvert.DeserializeObject<object>(call_swapi);
            var categories = JsonConvert.DeserializeObject<object>(call_chuck);

            //Create an object
            var results = new
            {
                Chuck = call_chuck,
                Swapi = call_swapi
            }; 
            //Tranform it to Json object
            var chuck_swapi = JsonConvert.SerializeObject(results);
            return chuck_swapi;
        }
         private static async Task<string> GetStringAsync(string url)
    {
        using (var httpClient = new HttpClient())
        {
            return await httpClient.GetStringAsync(url);
        }
    }
    }
}