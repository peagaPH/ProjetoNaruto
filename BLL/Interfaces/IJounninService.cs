using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IJounninService
    {
        Task Insert(JounninDTO cliente);
        Task<List<JounninDTO>> GetJounnin();
    }
}
