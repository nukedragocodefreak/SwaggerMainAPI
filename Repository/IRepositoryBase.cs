﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerAPI.Repository
{
    public interface IRepositoryBase<T> where T : class
    {
        Task< IEnumerable<T>> GetAll();
    }
}
