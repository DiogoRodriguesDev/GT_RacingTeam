using ClassLibrary_GT_RT;
using MediatR;

namespace GT_RT_BackEnd.Queries.Competicoes
{
    public record GetCompeticoesQuery : IRequest<List<Competicao>>
    {
        public string? Search { get; set; }

        public string? Nome { get; set; }
    }
}
