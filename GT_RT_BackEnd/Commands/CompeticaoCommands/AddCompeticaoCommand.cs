using ClassLibrary_GT_RT;
using MediatR;

namespace GT_RT_BackEnd.Commands.CompeticaoCommands
{
    public record AddCompeticaoCommand(Competicao Competicao) : IRequest<Competicao>;
}
