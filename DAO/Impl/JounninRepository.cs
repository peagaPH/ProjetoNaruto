using DAO.Interfaces;
using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class JounninRepository : IJounninRepository
    {
        public async Task Create(JounninDTO jounnin)
        {
            using (var context = new ChuninContext())
            {
                context.Jounnins.Add(jounnin);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<JounninDTO>> GetJounnins()
        {
            using (var context = new ChuninContext())
            {
                return await context.Jounnins.ToListAsync();
            }
        }
    }
}
