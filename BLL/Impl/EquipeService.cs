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
    public class EquipeService : BaseService, IEquipeService
    {
        private ChuninContext _context;
        public EquipeService(ChuninContext ctx)
        {
            this._context = ctx;
        }

        public async Task<List<EquipeDTO>> GetEquipes()
        {
            try
            {
                    return await _context.Equipes.ToListAsync();
            }
            catch (Exception ex)
            {
                File.WriteAllText("log.txt", ex.Message + " - " + ex.StackTrace);
                throw new Exception("Erro no banco de dados, contate o administrador");
            }
        }

        public async Task Insert(EquipeDTO equipe)
        {
            List<Error> errors = new List<Error>();

            if (string.IsNullOrWhiteSpace(equipe.Nome))
            {
                base.AddError("Nome", "Nome da equipe deve ser informado");
            }
            else if (equipe.Nome.Length < 5 || equipe.Nome.Length > 50)
            {
                base.AddError("Nome", "O nome deve conter entre 3 e 50 caracteres");
            }

            base.CheckErrors();

            try
            {
                    _context.Equipes.Add(equipe);
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
