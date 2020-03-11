using DAO.Interfaces;
using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class EquipeRepository : IEquipeRepository
    {

        private ChuninContext _context;
        public EquipeRepository(ChuninContext ctx)
        {
            this._context = ctx;
        }

        public async Task Create(EquipeDTO equipes)
        {
            _context.Equipes.Add(equipes);
            await _context.SaveChangesAsync();
        }

        public async Task<List<EquipeDTO>> GetEquipes()
        {
            return await _context.Equipes.ToListAsync();
        }
    }
}
