using DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO.Mappings
{
    class KageMapConfig : IEntityTypeConfiguration<KageDTO>
    {
        public void Configure(EntityTypeBuilder<KageDTO> builder)
        {
            builder.ToTable("KAGESS");
            builder.Property(c => c.Nome).HasMaxLength(50).IsRequired().IsUnicode(false);
        }
    }
}
