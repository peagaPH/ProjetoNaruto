using DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO.Mappings
{
    class EquipeMapConfig : IEntityTypeConfiguration<EquipeDTO>
    {
        public void Configure(EntityTypeBuilder<EquipeDTO> builder)
        {
            builder.ToTable("EQUIPES");
            builder.Property(c => c.Nome).HasMaxLength(50).IsRequired().IsUnicode(false);

        }
    }
}
