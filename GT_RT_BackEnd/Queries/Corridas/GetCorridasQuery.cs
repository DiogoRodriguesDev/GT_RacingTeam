using ClassLibrary_GT_RT;
using MediatR;

namespace GT_RT_BackEnd.Queries.Corridas
{
    public record GetCorridasQuery : IRequest<List<Corrida>>
    {
        public string? Search { get; set; }

        public string? Nome_Corrida { get; set; }
      
    }
}
