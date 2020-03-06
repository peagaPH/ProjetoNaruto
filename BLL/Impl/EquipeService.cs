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
        public async Task<List<EquipeDTO>> GetData()
        {
            try
            {
                using (ChuninContext context = new ChuninContext())
                {
                    return await context.Equipes.ToListAsync();
                }
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

            //APÓS VALIDAR TODOS OS CAMPOS, VERIFIQUE SE POSSUIMOS ERROS
            base.CheckErrors();
            try
            {
                using (ChuninContext context = new ChuninContext())
                {
                    context.Equipes.Add(equipe);
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                File.WriteAllText("log.txt", ex.Message + " - " + ex.StackTrace);
                throw new Exception("Erro no banco de dados, contate o admnistrador.");
            }
        }
    }
}
