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
    [Migration("20230509150342_modificar_RESULTADOScorrida3")]
    partial class modificar_RESULTADOScorrida3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClassLibrary_GT_RT.ClassificacaoGeral", b =>
                {
                    b.Property<int>("Id_Pontuacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Pontuacao"));

                    b.Property<int?>("Classificacao")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

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
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
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

                    b.Property<string>("CarrosPermitidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Circuito")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Id_Resultado")
                        .HasColumnType("int");

                    b.Property<int?>("Id_competicao")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Nome_Corrida")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumeroMinutos")
                        .HasColumnType("int");

                    b.Property<int?>("NumeroVoltas")
                        .HasColumnType("int");

                    b.Property<string>("Tipo_Pneus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_corrida");

                    b.HasIndex("Id_Resultado")
                        .IsUnique()
                        .HasFilter("[Id_Resultado] IS NOT NULL");

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

                    b.Property<int?>("Id_Piloto_Categoria")
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

                    b.Property<int?>("Piloto_CategoriaId_Piloto_Categorias")
                        .HasColumnType("int");

                    b.Property<int?>("Piloto_EquipaId")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id_piloto");

                    b.HasIndex("Piloto_CategoriaId_Piloto_Categorias");

                    b.HasIndex("Piloto_EquipaId");

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

                    b.Property<int?>("ClassificacaoGeralId_Pontuacao")
                        .HasColumnType("int");

                    b.Property<int?>("Id_Corrida")
                        .HasColumnType("int");

                    b.Property<int?>("Id_Piloto")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("PilotoId_piloto")
                        .HasColumnType("int");

                    b.Property<int?>("Posicao")
                        .HasColumnType("int");

                    b.Property<string>("VoltaMaisRapida")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Resultado");

                    b.HasIndex("ClassificacaoGeralId_Pontuacao");

                    b.HasIndex("PilotoId_piloto");

                    b.ToTable("Resultados");
                });

            modelBuilder.Entity("ClassLibrary_GT_RT.ResultadoCorrida", b =>
                {
                    b.Property<int>("Id_ResultadoCorrida")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_ResultadoCorrida"));

                    b.Property<int?>("Id_corrida")
                        .HasColumnType("int");

                    b.Property<int?>("Id_piloto")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("Pontos")
                        .HasColumnType("int");

                    b.Property<int?>("PosicaoFinal")
                        .HasColumnType("int");

                    b.Property<TimeSpan?>("Tempo_total")
                        .HasColumnType("time");

                    b.HasKey("Id_ResultadoCorrida");

                    b.HasIndex("Id_corrida");

                    b.HasIndex("Id_piloto");

                    b.ToTable("ResultadoCorrida");
                });

            modelBuilder.Entity("ClassLibrary_GT_RT.Corrida", b =>
                {
                    b.HasOne("ClassLibrary_GT_RT.Resultado", "Resultado")
                        .WithOne("Corrida")
                        .HasForeignKey("ClassLibrary_GT_RT.Corrida", "Id_Resultado");

                    b.Navigation("Resultado");
                });

            modelBuilder.Entity("ClassLibrary_GT_RT.Piloto", b =>
                {
                    b.HasOne("ClassLibrary_GT_RT.Piloto_Categorias", "Piloto_Categoria")
                        .WithMany()
                        .HasForeignKey("Piloto_CategoriaId_Piloto_Categorias");

                    b.HasOne("ClassLibrary_GT_RT.Equipa", "Piloto_Equipa")
                        .WithMany()
                        .HasForeignKey("Piloto_EquipaId");

                    b.Navigation("Piloto_Categoria");

                    b.Navigation("Piloto_Equipa");
                });

            modelBuilder.Entity("ClassLibrary_GT_RT.Resultado", b =>
                {
                    b.HasOne("ClassLibrary_GT_RT.ClassificacaoGeral", "ClassificacaoGeral")
                        .WithMany("Resultados")
                        .HasForeignKey("ClassificacaoGeralId_Pontuacao");

                    b.HasOne("ClassLibrary_GT_RT.Piloto", "Piloto")
                        .WithMany()
                        .HasForeignKey("PilotoId_piloto");

                    b.Navigation("ClassificacaoGeral");

                    b.Navigation("Piloto");
                });

            modelBuilder.Entity("ClassLibrary_GT_RT.ResultadoCorrida", b =>
                {
                    b.HasOne("ClassLibrary_GT_RT.Corrida", "Corrida")
                        .WithMany()
                        .HasForeignKey("Id_corrida");

                    b.HasOne("ClassLibrary_GT_RT.Piloto", "Piloto")
                        .WithMany()
                        .HasForeignKey("Id_piloto");

                    b.Navigation("Corrida");

                    b.Navigation("Piloto");
                });

            modelBuilder.Entity("ClassLibrary_GT_RT.ClassificacaoGeral", b =>
                {
                    b.Navigation("Resultados");
                });

            modelBuilder.Entity("ClassLibrary_GT_RT.Resultado", b =>
                {
                    b.Navigation("Corrida");
                });
#pragma warning restore 612, 618
        }
    }
}
