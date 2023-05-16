using ClassLibrary_GT_RT.Requests;
using ClassLibrary_GT_RT;
using MediatR;

namespace GT_RT_BackEnd.Queries.Competicoes
{
    public record GetCompeticaoQuery(CompeticaoRequest CompeticaoRequest) : IRequest<Competicao>;
}
