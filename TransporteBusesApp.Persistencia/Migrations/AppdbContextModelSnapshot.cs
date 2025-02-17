﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TransporteBusesApp.Persistencia;

namespace TransporteBusesApp.Persistencia.Migrations
{
    [DbContext(typeof(AppdbContext))]
    partial class AppdbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TransporteBusesApp.Dominio.Buses", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("kilometraje")
                        .HasColumnType("int");

                    b.Property<string>("marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("modelo")
                        .HasColumnType("int");

                    b.Property<int>("nro_asientos")
                        .HasColumnType("int");

                    b.Property<string>("placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Buses");
                });

            modelBuilder.Entity("TransporteBusesApp.Dominio.Estaciones", b =>
                {
                    b.Property<int?>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("coord_x")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("coord_y")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Estaciones");
                });

            modelBuilder.Entity("TransporteBusesApp.Dominio.Rutas", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("destinoid")
                        .HasColumnType("int");

                    b.Property<int?>("origenid")
                        .HasColumnType("int");

                    b.Property<int>("tiempo_estimado")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("destinoid");

                    b.HasIndex("origenid");

                    b.ToTable("Rutas");
                });

            modelBuilder.Entity("TransporteBusesApp.Dominio.Rutas", b =>
                {
                    b.HasOne("TransporteBusesApp.Dominio.Estaciones", "destino")
                        .WithMany()
                        .HasForeignKey("destinoid");

                    b.HasOne("TransporteBusesApp.Dominio.Estaciones", "origen")
                        .WithMany()
                        .HasForeignKey("origenid");

                    b.Navigation("destino");

                    b.Navigation("origen");
                });
#pragma warning restore 612, 618
        }
    }
}
