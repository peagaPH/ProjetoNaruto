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
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ESTACIONAMENTODB_ef62ac46ce0642bdb42d9f59ded55587;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<GenninDTO> Gennins { get; set; }
        public DbSet<EquipeDTO> Equipes { get; set; }
        public DbSet<JounninDTO> Jounnins { get; set; }

        

    }
}
