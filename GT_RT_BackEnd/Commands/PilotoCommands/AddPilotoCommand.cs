using ClassLibrary_GT_RT;
using MediatR;

namespace GT_RT_BackEnd.Commands.PilotoCommands
{
    public record AddPilotoCommand(Piloto Piloto) : IRequest<Piloto>;
}
