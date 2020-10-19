using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerAPI.Models.Data
{
    public interface Repo
    {
         Task<object> GetCategories();
         Task<object> GetPeople();      
         Task<object> Search(SearchData searchData);   
    }
}