﻿// <auto-generated />
using System;
using GT_RT_BackEnd.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GT_RT_BackEnd.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230505171040_Categorias_CLASSE")]
    partial class Categorias_CLASSE
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClassLibrary_GT_RT.Carro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CorridaId_corrida")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CorridaId_corrida");

                    b.ToTable("Carros");
                });

            modelBuilder.Entity("ClassLibrary_GT_RT.Circuito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Circuitos");
                });

            modelBuilder.Entity("ClassLibrary_GT_RT.ClassificacaoGeral", b =>
                {
                    b.Property<int>("Id_Pontuacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Pontuacao"));

                    b.Property<int>("Classificacao")
                        .HasColumnType("int");

                    b.HasKey("Id_Pontuacao");

                    b.ToTable("Classificacoes");
                });

            modelBuilder.Entity("ClassLibrary_GT_RT.Competicao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Competicoes");
                });

            modelBuilder.Entity("ClassLibrary_GT_RT.Corrida", b =>
                {
                    b.Property<int>("Id_corrida")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_corrida"));

                    b.Property<int>("CircuitoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Resultado")
                        .HasColumnType("int");

                    b.Property<int>("Id_circuito")
                        .HasColumnType("int");

                    b.Property<int>("Id_competicao")
                        .HasColumnType("int");

                    b.Property<int>("NumeroMinutos")
                        .HasColumnType("int");

                    b.Property<int>("NumeroVoltas")
                        .HasColumnType("int");

                    b.HasKey("Id_corrida");

                    b.HasIndex("CircuitoId");

                    b.HasIndex("Id_Resultado")
                        .IsUnique();

                    b.ToTable("Corridas");
                });

            modelBuilder.Entity("ClassLibrary_GT_RT.Equipa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Equipas");
                });

            modelBuilder.Entity("ClassLibrary_GT_RT.Piloto", b =>
                {
                    b.Property<int>("Id_piloto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_piloto"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Equipa")
                        .HasColumnType("int");

                    b.Property<int>("Id_Piloto_Categoria")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaisRegiao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Piloto_CategoriaId_Piloto_Categorias")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id_piloto");

                    b.HasIndex("Piloto_CategoriaId_Piloto_Categorias");

                    b.ToTable("Pilotos");
                });

            modelBuilder.Entity("ClassLibrary_GT_RT.Piloto_Categorias", b =>
                {
                    b.Property<int>("Id_Piloto_Categorias")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Piloto_Categorias"));

                    b.Property<string>("Nome_Piloto_Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Piloto_Categorias");

                    b.ToTable("Piloto_Categorias");
                });

            modelBuilder.Entity("ClassLibrary_GT_RT.Resultado", b =>
                {
                    b.Property<int>("Id_Resultado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Resultado"));

                    b.Property<int>("ClassificacaoGeralId_Pontuacao")
                        .HasColumnType("int");

                    b.Property<int>("Id_Corrida")
                        .HasColumnType("int");

                    b.Property<int>("Id_Piloto")
                        .HasColumnType("int");

                    b.Property<int>("PilotoId_piloto")
                        .HasColumnType("int");

                    b.Property<int>("Posicao")
                        .HasColumnType("int");

                    b.Property<string>("VoltaMaisRapida")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Resultado");

                    b.HasIndex("ClassificacaoGeralId_Pontuacao");

                    b.HasIndex("PilotoId_piloto");

                    b.ToTable("Resultados");
                });

            modelBuilder.Entity("ClassLibrary_GT_RT.Carro", b =>
                {
                    b.HasOne("ClassLibrary_GT_RT.Corrida", null)
                        .WithMany("CarrosPermitidos")
                        .HasForeignKey("CorridaId_corrida");
                });

            modelBuilder.Entity("ClassLibrary_GT_RT.Corrida", b =>
                {
                    b.HasOne("ClassLibrary_GT_RT.Circuito", "Circuito")
                        .WithMany()
                        .HasForeignKey("CircuitoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassLibrary_GT_RT.Resultado", "Resultado")
                        .WithOne("Corrida")
                        .HasForeignKey("ClassLibrary_GT_RT.Corrida", "Id_Resultado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Circuito");

                    b.Navigation("Resultado");
                });

            modelBuilder.Entity("ClassLibrary_GT_RT.Piloto", b =>
                {
                    b.HasOne("ClassLibrary_GT_RT.Piloto_Categorias", "Piloto_Categoria")
                        .WithMany()
                        .HasForeignKey("Piloto_CategoriaId_Piloto_Categorias")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Piloto_Categoria");
                });

            modelBuilder.Entity("ClassLibrary_GT_RT.Resultado", b =>
                {
                    b.HasOne("ClassLibrary_GT_RT.ClassificacaoGeral", "ClassificacaoGeral")
                        .WithMany("Resultados")
                        .HasForeignKey("ClassificacaoGeralId_Pontuacao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassLibrary_GT_RT.Piloto", "Piloto")
                        .WithMany()
                        .HasForeignKey("PilotoId_piloto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClassificacaoGeral");

                    b.Navigation("Piloto");
                });

            modelBuilder.Entity("ClassLibrary_GT_RT.ClassificacaoGeral", b =>
                {
                    b.Navigation("Resultados");
                });

            modelBuilder.Entity("ClassLibrary_GT_RT.Corrida", b =>
                {
                    b.Navigation("CarrosPermitidos");
                });

            modelBuilder.Entity("ClassLibrary_GT_RT.Resultado", b =>
                {
                    b.Navigation("Corrida")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
