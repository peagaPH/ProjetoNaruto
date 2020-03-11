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
    public class JounninService : BaseService, IJounninService
    {
        private ChuninContext _context;
        public JounninService(ChuninContext ctx)
        {
            this._context = ctx;
        }
        public async Task<List<JounninDTO>> GetJounnin()
        {
            try
            {
                    return await _context.Jounnins.ToListAsync();
            }
            catch (Exception ex)
            {
                File.WriteAllText("log.txt", ex.Message + " - " + ex.StackTrace);
                throw new Exception("Erro no banco de dados, contate o administrador");
            }
        }

        public async Task Insert(JounninDTO jounnin)
        {
            List<Error> errors = new List<Error>();

            if (string.IsNullOrWhiteSpace(jounnin.Nome))
            {
                base.AddError("Nome", "Nome do Jounnin deve ser informado.");
            }
            else if (jounnin.Nome.Length < 5 || jounnin.Nome.Length > 50)
            {
                base.AddError("Nome", "O nome deve conter entre 3 e 50 caracteres.");
            }
            try
            {
                    _context.Jounnins.Add(jounnin);
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
