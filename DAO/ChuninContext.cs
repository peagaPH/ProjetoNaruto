using DAO.Mappings;
using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                entityType.GetForeignKeys()
                    .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade)
                    .ToList()
                    .ForEach(fk => fk.DeleteBehavior = DeleteBehavior.Restrict);
                entityType.GetProperties().Where(c => c.ClrType == typeof(string)).ToList().ForEach(p => p.SetIsUnicode(false));
            }
            modelBuilder.ApplyConfiguration(new EquipeMapConfig());
            modelBuilder.ApplyConfiguration(new GenninMapConfig());
            modelBuilder.ApplyConfiguration(new JounninMapConfig());
            modelBuilder.ApplyConfiguration(new KageMapConfig());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<GenninDTO> Gennins { get; set; }
        public DbSet<EquipeDTO> Equipes { get; set; }
        public DbSet<JounninDTO> Jounnins { get; set; }
        public DbSet<KageDTO> Kages { get; set; }
        public DbSet<BatalhaDTO> Batalhas { get; set; }



    }
}
