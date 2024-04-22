﻿// <auto-generated />
using System;
using HernanJurado_Progreso1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HernanJurado_Progreso1.Migrations
{
    [DbContext(typeof(HernanJurado_Progreso1Context))]
    [Migration("20240422143139_HJuradoDB")]
    partial class HJuradoDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HernanJurado_Progreso1.Models.Carrera", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Campus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_Carrera")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Semestre")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Carrera");
                });

            modelBuilder.Entity("HernanJurado_Progreso1.Models.Estudiantes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly?>("Fecha")
                        .HasColumnType("date");

                    b.Property<bool?>("Inscrito")
                        .HasColumnType("bit");

                    b.Property<decimal?>("Matricula")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Estudiantes");
                });
#pragma warning restore 612, 618
        }
    }
}