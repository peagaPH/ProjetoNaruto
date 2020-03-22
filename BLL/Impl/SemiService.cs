using BLL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Impl
{
    public class SemiService : BaseService, ISemiService
    {
        public Task Insert(SemiDTO cliente)
        {
            throw new NotImplementedException();
        }

        public Task<List<SemiDTO>> GetEquipes()
        {
            throw new NotImplementedException();
        }
    }
}
