using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwaggerAPI.Models;
using SwaggerAPI.Models.Data;
using SwaggerAPI.Repository;

namespace SwaggerAPI.Controllers
{
    //api/search
    [Produces("application/json")]
    [Route("api/[controller]")]
     [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly UseRepo _repository = new UseRepo();
        private readonly ISearch _requestService;
        public SearchController(ISearch requestService)
        {
            _requestService = requestService;
        }
        [HttpPost]
          public async Task<object> Search(SearchData searchData)
         {
              var _chuckswapi = await _repository.Search(searchData);
              return (_chuckswapi);
         }
    }
}