using SwaggerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerAPI.Repository
{
    public interface IStarWars : IRepositoryBase<People>
    {
        Task<People> GetAllPeople();
    }
}
