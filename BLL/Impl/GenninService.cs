using BLL.Impl;
using BLL.Interfaces;
using Common;
using DAO;
using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace BLL
{
    public class GenninService : BaseService, IGenninService
    {
        public async Task<List<GenninDTO>> GetGennins()
        {
            try
            {
                using (ChuninContext context = new ChuninContext())
                {
                    return await context.Gennins.ToListAsync();
                }
            }
            catch (Exception ex)
            {
                File.WriteAllText("log.txt", ex.Message + " - " + ex.StackTrace);
                throw new Exception("Erro no banco de dados, contate o administrador");
            }
        }

        public async Task Insert(GenninDTO gennin)
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

            if (string.IsNullOrWhiteSpace(gennin.Idade))
            {
                base.AddError("Idade", "Idade do ninja deve ser informada.");
            }
            else if (gennin.Idade.Length < 7)
            {
                base.AddError("Idade", "O ninja deve conter pelo menos 7 anos.");
            }
            base.CheckErrors();

            //APÓS VALIDAR TODOS OS CAMPOS, VERIFIQUE SE POSSUIMOS ERROS

            try
            {
                using (ChuninContext context = new ChuninContext())
                {
                    context.Gennins.Add(gennin);
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
