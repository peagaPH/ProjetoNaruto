using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Interfaces
{
    public interface IEquipeRepository
    {
        Task Create(EquipeDTO equipes);
        Task<List<EquipeDTO>> GetEquipes();
    }
}
