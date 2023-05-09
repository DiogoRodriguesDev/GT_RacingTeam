using ClassLibrary_GT_RT.Requests;
using ClassLibrary_GT_RT;
using MediatR;

namespace GT_RT_BackEnd.Queries.ResultadoCorridas
{
    public record GetResultadoCorridaQuery(ResultadoCorridaRequest ResultadoCorridaRequest) : IRequest<ResultadoCorrida>;
}
