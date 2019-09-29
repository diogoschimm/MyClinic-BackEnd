using Microsoft.EntityFrameworkCore;
using MyClinic.Domain.Entities;
using MyClinic.Infra.Data.EntityConfig;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyClinic.Infra.Data.Contexto
{
   public class MyClinicContext : DbContext
    {
        public MyClinicContext(DbContextOptions<MyClinicContext> options) 
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
        }
    }
}
