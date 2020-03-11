using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    interface IKageService
    {
        Task Insert(KageDTO kage);
        Task<List<KageDTO>> GetKages();

    }
}
