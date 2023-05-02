using MediatR;

namespace GT_RT_BackEnd.Commands.PilotoCommands
{
    public record DeletePilotoCommand(int Id) : IRequest;
}
