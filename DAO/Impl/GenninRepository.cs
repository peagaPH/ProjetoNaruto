using DAO.Interfaces;
using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class GenninRepository : IGenninRepository
    {
        private ChuninContext _context;
        public GenninRepository(ChuninContext ctx)
        {
            this._context = ctx;
        }
        public async Task Create(GenninDTO gennin)
        {
                _context.Gennins.Add(gennin);
                await _context.SaveChangesAsync();
        }

        public async Task<List<GenninDTO>> GetGennins()
        {
                return await _context.Gennins.ToListAsync();
        }
    }
}
