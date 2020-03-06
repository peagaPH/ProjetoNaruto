using DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO.Mappings
{
    class GenninMapConfig : IEntityTypeConfiguration<GenninDTO>
    {
        public void Configure(EntityTypeBuilder<GenninDTO> builder)
        {
            builder.ToTable("GENNINS");
            builder.Property(c => c.Nome).HasMaxLength(50).IsRequired().IsUnicode(false);
        }
    }
}
