using BLL.Interfaces;
using Common;
using DAO;
using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

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
            try
            {
                return await _context.Batalhas.ToListAsync();
            }
            catch (Exception ex)
            {
                File.WriteAllText("log.txt", ex.Message + " - " + ex.StackTrace);
                throw new Exception("Erro no banco de dados, contate o administrador");
            }
        }

        public async Task Insert(BatalhaDTO batalha)
        {
            List<Error> errors = new List<Error>();

            base.CheckErrors();

            try
            {
                _context.Batalhas.Add(batalha);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                File.WriteAllText("log.txt", ex.Message + " - " + ex.StackTrace);
                throw new Exception("Erro no banco de dados, contate o admnistrador.");
            }
        }
    }
}
