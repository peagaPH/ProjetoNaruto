using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;


namespace DAO
{
    public class ChuninContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                
        }
        public ChuninContext(DbContextOptions<ChuninContext> options) : base(options)
        { 
        
        }
        public ChuninContext()
        {

        }

        public DbSet<GenninDTO> Gennins { get; set; }
        public DbSet<EquipeDTO> Equipes { get; set; }
        public DbSet<JounninDTO> Jounnins { get; set; }

        

    }
}
