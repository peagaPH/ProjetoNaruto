using BLL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Impl
{
    class JounninService : BaseService, IJounninService
    {
        public Task<List<JounninDTO>> GetData()
        {
            throw new NotImplementedException();
        }

        public Task Insert(JounninDTO cliente)
        {
            throw new NotImplementedException();
        }
    }
}
