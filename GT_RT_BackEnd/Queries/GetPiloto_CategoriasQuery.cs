using ClassLibrary_GT_RT;
using ClassLibrary_GT_RT.Requests;
using GT_RT_BackEnd.Handlers.PilotoHandlers;
using MediatR;

namespace GT_RT_BackEnd.Queries
{
    public record GetPiloto_CategoriasQuery: IRequest<List<Piloto_Categorias>>
    {
        public string? Search { get; set; }
    }
   
}
