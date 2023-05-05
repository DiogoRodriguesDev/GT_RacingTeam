using ClassLibrary_GT_RT;
using Microsoft.EntityFrameworkCore;

namespace GT_RT_BackEnd.Data
{
    public interface IDataContext
    {
        DbSet<Carro> Carros { get; set; }
        DbSet<Circuito> Circuitos { get; set; }
        DbSet<ClassificacaoGeral> Classificacoes { get; set; }
        DbSet<Competicao> Competicoes { get; set; }
        DbSet<Corrida> Corridas { get; set; }
        DbSet<Equipa> Equipas { get; set; }
        DbSet<Piloto> Pilotos { get; set; }
        DbSet<Resultado> Resultados { get; set; }
        DbSet<Piloto_Categorias> Piloto_Categorias { get; set; }
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellation = default);
    }
}