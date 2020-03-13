using DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO.Mappings
{
    public class BatalhaMapConfig : IEntityTypeConfiguration<BatalhaDTO>
    {
        public void Configure(EntityTypeBuilder<BatalhaDTO> builder)
        {
            builder.ToTable("BATALHAS");
        }
    }
}
