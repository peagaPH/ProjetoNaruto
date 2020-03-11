using BLL.Interfaces;
using DAO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Impl
{
    public class KageService : BaseService, IKageService
    {
        private ChuninContext _context;
        public KageService(ChuninContext ctx)
        {
            this._context = ctx;
        }

        public async Task<List<KageDTO>> GetGennins()
        {
            try
            {
                return await _context.Gennins.ToListAsync();
            }
            catch (Exception ex)
            {
                File.WriteAllText("log.txt", ex.Message + " - " + ex.StackTrace);
                throw new Exception("Erro no banco de dados, contate o administrador");
            }
        }

        public async Task Insert(KageDTO gennin)
        {
            List<Error> errors = new List<Error>();

            if (string.IsNullOrWhiteSpace(gennin.Nome))
            {
                base.AddError("Nome", "Nome do ninja deve ser informado.");
            }
            else if (gennin.Nome.Length < 5 || gennin.Nome.Length > 50)
            {
                base.AddError("Nome", "O nome deve conter entre 3 e 50 caracteres.");
            }

            if (string.IsNullOrWhiteSpace(gennin.Senha))
            {
                base.AddError("Idade", "Idade do ninja deve ser informada.");
            }
            else if (Convert.ToInt32(gennin.Senha) < 7)
            {
                base.AddError("Idade", "O ninja deve conter pelo menos 7 anos.");
            }
            base.CheckErrors();

            //APÓS VALIDAR TODOS OS CAMPOS, VERIFIQUE SE POSSUIMOS ERROS

            try
            {
                _context.Gennins.Add(gennin);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                File.WriteAllText("log.txt", ex.Message + " - " + ex.StackTrace);
                throw new Exception("Erro no banco de dados, contate o admnistrador.");
            }

        }
}
