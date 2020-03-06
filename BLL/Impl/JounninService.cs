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
        public async Task<List<JounninDTO>> GetData()
        {
            try
            {
                using (ChuninContext context = new ChuninContext())
                {
                    return await context.Jounnins.ToListAsync();
                }
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
                using (ChuninContext context = new ChuninContext())
                {
                    context.Jounnins.Add(jounnin);
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
