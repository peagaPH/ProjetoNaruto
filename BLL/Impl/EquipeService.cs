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

        public Task Insert(EquipeDTO equipe)
        {
            List<Error> errors = new List<Error>();

            if (string.IsNullOrWhiteSpace(equipe.))
            {
                base.AddError("Nome", "Nome deve ser informado");
            }
            else if (cliente.Nome.Length < 5 || cliente.Nome.Length > 50)
            {
                base.AddError("Nome", "O nome deve conter entre 5 e 50 caracteres");
            }

            //APÓS VALIDAR TODOS OS CAMPOS, VERIFIQUE SE POSSUIMOS ERROS
            base.CheckErrors();
            try
            {
                using (SSContext context = new SSContext())
                {
                    context.Clientes.Add(cliente);
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
