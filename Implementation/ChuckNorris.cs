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
    public class ChuckNorris : IChuckNorris
    {
        public async Task<IEnumerable<Categories>> GetAll()
        {
            var categories = new List<Categories>();
            categories = new List<Categories>();
            var callchuck = await SD.GetStringAsync(SD.baseUrlChuck + "categories/");
            var listcategories = JsonConvert.DeserializeObject<object>(callchuck);
            string[] propertyNames = listcategories.GetType().GetProperties().Select(p => p.Name).ToArray();
            foreach (var prop in propertyNames)
            {
                //categories.Category.Add(prop);
            }
            return categories;
        }
        public async Task<Categories> GetAllCategories()
        {
            var categories = new Categories();
            categories.Category = new List<string>();
            var callchuck = await SD.GetStringAsync(SD.baseUrlChuck + "categories/");
            var listcategories = JsonConvert.DeserializeObject<object>(callchuck);
            string[] propertyNames = listcategories.GetType().GetProperties().Select(p => p.Name).ToArray();
            foreach (var prop in propertyNames)
            {
                categories.Category.Add(prop);
            }
            return categories;
        }

    }
}
