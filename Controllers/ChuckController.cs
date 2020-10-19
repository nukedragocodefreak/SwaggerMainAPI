using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SwaggerAPI.Models;
using SwaggerAPI.Models.Data;
using System.Threading.Tasks;
using SwaggerAPI.Repository;

namespace SwaggerAPI.Controllers
{
    //api/chuck
     [Produces("application/json")]
     [Route("api/[controller]/categories")]
     [ApiController]
    public class ChuckController : ControllerBase
    {
        private readonly UseRepo _repository = new UseRepo();
        private readonly IChuckNorris _requestService;
        public ChuckController(IChuckNorris requestService)
        {
            _requestService = requestService;
        }
        [HttpGet]
        public async Task<Categories> GetCategories()
         {
             var _categories = await _requestService.GetAllCategories();
             return (_categories);
         }
    }
}