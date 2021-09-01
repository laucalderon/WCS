﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NEGOCIO;

namespace API.Migrations
{
    [DbContext(typeof(HogwartsContext))]
    [Migration("20210901201630_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "6.0.0-preview.5.21301.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DATOS.Solicitud", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("CasaSolicitada")
                        .HasColumnType("int");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Identificacion")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Solicitudes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellidos = "Lima Barreras",
                            CasaSolicitada = 1,
                            Edad = 18,
                            Identificacion = "136",
                            Nombre = "Carlos"
                        },
                        new
                        {
                            Id = 2,
                            Apellidos = "Isequilla",
                            CasaSolicitada = 2,
                            Edad = 17,
                            Identificacion = "145",
                            Nombre = "Josefina"
                        },
                        new
                        {
                            Id = 3,
                            Apellidos = "Miranda Ramírez",
                            CasaSolicitada = 3,
                            Edad = 20,
                            Identificacion = "150",
                            Nombre = "Pablo"
                        },
                        new
                        {
                            Id = 4,
                            Apellidos = "García Pedroso",
                            CasaSolicitada = 4,
                            Edad = 16,
                            Identificacion = "130",
                            Nombre = "Lidia"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
