using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IQuartasService
    {
        Task Insert(QuartasDTO cliente);
        Task<List<QuartasDTO>> GetEquipes();
    }
}
