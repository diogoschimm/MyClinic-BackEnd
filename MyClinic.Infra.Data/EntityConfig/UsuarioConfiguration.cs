using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyClinic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyClinic.Infra.Data.EntityConfig
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.UsuarioId);
            builder.Property(u => u.Papel).HasField("idFuncao");
        }
    }
}
