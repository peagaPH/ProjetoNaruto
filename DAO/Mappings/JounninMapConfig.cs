using DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO.Mappings
{
    class JounninMapConfig : IEntityTypeConfiguration<JounninDTO>
    {
        public void Configure(EntityTypeBuilder<JounninDTO> builder)
        {
            builder.ToTable("JOUNNINS");
            builder.Property(c => c.Nome).HasMaxLength(50).IsRequired().IsUnicode(false);
        }
    }
}
