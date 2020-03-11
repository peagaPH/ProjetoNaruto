using DAO.Interfaces;
using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class JounninRepository : IJounninRepository
    {
        private ChuninContext _context;
        public JounninRepository(ChuninContext ctx)
        {
            this._context = ctx;
        }
        public async Task Create(JounninDTO jounnin)
        {
                _context.Jounnins.Add(jounnin);
                await _context.SaveChangesAsync();
        }

        public async Task<List<JounninDTO>> GetJounnins()
        {
                return await _context.Jounnins.ToListAsync();
        }
    }
}
