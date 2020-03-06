using DAO.Interfaces;
using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class GenninRepository : IGenninRepository
    {
        public async Task Create(GenninDTO gennin)
        {
            using (var context = new ChuninContext())
            {
                context.Gennins.Add(gennin);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<GenninDTO>> GetGennins()
        {
            using (var context = new ChuninContext())
            {
                return await context.Gennins.ToListAsync();
            }
        }
    }
}
