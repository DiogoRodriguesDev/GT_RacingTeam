using ClassLibrary_GT_RT;
using MediatR;

namespace GT_RT_BackEnd.Queries
{
    public record GetPilotosQuery : IRequest<List<Piloto>>
    {
        public string? Search { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
