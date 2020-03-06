using DAO.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class GenninRepository : IGenninRepository
    {
        public Task Create(GenninDTO jounnin)
        {
            throw new NotImplementedException();
        }

        public Task<List<GenninDTO>> GetGennins()
        {
            throw new NotImplementedException();
        }
    }
}
