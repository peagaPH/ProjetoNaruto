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
        public async Task<List<EquipeDTO>> GetEquipes()
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

            if (string.IsNullOrWhiteSpace(equipe.Gennin1))
            {
                base.AddError("Nome", "Nome da equipe deve ser informado");
            }
            else if (equipe.Gennin1.Length < 5 || equipe.Gennin1.Length > 50)
            {
                base.AddError("Nome", "O nome deve conter entre 3 e 50 caracteres");
            }

            if (string.IsNullOrWhiteSpace(equipe.Gennin2))
            {
                base.AddError("Nome", "Nome da equipe deve ser informado");
            }
            else if (equipe.Gennin2.Length < 5 || equipe.Gennin2.Length > 50)
            {
                base.AddError("Nome", "O nome deve conter entre 3 e 50 caracteres");
            }

            if (string.IsNullOrWhiteSpace(equipe.Gennin3))
            {
                base.AddError("Nome", "Nome da equipe deve ser informado");
            }
            else if (equipe.Gennin3.Length < 5 || equipe.Gennin3.Length > 50)
            {
                base.AddError("Nome", "O nome deve conter entre 3 e 50 caracteres");
            }

            if (string.IsNullOrWhiteSpace(equipe.Jounnin))
            {
                base.AddError("Nome", "Nome da equipe deve ser informado");
            }
            else if (equipe.Jounnin.Length < 5 || equipe.Jounnin.Length > 50)
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
