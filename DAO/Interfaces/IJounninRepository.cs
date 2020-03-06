using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Interfaces
{
    public interface IJounninRepository
    {
        Task Create(JounninDTO jounnin);
        Task<List<JounninDTO>> GetJounnins();
    }
}
