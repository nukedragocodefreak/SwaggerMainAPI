using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwaggerAPI.Models;
using SwaggerAPI.Models.Data;
using SwaggerAPI.Repository;

namespace SwaggerAPI.Controllers
{
    //api/swapi
    [Produces("application/json")]
    [Route("api/[controller]/people")]
    [ApiController]
    public class SwapiController : ControllerBase
    {
        private readonly UseRepo _repository = new UseRepo();
        private readonly IStarWars _requestService;
        public SwapiController(IStarWars requestService)
        {
            _requestService = requestService;
        }
        [HttpGet]
          public async Task<People> GetPeople()
         {           
             var _people = await _requestService.GetAllPeople();
             return (_people);
         }
    }
}