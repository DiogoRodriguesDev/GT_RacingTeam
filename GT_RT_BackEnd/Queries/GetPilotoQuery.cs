using ClassLibrary_GT_RT;
using ClassLibrary_GT_RT.Requests;
using MediatR;

namespace GT_RT_BackEnd.Queries
{
    public record GetPilotoQuery(PilotoRequest PilotoRequest) : IRequest<Piloto>;
}