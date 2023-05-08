using ClassLibrary_GT_RT;
using MediatR;

namespace GT_RT_BackEnd.Queries
{
    public record GetEquipasQuery : IRequest<List<Equipa>>
    {
        public string? Search { get; set; }
    }
}
