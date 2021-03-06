﻿using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IGenninService
    {
        Task Insert(GenninDTO gennin);
        Task<List<GenninDTO>> GetGennins();
    }
}
