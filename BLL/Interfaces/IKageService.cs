using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IKageService
    {
        Task Insert(KageDTO kage);
        Task<KageDTO> Autenticar(string nome, string senha);


    }
}
