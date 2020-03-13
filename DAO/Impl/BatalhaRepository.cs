using DAO.Interfaces;
using DTO;
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
        public  Task<List<BatalhaDTO>> GetBatalhas()
        {
            throw new NotImplementedException();
        }

        public async Task Insert(BatalhaDTO batalha)
        {
            _context.Batalhas.Add(batalha);
            await _context.SaveChangesAsync();
        }
    }

}
