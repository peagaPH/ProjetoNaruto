using DAO.Interfaces;
using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Impl
{
    public class KageRepository : IKageRepository
    {
        private ChuninContext _context;
        public KageRepository(ChuninContext ctx)
        {
            this._context = ctx;
        }
        public async Task<KageDTO> Autenticar(string nome, string senha)
        {
            KageDTO kage = await _context.Kages.FirstOrDefaultAsync(u => u.Nome == nome && u.Senha == senha);

            if (kage == null)
            {
                throw new Exception("Nome e/ou senha inválidos");
            }
            return kage;
        }

        public async Task Create(KageDTO kages)
        {
            _context.Kages.Add(kages);
            await _context.SaveChangesAsync();
        }
    }
}
