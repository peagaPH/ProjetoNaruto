using DAO.Interfaces;
using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class EquipeRepository : IEquipeRepository
    {
        public async Task Create(EquipeDTO equipes)
        {
            using (var context = new ChuninContext())
            {
                context.Equipes.Add(equipes);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<EquipeDTO>> GetEquipes()
        {
            using (var context = new ChuninContext())
            {
                return await context.Equipes.ToListAsync();
            }
        }
    }
}
