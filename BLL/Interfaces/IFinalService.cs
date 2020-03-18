using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IFinalService
    {
        Task Insert(FinalDTO cliente);
        Task<List<FinalDTO>> GetEquipes();
    }
}
