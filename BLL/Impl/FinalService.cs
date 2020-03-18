using BLL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Impl
{
    public class FinalService : BaseService, IFinalService
    {
        public Task Insert(FinalDTO cliente)
        {
            throw new NotImplementedException();
        }

        public Task<List<FinalDTO>> GetEquipes()
        {
            throw new NotImplementedException();
        }
    }
}
