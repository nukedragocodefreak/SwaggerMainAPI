using SwaggerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerAPI.Repository
{
    public interface ISearch
    {
        Task<object> SearchData(SearchData searchData);
    }
}
