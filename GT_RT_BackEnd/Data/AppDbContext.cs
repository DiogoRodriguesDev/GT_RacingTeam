using Microsoft.AspNetCore.Components.Server.Circuits;
using Microsoft.EntityFrameworkCore;
using ClassLibrary_GT_RT;

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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source=DIO-PC\MSSQL_SERVER_DIO;Initial Catalog=GT_RacingTeam; Trusted_Connection=True; TrustServerCertificate=True;");
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
