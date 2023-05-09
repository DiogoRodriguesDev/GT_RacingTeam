using ClassLibrary_GT_RT;
using MediatR;

namespace GT_RT_BackEnd.Queries.ResultadoCorridas
{
    public record GetResultadoCorridasQuery : IRequest<List<ResultadoCorrida>>
    {
        public int? Id_ResultadoCorrida { get; set; }
        public int? Id_piloto { get; set; }
        public int? Id_corrida { get; set; }

        public string? Search { get; set; }
    }
}
