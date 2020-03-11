using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Interfaces
{
    public interface IKageRepository
    {
        Task Create(KageDTO kages);
        Task<List<KageDTO>> GetKages();
    }
}
