﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SEyGRE.Models
{
    public partial class seygreContext : DbContext
    {
        private readonly string connectionString;
        public seygreContext(string _connectionString)
        {
            connectionString = _connectionString;
        }

        public seygreContext(DbContextOptions<seygreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<Centrosacopio> Centrosacopio { get; set; }
        public virtual DbSet<Clasificacion> Clasificacion { get; set; }
        public virtual DbSet<Elementos> Elementos { get; set; }
        public virtual DbSet<Estatus> Estatus { get; set; }
        public virtual DbSet<Etapas> Etapas { get; set; }
        public virtual DbSet<Eventos> Eventos { get; set; }
        public virtual DbSet<Modificaciones> Modificaciones { get; set; }
        public virtual DbSet<Noticias> Noticias { get; set; }
        public virtual DbSet<Personal> Personal { get; set; }
        public virtual DbSet<Procesoreciclado> Procesoreciclado { get; set; }
        public virtual DbSet<Residuos> Residuos { get; set; }
        public virtual DbSet<Tipousuario> Tipousuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cargo>(entity =>
            {
                entity.ToTable("cargo");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripccion)
                    .HasColumnName("descripccion")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<Centrosacopio>(entity =>
            {
                entity.ToTable("centrosacopio");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Correo)
                    .HasColumnName("correo")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Documento)
                    .HasColumnName("documento")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.IdEstatus)
                    .HasColumnName("idEstatus")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdTipoUsuario)
                    .HasColumnName("idTipoUsuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Imagen)
                    .HasColumnName("imagen")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Latitud).HasColumnName("latitud");

                entity.Property(e => e.Longitud).HasColumnName("longitud");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Usuario)
                    .HasColumnName("usuario")
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<Clasificacion>(entity =>
            {
                entity.ToTable("clasificacion");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripccion)
                    .HasColumnName("descripccion")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Titulo)
                    .HasColumnName("titulo")
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<Elementos>(entity =>
            {
                entity.ToTable("elementos");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.Descripccion)
                    .HasColumnName("descripccion")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Porcentaje).HasColumnName("porcentaje");
            });

            modelBuilder.Entity<Estatus>(entity =>
            {
                entity.ToTable("estatus");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripccion)
                    .HasColumnName("descripccion")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Titulo)
                    .HasColumnName("titulo")
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<Etapas>(entity =>
            {
                entity.ToTable("etapas");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripccion)
                    .HasColumnName("descripccion")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<Eventos>(entity =>
            {
                entity.ToTable("eventos");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.HorarioFinal)
                    .HasColumnName("horarioFinal")
                    .HasColumnType("time");

                entity.Property(e => e.HorarioInicio)
                    .HasColumnName("horarioInicio")
                    .HasColumnType("time");

                entity.Property(e => e.IdCentroAcopio)
                    .HasColumnName("idCentroAcopio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEstatus)
                    .HasColumnName("idEstatus")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Latitud).HasColumnName("latitud");

                entity.Property(e => e.Longitud).HasColumnName("longitud");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Organizador)
                    .HasColumnName("organizador")
                    .HasColumnType("varchar(80)");

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Modificaciones>(entity =>
            {
                entity.ToTable("modificaciones");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Actividad)
                    .HasColumnName("actividad")
                    .HasColumnType("varchar(80)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.IdPersonal)
                    .HasColumnName("idPersonal")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Usuario)
                    .HasColumnName("usuario")
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<Noticias>(entity =>
            {
                entity.ToTable("noticias");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripccion)
                    .HasColumnName("descripccion")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.ImagenUrl)
                    .HasColumnName("imagenURL")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.NoticiaUrl)
                    .HasColumnName("noticiaURL")
                    .HasColumnType("varchar(500)");
            });

            modelBuilder.Entity<Personal>(entity =>
            {
                entity.ToTable("personal");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Apellidos)
                    .HasColumnName("apellidos")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasColumnType("varchar(90)");

                entity.Property(e => e.Edad)
                    .HasColumnName("edad")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdCargo)
                    .HasColumnName("idCargo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdCentro)
                    .HasColumnName("idCentro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(80)");
            });

            modelBuilder.Entity<Procesoreciclado>(entity =>
            {
                entity.ToTable("procesoreciclado");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Idetapa)
                    .HasColumnName("idetapa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Porcentaje)
                    .HasColumnName("porcentaje")
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<Residuos>(entity =>
            {
                entity.ToTable("residuos");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.IdCentroAcopio)
                    .HasColumnName("idCentroAcopio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdClasificacion)
                    .HasColumnName("idClasificacion")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEtapa)
                    .HasColumnName("idEtapa")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Peso).HasColumnName("peso");
            });

            modelBuilder.Entity<Tipousuario>(entity =>
            {
                entity.ToTable("tipousuario");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripccion)
                    .HasColumnName("descripccion")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)");
            });
        }
    }
}
