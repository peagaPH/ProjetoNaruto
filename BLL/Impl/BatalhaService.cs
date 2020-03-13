using BLL.Interfaces;
using DAO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Impl
{
    public class BatalhaService : BaseService, IBatalhaService
    {
        private ChuninContext _context;
        public BatalhaService(ChuninContext ctx)
        {
            this._context = ctx;
        }
        public async Task<List<BatalhaDTO>> GetBatalhas()
        {
            throw new NotImplementedException();
        }

        public Task Insert(BatalhaDTO batalha)
        {
            throw new NotImplementedException();
        }
    }
}
