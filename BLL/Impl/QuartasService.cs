using BLL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Impl
{
    public class QuartasService : BaseService, IQuartasService
    {
        public Task Insert(QuartasDTO cliente)
        {
            throw new NotImplementedException();
        }

        public Task<List<QuartasDTO>> GetEquipes()
        {
            throw new NotImplementedException();
        }
    }
}
