using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Interfaces
{
    public interface IGenninRepository
    {
        Task Create(GenninDTO jounnin);
        Task<List<GenninDTO>> GetGennins();
    }
}
