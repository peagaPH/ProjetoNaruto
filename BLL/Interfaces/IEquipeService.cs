using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IEquipeService
    {
        Task Insert(EquipeDTO cliente);
        Task<List<EquipeDTO>> GetEquipes();
    }
}
