using DATOS;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace NEGOCIO
{
 
    public class HogwartsContext:DbContext
    {
        private readonly IConfiguration Configuration;

        public HogwartsContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("HogwartsDatabase"), b=>b.MigrationsAssembly("API"));
        }

        public DbSet<Solicitud> Solicitudes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // SEEDERS
            modelBuilder.Entity<Solicitud>()
                .HasData(
                new Solicitud 
                     {
                         Id=1,
                         Identificacion = "136",
                         Nombre = "Carlos",
                         Apellidos = "Lima Barreras",
                         Edad = 18,
                         CasaSolicitada = Casa.Gryffindor
                     },
                   new Solicitud
                   {
                         Id = 2,
                         Identificacion = "145",
                         Nombre = "Josefina",
                         Apellidos = "Isequilla",
                         Edad = 17,
                         CasaSolicitada = Casa.Hufflepuff
                     },
                     new Solicitud
                     {
                         Id = 3,
                         Identificacion = "150",
                         Nombre = "Pablo",
                         Apellidos = "Miranda Ramírez",
                         Edad = 20,
                         CasaSolicitada = Casa.Ravenclaw
                     },
                    new Solicitud
                    {
                          Id = 4,
                          Identificacion = "130",
                          Nombre = "Lidia",
                          Apellidos = "García Pedroso",
                          Edad = 16,
                          CasaSolicitada = Casa.Slytherin
                      });
        }
    }
}
