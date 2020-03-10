using DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO.Mappings
{
    public class EquipeMapConfig : IEntityTypeConfiguration<EquipeDTO>
    {
        public void Configure(EntityTypeBuilder<EquipeDTO> builder)
        {
            builder.ToTable("EQUIPES");
            builder.Property(c => c.Gennin1).HasMaxLength(50).IsRequired().IsUnicode(false);
            builder.Property(c => c.Gennin2).HasMaxLength(50).IsRequired().IsUnicode(false);
            builder.Property(c => c.Gennin3).HasMaxLength(50).IsRequired().IsUnicode(false);
            builder.Property(c => c.Jounnin).HasMaxLength(50).IsRequired().IsUnicode(false);

        }
    }
}
