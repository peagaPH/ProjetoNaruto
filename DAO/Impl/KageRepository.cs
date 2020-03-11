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
        public async Task Create(KageDTO kages)
        {
            _context.Kages.Add(kages);
            await _context.SaveChangesAsync();
        }

        public async Task<List<KageDTO>> GetKages()
        {
            return await _context.Kages.ToListAsync();
        }
    }
}
