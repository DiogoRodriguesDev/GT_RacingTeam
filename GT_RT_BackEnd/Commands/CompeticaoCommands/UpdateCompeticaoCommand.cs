using ClassLibrary_GT_RT;
using MediatR;

namespace GT_RT_BackEnd.Commands.CompeticaoCommands
{
    public record UpdateCompeticaoCommand(Competicao Competicao, int Id) : IRequest<Competicao>;
}
