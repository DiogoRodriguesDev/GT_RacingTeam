using Microsoft.AspNetCore.Components.Server.Circuits;
using Microsoft.EntityFrameworkCore;
using ClassLibrary_GT_RT;
using Newtonsoft.Json;

namespace GT_RT_BackEnd.Data
{
    public class AppDbContext : DbContext, IDataContext
    {
        public DbSet<ClassificacaoGeral> Classificacoes { get; set; }
        public DbSet<Competicao> Competicoes { get; set; }
        public DbSet<Corrida> Corridas { get; set; }
        public DbSet<Equipa> Equipas { get; set; }
        public DbSet<Piloto> Pilotos { get; set; }
        public DbSet<Resultado> Resultados { get; set; }
        public DbSet<Piloto_Categorias> Piloto_Categorias { get; set; }
        public DbSet<ResultadoCorrida> ResultadoCorrida { get; set; }
        public DbSet<Posicao> Posicao { get; set; }
        public DbSet<PosicaoNovosPontos_PRO> PosicaoNovosPontos_PRO { get; set; }
        public DbSet<PosicaoNovosPontos_PROAM> PosicaoNovosPontos_PROAM { get; set; }
        public DbSet<PosicaoNovosPontos_AM> PosicaoNovosPontos_AM { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            //optionsBuilder.UseSqlServer(@"Data Source=94.46.180.24\MSSQLSERVER2019;Initial Catalog=GT_RacingTeam; Trusted_Connection=True; TrustServerCertificate=True; ");//User Id = ; Password=;
            optionsBuilder.UseSqlServer(@"Data Source=94.46.180.24\MSSQLSERVER2019;Initial Catalog=GT_RacingTeam;User Id=dioscp;Password=dioXCZW558255;TrustServerCertificate=True;");
        }
        




        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Piloto>()
        //        .Property(p => p.Categoria)
        //        .HasConversion<int>(); // Armazena o enum como inteiro no banco de dados

        //    base.OnModelCreating(modelBuilder);
        //}


    }
}
