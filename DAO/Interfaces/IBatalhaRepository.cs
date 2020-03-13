using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Interfaces
{
    public interface IBatalhaRepository
    {
        Task Insert(BatalhaDTO batalha);
        Task<List<BatalhaDTO>> GetBatalhas();
    }
}
