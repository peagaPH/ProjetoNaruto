using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ISemiService
    {
        Task Insert(SemiDTO cliente);
        Task<List<SemiDTO>> GetEquipes();
    }
}
