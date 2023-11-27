﻿using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.IServices
{
    public interface ICarService
    {
        Task<IEnumerable<Car>> GetAll();
    }
}
