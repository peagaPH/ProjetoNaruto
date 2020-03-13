using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IBatalhaService
    {
        Task Insert(BatalhaDTO batalha);
        Task<List<BatalhaDTO>> GetBatalhas();


    }
}
