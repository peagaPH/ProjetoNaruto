﻿using BLL.Impl;
using BLL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL
{
    public class GenninService : BaseService, IGenninService
    {
        public Task<List<GenninDTO>> GetData()
        {
            throw new NotImplementedException();
        }

        public Task Insert(GenninDTO gennin)
        {
            throw new NotImplementedException();
        }
    }
}
