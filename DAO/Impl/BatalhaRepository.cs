using DAO.Interfaces;
using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Impl
{
    public class BatalhaRepository : IBatalhaRepository
    {
        private ChuninContext _context;
        public BatalhaRepository(ChuninContext ctx)
        {
            this._context = ctx;
        }

        public async Task<List<BatalhaDTO>> GetBatalhas()
        {
            return await _context.Batalhas.ToListAsync();
        }

        public async Task Insert(BatalhaDTO batalha)
        {
            _context.Batalhas.Add(batalha);
            await _context.SaveChangesAsync();
        }
    }

}
